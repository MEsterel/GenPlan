using System;
using System.Reflection;
using System.Windows.Forms;
using GenPlan.Core;

namespace GenPlan
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // 1. Initiate Variables && dlls
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string resourceName = new AssemblyName(args.Name).Name + ".dll";
                    string resource = Array.Find(Assembly.GetExecutingAssembly().GetManifestResourceNames(), element => element.EndsWith(resourceName));

                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                    {
                        Byte[] assemblyData = new Byte[stream.Length];
                        stream.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }
                };

                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                ErrorProtocol.TriggerError(ex);
            }
        }
    }
}