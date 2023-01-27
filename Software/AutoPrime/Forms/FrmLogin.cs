using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
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
            Korisnik prijavljeni = new Korisnik();
            KorisnikServices servis = new KorisnikServices();
            prijavljeni = servis.Prijava(korisnickoIme, lozinka);
            

            if(prijavljeni == null)
            {
                MessageBox.Show("Krivo uneseni podaci!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrijavljeniKorisnik novi = new PrijavljeniKorisnik();
                novi.NamjestiKorisnika(prijavljeni);
                FrmIndex pocetna = new FrmIndex(prijavljeni);
                pocetna.Show();
            }
            this.Hide();

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistration registracija = new FrmRegistration();            
            registracija.Show();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKorime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
