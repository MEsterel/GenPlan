namespace GenPlan.Addons
{
    partial class GroupsViewerUserCtrl
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
            this.grpLstView = new System.Windows.Forms.ListView();
            this.groupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupsLstViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteGroupBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.groupsLstViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLstView
            // 
            this.grpLstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.groupName,
            this.groupCount});
            this.grpLstView.ContextMenuStrip = this.groupsLstViewMenuStrip;
            this.grpLstView.FullRowSelect = true;
            this.grpLstView.HideSelection = false;
            this.grpLstView.Location = new System.Drawing.Point(3, 3);
            this.grpLstView.MultiSelect = false;
            this.grpLstView.Name = "grpLstView";
            this.grpLstView.Size = new System.Drawing.Size(413, 261);
            this.grpLstView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grpLstView.TabIndex = 2;
            this.grpLstView.UseCompatibleStateImageBehavior = false;
            this.grpLstView.View = System.Windows.Forms.View.Details;
            this.grpLstView.SelectedIndexChanged += new System.EventHandler(this.grpLstView_SelectedIndexChanged);
            this.grpLstView.DoubleClick += new System.EventHandler(this.grpLstView_DoubleClick);
            this.grpLstView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grpLstView_KeyDown);
            // 
            // groupName
            // 
            this.groupName.Text = "Nom de ma classe";
            this.groupName.Width = 258;
            // 
            // groupCount
            // 
            this.groupCount.Text = "Nombre d\'élèves";
            this.groupCount.Width = 101;
            // 
            // groupsLstViewMenuStrip
            // 
            this.groupsLstViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.groupsLstViewMenuStrip.Name = "studentLstViewMenuStrip";
            this.groupsLstViewMenuStrip.Size = new System.Drawing.Size(130, 48);
            this.groupsLstViewMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.groupsLstViewMenuStrip_Opening);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::GenPlan.Properties.Resources.edit16;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GenPlan.Properties.Resources.minus16;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(502, 345);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyBtn.Enabled = false;
            this.modifyBtn.Image = global::GenPlan.Properties.Resources.edit16;
            this.modifyBtn.Location = new System.Drawing.Point(228, 270);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(91, 24);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modifier";
            this.modifyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGroupBtn.Enabled = false;
            this.deleteGroupBtn.Image = global::GenPlan.Properties.Resources.minus16;
            this.deleteGroupBtn.Location = new System.Drawing.Point(325, 270);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(91, 24);
            this.deleteGroupBtn.TabIndex = 5;
            this.deleteGroupBtn.Text = "Supprimer";
            this.deleteGroupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteGroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteGroupBtn.UseVisualStyleBackColor = true;
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addGroupBtn.Image = global::GenPlan.Properties.Resources.add16;
            this.addGroupBtn.Location = new System.Drawing.Point(3, 270);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(130, 24);
            this.addGroupBtn.TabIndex = 4;
            this.addGroupBtn.Text = "Ajouter une classe";
            this.addGroupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // GroupsViewerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteGroupBtn);
            this.Controls.Add(this.addGroupBtn);
            this.Controls.Add(this.grpLstView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GroupsViewerUserCtrl";
            this.Size = new System.Drawing.Size(419, 297);
            this.groupsLstViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView grpLstView;
        private System.Windows.Forms.ColumnHeader groupName;
        private System.Windows.Forms.ColumnHeader groupCount;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Button deleteGroupBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.ContextMenuStrip groupsLstViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
