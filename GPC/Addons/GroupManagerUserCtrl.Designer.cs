namespace GenPlan.Addons
{
    partial class GroupManagerUserCtrl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsLstView = new System.Windows.Forms.ListView();
            this.studentNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affinitiesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsLstViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentNbrTxt = new System.Windows.Forms.Label();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.studentTxt = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.affinitiesGrpBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.affinitiesLst = new System.Windows.Forms.ListBox();
            this.affinitiesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAffinityLnkLbl = new System.Windows.Forms.LinkLabel();
            this.deleteAffinityBtn = new System.Windows.Forms.Button();
            this.addAffinityBtn = new System.Windows.Forms.Button();
            this.affinitiesCmbBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.studentsLstViewMenuStrip.SuspendLayout();
            this.affinitiesGrpBox.SuspendLayout();
            this.affinitiesMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.studentsLstView);
            this.groupBox1.Controls.Add(this.studentNbrTxt);
            this.groupBox1.Controls.Add(this.deleteStudentBtn);
            this.groupBox1.Controls.Add(this.studentTxt);
            this.groupBox1.Controls.Add(this.addStudentBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des élèves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajouter un élève :";
            // 
            // studentsLstView
            // 
            this.studentsLstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentNameCol,
            this.affinitiesCol});
            this.studentsLstView.ContextMenuStrip = this.studentsLstViewMenuStrip;
            this.studentsLstView.FullRowSelect = true;
            this.studentsLstView.HideSelection = false;
            this.studentsLstView.LabelEdit = true;
            this.studentsLstView.Location = new System.Drawing.Point(6, 51);
            this.studentsLstView.MultiSelect = false;
            this.studentsLstView.Name = "studentsLstView";
            this.studentsLstView.Size = new System.Drawing.Size(473, 158);
            this.studentsLstView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.studentsLstView.TabIndex = 26;
            this.studentsLstView.UseCompatibleStateImageBehavior = false;
            this.studentsLstView.View = System.Windows.Forms.View.Details;
            this.studentsLstView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.studentsLstView_AfterLabelEdit);
            this.studentsLstView.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.studentsLstView_BeforeLabelEdit);
            this.studentsLstView.SelectedIndexChanged += new System.EventHandler(this.StudentsLstView_SelectedIndexChanged);
            this.studentsLstView.Resize += new System.EventHandler(this.studentsLstView_Resize);
            // 
            // studentNameCol
            // 
            this.studentNameCol.Text = "Élève";
            this.studentNameCol.Width = 150;
            // 
            // affinitiesCol
            // 
            this.affinitiesCol.Text = "Affinités de bavardage";
            this.affinitiesCol.Width = 314;
            // 
            // studentsLstViewMenuStrip
            // 
            this.studentsLstViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renommerToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.studentsLstViewMenuStrip.Name = "studentLstViewMenuStrip";
            this.studentsLstViewMenuStrip.Size = new System.Drawing.Size(134, 48);
            this.studentsLstViewMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.studentLstViewMenuStrip_Opening);
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Image = global::GenPlan.Properties.Resources.edit16;
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renommerToolStripMenuItem.Text = "Renommer";
            this.renommerToolStripMenuItem.Click += new System.EventHandler(this.renommerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GenPlan.Properties.Resources.deleteUser16;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // studentNbrTxt
            // 
            this.studentNbrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentNbrTxt.AutoSize = true;
            this.studentNbrTxt.Location = new System.Drawing.Point(6, 220);
            this.studentNbrTxt.Name = "studentNbrTxt";
            this.studentNbrTxt.Size = new System.Drawing.Size(111, 15);
            this.studentNbrTxt.TabIndex = 25;
            this.studentNbrTxt.Text = "Nombre d\'élèves : 0";
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStudentBtn.Enabled = false;
            this.deleteStudentBtn.Image = global::GenPlan.Properties.Resources.deleteUser16;
            this.deleteStudentBtn.Location = new System.Drawing.Point(383, 215);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(96, 24);
            this.deleteStudentBtn.TabIndex = 3;
            this.deleteStudentBtn.Text = "Supprimer";
            this.deleteStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteStudentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // studentTxt
            // 
            this.studentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTxt.Location = new System.Drawing.Point(111, 22);
            this.studentTxt.Name = "studentTxt";
            this.studentTxt.Size = new System.Drawing.Size(283, 23);
            this.studentTxt.TabIndex = 0;
            this.studentTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentTxt_KeyDown);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentBtn.Image = global::GenPlan.Properties.Resources.addUser16;
            this.addStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addStudentBtn.Location = new System.Drawing.Point(400, 21);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(79, 24);
            this.addStudentBtn.TabIndex = 1;
            this.addStudentBtn.Text = "Ajouter";
            this.addStudentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // affinitiesGrpBox
            // 
            this.affinitiesGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.affinitiesGrpBox.Controls.Add(this.label3);
            this.affinitiesGrpBox.Controls.Add(this.affinitiesLst);
            this.affinitiesGrpBox.Controls.Add(this.helpAffinityLnkLbl);
            this.affinitiesGrpBox.Controls.Add(this.deleteAffinityBtn);
            this.affinitiesGrpBox.Controls.Add(this.addAffinityBtn);
            this.affinitiesGrpBox.Controls.Add(this.affinitiesCmbBox);
            this.affinitiesGrpBox.Location = new System.Drawing.Point(3, 289);
            this.affinitiesGrpBox.Name = "affinitiesGrpBox";
            this.affinitiesGrpBox.Size = new System.Drawing.Size(485, 194);
            this.affinitiesGrpBox.TabIndex = 1;
            this.affinitiesGrpBox.TabStop = false;
            this.affinitiesGrpBox.Text = "Affinités de bavardage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ajouter une affinité de bavardage :";
            // 
            // affinitiesLst
            // 
            this.affinitiesLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.affinitiesLst.ContextMenuStrip = this.affinitiesMenuStrip;
            this.affinitiesLst.FormattingEnabled = true;
            this.affinitiesLst.ItemHeight = 15;
            this.affinitiesLst.Location = new System.Drawing.Point(6, 51);
            this.affinitiesLst.Name = "affinitiesLst";
            this.affinitiesLst.Size = new System.Drawing.Size(473, 109);
            this.affinitiesLst.TabIndex = 6;
            // 
            // affinitiesMenuStrip
            // 
            this.affinitiesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem1});
            this.affinitiesMenuStrip.Name = "affinitiesMenuStrip";
            this.affinitiesMenuStrip.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.SupprimerToolStripMenuItem1_Click);
            // 
            // helpAffinityLnkLbl
            // 
            this.helpAffinityLnkLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpAffinityLnkLbl.AutoSize = true;
            this.helpAffinityLnkLbl.Location = new System.Drawing.Point(6, 169);
            this.helpAffinityLnkLbl.Name = "helpAffinityLnkLbl";
            this.helpAffinityLnkLbl.Size = new System.Drawing.Size(127, 15);
            this.helpAffinityLnkLbl.TabIndex = 7;
            this.helpAffinityLnkLbl.TabStop = true;
            this.helpAffinityLnkLbl.Text = "Comment ça marche ?";
            this.helpAffinityLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpAffinityLnkLbl_LinkClicked);
            // 
            // deleteAffinityBtn
            // 
            this.deleteAffinityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAffinityBtn.Location = new System.Drawing.Point(400, 164);
            this.deleteAffinityBtn.Name = "deleteAffinityBtn";
            this.deleteAffinityBtn.Size = new System.Drawing.Size(79, 24);
            this.deleteAffinityBtn.TabIndex = 8;
            this.deleteAffinityBtn.Text = "Supprimer";
            this.deleteAffinityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteAffinityBtn.UseVisualStyleBackColor = true;
            this.deleteAffinityBtn.Click += new System.EventHandler(this.DeleteAffinityBtn_Click);
            // 
            // addAffinityBtn
            // 
            this.addAffinityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAffinityBtn.Location = new System.Drawing.Point(420, 21);
            this.addAffinityBtn.Name = "addAffinityBtn";
            this.addAffinityBtn.Size = new System.Drawing.Size(59, 24);
            this.addAffinityBtn.TabIndex = 5;
            this.addAffinityBtn.Text = "Ajouter";
            this.addAffinityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAffinityBtn.UseVisualStyleBackColor = true;
            this.addAffinityBtn.Click += new System.EventHandler(this.AddAffinityBtn_Click);
            // 
            // affinitiesCmbBox
            // 
            this.affinitiesCmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.affinitiesCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinitiesCmbBox.FormattingEnabled = true;
            this.affinitiesCmbBox.Location = new System.Drawing.Point(201, 22);
            this.affinitiesCmbBox.Name = "affinitiesCmbBox";
            this.affinitiesCmbBox.Size = new System.Drawing.Size(213, 23);
            this.affinitiesCmbBox.Sorted = true;
            this.affinitiesCmbBox.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.affinitiesGrpBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 486);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupNameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 29);
            this.panel1.TabIndex = 2;
            // 
            // groupNameTxt
            // 
            this.groupNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameTxt.Location = new System.Drawing.Point(108, 3);
            this.groupNameTxt.Name = "groupNameTxt";
            this.groupNameTxt.Size = new System.Drawing.Size(374, 23);
            this.groupNameTxt.TabIndex = 1;
            this.groupNameTxt.TextChanged += new System.EventHandler(this.groupNameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de la classe :";
            // 
            // GroupManagerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GroupManagerUserCtrl";
            this.Size = new System.Drawing.Size(491, 486);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.studentsLstViewMenuStrip.ResumeLayout(false);
            this.affinitiesGrpBox.ResumeLayout(false);
            this.affinitiesGrpBox.PerformLayout();
            this.affinitiesMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox affinitiesGrpBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.TextBox studentTxt;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.ComboBox affinitiesCmbBox;
        private System.Windows.Forms.Button addAffinityBtn;
        private System.Windows.Forms.LinkLabel helpAffinityLnkLbl;
        private System.Windows.Forms.Button deleteAffinityBtn;
        private System.Windows.Forms.ListBox affinitiesLst;
        private System.Windows.Forms.Label studentNbrTxt;
        private System.Windows.Forms.ListView studentsLstView;
        private System.Windows.Forms.ColumnHeader studentNameCol;
        private System.Windows.Forms.ColumnHeader affinitiesCol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox groupNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip studentsLstViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem renommerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip affinitiesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
