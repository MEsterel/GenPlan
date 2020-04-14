namespace GenPlan.Addons
{
    partial class RoomsViewerUserCtrl
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
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.roomLstView = new System.Windows.Forms.ListView();
            this.roomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteGroupBtn = new System.Windows.Forms.Button();
            this.roomsLstViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsLstViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRoomBtn.Image = global::GenPlan.Properties.Resources.add16;
            this.addRoomBtn.Location = new System.Drawing.Point(3, 290);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(123, 24);
            this.addRoomBtn.TabIndex = 7;
            this.addRoomBtn.Text = "Ajouter une salle";
            this.addRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addRoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // roomLstView
            // 
            this.roomLstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomName,
            this.placesCount});
            this.roomLstView.ContextMenuStrip = this.roomsLstViewMenuStrip;
            this.roomLstView.FullRowSelect = true;
            this.roomLstView.HideSelection = false;
            this.roomLstView.Location = new System.Drawing.Point(3, 3);
            this.roomLstView.Name = "roomLstView";
            this.roomLstView.Size = new System.Drawing.Size(410, 281);
            this.roomLstView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.roomLstView.TabIndex = 6;
            this.roomLstView.UseCompatibleStateImageBehavior = false;
            this.roomLstView.View = System.Windows.Forms.View.Details;
            this.roomLstView.SelectedIndexChanged += new System.EventHandler(this.roomLstView_SelectedIndexChanged);
            this.roomLstView.DoubleClick += new System.EventHandler(this.roomLstView_DoubleClick);
            this.roomLstView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomLstView_KeyDown);
            // 
            // roomName
            // 
            this.roomName.Text = "Nom de ma salle";
            this.roomName.Width = 258;
            // 
            // placesCount
            // 
            this.placesCount.Text = "Nombre de places";
            this.placesCount.Width = 110;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyBtn.Enabled = false;
            this.modifyBtn.Image = global::GenPlan.Properties.Resources.edit16;
            this.modifyBtn.Location = new System.Drawing.Point(225, 290);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(91, 24);
            this.modifyBtn.TabIndex = 9;
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
            this.deleteGroupBtn.Location = new System.Drawing.Point(322, 290);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(91, 24);
            this.deleteGroupBtn.TabIndex = 8;
            this.deleteGroupBtn.Text = "Supprimer";
            this.deleteGroupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteGroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteGroupBtn.UseVisualStyleBackColor = true;
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // roomsLstViewMenuStrip
            // 
            this.roomsLstViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.roomsLstViewMenuStrip.Name = "studentLstViewMenuStrip";
            this.roomsLstViewMenuStrip.Size = new System.Drawing.Size(130, 48);
            this.roomsLstViewMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.roomsLstViewMenuStrip_Opening);
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
            // RoomsViewerUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteGroupBtn);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.roomLstView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RoomsViewerUserCtrl";
            this.Size = new System.Drawing.Size(416, 317);
            this.roomsLstViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.ListView roomLstView;
        private System.Windows.Forms.ColumnHeader roomName;
        private System.Windows.Forms.ColumnHeader placesCount;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteGroupBtn;
        private System.Windows.Forms.ContextMenuStrip roomsLstViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
