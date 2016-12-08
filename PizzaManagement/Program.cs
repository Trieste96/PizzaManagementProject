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
            if (authUI.switchToMangerUI == true)
            {
                ManagerUI manager_ui = new ManagerUI();
                manager_ui.getUserInfo(authUI.user);
                Application.Run(manager_ui);
            }
            else if (authUI.switchToCsrUI == true)
            {
                CsrUI csr_ui = new CsrUI();
                csr_ui.getUserInfo(authUI.user);
                Application.Run(csr_ui);
            }
           
        }
    }
}
