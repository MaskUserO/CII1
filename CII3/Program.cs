using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CII3.Views;
using CII3.Models;
using CII3.Presenters;
using CII3._Repositories;
using System.Configuration;

namespace CII3
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString ;
            IMainForm view = new MainForm();
            new MainFormPresent(view, sqlConnectionString);

    
            Application.Run((Form)view);
        }
    }
}
