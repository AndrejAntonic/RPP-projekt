using AutoPrime.Forms;
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
    public partial class FrmIndex : Form
    {
        //Bruno Pavlović
        private OglasServices oglasServices = new OglasServices();
        Korisnik prijavljeniKorisnik = new Korisnik();
        public FrmIndex(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        //Juraj Gaši
        //vodi nas na formu kreiraj oglas
        private void btnKreirajOglas_Click(object sender, EventArgs e)
        {
            FrmCreateAds kreirajOglas = new FrmCreateAds();
            kreirajOglas.ShowDialog();
        }

        //Juraj Gaši
        //vodi nas na formu kreiraj aukciju
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
            FrmShowProfile profil = new FrmShowProfile(prijavljeniKorisnik);
            profil.ShowDialog();
        }
        //Bruno Pavlović
        //otvaranje forme za pregled oglasa i aukcija
        private void btnPregledOglasaAukcija_Click(object sender, EventArgs e)
        {
            FrmAdAndAuctionReview frmAdAndAuctionReview = new FrmAdAndAuctionReview();
            frmAdAndAuctionReview.ShowDialog();
        }
        //Bruno Pavlović
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            ShowAds();
        }
        //Bruno Pavlović
        private void ShowAds()
        {
            //prikaz najtraženijih oglasa prema broju pregleda
            dgvNajtrazeniji.DataSource = oglasServices.GetMostWantedOglas();
            HideOglasAtributes();
        }

        private void HideOglasAtributes()
        {
            //sakrivanje nepotrebnih stupaca
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
        //Bruno Pavlovic
        private void btnPregledOdabranog_Click(object sender, EventArgs e)
        {
            //azuriranje broja pregleda oglasa nakon klika te otvaranje forme za detaljni pregled odabranog
            Ogla oglas = dgvNajtrazeniji.CurrentRow.DataBoundItem as Ogla;

            if (oglas != null)
            {
                oglas.broj_pregleda = oglas.broj_pregleda + 1;
                oglasServices.UpdateOglasView(oglas);
            }

            ShowAds();
            FrmDetailAdAndAuctionReview frm = new FrmDetailAdAndAuctionReview(oglas);
            frm.ShowDialog();
        }

        private void FrmIndex_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmIndex.pdf";
            Process.Start(pdfPath);
        }

        private void btnSlikaTester_Click(object sender, EventArgs e)
        {
            SlikaTester tester = new SlikaTester();
            tester.ShowDialog();
        }
    }
}
