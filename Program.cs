using FinalProjectDB.Forms;
using FinalProjectDB.Forms.Admin;
using FinalProjectDB.Forms.Employee;
using FinalProjectDB.Forms.StartingForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProjectDB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FinalProjectDB.Forms.StartingForms.FormSignInSignUp());
        }
    }
}
