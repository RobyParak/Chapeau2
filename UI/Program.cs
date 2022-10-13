using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          

            //Application.Run(new LoginForm());

            //the below opens and works
            Bill bill = new Bill(88);
            Table table = new Table(3);
            Application.Run(new Payment(table,bill));
        }
    }
}
