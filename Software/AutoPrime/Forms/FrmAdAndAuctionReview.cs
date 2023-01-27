using BusinessLogicModel.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void FillMarka()
        {
            cmbMarka.DataSource = MarkaServices.GetMarkas();
        }

        private void PrikaziAukcije()
        {
            dgvAukcije.DataSource = aukcijeServices.GetAukcije();
            dgvAukcije.Columns["Ponudas"].Visible = false;
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
        }

        private void PrikaziOglase()
        {
            dgvOglasi.DataSource = oglasServices.GetOglas();
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
            dgvOglasi.Columns["Korisniks"].Visible = false;
            dgvOglasi.Columns["Slikas"].Visible = false;
        }

        private void btnPregledOglasa_Click(object sender, EventArgs e)
        {
            Ogla odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;/*
            odabrani = new Ogla
            {
                broj_pregleda = odabrani.broj_pregleda + 1
            };
            oglasServices.UpdateOglas(odabrani);*/

            FrmDetailAdAndAuctionReview otvori = new FrmDetailAdAndAuctionReview(odabrani);
            otvori.ShowDialog();
            Close();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabrana = cmbMarka.SelectedItem.ToString();
            FillModel(odabrana);
        }
    }
}
