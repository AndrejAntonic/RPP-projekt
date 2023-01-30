using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
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
    public partial class FrmRegistration : Form
    {
        //Danijel Žebčević
        public FrmRegistration()
        {
            //inicijalizacija forme
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            //vraćanje na formu za login
            FrmLogin logiranje = new FrmLogin();
            logiranje.Show();
            this.Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            //učitavanje unesenih podataka
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
            //provjera da su sva polja unesena
            if (lozinka == lozinka2 && lozinka != "" && lozinka != null && korime != "" && telefon != "" && ime != "" && prezime != "")
            {
                //spremanje korisnika u bazu
                KorisnikServices servis = new KorisnikServices();
                servis.AddKorisniks(noviKorisnik);
                this.Close();
            }
            //ispis greške ako su neki podaci krivo uneseni ili nepostojeći
            else
            {
                MessageBox.Show("Nisu uneseni točni podaci!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistration_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //dodatne upute za pomoć u radu s aplikacijom
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmRegistration.pdf";
            Process.Start(pdfPath);
        }
    }
}
