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

namespace AutoPrime
{
    public partial class FrmReview : Form
    {
        //Andrej Antonić
        //Inicijalizacija svih potrebnih klasa i vrijednosti
        Korisnik selectedKorisnik = new Korisnik();
        Korisnik loggedKorisnik = PrijavljeniKorisnik.prijavljeniKorisnik;
        RecenzijaServices recenzijaServices = new RecenzijaServices();
        string star = "★";
        public FrmReview(Korisnik korisnik) //Spremanje prosljeđenog korisnika
        {
            InitializeComponent();
            selectedKorisnik = korisnik;
            lblStars.Text = star;
        }

        private void btnClose_Click(object sender, EventArgs e) //Zatvaranje forme
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Spremanje recenzije u bazu
        {
            if (txtComment.Text != "") //Provjera vrijednosti komentara
            {
                Recenzija recenzija = new Recenzija
                {
                    Ocjena = tcbRating.Value,
                    Komentar = txtComment.Text,
                    Za_korisnik_id = selectedKorisnik.Id_korisnika,
                    Od_korisnik_id = loggedKorisnik.Id_korisnika,
                    Datum = DateTime.Now
                };

                recenzijaServices.AddRecenzija(recenzija); //Dodavanje recenzije u bazu

                Close();
            }
            else
                MessageBox.Show("Unesite komentar za recenziju", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tcbRating_ValueChanged(object sender, EventArgs e) //Prikazivanje zvjezdica prilikom promjene ocjene
        {
            lblStars.Text = "";
            for(int i = 0; i < tcbRating.Value; i++)
            {
                lblStars.Text += star;
            }
        }

        private void FrmReview_HelpRequested(object sender, HelpEventArgs hlpevent) //F1 pomoć
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
