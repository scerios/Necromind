using NecromindLibrary;
using System;
using System.Windows.Forms;

namespace Necromind
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

            // Initializes the DB connection
            GlobalConfig.InitializeConnection();

            Application.Run(new Necromind());
        }
    }
}
