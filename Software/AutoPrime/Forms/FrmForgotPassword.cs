using BusinessLogicModel.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrime.Forms
{
    public partial class FrmForgotPassword : Form
    {
        //Danijel Žebčević
        public FrmForgotPassword()
        {
            //inicijalizacija forme
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            //zatvaranje forme
            Close();
        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            //učitavanje korisnikovih podataka
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korime = txtKorime.Text;
            string lozinka1 = txtLozinka1.Text;
            string lozinka2 = txtLozinka2.Text;
            string telefon = txtTelefon.Text;

            //provjera postoji li korisnik s unesenim podacima
            KorisnikServices servis = new KorisnikServices();
            Korisnik trenutni = servis.ChangePassword(korime, telefon, ime, prezime);
            if (trenutni != null)
            {
                //provjera da li se poklapaju lozinke
                if (lozinka1 == lozinka2)
                {
                    trenutni.Lozinka = lozinka1;
                    servis.UpdateKorisniks(trenutni);
                    this.Close();
                }
                //prikaz greške ako se lozinke ne poklapaju
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //ispis greške ako ne postoji korisnik s unesenim podacima
            else
            {
                MessageBox.Show("Korisnik s navedenim podacima ne postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmForgotPassword_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //dodatne upute za pomoć u radu s aplikacijom
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmForgotPassword.pdf";
            Process.Start(pdfPath);
        }
    }
}
