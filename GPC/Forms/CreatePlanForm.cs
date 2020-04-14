using GenPlan.Core;
using System;
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
    public partial class CreatePlanForm : Form
    {
        public CreatePlanForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePlanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (planMngrUC.Generating)
            {
                DialogResult res = MessageBox.Show("Une génération est en cours. Voulez-vous vraiment abandonner ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (planMngrUC.UnsavedData)
            {
                DialogResult res = MessageBox.Show("Voulez-vous sauvegarder la dernière génération ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    if (!Validate())
                    {
                        e.Cancel = true;
                    }
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private new bool Validate()
        {
            if (planMngrUC.LastSucessfulResult == null)
            {
                MessageBox.Show(this, "Veuillez effectuer une génération réussie avec de valider.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(planMngrUC.PlanNameTxt))
            {
                MessageBox.Show(this, "Veuillez insérer un nom pour ce plan de classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (SaveManager.Data.Plans.Exists(x => x.Name == planMngrUC.PlanNameTxt))
            {
                MessageBox.Show("Un plan de classe portant le même nom existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SaveManager.Data.Plans.Add(planMngrUC.LastSucessfulResult);
            planMngrUC.UnsavedData = false;
            this.DialogResult = DialogResult.OK;
            return true;
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            Validate();
        }
    }
}
