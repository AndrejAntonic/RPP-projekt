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
    public partial class FrmShowDetailReview : Form
    {
        //Andrej Antonić
        //Inicijalizacija svih potrebnih klasa
        Recenzija recenzija = new Recenzija();
        KorisnikServices korisnikServices = new KorisnikServices();
        public FrmShowDetailReview(Recenzija recenzija) //Spremanje prosljeđene recenzije
        {
            InitializeComponent();
            this.recenzija = recenzija;
        }

        private void FrmShowDetailReview_Load(object sender, EventArgs e) //Učitavanje forme
        {
            LoadAllDetails();
        }

        private void LoadAllDetails() //Učitavanje svih detalja prosljeđene recenzije
        {
            Korisnik korisnik = korisnikServices.GetKorisnikById(recenzija.Od_korisnik_id);
            txtUserPost.Text = korisnik.Korimme;
            txtRating.Text = recenzija.Ocjena.ToString();
            txtDate.Text = recenzija.Datum.ToString();
            txtComment.Text = recenzija.Komentar;
        }

        private void btnClose_Click(object sender, EventArgs e) //Zatvaranje forme
        {
            Close();
        }

        private void FrmShowDetailReview_HelpRequested(object sender, HelpEventArgs hlpevent) //F1 pomoć
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowDetailReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
