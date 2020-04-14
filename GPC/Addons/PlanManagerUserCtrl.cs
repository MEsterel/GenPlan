using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenPlan.Objects;
using GenPlan.Core;
using System.Diagnostics;

namespace GenPlan.Addons
{
    public partial class PlanManagerUserCtrl : UserControl
    {
        Random rdm = new Random();

        BackgroundWorker bgw = new BackgroundWorker();

        PlanOptions planOptionsDuringGen = new PlanOptions();
        private Plan _lastSuccessfulResult;

        private Stopwatch genStopwatch = new Stopwatch();
        private Timer genTimer = new Timer() { Interval = 1000 };
        private float lastPlacedStudentsPercent = 0f;
        private string lastPlacedStudentName = "N/A";

        public bool Generating { get; private set; } = false;
        public int GenerationCount { get; private set; } = 0;
        public string PlanNameTxt => planNameTxt.Text;
        public bool UnsavedData { get; internal set; } = false;
        public Plan LastSucessfulResult {
            get
            {
                _lastSuccessfulResult.Name = planNameTxt.Text;
                return _lastSuccessfulResult;
            }
            private set => _lastSuccessfulResult = value; }

        

        public PlanManagerUserCtrl()
        {
            InitializeComponent();

            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.DoWork += Bgw_DoWork;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            genTimer.Tick += GenTimer_Tick;

            planDrawerUC.CanExport = false;

            LoadRoomsAndGroups();
        }
        

        private void LoadRoomsAndGroups()
        {
            roomCmbBox.Items.AddRange(SaveManager.Data.Rooms.ToArray());
            groupCmbBox.Items.AddRange(SaveManager.Data.Groups.ToArray());
        }

        private void roomCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            planDrawerUC.DrawPlaces((Room)roomCmbBox.SelectedItem);
            CheckRoomCapacity();
        }

