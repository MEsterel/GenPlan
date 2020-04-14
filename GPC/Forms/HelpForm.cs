﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenPlan.Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm(string text, string caption)
        {
            InitializeComponent();

            this.Text = "Aide : " + caption;
            titleLbl.Text = this.Text;
            messageTxt.Text = text;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
