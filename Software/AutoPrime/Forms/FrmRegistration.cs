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
                Broj_telefona = telefon,
                Grad = grad,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                Korimme = korime
            };
            if (lozinka == lozinka2 && lozinka != "" && lozinka != null && korime != "")
            {
                KorisnikRepository dodaj = new KorisnikRepository();
                dodaj.Add(noviKorisnik);
            }
            this.Close();
        }
    }
}
