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
    public partial class FrmAdAndAuctionReview : Form
    {
        private OglasServices oglasServices = new OglasServices();
        private AukcijeServices aukcijeServices = new AukcijeServices();
        private MarkaServices MarkaServices = new MarkaServices();
        private ModelServices modelServices = new ModelServices();

        public FrmAdAndAuctionReview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdAndAuctionReview_Load(object sender, EventArgs e)
        {
            PrikaziOglase();
            PrikaziAukcije();
            FillMarka();
        }

        private void FillModel(string marka)
        {
            cmbModel.DataSource = modelServices.GetCertainModelsByName(marka);
            cmbModel.SelectedItem = null;
        }

        private void FillMarka()
        {
            cmbMarka.DataSource = MarkaServices.GetMarkas();
            cmbMarka.SelectedItem = null;
        }

        private void PrikaziAukcije()
        {
            dgvAukcije.DataSource = aukcijeServices.GetAukcije();
            dgvAukcije.Columns["Ponudas"].Visible = false;
            dgvAukcije.Columns["id_aukcije"].Visible = false;
            dgvAukcije.Columns["marka_id"].Visible = false;
            dgvAukcije.Columns["model_id"].Visible = false;
            dgvAukcije.Columns["motor_id"].Visible = false;
        }

        private void PrikaziOglase()
        {
            dgvOglasi.DataSource = oglasServices.GetOglas();
            HideOglasAtributes();
        }

        private void HideOglasAtributes()
        {
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
            dgvOglasi.Columns["Korisniks"].Visible = false;
            dgvOglasi.Columns["Slikas"].Visible = false;
            dgvOglasi.Columns["id_oglas"].Visible = false;
            dgvOglasi.Columns["ostecenje"].Visible = false;
            dgvOglasi.Columns["leasing"].Visible = false;
            dgvOglasi.Columns["iznajmljeno_id"].Visible = false;
            dgvOglasi.Columns["prodano_korisnik_id"].Visible = false;
            dgvOglasi.Columns["Korisnik1"].Visible = false;
        }

        private void btnPregledOglasa_Click(object sender, EventArgs e)
        {
            Ogla odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;
            
            if (odabrani != null)
            {
                odabrani.broj_pregleda = odabrani.broj_pregleda + 1;
                oglasServices.UpdateOglasView(odabrani);
            }
            PrikaziOglase();

            FrmDetailAdAndAuctionReview otvori = new FrmDetailAdAndAuctionReview(odabrani);
            otvori.ShowDialog();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedItem!=null)
            {
                var odabrana = cmbMarka.SelectedItem.ToString();
                FillModel(odabrana);
            }

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var marka ="";
            if (cmbMarka.SelectedItem!=null)
            {
                marka = cmbMarka.SelectedItem.ToString();
            }
            var model ="";
            if (cmbModel.SelectedItem!=null)
            {
                model = cmbModel.SelectedItem.ToString();
            }
            var godina="";
            if (cmbGodina.SelectedItem != null)
            {
                godina = cmbGodina.SelectedItem.ToString();
            }
            var kilometraza="";
            if (cmbKilometraza.SelectedItem!=null)
            {
                kilometraza = cmbKilometraza.SelectedItem.ToString();
            }
            var cijena ="";
            if (cmbCijena.SelectedItem!= null)
            {
                cijena = cmbCijena.SelectedItem.ToString();
            }

            dgvOglasi.DataSource = oglasServices.FilterOglas(marka, model, godina, kilometraza, cijena);
            HideOglasAtributes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PrikaziOglase();
            PrikaziAukcije();
            cmbGodina.SelectedItem = null;
            cmbModel.SelectedItem = null;
            cmbMarka.SelectedItem = null;
            cmbKilometraza.SelectedItem = null;
            cmbCijena.SelectedItem = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOglasi.DataSource = oglasServices.GetCertainOglass(txtSearch.Text);
            dgvAukcije.DataSource = aukcijeServices.GetCertainAukcije(txtSearch.Text);
        }

        private void btnPregledAukcije_Click(object sender, EventArgs e)
        {
            Aukcije odabrana = dgvAukcije.CurrentRow.DataBoundItem as Aukcije;
            FrmDetailAdAndAuctionReview frm = new FrmDetailAdAndAuctionReview(odabrana);
            frm.Show();
        }

        private void FrmAdAndAuctionReview_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmAdAndAuctionReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
