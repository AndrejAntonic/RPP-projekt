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
        Recenzija recenzija = new Recenzija();
        KorisnikServices korisnikServices = new KorisnikServices();
        public FrmShowDetailReview(Recenzija recenzija)
        {
            InitializeComponent();
            this.recenzija = recenzija;
        }

        private void FrmShowDetailReview_Load(object sender, EventArgs e)
        {
            LoadAllDetails();
        }

        private void LoadAllDetails()
        {
            Korisnik korisnik = korisnikServices.GetKorisnikById(recenzija.Od_korisnik_id);
            txtUserPost.Text = korisnik.Korimme;
            txtRating.Text = recenzija.Ocjena.ToString();
            txtDate.Text = recenzija.Datum.ToString();
            txtComment.Text = recenzija.Komentar;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowDetailReview_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowDetailReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
