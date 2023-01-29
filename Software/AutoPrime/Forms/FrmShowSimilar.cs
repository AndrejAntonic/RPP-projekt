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

    {
        private Ogla oglas = new Ogla();

        public FrmShowSimilar(Ogla odabran)
        {
            oglas = odabran;
            InitializeComponent();
        }

        private void btnDetaljan_Click(object sender, EventArgs e)
        {
            var odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;
            FrmDetailAdAndAuctionReview detaljni = new FrmDetailAdAndAuctionReview(odabrani);
            detaljni.Show();
        }

        private void btnLeasing_Click(object sender, EventArgs e)
        {
            FrmLeasing leasing = new FrmLeasing();
            leasing.Show();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowSimilar_Load(object sender, EventArgs e)
        {
            OglasServices servis = new OglasServices();
            dgvOglasi.DataSource = servis.GetSimilarOglas(oglas);
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
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowSimilar.pdf";
            Process.Start(pdfPath);
        }
    }
}
