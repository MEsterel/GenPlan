using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenPlan.Forms;
using GenPlan.Core;
using GenPlan.Objects;

namespace GenPlan.Addons
{
    public partial class PlansViewerUserCtrl : UserControl
    {
        public bool UnsavedData { get; set; } = false;

        public PlansViewerUserCtrl()
        {
            InitializeComponent();

            SaveManager.LoadedFile += LoadPlans;
            SaveManager.Saved += SaveManager_Saved;
            SaveManager.NewFile += SaveManager_NewFile;
        }

        private void SaveManager_NewFile(object sender, EventArgs e)
        {
            planLstView.Items.Clear();
            viewBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void SaveManager_Saved(object sender, EventArgs e)
        {
            UnsavedData = false;
        }

        private void LoadPlans(object sender = null, EventArgs e = null)
        {
            planLstView.Items.Clear();
            foreach (Plan plan in SaveManager.Data.Plans)
            {
                planLstView.Items.Add(new ListViewItem(new string[] { plan.Name, plan.Date.ToString("MM/dd/yyyy HH:mm:ss") }) { Name = plan.Name });
            }
        }

        private void createPlanBtn_Click(object sender, EventArgs e)
        {
            CreatePlanForm cpf = new CreatePlanForm();
            if (cpf.ShowDialog() == DialogResult.OK)
            {
                LoadPlans();
                UnsavedData = true;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (planLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez un plan de classe à consulter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PlanViewerForm pvf = new PlanViewerForm();
            pvf.LoadPlan(SaveManager.Data.Plans.Find(x => x.Name == planLstView.SelectedItems[0].Name));
            pvf.ShowDialog();

            planLstView.Items[planLstView.SelectedItems[0].Name].Text = pvf.WorkingPlan.Name;
            planLstView.Items[planLstView.SelectedItems[0].Name].Name = pvf.WorkingPlan.Name;
        }

        private void planLstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planLstView.SelectedItems.Count == 1)
            {
                viewBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            else
            {
                viewBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void planLstView_DoubleClick(object sender, EventArgs e)
        {
            if (planLstView.SelectedItems.Count == 1)
            {
                viewBtn_Click(null, null);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (planLstView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Sélectionnez un plan de classe à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer le plan de classe " + planLstView.SelectedItems[0].Name + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res != DialogResult.Yes)
                return;

            SaveManager.Data.Plans.Remove(SaveManager.Data.Plans.Find(x => x.Name == planLstView.SelectedItems[0].Name));

            planLstView.Items.Remove(planLstView.SelectedItems[0]);
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBtn_Click(null, null);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBtn_Click(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (planLstView.SelectedItems.Count != 1)
            {
                e.Cancel = true;
            }
        }
    }
}
