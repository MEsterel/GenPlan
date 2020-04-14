namespace GenPlan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.plansTab = new System.Windows.Forms.TabPage();
            this.plansViewerUC = new GenPlan.Addons.PlansViewerUserCtrl();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.grpsViewerUC = new GenPlan.Addons.GroupsViewerUserCtrl();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.roomsViewerUC = new GenPlan.Addons.RoomsViewerUserCtrl();
            this.tabImgLst = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.commentDémarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chercherUneMiseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.plansTab.SuspendLayout();
            this.groupsTab.SuspendLayout();
            this.roomsTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.plansTab);
            this.tabControl1.Controls.Add(this.groupsTab);
            this.tabControl1.Controls.Add(this.roomsTab);
            this.tabControl1.ImageList = this.tabImgLst;
            this.tabControl1.Location = new System.Drawing.Point(-3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // plansTab
            // 
            this.plansTab.Controls.Add(this.plansViewerUC);
            this.plansTab.ImageIndex = 2;
            this.plansTab.Location = new System.Drawing.Point(4, 24);
            this.plansTab.Name = "plansTab";
            this.plansTab.Padding = new System.Windows.Forms.Padding(3);
            this.plansTab.Size = new System.Drawing.Size(480, 316);
            this.plansTab.TabIndex = 2;
            this.plansTab.Text = "Mes plans de classe";
            this.plansTab.UseVisualStyleBackColor = true;
            // 
            // plansViewerUC
            // 
            this.plansViewerUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plansViewerUC.BackColor = System.Drawing.Color.White;
            this.plansViewerUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plansViewerUC.Location = new System.Drawing.Point(3, 3);
            this.plansViewerUC.Name = "plansViewerUC";
            this.plansViewerUC.Size = new System.Drawing.Size(474, 310);
            this.plansViewerUC.TabIndex = 0;
            this.plansViewerUC.UnsavedData = false;
            // 
            // groupsTab
            // 
            this.groupsTab.Controls.Add(this.grpsViewerUC);
            this.groupsTab.ImageIndex = 0;
            this.groupsTab.Location = new System.Drawing.Point(4, 24);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.groupsTab.Size = new System.Drawing.Size(480, 316);
            this.groupsTab.TabIndex = 0;
            this.groupsTab.Text = "Mes classes";
            this.groupsTab.UseVisualStyleBackColor = true;
            // 
            // grpsViewerUC
            // 
            this.grpsViewerUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpsViewerUC.BackColor = System.Drawing.Color.White;
            this.grpsViewerUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpsViewerUC.Location = new System.Drawing.Point(3, 3);
            this.grpsViewerUC.Name = "grpsViewerUC";
            this.grpsViewerUC.Size = new System.Drawing.Size(474, 310);
            this.grpsViewerUC.TabIndex = 0;
            // 
            // roomsTab
            // 
            this.roomsTab.Controls.Add(this.roomsViewerUC);
            this.roomsTab.ImageIndex = 1;
            this.roomsTab.Location = new System.Drawing.Point(4, 24);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(480, 316);
            this.roomsTab.TabIndex = 1;
            this.roomsTab.Text = "Mes salles";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // roomsViewerUC
            // 
            this.roomsViewerUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomsViewerUC.BackColor = System.Drawing.Color.White;
            this.roomsViewerUC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsViewerUC.Location = new System.Drawing.Point(3, 3);
            this.roomsViewerUC.Name = "roomsViewerUC";
            this.roomsViewerUC.Size = new System.Drawing.Size(474, 310);
            this.roomsViewerUC.TabIndex = 0;
            // 
            // tabImgLst
            // 
            this.tabImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabImgLst.ImageStream")));
            this.tabImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.tabImgLst.Images.SetKeyName(0, "group16.png");
            this.tabImgLst.Images.SetKeyName(1, "layer16.png");
            this.tabImgLst.Images.SetKeyName(2, "table16.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.donationBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(483, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator3,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripDropDownButton1.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = global::GenPlan.Properties.Resources.new16;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = global::GenPlan.Properties.Resources.folder16;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::GenPlan.Properties.Resources.save16;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentDémarrerToolStripMenuItem,
            this.toolStripSeparator2,
            this.chercherUneMiseÀJourToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(35, 22);
            this.toolStripDropDownButton2.Text = "Aide";
            // 
            // commentDémarrerToolStripMenuItem
            // 
            this.commentDémarrerToolStripMenuItem.Name = "commentDémarrerToolStripMenuItem";
            this.commentDémarrerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.commentDémarrerToolStripMenuItem.Text = "Comment démarrer ?";
            this.commentDémarrerToolStripMenuItem.Click += new System.EventHandler(this.commentDémarrerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // chercherUneMiseÀJourToolStripMenuItem
            // 
            this.chercherUneMiseÀJourToolStripMenuItem.Image = global::GenPlan.Properties.Resources.update24;
            this.chercherUneMiseÀJourToolStripMenuItem.Name = "chercherUneMiseÀJourToolStripMenuItem";
            this.chercherUneMiseÀJourToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.chercherUneMiseÀJourToolStripMenuItem.Text = "Chercher une mise à jour";
            this.chercherUneMiseÀJourToolStripMenuItem.Click += new System.EventHandler(this.chercherUneMiseÀJourToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // donationBtn
            // 
            this.donationBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.donationBtn.Image = global::GenPlan.Properties.Resources.girtTwo16;
            this.donationBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.donationBtn.Name = "donationBtn";
            this.donationBtn.Size = new System.Drawing.Size(93, 22);
            this.donationBtn.Text = "Faire un don";
            this.donationBtn.Click += new System.EventHandler(this.donationBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::GenPlan.Properties.Resources.bug16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton1.Text = "Rapport de bug";
            this.toolStripButton1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 369);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Titre]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.plansTab.ResumeLayout(false);
            this.groupsTab.ResumeLayout(false);
            this.roomsTab.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage plansTab;
        private System.Windows.Forms.ImageList tabImgLst;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem commentDémarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private Addons.GroupsViewerUserCtrl grpsViewerUC;
        private Addons.RoomsViewerUserCtrl roomsViewerUC;
        private Addons.PlansViewerUserCtrl plansViewerUC;
        private System.Windows.Forms.ToolStripButton donationBtn;
        private System.Windows.Forms.ToolStripMenuItem chercherUneMiseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}