namespace GenPlan.Addons
{
    partial class PlansViewerUserCtrl
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
            this.planLstView = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createPlanBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // planLstView
            // 
            this.planLstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.dateCol});
            this.planLstView.ContextMenuStrip = this.contextMenuStrip1;
            this.planLstView.FullRowSelect = true;
            this.planLstView.Location = new System.Drawing.Point(3, 3);
            this.planLstView.Name = "planLstView";
            this.planLstView.Size = new System.Drawing.Size(444, 235);
            this.planLstView.TabIndex = 0;
            this.planLstView.UseCompatibleStateImageBehavior = false;
            this.planLstView.View = System.Windows.Forms.View.Details;
            this.planLstView.SelectedIndexChanged += new System.EventHandler(this.planLstView_SelectedIndexChanged);
            this.planLstView.DoubleClick += new System.EventHandler(this.planLstView_DoubleClick);
            // 
            // nameCol
            // 
            this.nameCol.Text = "Nom de mon plan de classe";
            this.nameCol.Width = 258;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Image = global::GenPlan.Properties.Resources.eye16;
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GenPlan.Properties.Resources.minus16;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBtn.Enabled = false;
            this.viewBtn.Image = global::GenPlan.Properties.Resources.eye16;
            this.viewBtn.Location = new System.Drawing.Point(257, 244);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(93, 24);
            this.viewBtn.TabIndex = 9;
            this.viewBtn.Text = "Consulter";
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Image = global::GenPlan.Properties.Resources.minus16;
            this.deleteBtn.Location = new System.Drawing.Point(356, 244);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(91, 24);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // createPlanBtn
            // 
            this.createPlanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createPlanBtn.Image = global::GenPlan.Properties.Resources.add16;
            this.createPlanBtn.Location = new System.Drawing.Point(3, 244);
            this.createPlanBtn.Name = "createPlanBtn";
            this.createPlanBtn.Size = new System.Drawing.Size(153, 24);
            this.createPlanBtn.TabIndex = 7;
            this.createPlanBtn.Text = "Créer un plan de classe";
            this.createPlanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createPlanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createPlanBtn.UseVisualStyleBackColor = true;
            this.createPlanBtn.Click += new System.EventHandler(this.createPlanBtn_Click);
            // 
            // PlansViewerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createPlanBtn);
            this.Controls.Add(this.planLstView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlansViewerUserCtrl";
            this.Size = new System.Drawing.Size(450, 271);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView planLstView;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createPlanBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
