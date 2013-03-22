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
            
            //window.showMainForm();
            Application.Run(window);

            /*LoginForm loginForm = new LoginForm();
            loginForm.Parent = window;*/

            Connexion c = Connexion.getInstance();
            c.select();
        }
    }
}
