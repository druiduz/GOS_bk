using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GOS.Classes;

namespace GOS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.MdiParent;
            main.vendeur = User.Login(this.txtLogin.Text, this.txtPass.Text);
            if (main.vendeur != null)
            {
                HomeForm f = new HomeForm();
                f.MdiParent = this.MdiParent;
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login / mdp incorrecte !!");
            }
        }
    }
}
