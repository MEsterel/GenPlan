namespace GenPlan.Addons
{
    partial class PlanDrawerUserCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.exportPnl = new System.Windows.Forms.Panel();
            this.imageExportBtn = new System.Windows.Forms.Button();
            this.descLblV2 = new System.Windows.Forms.Label();
            this.zoomTrkBar = new System.Windows.Forms.TrackBar();
            this.zoomLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.exportPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrkBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "AVANT DE LA SALLE";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv.Location = new System.Drawing.Point(3, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 48;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowCellToolTips = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(427, 308);
            this.dgv.TabIndex = 28;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // exportPnl
            // 
            this.exportPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportPnl.Controls.Add(this.imageExportBtn);
            this.exportPnl.Location = new System.Drawing.Point(3, 312);
            this.exportPnl.Name = "exportPnl";
            this.exportPnl.Size = new System.Drawing.Size(223, 29);
            this.exportPnl.TabIndex = 34;
            // 
            // imageExportBtn
            // 
            this.imageExportBtn.Location = new System.Drawing.Point(0, 3);
            this.imageExportBtn.Name = "imageExportBtn";
            this.imageExportBtn.Size = new System.Drawing.Size(173, 25);
            this.imageExportBtn.TabIndex = 31;
            this.imageExportBtn.Text = "Exporter en tant qu\'image...";
            this.imageExportBtn.UseVisualStyleBackColor = true;
            this.imageExportBtn.Click += new System.EventHandler(this.imageExportBtn_Click);
            // 
            // descLblV2
            // 
            this.descLblV2.AutoSize = true;
            this.descLblV2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLblV2.Location = new System.Drawing.Point(18, 20);
            this.descLblV2.Name = "descLblV2";
            this.descLblV2.Size = new System.Drawing.Size(70, 18);
            this.descLblV2.TabIndex = 35;
            this.descLblV2.Text = "descLblV2";
            this.descLblV2.Visible = false;
            // 
            // zoomTrkBar
            // 
            this.zoomTrkBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrkBar.Location = new System.Drawing.Point(326, 312);
            this.zoomTrkBar.Maximum = 20;
            this.zoomTrkBar.Minimum = 1;
            this.zoomTrkBar.Name = "zoomTrkBar";
            this.zoomTrkBar.Size = new System.Drawing.Size(104, 45);
            this.zoomTrkBar.TabIndex = 36;
            this.zoomTrkBar.TickFrequency = 2;
            this.zoomTrkBar.Value = 10;
            this.zoomTrkBar.Scroll += new System.EventHandler(this.zoomTrkBar_Scroll);
            // 
            // zoomLbl
            // 
            this.zoomLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomLbl.Location = new System.Drawing.Point(251, 320);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.Size = new System.Drawing.Size(81, 13);
            this.zoomLbl.TabIndex = 37;
            this.zoomLbl.Text = "Zoom : 100 %";
            this.zoomLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlanDrawerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.zoomLbl);
            this.Controls.Add(this.zoomTrkBar);
            this.Controls.Add(this.descLblV2);
            this.Controls.Add(this.exportPnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanDrawerUserCtrl";
            this.Size = new System.Drawing.Size(433, 344);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.exportPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrkBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel exportPnl;
        private System.Windows.Forms.Label descLblV2;
        private System.Windows.Forms.Button imageExportBtn;
        private System.Windows.Forms.TrackBar zoomTrkBar;
        private System.Windows.Forms.Label zoomLbl;
    }
}
