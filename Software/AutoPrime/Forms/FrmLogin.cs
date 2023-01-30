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
    public partial class FrmLogin : Form
    {
        //Danijel Žebčević
        public FrmLogin()
        {
            //inicijalizacija forme
            InitializeComponent();
        }

        private void btnZabLozinka_Click(object sender, EventArgs e)
        {
            //otvaranje forme za zaboravljenu lozinku
            FrmForgotPassword zaboravljenaLozinka = new FrmForgotPassword();
            zaboravljenaLozinka.Show();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorime.Text;
            string lozinka = txtLozinka.Text;
            Korisnik prijavljeni = new Korisnik();
            KorisnikServices servis = new KorisnikServices();
            //provjera jesu li uneseni točni podaci
            prijavljeni = servis.Login(korisnickoIme, lozinka);
            
            //javljanje greške ako je korisnik unio krivo korisničko ime ili lozinku
            if(prijavljeni == null)
            {
                MessageBox.Show("Krivo uneseni podaci!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLozinka.Text = "";
            }
            else
            {
                //spremanje prijavljenog korisnika u statičnu klasu
                PrijavljeniKorisnik novi = new PrijavljeniKorisnik();
                novi.NamjestiKorisnika(prijavljeni);
                this.Hide();

                //otvaranje početne forme aplikacije
                FrmIndex pocetna = new FrmIndex(prijavljeni);
                pocetna.ShowDialog();
                Close();
            }

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            //otvaranje formu za registraciju
            FrmRegistration registracija = new FrmRegistration();            
            registracija.Show();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKorime_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //dodatne upute za pomoć u radu s aplikacijom
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmLogin.pdf";
            Process.Start(pdfPath);
        }
    }
}
