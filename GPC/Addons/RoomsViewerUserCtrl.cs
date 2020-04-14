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
using GenPlan.Core;
using GenPlan.Objects;

namespace GenPlan.Addons
{
    public partial class RoomsViewerUserCtrl : UserControl
    {
        public bool UnsavedData { get; private set; } = false;

        public RoomsViewerUserCtrl()
        {
            InitializeComponent();

            SaveManager.LoadedFile += LoadRooms;
            SaveManager.Saved += SaveManager_Saved;
            SaveManager.NewFile += SaveManager_NewFile;
        }

        private void SaveManager_NewFile(object sender, EventArgs e)
        {
            roomLstView.Items.Clear();
            modifyBtn.Enabled = false;
            deleteGroupBtn.Enabled = false;
        }

        private void SaveManager_Saved(object sender, EventArgs e)
        {
            UnsavedData = false;
        }

        private void LoadRooms(object sender = null, EventArgs e = null)
        {
            roomLstView.Items.Clear();
            foreach (Room room in SaveManager.Data.Rooms)
            {
                roomLstView.Items.Add((new ListViewItem(new string[] { room.Name, room.PlacesCount.ToString() }) { Name = room.Name }));
            }
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            AddRoomForm arf = new AddRoomForm();
            arf.ShowDialog();
            LoadRooms();
        }

        private void roomLstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomLstView.SelectedItems.Count != 1)
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

            if (roomLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez une salle à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string initialRoomName = roomLstView.SelectedItems[0].Text;

            ModifyRoomForm mrf = new ModifyRoomForm(SaveManager.Data.Rooms.Find(x => x.Name == initialRoomName));
            if (mrf.ShowDialog() == DialogResult.OK)
            {
                roomLstView.Items[initialRoomName].SubItems[1].Text = mrf.FinalRoom.PlacesCount.ToString();
                roomLstView.Items[initialRoomName].Text = mrf.FinalRoom.Name;
                roomLstView.Items[initialRoomName].Name = mrf.FinalRoom.Name;
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyBtn_Click(null, null);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteGroupBtn_Click(null, null);
        }

        private void roomLstView_DoubleClick(object sender, EventArgs e)
        {
            if (roomLstView.SelectedItems.Count != 1)
            {
                return;
            }

            modifyBtn_Click(null, null);
        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (roomLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez une classe à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer la salle " + roomLstView.SelectedItems[0].Name + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res != DialogResult.Yes)
                return;

            SaveManager.Data.Rooms.Remove(SaveManager.Data.Rooms.Find(x => x.Name == roomLstView.SelectedItems[0].Name));

            roomLstView.Items.Remove(roomLstView.SelectedItems[0]);
        }

        private void roomsLstViewMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (roomLstView.SelectedItems.Count != 1)
            {
                e.Cancel = true;
            }
        }

        private void roomLstView_KeyDown(object sender, KeyEventArgs e)
        {
            if (roomLstView.SelectedItems.Count != 1)
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
