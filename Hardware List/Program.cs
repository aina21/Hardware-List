using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fatemeh_HardWare
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
            ServiceManager srv = new ServiceManager();
            Application.Run();
        }
    }
}
