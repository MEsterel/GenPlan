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
using System.IO;

namespace GenPlan.Addons
{
    public partial class PlanDrawerUserCtrl : UserControl
    {
        const int CellWidth = 90;
        const int CellHeight = 70;
        const int HDExport = 2;
        const int SDExport = 1;

        public string ExportName { get; set; }
        public Plan WorkingPlan { get; private set; }
        
        private bool _canExport = true;
        private float _zoom = 1;

        public bool CanExport
        {
            get => _canExport;
            set
            {
                _canExport = value;
                exportPnl.Enabled = value;
            }
        }

        public float Zoom
        {
            get => _zoom;
            private set
            {
                _zoom = value;

                zoomLbl.Text = "Zoom : " + _zoom * 100 + " %";

                dgv.Font = new Font(dgv.Font.FontFamily, _zoom * 10 - 1);
                dgv.RowsDefaultCellStyle.Font = new Font(dgv.RowsDefaultCellStyle.Font.FontFamily, _zoom * 10 + 1);

                dgv.RowHeadersWidth = (int)(48 * Zoom);

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.Width = (int)(CellWidth * _zoom);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = (int)(CellHeight * _zoom);
                }
            }
        }

        public event EventHandler AboutToExport;
        private void RaiseAboutToExport()
        {
            AboutToExport?.Invoke(null, new EventArgs());
        }

        public PlanDrawerUserCtrl()
        {
            InitializeComponent();

            dgv.MouseWheel += Dgv_MouseWheel;
        }

        private void Dgv_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                float nextZoom = (float)Math.Round(Zoom + e.Delta / 1200f, 3);
                
