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
        Korisnik selectedKorisnik = new Korisnik();
        Korisnik loggedKorisnik = PrijavljeniKorisnik.prijavljeniKorisnik;
        RecenzijaServices recenzijaServices = new RecenzijaServices();
        string star = "★";
        public FrmReview(Korisnik korisnik)
        {
            InitializeComponent();
            selectedKorisnik = korisnik;
            lblStars.Text = star;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtComment.Text != "")
            {
                Recenzija recenzija = new Recenzija
                {
                    Ocjena = tcbRating.Value,
                    Komentar = txtComment.Text,
                    Za_korisnik_id = selectedKorisnik.Id_korisnika,
                    Od_korisnik_id = loggedKorisnik.Id_korisnika,
                    Datum = DateTime.Now
                };

                recenzijaServices.AddRecenzija(recenzija);

                Close();
            }
            else
                MessageBox.Show("Unesite komentar za recenziju", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tcbRating_ValueChanged(object sender, EventArgs e)
        {
            lblStars.Text = "";
            for(int i = 0; i < tcbRating.Value; i++)
            {
                lblStars.Text += star;
            }
        }

        private void FrmReview_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
