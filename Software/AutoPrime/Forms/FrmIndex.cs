using AutoPrime.Forms;
using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
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

namespace AutoPrime
{
    public partial class FrmIndex : Form
    {
        private OglasServices oglasServices = new OglasServices();
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void btnKreirajOglas_Click(object sender, EventArgs e)
        {
            FrmCreateAds kreirajOglas = new FrmCreateAds();
            kreirajOglas.ShowDialog();
        }

        private void btnKreirajAukciju_Click(object sender, EventArgs e)
        {
            FrmCreateAuction kreirajAukciju = new FrmCreateAuction();
            kreirajAukciju.ShowDialog();
        }

        private void btnLeasing_Click(object sender, EventArgs e)
        {
            FrmLeasing leasingForma = new FrmLeasing();
            leasingForma.ShowDialog();
        }

        private void btnKalkulator_Click(object sender, EventArgs e)
        {
            PrijavljeniKorisnik dude = new PrijavljeniKorisnik();
            var a = dude.VratiPrijavljenog();
            FrmKalkulator kalkulatorForma = new FrmKalkulator();
            kalkulatorForma.ShowDialog();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FrmShowProfile profil = new FrmShowProfile();
            profil.ShowDialog();
        }

        private void btnPregledOglasaAukcija_Click(object sender, EventArgs e)
        {
            FrmAdAndAuctionReview frmAdAndAuctionReview = new FrmAdAndAuctionReview();
            frmAdAndAuctionReview.ShowDialog();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            dgvNajtrazeniji.DataSource = oglasServices.GetMostWantedOglas();
            HideOglasAtributes();
        }

        private void HideOglasAtributes()
        {
            dgvNajtrazeniji.Columns["korisnik_id"].Visible = false;
            dgvNajtrazeniji.Columns["marka_id"].Visible = false;
            dgvNajtrazeniji.Columns["model_id"].Visible = false;
            dgvNajtrazeniji.Columns["motor_id"].Visible = false;
            dgvNajtrazeniji.Columns["Korisniks"].Visible = false;
            dgvNajtrazeniji.Columns["Slikas"].Visible = false;
            dgvNajtrazeniji.Columns["id_oglas"].Visible = false;
            dgvNajtrazeniji.Columns["ostecenje"].Visible = false;
            dgvNajtrazeniji.Columns["leasing"].Visible = false;
            dgvNajtrazeniji.Columns["iznajmljeno_id"].Visible = false;
            dgvNajtrazeniji.Columns["prodano_korisnik_id"].Visible = false;
            dgvNajtrazeniji.Columns["Korisnik1"].Visible = false;
        }

        private void btnPregledOdabranog_Click(object sender, EventArgs e)
        {
            Ogla oglas = dgvNajtrazeniji.CurrentRow.DataBoundItem as Ogla;
            FrmDetailAdAndAuctionReview frm = new FrmDetailAdAndAuctionReview(oglas);
            frm.ShowDialog();
        }
    }
}
