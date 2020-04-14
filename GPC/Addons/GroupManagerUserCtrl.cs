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
    public partial class GroupManagerUserCtrl : UserControl
    {
        public bool UnsavedData { get; set; } = false;

        private Student beforeLabelEditStudent;

        private Group _workingGroup = new Group();
        public Group WorkingGroup
        {
            get
            {
                _workingGroup.Name = GroupNameTxt;
                return _workingGroup;
            }
            private set
            {
                _workingGroup = value;
            }
        }

        public string GroupNameTxt => groupNameTxt.Text;

        public GroupManagerUserCtrl()
        {
            InitializeComponent();
            SizeLastColumn(studentsLstView);

            EnableAffinityControls(false);
            studentsLstView.Sort();
        }

        public void LoadGroup(Group workingGroup)
        {
            groupNameTxt.Text = workingGroup.Name;
            WorkingGroup = new Group(workingGroup);

            studentsLstView.Items.Clear();

            foreach (Student st in WorkingGroup.Students)
            {
                studentsLstView.Items.Add(new ListViewItem(new string[] { st.Name, st.TalkingAffinitiesToString() }) { Name = st.Name });
            }

            RefreshStudentCount();

            UnsavedData = false;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (String.IsNullOrWhiteSpace(studentTxt.Text))
            {
                MessageBox.Show("Veuillez indiquer le nom de l'élève à ajouter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (WorkingGroup.Students.Any(x => x.Name == studentTxt.Text))
            {
                MessageBox.Show("Un élève du même nom a déjà été ajouté dans cette classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WorkingGroup.AddStudent(new Student(studentTxt.Text));
            studentsLstView.Items.Add(new ListViewItem(new string[] { studentTxt.Text, "" }) { Name = studentTxt.Text });

            studentTxt.Text = "";
            RefreshStudentCount();
        }

        private void RefreshStudentCount()
        {
            studentNbrTxt.Text = "Nombre d'élèves : " + WorkingGroup.StudentsCount;
        }

        private void StudentTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddStudentBtn_Click(sender, null);
                e.SuppressKeyPress = true;
            }
        }

        private void StudentsLst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteStudentBtn_Click(sender, null);
            }
        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (studentsLstView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student selectedStudent = WorkingGroup.Students.Find(x => x.Name == studentsLstView.SelectedItems[0].Name);

            string[] exAffinities = selectedStudent.TalkingAffinities.ToArray();

            WorkingGroup.DeleteStudent(selectedStudent);
            studentsLstView.Items.Remove(studentsLstView.SelectedItems[0]);

            foreach (string affinity in exAffinities)
            {
                studentsLstView.Items[affinity].SubItems[1].Text = WorkingGroup.Students.Find(x => x.Name == affinity).TalkingAffinitiesToString();
            }

            RefreshStudentCount();
        }

        private void StudentsLstView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (studentsLstView.SelectedItems.Count == 0)
            {
                // Delete button
                deleteStudentBtn.Enabled = false;

                // Affinity update
                EnableAffinityControls(false);
                affinitiesCmbBox.Items.Clear();
                affinitiesLst.Items.Clear();
            }
            else
            {
                // Delete button
                deleteStudentBtn.Enabled = true;

                // Affinity update
                EnableAffinityControls(true, studentsLstView.SelectedItems[0].Text);

                Student selectedStudent = WorkingGroup.Students.Find(x => x.Name == studentsLstView.SelectedItems[0].Text);
                RefreshAffinities(selectedStudent);
            }
        }

        private void RefreshAffinities(Student selectedStudent)
        {
            if (selectedStudent == null)
            {
                return;
            }

            affinitiesCmbBox.Items.Clear();
            affinitiesLst.Items.Clear();

            affinitiesCmbBox.Items.AddRange(WorkingGroup.Students
                .Where(x => selectedStudent.TalkingAffinitiesToArray().Contains(x.Name) == false && x != selectedStudent).ToArray());

            affinitiesLst.Items.AddRange(selectedStudent.TalkingAffinitiesToArray());
        }

        private void EnableAffinityControls(bool v, string name = "")
        {
            if (v)
            {
                affinitiesGrpBox.Text = "Affinités de bavardage : " + name;
                affinitiesGrpBox.ForeColor = Color.Black;
                addAffinityBtn.Enabled = true;
                affinitiesCmbBox.Enabled = true;
                affinitiesLst.Enabled = true;
                deleteAffinityBtn.Enabled = true;
            }
            else
            {
                affinitiesGrpBox.Text = "Affinités de bavardage";
                affinitiesGrpBox.ForeColor = Color.DarkGray;
                addAffinityBtn.Enabled = false;
                affinitiesCmbBox.Enabled = false;
                affinitiesLst.Enabled = false;
                deleteAffinityBtn.Enabled = false;
            }
        }

        private void AddAffinityBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (affinitiesCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un élève dans la liste proposée.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Student selectedStudent = WorkingGroup.Students.Find(x => x.Name == studentsLstView.SelectedItems[0].Text);
            string newAffinityName = affinitiesCmbBox.SelectedItem.ToString();

            // Add affinity in student objects
            selectedStudent.AddAffinity(WorkingGroup.Students.Find(x => x.Name == newAffinityName));

            // Add affinity in list
            affinitiesLst.Items.Add(newAffinityName);

            // Remove affinity from cmbbox
            affinitiesCmbBox.Items.Remove(newAffinityName);

            // Add affinity in StudentsLstView

            studentsLstView.Items[selectedStudent.Name].SubItems[1].Text = selectedStudent.TalkingAffinitiesToString();
            studentsLstView.Items[newAffinityName].SubItems[1].Text = WorkingGroup.Students.Find(x => x.Name == newAffinityName).TalkingAffinitiesToString();

            RefreshAffinities(selectedStudent);
        }

        private void helpAffinityLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpForm hf = new HelpForm("Une affinité de bavardage entre deux élèves implique qu'ils ne pourront pas être côte-à-côte." +
                "\r\n\r\nPour ajouter des affinités de bavardage à un élève :" +
                "\r\n1. Sélectionnez un élève dans la liste des élèves de la classe." +
                "\r\n2. Sélectionnez un élève dans le menu déroulant." +
                "\r\n3. Cliquez sur Ajouter." +
                "\r\n\r\n À noter : une affinité de bavardage est réciproque entre les deux élèves.",
                "Affinités de bavardage");
            hf.ShowDialog();
        }

        private void studentsLstView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (beforeLabelEditStudent == null)
            {
                e.CancelEdit = true;
                return;
            }

            if (e.Label == null)
            {
                e.CancelEdit = true;
                return;
            }

            if (WorkingGroup.Students.Exists(x => x.Name == e.Label))
            {
                MessageBox.Show("Un élève du même nom existe déjà. Veuillez en choisir un autre.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.CancelEdit = true;
                return;
            }

            WorkingGroup.RenameStudent(beforeLabelEditStudent, e.Label);

            studentsLstView.Items[e.Item].Name = e.Label;

            foreach (string affinity in beforeLabelEditStudent.TalkingAffinities)
            {
                studentsLstView.Items[affinity].SubItems[1].Text = WorkingGroup.Students.Find(x => x.Name == affinity).TalkingAffinitiesToString();
            }

            UnsavedData = true;
        }

        private void studentsLstView_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (studentsLstView.SelectedItems.Count == 0)
            {
                e.CancelEdit = true;
                return;
            }
            beforeLabelEditStudent = WorkingGroup.Students.Find(x => x.Name == studentsLstView.SelectedItems[0].Text);
        }

        private void studentLstViewMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (studentsLstView.SelectedItems.Count != 1)
            {
                e.Cancel = true;
            }
        }

        private void renommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentsLstView.SelectedItems.Count == 1)
            {
                studentsLstView.SelectedItems[0].BeginEdit();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e) // Supprimer, du menu des élèves
        {
            DeleteStudentBtn_Click(this, null);
        }

        private void SupprimerToolStripMenuItem1_Click(object sender, EventArgs e) // Supprimer, du menu des affinités
        {
            DeleteAffinityBtn_Click(null, null);
        }

        private void DeleteAffinityBtn_Click(object sender, EventArgs e)
        {
            UnsavedData = true;

            if (affinitiesLst.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionner une affinité de bavardage à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Student selectedStudent = WorkingGroup.Students.Find(x => x.Name == studentsLstView.SelectedItems[0].Text);
            Student selectedAffinity = WorkingGroup.Students.Find(x => x.Name == (string)affinitiesLst.SelectedItem);
            selectedStudent.DeleteAffinity(selectedAffinity);

            studentsLstView.Items[selectedStudent.Name].SubItems[1].Text = selectedStudent.TalkingAffinitiesToString();
            studentsLstView.Items[selectedAffinity.Name].SubItems[1].Text = selectedAffinity.TalkingAffinitiesToString();

            affinitiesLst.Items.Remove(affinitiesLst.SelectedItem);
        }

        private void groupNameTxt_TextChanged(object sender, EventArgs e)
        {
            UnsavedData = true;
        }

        private void studentsLstView_Resize(object sender, EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void SizeLastColumn(ListView lv)
        {
            studentsLstView.Columns[lv.Columns.Count - 1].Width = -2;
        }
    }
}
