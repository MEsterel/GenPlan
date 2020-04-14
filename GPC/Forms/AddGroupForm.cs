using GenPlan.Core;
using System;
using System.Windows.Forms;

namespace GenPlan.Forms
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void AddGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grpMngr.UnsavedData)
            {
                DialogResult res = MessageBox.Show("Certaines données n'ont pas été sauvegardées. Voulez-vous sauvegarder les modifications avant de quitter ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    if (!Validate())
                    {
                        e.Cancel = true;
                    }
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private new bool Validate()
        {
            if (String.IsNullOrWhiteSpace(grpMngr.GroupNameTxt))
            {
                MessageBox.Show("Veuillez indiquer le nom de la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (SaveManager.Data.Groups.Exists(x => x.Name == grpMngr.GroupNameTxt))
            {
                MessageBox.Show("Une classe portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (grpMngr.WorkingGroup.StudentsCount <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins un élève à la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SaveManager.Data.Groups.Add(grpMngr.WorkingGroup);
            grpMngr.UnsavedData = false;
            this.DialogResult = DialogResult.OK;
            return true;
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Validate();
        }
    }
}