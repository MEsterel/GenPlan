using GenPlan.Objects;
using GenPlan.Core;
using System;
using System.Windows.Forms;

namespace GenPlan.Forms
{
    public partial class ModifyGroupForm : Form
    {
        public Group FinalGroup;
        private Group initialGroup;

        public ModifyGroupForm(Group group)
        {
            InitializeComponent();

            initialGroup = group;
            grpMngr.LoadGroup(group);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyGroupForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private new bool Validate()
        {
            if (String.IsNullOrWhiteSpace(grpMngr.GroupNameTxt))
            {
                MessageBox.Show("Veuillez indiquer le nom de la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (SaveManager.Data.Groups.Exists(x => x.Name == grpMngr.GroupNameTxt) && grpMngr.GroupNameTxt != initialGroup.Name)
            {
                MessageBox.Show("Une classe portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (grpMngr.WorkingGroup.StudentsCount <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins un élève à la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SaveManager.Data.Groups.Remove(initialGroup);
            SaveManager.Data.Groups.Add(grpMngr.WorkingGroup);
            FinalGroup = grpMngr.WorkingGroup;
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