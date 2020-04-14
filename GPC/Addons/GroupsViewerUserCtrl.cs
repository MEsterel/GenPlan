using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenPlan.Forms;
using GenPlan.Objects;
using GenPlan.Core;

namespace GenPlan.Addons
{
    public partial class GroupsViewerUserCtrl : UserControl
    {
        public bool UnsavedData { get; private set; } = false;

        public GroupsViewerUserCtrl()
        {
            InitializeComponent();

            SaveManager.LoadedFile += LoadGroups;
            SaveManager.Saved += SaveManager_Saved;
            SaveManager.NewFile += SaveManager_NewFile;
        }

        private void SaveManager_NewFile(object sender, EventArgs e)
        {
            grpLstView.Items.Clear();
            modifyBtn.Enabled = false;
            deleteGroupBtn.Enabled = false;
        }

        private void SaveManager_Saved(object sender, EventArgs e)
        {
            UnsavedData = false;
        }

        private void LoadGroups(object sender = null, EventArgs e = null)
        {
            grpLstView.Items.Clear();
            foreach (Group grp in SaveManager.Data.Groups)
            {
                grpLstView.Items.Add((new ListViewItem(new string[] { grp.Name, grp.StudentsCount.ToString() }) { Name = grp.Name }));
            }
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            AddGroupForm agf = new AddGroupForm();

            agf.ShowDialog();

            LoadGroups();
        }

        private void grpLstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grpLstView.SelectedItems.Count != 1)
            {
                modifyBtn.Enabled = false;
                deleteGroupBtn.Enabled = false;
            }
            else
            {
                modifyBtn.Enabled = true;
                deleteGroupBtn.Enabled = true;
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (grpLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez une classe à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string initialGroupName = grpLstView.SelectedItems[0].Text;

            ModifyGroupForm mgf = new ModifyGroupForm(SaveManager.Data.Groups.Find(x => x.Name == initialGroupName));
            if (mgf.ShowDialog() == DialogResult.OK)
            {
                grpLstView.Items[initialGroupName].SubItems[1].Text = mgf.FinalGroup.StudentsCount.ToString();
                grpLstView.Items[initialGroupName].Text = mgf.FinalGroup.Name;
                grpLstView.Items[initialGroupName].Name = mgf.FinalGroup.Name;
            }
        }

        private void grpLstView_DoubleClick(object sender, EventArgs e)
        {
            if (grpLstView.SelectedItems.Count != 1)
            {
                return;
            }

            modifyBtn_Click(null, null);
        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (grpLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez une classe à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer la classe " + grpLstView.SelectedItems[0].Name + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res != DialogResult.Yes)
                return;

            SaveManager.Data.Groups.Remove(SaveManager.Data.Groups.Find(x => x.Name == grpLstView.SelectedItems[0].Name));

            grpLstView.Items.Remove(grpLstView.SelectedItems[0]);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteGroupBtn_Click(null, null);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyBtn_Click(null, null);
        }

        private void groupsLstViewMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (grpLstView.SelectedItems.Count != 1)
            {
                e.Cancel = true;
            }
        }

        private void grpLstView_KeyDown(object sender, KeyEventArgs e)
        {
            if (grpLstView.SelectedItems.Count != 1)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                modifyBtn_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteGroupBtn_Click(null, null);
            }
        }
    }
}
