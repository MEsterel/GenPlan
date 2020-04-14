using GenPlan.Objects;
using GenPlan.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenPlan.Forms
{
    public partial class PlanViewerForm : Form
    {
        public Plan WorkingPlan { get; private set; }
        public string InitialName { get; private set; }

        public PlanViewerForm()
        {
            InitializeComponent();
            planDrawerUC.AboutToExport += PlanDrawerUC_AboutToExport;
        }

        private void PlanDrawerUC_AboutToExport(object sender, EventArgs e)
        {
            planDrawerUC.ExportName = nameTxt.Text;
        }

        public void LoadPlan(Plan plan)
        {
            WorkingPlan = plan;
            nameTxt.Text = plan.Name;
            InitialName = plan.Name;

            string affinitiesDesc;
            string fillModeDesc;

            switch (WorkingPlan.Options.AffinitiesMode)
            {
                case AffinitiesModeEnum.SideBySide:
                    affinitiesDesc = "Directement côtes-à-côtes";
                    break;

                case AffinitiesModeEnum.OneSquareRadius:
                    affinitiesDesc = "Dans un rayon de 1 case";
                    break;

                case AffinitiesModeEnum.TwoSquaresRadius:
                    affinitiesDesc = "Dans un rayon de 2 cases";
                    break;

                default:
                    affinitiesDesc = "N/A";
                    break;
            }

            switch (WorkingPlan.Options.FillMode)
            {
                case FillModeEnum.Avant:
                    fillModeDesc = "En avant de la salle";
                    break;

                case FillModeEnum.Arriere:
                    fillModeDesc = "En arrière de la salle";
                    break;

                default:
                    fillModeDesc = "N/A";
                    break;
            }


            detailsTxt.Text = String.Format("Salle : {1} ({2} places)" +
                "\r\n\r\nClasse : {3} ({4} élèves)" +
                "\r\n\r\nEmpêcher les affinités de bavardage : {5}" +
                "\r\n\r\nÉlèves placés : {6}",
                WorkingPlan.Name, WorkingPlan.RoomName, WorkingPlan.Seats.Count, WorkingPlan.GroupName, WorkingPlan.NotEmptySeatsCount, affinitiesDesc, fillModeDesc);


            planDrawerUC.DrawPlan(WorkingPlan);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Veuillez indiquer le nom de la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SaveManager.Data.Rooms.Exists(x => x.Name == nameTxt.Text) && nameTxt.Text != WorkingPlan.Name)
            {
                MessageBox.Show("Une classe portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nameTxt.Text != WorkingPlan.Name)
            {
                SaveManager.Data.Plans.Find(x => x == WorkingPlan).Name = nameTxt.Text;
            }

            this.Close();
        }
    }
}
