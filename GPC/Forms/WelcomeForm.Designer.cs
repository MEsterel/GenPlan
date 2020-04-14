namespace GenPlan.Forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.lastBaseBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastBaseBtn
            // 
            this.lastBaseBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBaseBtn.Image = global::GenPlan.Properties.Resources.clock16;
            this.lastBaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastBaseBtn.Location = new System.Drawing.Point(12, 113);
            this.lastBaseBtn.Name = "lastBaseBtn";
            this.lastBaseBtn.Size = new System.Drawing.Size(196, 43);
            this.lastBaseBtn.TabIndex = 0;
            this.lastBaseBtn.Text = " Dernière base GenPlan utilisée :";
            this.lastBaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lastBaseBtn.UseVisualStyleBackColor = true;
            this.lastBaseBtn.Click += new System.EventHandler(this.lastBaseBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.ForeColor = System.Drawing.Color.Black;
            this.openBtn.Image = global::GenPlan.Properties.Resources.folder32;
            this.openBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openBtn.Location = new System.Drawing.Point(113, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(95, 95);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "\r\nOuvrir un fichier GenPlan\r\n";
            this.openBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.Black;
            this.newBtn.Image = global::GenPlan.Properties.Resources.addPage32;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newBtn.Location = new System.Drawing.Point(12, 12);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(95, 95);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "\r\nNouveau fichier GenPlan";
            this.newBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(219, 168);
            this.Controls.Add(this.lastBaseBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.newBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bienvenue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseFileStartForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button lastBaseBtn;
    }
}