using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GOS.Forms;

namespace GOS
{
    class GOS
    {
        public GOS()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm window = new MainForm();
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = window;

            loginForm.Show();

            //window.showMainForm();
            Application.Run(window);

            /*Connexion c = Connexion.getInstance();
            c.select();*/
        }
    }
}