                if ((float)zoomTrkBar.Minimum / 10f <= nextZoom && nextZoom <= (float)zoomTrkBar.Maximum / 10f)
                {
                    Zoom = nextZoom;
                    zoomTrkBar.Value = (int)Math.Round(Zoom * 10);
                }
            }
        }

        private void AddColumn(int number = 1)
        {
            for (int i = 0; i < number; i++)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Column" + (dgv.Columns.Count),
                    HeaderText = GetColumnName(dgv.Columns.Count),
                    Width = (int)(CellWidth * Zoom),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }
        }

        private void AddRow(int number = 1)
        {
            for (int i = 0; i < number; i++)
            {
                dgv.Rows.Add(new DataGridViewRow
                {
                    Height = (int)(CellHeight * Zoom),
                    HeaderCell = new DataGridViewRowHeaderCell { Value = dgv.Rows.Count.ToString() }
                });
            }
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


        public void DrawPlaces(Room room)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            foreach ((int, int) coordonnee in (room.Places))
            {
                if (coordonnee.Item1 > dgv.ColumnCount - 1)
                {
                    AddColumn(coordonnee.Item1 - dgv.ColumnCount + 1);
                }
                if (coordonnee.Item2 > dgv.RowCount - 1)
                {
                    AddRow(coordonnee.Item2 - dgv.RowCount + 1);
                }

                ChangeCellBackcolor(coordonnee, Color.Yellow);
            }
        }

        public void DrawPlan(Plan plan)
        {
            WorkingPlan = plan;
            ExportName = plan.Name;

            foreach (Seat seat in plan.Seats)
            {
                if (seat.Coordonnees.Item1 > dgv.ColumnCount - 1)
                {
                    AddColumn(seat.Coordonnees.Item1 - dgv.ColumnCount + 1);
                }
                if (seat.Coordonnees.Item2 > dgv.RowCount - 1)
                {
                    AddRow(seat.Coordonnees.Item2 - dgv.RowCount + 1);
                }

                ChangeCellBackcolor(seat.Coordonnees, Color.Yellow);

                ChangeCellValue(seat.Coordonnees, seat.StudentName);
            }
        }

        public void ChangeCellBackcolor((int, int) cellCoordinate, Color backColor)
        {
            dgv.Rows[cellCoordinate.Item2].Cells[cellCoordinate.Item1].Style.BackColor = backColor;
        }

        public void ChangeCellValue((int, int) cellCoordinate, object value)
        {
            dgv.Rows[cellCoordinate.Item2].Cells[cellCoordinate.Item1].Value = value;
        }

        public DataGridViewCell GetCell((int, int) cellCoordinate)
        {
            return dgv.Rows[cellCoordinate.Item2].Cells[cellCoordinate.Item1];
        }

        public void RefreshPlan()
        {
            dgv.Refresh();
        }

        private void imageExportBtn_Click(object sender, EventArgs e)
        {
            RaiseAboutToExport();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image PNG (HD)|*.png|Image PNG (SD)|*.png";
            sfd.AddExtension = true;
            sfd.CheckPathExists = true;
            sfd.OverwritePrompt = true;
            sfd.FileName = ExportName;
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                dgv.ClearSelection();

                this.SuspendLayout();

                float previousZoom = Zoom;
                switch (sfd.FilterIndex)
                {
                    case 1:
                        Zoom = HDExport;
                        break;

                    case 2:
                        Zoom = SDExport;
                        break;
                }
                

                // Resize label font
                descLblV2.Font = new Font(descLblV2.Font.FontFamily, Zoom * 10 + 1);

                //Resize DataGridView to full height.
                int height = dgv.Height;
                dgv.Height = (int)((dgv.RowCount * CellHeight + 25) * Zoom);

                //Resize DataGridView to full width.
                int width = dgv.Width;
                dgv.Width = (int)((dgv.ColumnCount * CellWidth + 47 + (dgv.RowHeadersWidth - 45)) * Zoom);

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

                descLblV2.Text = String.Format("" +
                    "Nom du plan de classe :                                {0}" +
                    "\r\nSalle :                                                                    {1} ({2} places)" +
                    "\r\nClasse :                                                                 {3} ({4} élèves)" +
                    "\r\nEmpêcher les affinités de bavardage :     {5}" +
                    "\r\nÉlèves placés :                                                   {6}",
                    ExportName, WorkingPlan.RoomName, WorkingPlan.Seats.Count, WorkingPlan.GroupName, WorkingPlan.NotEmptySeatsCount, affinitiesDesc, fillModeDesc);

                

                //Create a Bitmap and draw the DataGridView on it.
                Bitmap bitmap = new Bitmap(Math.Max(dgv.Width, descLblV2.Width), dgv.Height + 10 + descLblV2.Height);

                dgv.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dgv.Width, dgv.Height));
                
                descLblV2.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, dgv.Height + 10, descLblV2.Width, descLblV2.Height));

                //Resize DataGridView back to original height.
                dgv.Height = height;
                dgv.Width = width;

                Zoom = previousZoom;

                this.ResumeLayout();

                //Save the Bitmap to folder.

                bitmap.Save(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le plan de classe n'a pas pu être exporté. Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pdfExportBtn_Click(object sender, EventArgs e)
        {
            //SaveFileDialog savepdf = new SaveFileDialog();
            //savepdf.Filter = "Fichier PDF |*.pdf";
            //if (savepdf.ShowDialog() == DialogResult.OK)
            //{
            //    //Creating iTextSharp Table from the DataTable data
            //    PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            //    pdfTable.DefaultCell.MinimumHeight = CellHeight * 10f;
            //    pdfTable.DefaultCell.Padding = 3;
            //    pdfTable.WidthPercentage = 30;
            //    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //    pdfTable.DefaultCell.BorderWidth = 1;

            //    //Adding Header row
            //    foreach (DataGridViewColumn column in dgv.Columns)
            //    {
            //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //        pdfTable.AddCell(cell);
            //    }

            //    for (int i = 0; i < dgv.Rows.Count - 1; i++)
            //    {
            //        for (int j = 0; j < dgv.Rows[1].Cells.Count; j++)
            //        {
            //            if (dgv.Rows[i].Cells[j].Value == null || (string)dgv.Rows[i].Cells[j].Value == "")
            //            {
            //                continue;
            //            }
            //            pdfTable.AddCell("");
            //            pdfTable.AddCell("");
            //            pdfTable.AddCell("");
            //            pdfTable.AddCell(new PdfPCell(new Phrase(dgv.Rows[i].Cells[j].Value.ToString())) { BackgroundColor = dgv.Rows[i].Cells[j].Style.BackColor == Color.Yellow ? BaseColor.YELLOW : BaseColor.WHITE });
            //        }
            //    }


            //    pdfTable.WidthPercentage = (float)CellWidth;

            //    //Exporting to PDF
            //    using (FileStream stream = new FileStream(savepdf.FileName, FileMode.Create))
            //    {
            //        Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
            //        PdfWriter.GetInstance(pdfDoc, stream);
            //        pdfDoc.Open();
            //        pdfDoc.Add(pdfTable);
            //        pdfDoc.Close();
            //        stream.Close();
            //    }

            //}
        }

        private void excelExportBtn_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            dgv.ClearSelection();
        }

        private void zoomTrkBar_Scroll(object sender, EventArgs e)
        {
            Zoom = zoomTrkBar.Value / 10f;
        }
    }
}
