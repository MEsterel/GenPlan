namespace GenPlan.Addons
{
    partial class PlanOptionsUserCtrl
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
            this.ignoreAffinitiesChkBox = new System.Windows.Forms.CheckBox();
            this.affinitiesModeCmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.animeGenChkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fillModeCmbBox = new System.Windows.Forms.ComboBox();
            this.animationSpeedTrkBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.debugModeChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrkBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ignoreAffinitiesChkBox
            // 
            this.ignoreAffinitiesChkBox.AutoSize = true;
            this.ignoreAffinitiesChkBox.Location = new System.Drawing.Point(3, 3);
            this.ignoreAffinitiesChkBox.Name = "ignoreAffinitiesChkBox";
            this.ignoreAffinitiesChkBox.Size = new System.Drawing.Size(200, 19);
            this.ignoreAffinitiesChkBox.TabIndex = 14;
            this.ignoreAffinitiesChkBox.Text = "Ignorer les affinités de bavardage";
            this.ignoreAffinitiesChkBox.UseVisualStyleBackColor = true;
            this.ignoreAffinitiesChkBox.CheckedChanged += new System.EventHandler(this.ignoreAffinitiesChkBox_CheckedChanged);
            // 
            // affinitiesModeCmbBox
            // 
            this.affinitiesModeCmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.affinitiesModeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinitiesModeCmbBox.FormattingEnabled = true;
            this.affinitiesModeCmbBox.Items.AddRange(new object[] {
            "Directement côtes-à-côtes",
            "Dans un rayon de 1 case",
            "Dans un rayon de 2 cases",
            "Dans un rayon de 3 cases",
            "Dans un rayon de 4 cases",
            "Dans un rayon de 5 cases (très lent)"});
            this.affinitiesModeCmbBox.Location = new System.Drawing.Point(3, 57);
            this.affinitiesModeCmbBox.Name = "affinitiesModeCmbBox";
            this.affinitiesModeCmbBox.Size = new System.Drawing.Size(302, 23);
            this.affinitiesModeCmbBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Éviter le placements d\'affinités de bavardage :";
            // 
            // animeGenChkBox
            // 
            this.animeGenChkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animeGenChkBox.AutoSize = true;
            this.animeGenChkBox.Location = new System.Drawing.Point(3, 226);
            this.animeGenChkBox.Name = "animeGenChkBox";
            this.animeGenChkBox.Size = new System.Drawing.Size(137, 19);
            this.animeGenChkBox.TabIndex = 11;
            this.animeGenChkBox.Text = "Animer la génération";
            this.animeGenChkBox.UseVisualStyleBackColor = true;
            this.animeGenChkBox.CheckedChanged += new System.EventHandler(this.animeGenChkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Placer les élèves :";
            // 
            // fillModeCmbBox
            // 
            this.fillModeCmbBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillModeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillModeCmbBox.FormattingEnabled = true;
            this.fillModeCmbBox.Items.AddRange(new object[] {
            "En avant de la salle",
            "En arrière de la salle"});
            this.fillModeCmbBox.Location = new System.Drawing.Point(102, 103);
            this.fillModeCmbBox.Name = "fillModeCmbBox";
            this.fillModeCmbBox.Size = new System.Drawing.Size(203, 23);
            this.fillModeCmbBox.TabIndex = 16;
            // 
            // animationSpeedTrkBar
            // 
            this.animationSpeedTrkBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animationSpeedTrkBar.Enabled = false;
            this.animationSpeedTrkBar.LargeChange = 300;
            this.animationSpeedTrkBar.Location = new System.Drawing.Point(146, 214);
            this.animationSpeedTrkBar.Maximum = 300;
            this.animationSpeedTrkBar.Minimum = 1;
            this.animationSpeedTrkBar.Name = "animationSpeedTrkBar";
            this.animationSpeedTrkBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.animationSpeedTrkBar.Size = new System.Drawing.Size(159, 45);
            this.animationSpeedTrkBar.SmallChange = 10;
            this.animationSpeedTrkBar.TabIndex = 17;
            this.animationSpeedTrkBar.TickFrequency = 100;
            this.animationSpeedTrkBar.Value = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(146, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vitesse d\'animation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // debugModeChk
            // 
            this.debugModeChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debugModeChk.AutoSize = true;
            this.debugModeChk.Enabled = false;
            this.debugModeChk.Location = new System.Drawing.Point(3, 189);
            this.debugModeChk.Name = "debugModeChk";
            this.debugModeChk.Size = new System.Drawing.Size(173, 19);
            this.debugModeChk.TabIndex = 19;
            this.debugModeChk.Text = "[Développeur] Debug mode";
            this.debugModeChk.UseVisualStyleBackColor = true;
            this.debugModeChk.Visible = false;
            // 
            // PlanOptionsUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.debugModeChk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animationSpeedTrkBar);
            this.Controls.Add(this.fillModeCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ignoreAffinitiesChkBox);
            this.Controls.Add(this.affinitiesModeCmbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.animeGenChkBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanOptionsUserCtrl";
            this.Size = new System.Drawing.Size(308, 263);
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedTrkBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ignoreAffinitiesChkBox;
        private System.Windows.Forms.ComboBox affinitiesModeCmbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox animeGenChkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fillModeCmbBox;
        private System.Windows.Forms.TrackBar animationSpeedTrkBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox debugModeChk;
    }
}
