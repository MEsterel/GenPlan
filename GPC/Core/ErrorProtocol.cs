using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenPlan.Core
{
    public static class ErrorProtocol
    {
        public static void TriggerError(Exception ex)
        {
            MExceptionReporter.ReportException re = new MExceptionReporter.ReportException(Application.ProductName, ex);
            re.ShowDialog();
        }
    }
}
