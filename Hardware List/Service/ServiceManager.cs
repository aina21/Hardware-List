using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fatemeh_HardWare
{
    class ServiceManager
    {
        /// <summary>
        /// open loggin
        /// </summary>
        public ServiceManager()
        {
            frmLogin a = new frmLogin();
            a.Show();
        }

        /// <summary>
        /// exit program
        /// </summary>
        public static void Exit()
        {
            Application.Exit();
        }

        public static int User 
        { get; set; }
    }
}
