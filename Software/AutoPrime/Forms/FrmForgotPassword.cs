using BusinessLogicModel.Services;
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
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korime = txtKorime.Text;
            string lozinka1 = txtLozinka1.Text;
            string lozinka2 = txtLozinka2.Text;
            string telefon = txtTelefon.Text;

            KorisnikServices servis = new KorisnikServices();
            Korisnik trenutni = servis.ChangePassword(korime, telefon, ime, prezime);
            if (trenutni != null)
            {
                if (lozinka1 == lozinka2)
                {
                    trenutni.Lozinka = lozinka1;
                    servis.UpdateKorisniks(trenutni);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Korisnik s navedenim podacima ne postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
    }
}
