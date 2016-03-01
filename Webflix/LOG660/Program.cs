using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG660.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());

            // Test page UserControl
            //Application.Run(new UI.Test.TestAdvancedSearch());

            // JP Test page principale
            //Application.Run(new filmsConsultation());
        }
    }
}