        private void groupCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRoomCapacity();
        }

        private void CheckRoomCapacity()
        {
            if (roomCmbBox.SelectedItem == null || groupCmbBox.SelectedItem == null)
            {
                return;
            }

            if (((Room)roomCmbBox.SelectedItem).PlacesCount < ((Group)groupCmbBox.SelectedItem).StudentsCount)
            {
                MessageBox.Show("Veuillez sélectionner une classe avec moins d'élèves que de places dans la salle sélectionnée.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupCmbBox.SelectedIndex = -1;
                return;
            }
        }


        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (roomCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une salle.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (groupCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            planDrawerUC.DrawPlaces((Room)roomCmbBox.SelectedItem); // check up

            StartGeneration();
        }

        private void StartGeneration()
        {
            generateBtn.Text = "GÉNÉRATION EN COURS...";
            generateBtn.Enabled = false;
            cancelBtn.Enabled = true;
            optionsGrpBox.Enabled = false;
            planOptionsDuringGen = planOptionsUC.GetOptions();
            prgBar.Style = ProgressBarStyle.Marquee;
            Generating = true;
            planDrawerUC.CanExport = false;            
            GenerationCount++;


            generatingStatePnl.Enabled = true;
            genStateLbl.Text = "En cours...";
            genStateLbl.ForeColor = Color.Blue;
            lastPlacedStudentsPercent = 0;
            GenTimer_Tick(null, null);
            genStopwatch.Start();
            genTimer.Start();


            bgw.RunWorkerAsync(new GenerationParameters()
            {
                Room = (Room)roomCmbBox.SelectedItem,
                Group = (Group)groupCmbBox.SelectedItem,
                PlanOptions = planOptionsDuringGen
            });
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Plan workingPlan = new Plan();

            GenerationParameters args = (GenerationParameters)e.Argument;

            workingPlan.RoomName = args.Room.Name;
            workingPlan.GroupName = args.Group.Name;

            args.Room.Places.ForEach(x => workingPlan.Seats.Add(new Seat((x.Item1, x.Item2))));

            // sort by fill mode
            if (args.PlanOptions.FillMode == FillModeEnum.Avant)
            {
                workingPlan.Seats.Sort((x, y) =>
                {
                    int result = y.Coordonnees.Item2.CompareTo(x.Coordonnees.Item2);
                    return result == 0 ? y.Coordonnees.Item1.CompareTo(x.Coordonnees.Item1) : result;
                });
            }
            else if (args.PlanOptions.FillMode == FillModeEnum.Arriere)
            {
                workingPlan.Seats.Sort((x, y) =>
                {
                    int result = x.Coordonnees.Item2.CompareTo(y.Coordonnees.Item2);
                    return result == 0 ? x.Coordonnees.Item1.CompareTo(y.Coordonnees.Item1) : result;
                });
            }

            // cut the not empty seats count to the number of students
            for (int i = args.Group.StudentsCount; i < workingPlan.Seats.Count; i++)
            {
                workingPlan.Seats[i].MustBeEmpty = true;
            }

            // start recursivity
            RecursiveIndicatorEnum res = FillRemainingPlaces(workingPlan, args);
            if (res == RecursiveIndicatorEnum.False)
            {
                throw new Exception("Impossible de terminer la génération.");
            }
            else if (res == RecursiveIndicatorEnum.Cancel)
            {
                e.Cancel = true;
                e.Result = workingPlan;
            }
            else
            {
                e.Result = workingPlan;
            }
        }

        private RecursiveIndicatorEnum FillRemainingPlaces(Plan workingPlan, GenerationParameters args)
        {
                // quicken cancellation
                if (bgw.CancellationPending)
                {
                    return RecursiveIndicatorEnum.Cancel;
                }


                int remainingStudentsCount = args.Group.Students.Where(x => !workingPlan.Seats.Exists(y => y.StudentName == x.Name)).Count();


                if (remainingStudentsCount == 0)
                {
                    return RecursiveIndicatorEnum.True;
                }

                Seat workingSeat = workingPlan.Seats.Find(x => x.StudentName == "" && !x.MustBeEmpty && !x.EmptyForGen); // take next seat if first seat is intentionnaly empty


                // list of student names possibilities
                List<string> placePossibilities = PlacePossibilities(workingPlan, workingSeat.Coordonnees, args);

                Seat changedMustBeEmpty = null;


            while (placePossibilities.Count > 0 || !workingSeat.EmptyForGen)
            {
                if (placePossibilities.Count == 0 && workingPlan.Seats.FindAll(x => x.MustBeEmpty).Count() > 0)
                {
                    changedMustBeEmpty = workingPlan.Seats.Find(x => x.MustBeEmpty);
                    changedMustBeEmpty.MustBeEmpty = false;

                    workingSeat.EmptyForGen = true;

                    workingSeat.StudentName = "";
                }
                else if (placePossibilities.Count() == 0)
                {
                    return RecursiveIndicatorEnum.False;
                }
                else
                {
                    workingSeat.StudentName = placePossibilities[rdm.Next(placePossibilities.Count)];
                }

                bgw.ReportProgress(0, new GenerationUserState() { UpdatedSeat = workingSeat, PlacedStudentsPercent = (float)(args.Group.StudentsCount - remainingStudentsCount) / (float)args.Group.StudentsCount });
                if (args.PlanOptions.AnimateGeneration)
                {
                    System.Threading.Thread.Sleep(args.PlanOptions.AnimationSpeed);
                }

                RecursiveIndicatorEnum nextResponse = FillRemainingPlaces(workingPlan, args);
                if (nextResponse == RecursiveIndicatorEnum.True)
                {
                    return RecursiveIndicatorEnum.True;
                }
                else if (nextResponse == RecursiveIndicatorEnum.Cancel)
                {
                    return RecursiveIndicatorEnum.Cancel;
                }
                else
                {
                    if (!workingSeat.EmptyForGen)
                    {
                        placePossibilities.Remove(workingSeat.StudentName);
                        workingSeat.StudentName = "";

                        bgw.ReportProgress(0, new GenerationUserState() { UpdatedSeat = new Seat(workingSeat.Coordonnees, "") });
                        if (args.PlanOptions.AnimateGeneration)
                        {
                            System.Threading.Thread.Sleep(args.PlanOptions.AnimationSpeed);
                        }
                    }
                    else
                    {
                        if (changedMustBeEmpty != null)
                        {
                            changedMustBeEmpty.MustBeEmpty = true;
                        }

                        workingSeat.EmptyForGen = false;

                        break;
                    }
                }
            }

            return RecursiveIndicatorEnum.False;
        }

        private List<string> PlacePossibilities(Plan workingPlan, (int, int) seatCoordinate, GenerationParameters args)
        {
            List<string> res = args.Group.Students.Where(x => !workingPlan.Seats.Exists(y => y.StudentName == x.Name)).Select(x => x.Name).ToList();
            List<string> surroundings = new List<string>();

            if (args.PlanOptions.AffinitiesMode == AffinitiesModeEnum.SideBySide)
            {
                for (int i = -1; i < 3; i += 2)
                {
                    Seat sideSeat = workingPlan.Seats.Find(x => x.Coordonnees.Item1 == seatCoordinate.Item1 + i && x.Coordonnees.Item2 == seatCoordinate.Item2);
                    if (sideSeat != null && sideSeat.StudentName != "")
                    {
                        foreach (string affinityName in args.Group.Students.Find(x => x.Name == sideSeat.StudentName).TalkingAffinitiesToArray())
                        {
                            try // try si la personne à retirer l'a déjà été.
                            {
                                res.Remove(affinityName);
                            }
                            catch { }
                        }
                    }
                }

                for (int j = -1; j < 3; j += 2)
                {
                    Seat sideSeat = workingPlan.Seats.Find(x => x.Coordonnees.Item1 == seatCoordinate.Item1 && x.Coordonnees.Item2 == seatCoordinate.Item2 + j);
                    if (sideSeat != null && sideSeat.StudentName != "")
                    {
                        foreach (string affinityName in args.Group.Students.Find(x => x.Name == sideSeat.StudentName).TalkingAffinitiesToArray())
                        {
                            try // try si la personne à retirer l'a déjà été.
                            {
                                res.Remove(affinityName);
                            }
                            catch { }
                        }
                    }
                }
            }
            else
            {
                int a = 0;
                int b = 0;
                int maxNotIncluded = 0;

                switch (args.PlanOptions.AffinitiesMode)
                {
                    case AffinitiesModeEnum.OneSquareRadius:
                        a = -1;
                        b = -1;
                        maxNotIncluded = 2;
                        break;

                    case AffinitiesModeEnum.TwoSquaresRadius:
                        a = -2;
                        b = -2;
                        maxNotIncluded = 3;
                        break;

                    case AffinitiesModeEnum.ThreeSquaresRadius:
                        a = -3;
                        b = -3;
                        maxNotIncluded = 4;
                        break;

                    case AffinitiesModeEnum.FourSquaresRadius:
                        a = -4;
                        b = -4;
                        maxNotIncluded = 5;
                        break;

                    case AffinitiesModeEnum.FiveSquaresRadius:
                        a = -4;
                        b = -4;
                        maxNotIncluded = 5;
                        break;

                    default:
                        throw new Exception("Le mode d'affinité n'est pas reconnu.");
                }

                for (int i = a; i < maxNotIncluded; i++)
                {
                    for (int j = b; j < maxNotIncluded; j++)
                    {
                        if (j == 0 && i == 0)
                            continue;

                        (int, int) studiedSeat = (seatCoordinate.Item1 + j, seatCoordinate.Item2 + i);

                        Seat sideSeat = workingPlan.Seats.Find(x => x.Coordonnees.Item1 == studiedSeat.Item1 && x.Coordonnees.Item2 == studiedSeat.Item2);

                        if (args.PlanOptions.DebugMode)
                        {
                            bgw.ReportProgress(0, new GenerationUserState() { DebugSeat1 = seatCoordinate, DebugSeat2 = (studiedSeat.Item1, studiedSeat.Item2) });
                            System.Threading.Thread.Sleep(args.PlanOptions.AnimationSpeed * 20);
                        }

                        if (sideSeat != null && sideSeat.StudentName != "")
                        {
                            surroundings.Add(sideSeat.StudentName);

                            foreach (string affinityName in args.Group.Students.Find(x => x.Name == sideSeat.StudentName).TalkingAffinitiesToArray())
                            {
                                res.Remove(affinityName);
                            }
                        }
                    }
                }
            }

            return res;
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GenerationUserState args = (GenerationUserState)e.UserState;

            if (planOptionsDuringGen.AnimateGeneration)
            {
                if (planOptionsDuringGen.DebugMode && args.DebugSeat1.Item1 != -1)
                {

                    try
                    {
                        Color previousCol1 = planDrawerUC.GetCell(args.DebugSeat1).Style.BackColor;
                        planDrawerUC.ChangeCellBackcolor(args.DebugSeat1, Color.Red);
                        planDrawerUC.RefreshPlan();
                        System.Threading.Thread.Sleep(planOptionsDuringGen.AnimationSpeed / 4);
                        planDrawerUC.ChangeCellBackcolor(args.DebugSeat1, previousCol1);
                        planDrawerUC.RefreshPlan();

                    }
                    catch { }

                    try
                    {
                        Color previousCol2 = planDrawerUC.GetCell(args.DebugSeat2).Style.BackColor;
                        planDrawerUC.ChangeCellBackcolor(args.DebugSeat2, Color.Magenta);
                        planDrawerUC.RefreshPlan();
                        System.Threading.Thread.Sleep(planOptionsDuringGen.AnimationSpeed / 4);
                        planDrawerUC.ChangeCellBackcolor(args.DebugSeat2, previousCol2);
                        planDrawerUC.RefreshPlan();
                    }
                    catch { }
                }
                else
                {
                    planDrawerUC.ChangeCellValue(args.UpdatedSeat.Coordonnees, args.UpdatedSeat.StudentName);
                }
            }

            if (args.PlacedStudentsPercent != -1)
            {
                lastPlacedStudentName = args.UpdatedSeat.StudentName;
                lastPlacedStudentsPercent = args.PlacedStudentsPercent;
            }
        }


        private void GenTimer_Tick(object sender, EventArgs e)
        {
            genDurationLbl.Text = String.Format("{0}:{1}:{2}", genStopwatch.Elapsed.Hours.ToString("00"), genStopwatch.Elapsed.Minutes.ToString("00"),
                genStopwatch.Elapsed.Seconds.ToString("00"));
            genPlacedStudentsLbl.Text = Math.Round(lastPlacedStudentsPercent * 100, 3).ToString() + " %";
            genLastStudentPlacedLbl.Text = lastPlacedStudentName;
        }


        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                EndGeneration();
                genStateLbl.Text = "Erreur";
                genStateLbl.ForeColor = Color.Red;

                MessageBox.Show("Impossible d'aboutir à un plan de classe avec la configuration actuelle." +
                    "\r\n\r\nSi l'erreur persiste, essayez les actions suivantes :" +
                    "\r\n1. Changez le mode de placement des affinités de bavardage;" +
                    "\r\n2. Augmentez le nombre de places;" +
                    "\r\n3. Diminuez le nombre d'affinités de bavardage."                   
                    
                    //+ "\r\n\r\nDétails de l'erreur : " + e.Error.Message
                    , "Erreur de génération", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else if (e.Cancelled)
            {
                EndGeneration();
                genStateLbl.Text = "Annulée";
                genStateLbl.ForeColor = Color.Red;
            }
            else
            {
                LastSucessfulResult = (Plan)e.Result;
                planDrawerUC.DrawPlan(LastSucessfulResult);
                UnsavedData = true;
                planDrawerUC.CanExport = true;

                EndGeneration();
                genStateLbl.Text = "Terminée !";
                genStateLbl.ForeColor = Color.LimeGreen;
                genPlacedStudentsLbl.Text = "100 %";
            }
        }

        private void EndGeneration()
        {
            generateBtn.Text = "GÉNÉRER";
            generateBtn.Enabled = true;
            cancelBtn.Enabled = false;
            optionsGrpBox.Enabled = true;
            Generating = false;
            prgBar.Style = ProgressBarStyle.Continuous;

            genStopwatch.Reset();
            genTimer.Stop();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (bgw.IsBusy)
            {
                bgw.CancelAsync();
            }
        }
    }
}
