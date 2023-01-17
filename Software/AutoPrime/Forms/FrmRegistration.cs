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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FrmLogin logiranje = new FrmLogin();
            logiranje.Show();
            this.Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string lozinka = txtLozinka1.Text;
            string lozinka2 = txtLozinka2.Text;
            string grad = txtGrad.Text;
            string telefon = txtTelefon.Text;
            string korime = txtKorime.Text;
            Korisnik noviKorisnik = new Korisnik { 
                Ime = ime,
                Prezime = prezime,
                Korimme = korime,
                Lozinka = lozinka,
                Broj_telefona = telefon,
                Grad = grad
            };
            if (lozinka == lozinka2 && lozinka != "" && lozinka != null && korime != "" && telefon != "" && ime != "" && prezime != "")
            {
                KorisnikServices servis = new KorisnikServices();
                servis.AddKorisniks(noviKorisnik);
            }
            else
            {
                MessageBox.Show("Nisu uneseni točni podaci!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
