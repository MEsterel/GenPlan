using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUpdate;

namespace GenPlan.Core
{
    class Updater : IMUpdatable
    {
        private MUpdater updater;
        public Form FormReferent { get; private set; }

        public Assembly ApplicationAssembly => Assembly.GetExecutingAssembly();

        public Icon ApplicationIcon => FormReferent.Icon;

        public string ApplicationID => Properties.Settings.Default.MUpdateAppID;

        public string ApplicationName => Application.ProductName;

        public Form Context => FormReferent;

        public string Language => "fr";

        public Uri UpdateXmlLocation => new Uri(Properties.Settings.Default.MUpdateXmlFileLink);

        public Updater(Form formReferent)
        {
            FormReferent = formReferent;

            updater = new MUpdater(this);
        }

        public void DoUpdateSync(bool notifNoUpdate = false)
        {
            try
            {
                updater.DoUpdateSync(notifNoUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'effectuer la mise à jour. Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void DoUpdateAsync()
        {
            try
            {
                updater.DoUpdateAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'effectuer la mise à jour. Détails : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
