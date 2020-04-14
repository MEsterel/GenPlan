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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private new bool Validate()
        {
            if (string.IsNullOrWhiteSpace(roomMngr.RoomNameTxt))
            {
                MessageBox.Show(this, "Veuillez insérer un nom pour la nouvelle salle.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (SaveManager.Data.Rooms.Exists(x => x.Name == roomMngr.RoomNameTxt))
            {
                MessageBox.Show("Une salle portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Room res = roomMngr.GetRoom();

            if (res.PlacesCount <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une place dans cette salle.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SaveManager.Data.Rooms.Add(res);
            roomMngr.UnsavedData = false;
            this.DialogResult = DialogResult.OK;
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRoomForm_FormClosing(object sender, FormClosingEventArgs e)
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
