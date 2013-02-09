using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GOS
{
    class Inteface
    {
            
        public void Interface()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public void showMainForm()
        {
            Form mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
