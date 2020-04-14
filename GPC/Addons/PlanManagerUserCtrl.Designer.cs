namespace GenPlan.Addons
{
    partial class PlanManagerUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanManagerUserCtrl));
            this.label1 = new System.Windows.Forms.Label();
            this.planNameTxt = new System.Windows.Forms.TextBox();
            this.roomCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupCmbBox = new System.Windows.Forms.ComboBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.planDrawerUC = new GenPlan.Addons.PlanDrawerUserCtrl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.optionsGrpBox = new System.Windows.Forms.GroupBox();
            this.planOptionsUC = new GenPlan.Addons.PlanOptionsUserCtrl();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generatingStatePnl = new System.Windows.Forms.Panel();
            this.genLastStudentPlacedLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.genDurationLbl = new System.Windows.Forms.Label();
            this.genPlacedStudentsLbl = new System.Windows.Forms.Label();
            this.genStateLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.optionsGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.generatingStatePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // planNameTxt
            // 
            this.planNameTxt.Location = new System.Drawing.Point(55, 3);
            this.planNameTxt.Name = "planNameTxt";
            this.planNameTxt.Size = new System.Drawing.Size(327, 23);
            this.planNameTxt.TabIndex = 1;
            // 
            // roomCmbBox
            // 
            this.roomCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomCmbBox.FormattingEnabled = true;
            this.roomCmbBox.Location = new System.Drawing.Point(55, 32);
            this.roomCmbBox.Name = "roomCmbBox";
            this.roomCmbBox.Size = new System.Drawing.Size(327, 23);
            this.roomCmbBox.TabIndex = 4;
            this.roomCmbBox.SelectedIndexChanged += new System.EventHandler(this.roomCmbBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salle :";
            // 
            // groupCmbBox
            // 
            this.groupCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCmbBox.FormattingEnabled = true;
            this.groupCmbBox.Location = new System.Drawing.Point(55, 61);
            this.groupCmbBox.Name = "groupCmbBox";
            this.groupCmbBox.Size = new System.Drawing.Size(327, 23);
            this.groupCmbBox.TabIndex = 7;
            this.groupCmbBox.SelectedIndexChanged += new System.EventHandler(this.groupCmbBox_SelectedIndexChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(3, 324);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(379, 41);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "GÉNÉRER";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.planDrawerUC);
            this.groupBox2.Location = new System.Drawing.Point(388, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 730);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat de la génération";
            // 
            // planDrawerUC
            // 
            this.planDrawerUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planDrawerUC.BackColor = System.Drawing.Color.White;
            this.planDrawerUC.CanExport = true;
            this.planDrawerUC.ExportName = null;
            this.planDrawerUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planDrawerUC.Location = new System.Drawing.Point(6, 22);
            this.planDrawerUC.Name = "planDrawerUC";
            this.planDrawerUC.Size = new System.Drawing.Size(620, 702);
            this.planDrawerUC.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // optionsGrpBox
            // 
            this.optionsGrpBox.Controls.Add(this.planOptionsUC);
            this.optionsGrpBox.Location = new System.Drawing.Point(3, 90);
            this.optionsGrpBox.Name = "optionsGrpBox";
            this.optionsGrpBox.Size = new System.Drawing.Size(379, 228);
            this.optionsGrpBox.TabIndex = 15;
            this.optionsGrpBox.TabStop = false;
            this.optionsGrpBox.Text = "Options";
            // 
            // planOptionsUC
            // 
            this.planOptionsUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planOptionsUC.BackColor = System.Drawing.Color.White;
            this.planOptionsUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planOptionsUC.Location = new System.Drawing.Point(6, 22);
            this.planOptionsUC.Name = "planOptionsUC";
            this.planOptionsUC.Size = new System.Drawing.Size(367, 200);
            this.planOptionsUC.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelBtn.Location = new System.Drawing.Point(310, 370);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(72, 25);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(3, 371);
            this.prgBar.MarqueeAnimationSpeed = 20;
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(301, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(24, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 216);
            this.label2.TabIndex = 18;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GenPlan.Properties.Resources.warning16;
            this.pictureBox2.Location = new System.Drawing.Point(2, 636);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GenPlan.Properties.Resources.info16;
            this.pictureBox1.Location = new System.Drawing.Point(3, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generatingStatePnl);
            this.groupBox1.Controls.Add(this.genStateLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 87);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moniteur de génération";
            // 
            // generatingStatePnl
            // 
            this.generatingStatePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatingStatePnl.Controls.Add(this.genLastStudentPlacedLbl);
            this.generatingStatePnl.Controls.Add(this.label8);
            this.generatingStatePnl.Controls.Add(this.label6);
            this.generatingStatePnl.Controls.Add(this.label7);
            this.generatingStatePnl.Controls.Add(this.genDurationLbl);
            this.generatingStatePnl.Controls.Add(this.genPlacedStudentsLbl);
            this.generatingStatePnl.Enabled = false;
            this.generatingStatePnl.Location = new System.Drawing.Point(6, 35);
            this.generatingStatePnl.Name = "generatingStatePnl";
            this.generatingStatePnl.Size = new System.Drawing.Size(367, 46);
            this.generatingStatePnl.TabIndex = 6;
            // 
            // genLastStudentPlacedLbl
            // 
            this.genLastStudentPlacedLbl.AutoSize = true;
            this.genLastStudentPlacedLbl.Location = new System.Drawing.Point(139, 30);
            this.genLastStudentPlacedLbl.Name = "genLastStudentPlacedLbl";
            this.genLastStudentPlacedLbl.Size = new System.Drawing.Size(29, 15);
            this.genLastStudentPlacedLbl.TabIndex = 6;
            this.genLastStudentPlacedLbl.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Dernier élève placé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Durée de génération :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Élèves placés :";
            // 
            // genDurationLbl
            // 
            this.genDurationLbl.AutoSize = true;
            this.genDurationLbl.Location = new System.Drawing.Point(139, 0);
            this.genDurationLbl.Name = "genDurationLbl";
            this.genDurationLbl.Size = new System.Drawing.Size(29, 15);
            this.genDurationLbl.TabIndex = 4;
            this.genDurationLbl.Text = "N/A";
            // 
            // genPlacedStudentsLbl
            // 
            this.genPlacedStudentsLbl.AutoSize = true;
            this.genPlacedStudentsLbl.Location = new System.Drawing.Point(139, 15);
            this.genPlacedStudentsLbl.Name = "genPlacedStudentsLbl";
            this.genPlacedStudentsLbl.Size = new System.Drawing.Size(29, 15);
            this.genPlacedStudentsLbl.TabIndex = 3;
            this.genPlacedStudentsLbl.Text = "N/A";
            // 
            // genStateLbl
            // 
            this.genStateLbl.AutoSize = true;
            this.genStateLbl.BackColor = System.Drawing.Color.White;
            this.genStateLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.genStateLbl.Location = new System.Drawing.Point(145, 19);
            this.genStateLbl.Name = "genStateLbl";
            this.genStateLbl.Size = new System.Drawing.Size(48, 15);
            this.genStateLbl.TabIndex = 5;
            this.genStateLbl.Text = "À l\'arrêt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "État de la génération :";
            // 
            // PlanManagerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.optionsGrpBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupCmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomCmbBox);
            this.Controls.Add(this.planNameTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanManagerUserCtrl";
            this.Size = new System.Drawing.Size(1023, 736);
            this.groupBox2.ResumeLayout(false);
            this.optionsGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.generatingStatePnl.ResumeLayout(false);
            this.generatingStatePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox planNameTxt;
        private System.Windows.Forms.ComboBox roomCmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groupCmbBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox optionsGrpBox;
        private PlanOptionsUserCtrl planOptionsUC;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PlanDrawerUserCtrl planDrawerUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label genStateLbl;
        private System.Windows.Forms.Label genDurationLbl;
        private System.Windows.Forms.Label genPlacedStudentsLbl;
        private System.Windows.Forms.Panel generatingStatePnl;
        private System.Windows.Forms.Label genLastStudentPlacedLbl;
        private System.Windows.Forms.Label label8;
    }
}
