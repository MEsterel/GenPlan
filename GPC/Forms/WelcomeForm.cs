using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GenPlan.Core;

namespace GenPlan.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            try
            {
                if (Properties.Settings.Default.LastWorkingPath != "" && File.Exists(Properties.Settings.Default.LastWorkingPath))
                {
                    lastBaseBtn.Text = " Dernière fichier GenPlan utilisé : " + Path.GetFileName(Properties.Settings.Default.LastWorkingPath);

                    return;
                }
            }
            catch { }

            lastBaseBtn.Text = " Pas de dernier fichier utilisé trouvé";
            lastBaseBtn.Enabled = false;
        }

        /// <summary>
        /// Prevents the window from being moved
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        /// <summary>
        /// If window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFileStartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// If new base btn is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (SaveManager.Open())
                this.DialogResult = DialogResult.OK;
        }

        private void lastBaseBtn_Click(object sender, EventArgs e)
        {
            if (SaveManager.Open(Properties.Settings.Default.LastWorkingPath))
                this.DialogResult = DialogResult.OK; // Alors fermer cette fenetre
        }
    }
}
