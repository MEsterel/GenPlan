using GenPlan.Forms;
using GenPlan.Core;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace GenPlan
{
    public partial class MainForm : Form
    {
        private Updater updater;

        public MainForm()
        {
            InitializeComponent();

            SaveManager.LoadedFile += SaveManager_LoadedFile;
            SaveManager.NewFile += SaveManager_NewFile;

            updater = new Updater(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addform = new AddGroupForm();
            this.AddOwnedForm(addform);
            addform.ShowDialog();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveManager.Save(true);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveManager.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grpsViewerUC.UnsavedData || roomsViewerUC.UnsavedData || plansViewerUC.UnsavedData)
            {
                DialogResult res = MessageBox.Show(this, "Certaines données n'ont pas été sauvegardées. Voulez-vous sauvegarder les modifications avant de quitter ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    SaveManager.Save();
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.AddOwnedForm(wf);
            if (wf.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }

            updater.DoUpdateAsync();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grpsViewerUC.UnsavedData || roomsViewerUC.UnsavedData)
            {
                DialogResult res = MessageBox.Show(this, "Certaines données n'ont pas été sauvegardées. Voulez-vous sauvegarder avant de créer un nouveau fichier ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    SaveManager.Save();
                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            SaveManager.New();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grpsViewerUC.UnsavedData || roomsViewerUC.UnsavedData)
            {
                DialogResult res = MessageBox.Show(this, "Certaines données n'ont pas été sauvegardées. Voulez-vous sauvegarder avant d'ouvrir un autre fichier ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    SaveManager.Save();
                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            SaveManager.Open();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveManager_LoadedFile(object sender, EventArgs e)
        {
            this.Text = SaveManager.WorkingName + " - Générateur de Plan de Classe";
        }

        private void SaveManager_NewFile(object sender, EventArgs e)
        {
            this.Text = "Nouveau - Générateur de Plan de Classe";
        }

        private void commentDémarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm("Commencez par créer une classe ainsi qu'une salle. " +
                "Rendez-vous ensuite dans l'onglet 'Mes plans de classe' pour en créer un. " +
                "\r\n\r\nAttention ! La salle devra contenir plus de places que d'élèves...",
                "Comment démarrer ?");
            hf.ShowDialog();
        }

        private void donationBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.DonationLink);
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void chercherUneMiseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                updater.DoUpdateSync(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'effectuer la mise à jour. Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
        }
    }
}