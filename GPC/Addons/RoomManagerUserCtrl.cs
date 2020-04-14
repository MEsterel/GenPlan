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
using GenPlan.Forms;

namespace GenPlan.Addons
{
    public partial class RoomManagerUserCtrl : UserControl
    {
        public bool UnsavedData { get; set; } = false;

        public string RoomNameTxt => roomNameTxt.Text;

        int placesCount = 0;
        public int PlacesCount
        {
            get => placesCount;
            set { placesCount = value; placesCountLbl.Text = "Nombre de places : " + placesCount; }
        }

        public RoomManagerUserCtrl()
        {
            InitializeComponent();

            AddColumn(20);
            AddRow(11);

            UnsavedData = false;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                dgv.ClearSelection();
                return;
            }

            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                if (cell.Style.BackColor != Color.Yellow)
                {
                    cell.Style.BackColor = Color.Yellow;
                    PlacesCount++;
                }
                else
                {
                    cell.Style.BackColor = Color.White;
                    PlacesCount--;
                }
            }

            placesCountLbl.Text = "Nombre de places : " + PlacesCount;
            dgv.ClearSelection();

            UnsavedData = true;
        }

        private void newLineBtn_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void newColumnBtn_Click(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void AddColumn(int number = 1)
        {
            for (int i = 0; i < number; i++)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Column" + (dgv.Columns.Count),
                    HeaderText = GetColumnName(dgv.Columns.Count),
                    Width = 25,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            UnsavedData = true;
        }

        private void AddRow(int number = 1)
        {
            for (int i = 0; i < number; i++)
            {
                dgv.Rows.Add(new DataGridViewRow
                    {
                        MinimumHeight = 25,
                        HeaderCell = new DataGridViewRowHeaderCell { Value = dgv.Rows.Count.ToString() }
                    });
            }

            UnsavedData = true;
        }

        static string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length];

            return value;
        }

        public Room GetRoom()
        {
            Room result = new Room(RoomNameTxt);

            foreach(DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.Yellow)
                    {
                        result.AddPlace(cell.ColumnIndex, cell.RowIndex);
                    }
                }
            }

            return result;
        }

        public void LoadRoom(Room room)
        {
            roomNameTxt.Text = room.Name;

            dgv.Columns.Clear();
            dgv.Rows.Clear();
            AddColumn(20);
            AddRow(11);

            foreach ((int,int) coordonnee in room.Places)
            {
                if (coordonnee.Item1 > dgv.ColumnCount - 1)
                {
                    AddColumn(coordonnee.Item1 - dgv.ColumnCount + 1);
                }
                if (coordonnee.Item2 > dgv.RowCount - 1)
                {
                    AddRow(coordonnee.Item2 - dgv.RowCount + 1);
                }

                dgv.Rows[coordonnee.Item2].Cells[coordonnee.Item1].Style.BackColor = Color.Yellow;
            }

            PlacesCount = room.PlacesCount;

            UnsavedData = false;
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpForm hf = new HelpForm("Chaque case représente un emplacement possible pour une place."
                + "\r\n\r\nPour ajouter ou supprimer des places :"
                + "\r\n1. Cliquez sur une case. Elle change de couleur."
                + "\r\n2. Si la case est jaune : cet emplacement est désormais une place potentielle."
                + "\r\n3. Si la case est blanche : il n'y a pas de place disponible à cet endroit."
                + "\r\nVous pouvez ajouter sélectionner plusieurs cases à la fois."
                + "\r\n\r\nÀ noter : vous pouvez ajouter des lignes ou des colonnes si l'espace proposé initialement est insuffisant.",
                "Faire un plan de salle");
            hf.ShowDialog();
        }
    }
}
