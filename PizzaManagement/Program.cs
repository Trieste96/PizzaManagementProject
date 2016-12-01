using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaManagement
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
            AuthenticationUI authUI = new AuthenticationUI();          
            Application.Run(authUI);
            if(authUI.switchToMangerUI == true)
            {
                ManagerUI mui = new ManagerUI();
                mui.getUserInfo(authUI.user);
                Application.Run(mui);
            }
           
        }
    }
}
