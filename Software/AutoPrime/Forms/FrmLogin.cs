using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrime.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnZabLozinka_Click(object sender, EventArgs e)
        {
            FrmForgotPassword zaboravljenaLozinka = new FrmForgotPassword();
            zaboravljenaLozinka.Show();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorime.Text;
            string lozinka = txtLozinka.Text;
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistration registracija = new FrmRegistration();            
            registracija.Show();
        }
    }
}
