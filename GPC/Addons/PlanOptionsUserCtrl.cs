using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenPlan.Objects;

namespace GenPlan.Addons
{
    public partial class PlanOptionsUserCtrl : UserControl
    {
        public PlanOptionsUserCtrl()
        {
            InitializeComponent();

            affinitiesModeCmbBox.SelectedIndex = 0;
            fillModeCmbBox.SelectedIndex = 0;
        }

        public void LoadOptions(PlanOptions options)
        {
            ignoreAffinitiesChkBox.Checked = options.IgnoreAffinities;
            affinitiesModeCmbBox.SelectedIndex = (int)options.AffinitiesMode;
            animeGenChkBox.Checked = options.AnimateGeneration;
            fillModeCmbBox.SelectedIndex = (int)options.FillMode;
            animationSpeedTrkBar.Value = options.AnimationSpeed;
            debugModeChk.Checked = options.DebugMode;
        }

        public PlanOptions GetOptions()
        {
            return new PlanOptions()
            {
                IgnoreAffinities = ignoreAffinitiesChkBox.Checked,
                AffinitiesMode = (AffinitiesModeEnum)affinitiesModeCmbBox.SelectedIndex,
                AnimateGeneration = animeGenChkBox.Checked,
                FillMode = (FillModeEnum)fillModeCmbBox.SelectedIndex,
                AnimationSpeed = animationSpeedTrkBar.Value,
                DebugMode = debugModeChk.Checked
            };
        }

        private void animeGenChkBox_CheckedChanged(object sender, EventArgs e)
        {
            animationSpeedTrkBar.Enabled = animeGenChkBox.Checked;
            debugModeChk.Enabled = animeGenChkBox.Checked;
        }

        private void ignoreAffinitiesChkBox_CheckedChanged(object sender, EventArgs e)
        {
            affinitiesModeCmbBox.Enabled = !ignoreAffinitiesChkBox.Checked;
        }
    }
}
