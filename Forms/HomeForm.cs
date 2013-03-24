using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GOS.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Vente_Click(object sender, EventArgs e)
        {
            VenteForm vente = new VenteForm();
            vente.MdiParent = this.MdiParent;
            this.Hide();
            vente.Show();
        }
    }
}
