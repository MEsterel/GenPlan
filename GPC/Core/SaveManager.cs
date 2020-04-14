using GenPlan.Objects;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GenPlan.Core
{
    public static class SaveManager
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(GenPlanSaveData));

        public static event EventHandler LoadedFile;

        public static event EventHandler NewFile;

        public static event EventHandler Saved;

        public static GenPlanSaveData Data { get; set; } = new GenPlanSaveData();
        public static string WorkingName => Path.GetFileName(WorkingPath);
        public static string WorkingPath { get; set; }

        public static void New()
        {
            WorkingPath = "";

            SaveManager.Data = new Objects.GenPlanSaveData();

            RaiseNewFile();
        }

        public static bool Open(string path = "", bool displayError = true)
        {
            try
            {
                if (File.Exists(path))
                {
                    WorkingPath = path;
                }
                else
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.CheckFileExists = true;
                    ofd.Filter = "Fichier de données GenPlan (*.GenPlan)|*.GenPlan";
                    ofd.Multiselect = false;
                    ofd.Title = "Ouvrir";
                    ofd.CheckFileExists = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        WorkingPath = ofd.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }

                using (TextReader tr = new StreamReader(WorkingPath))
                {
                    Data = (GenPlanSaveData)serializer.Deserialize(tr);
                }

                Properties.Settings.Default.LastWorkingPath = WorkingPath;
                Properties.Settings.Default.Save();

                RaiseLoadedFile();
                return true;
            }
            catch (Exception ex)
            {
                if (displayError)
                    MessageBox.Show("Erreur lors de la lecture du fichier.\n Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                WorkingPath = "";

                return false;
            }
        }

        public static bool Save(bool saveUnder = false, bool displayError = true)
        {
            try
            {
                if (!File.Exists(WorkingPath) || saveUnder)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Fichier de données GenPlan (*.GenPlan)|*.GenPlan";
                    sfd.DefaultExt = "GenPlan";
                    sfd.AddExtension = true;
                    sfd.OverwritePrompt = true;
                    sfd.ValidateNames = true;
                    sfd.Title = "Enregistrer sous";

                    sfd.CheckPathExists = true;

                    DialogResult res = sfd.ShowDialog();

                    if (res == DialogResult.OK)
                    {
                        WorkingPath = sfd.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }

                using (TextWriter tw = new StreamWriter(WorkingPath, false))
                {
                    serializer.Serialize(tw, Data);
                }

                Properties.Settings.Default.LastWorkingPath = WorkingPath;
                Properties.Settings.Default.Save();
                RaiseSaved();

                return true;
            }
            catch (Exception ex)
            {
                if (displayError)
                    MessageBox.Show("Erreur lors de l'enregistrement du fichier.\n Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                WorkingPath = "";

                return false;
            }
        }

        private static void RaiseLoadedFile()
        {
            LoadedFile?.Invoke(null, new EventArgs());
        }

        private static void RaiseNewFile()
        {
            NewFile?.Invoke(null, new EventArgs());
        }

        private static void RaiseSaved()
        {
            Saved?.Invoke(null, new EventArgs());
        }
    }
}