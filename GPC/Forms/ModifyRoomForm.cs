using GenPlan.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenPlan.Core;

namespace GenPlan.Forms
{
    public partial class ModifyRoomForm : Form
    {
        public Room FinalRoom;
        private Room initialRoom;

        public ModifyRoomForm(Room Room)
        {
            InitializeComponent();

            initialRoom = Room;
            roomMngr.LoadRoom(Room);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private new bool Validate()
        {
            if (String.IsNullOrWhiteSpace(roomMngr.RoomNameTxt))
            {
                MessageBox.Show("Veuillez indiquer le nom de la classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (SaveManager.Data.Rooms.Exists(x => x.Name == roomMngr.RoomNameTxt) && roomMngr.RoomNameTxt != initialRoom.Name)
            {
                MessageBox.Show("Une classe portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (roomMngr.GetRoom().PlacesCount <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une place à la salle.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FinalRoom = roomMngr.GetRoom();
            SaveManager.Data.Rooms.Remove(initialRoom);
            SaveManager.Data.Rooms.Add(FinalRoom);            
            roomMngr.UnsavedData = false;

            this.DialogResult = DialogResult.OK;
            return true;
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void ModifyRoomForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (roomMngr.UnsavedData)
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
    }
}
