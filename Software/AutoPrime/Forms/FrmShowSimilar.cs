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
    public partial class FrmShowSimilar : Form

        //Danijel Žebčević

    {
        private Ogla oglas = new Ogla();

        public FrmShowSimilar(Ogla odabran)
        {
            //inicijalizacija forme
            oglas = odabran;
            InitializeComponent();
        }

        private void btnDetaljan_Click(object sender, EventArgs e)
        {
            //otvaranje forme za detaljan prikaz odabranog oglasa
            var odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;
            FrmDetailAdAndAuctionReview detaljni = new FrmDetailAdAndAuctionReview(odabrani);
            detaljni.Show();
        }

        private void btnLeasing_Click(object sender, EventArgs e)
        {
            //otvaranje forme za leasing
            FrmLeasing leasing = new FrmLeasing();
            leasing.Show();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            //zatvaranje forme
            Close();
        }

        private void FrmShowSimilar_Load(object sender, EventArgs e)
        {
            //dohvaćanje sličnih oglasa
            OglasServices servis = new OglasServices();
            dgvOglasi.DataSource = servis.GetSimilarOglas(oglas);
            //sakrivanje nepotrebnih stupaca
            dgvOglasi.Columns["slikas"].Visible = false;
            dgvOglasi.Columns["korisniks"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["iznajmljeno_id"].Visible = false;
            dgvOglasi.Columns["prodano_korisnik_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
            dgvOglasi.Columns["Korisnik1"].Visible = false;
        }

        private void FrmShowSimilar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //dodatne upute za pomoć u radu s aplikacijom
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowSimilar.pdf";
            Process.Start(pdfPath);
        }
    }
}
