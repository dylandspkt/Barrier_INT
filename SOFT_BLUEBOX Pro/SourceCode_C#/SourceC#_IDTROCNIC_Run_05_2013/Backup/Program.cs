using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLUEBOX_Polling
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

            Application.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            // Set the english culture as current culture.
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");

            Application.Run(new MainForm());
        }
    }
}