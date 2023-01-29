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

namespace AutoPrime.Forms
{
    public partial class FrmEditAds : Form
    {
        private Ogla oglas = new Ogla();
        private OglasServices oglasServis = new OglasServices();
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private OstecenjaServices ostecenjaServis = new OstecenjaServices();
        private SlikaServices slikaServis = new SlikaServices();
        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();
        public FrmEditAds(Ogla odabrani)
        {
            InitializeComponent();
            this.oglas = odabrani;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            oglas.naziv = txtNaslovOglasa.Text;
            oglas.Marka = cmbMarkaVozila.SelectedItem as Marka;
            oglas.Model = cmbModelVozila.SelectedItem as Model;
            oglas.Motor = cmbMotor.SelectedItem as Motor;
            oglas.godina = Int32.Parse(txtGodinaProizvodnje.Text);
            oglas.cijena = txtCijena.Text;
            oglas.kilometraza = txtKilometraza.Text;
            oglas.lokacija_vozila = txtLokacija.Text;
            oglas.datum = dtpDatum.Value;
            oglas.ostecenje = (byte)cbOstecenja.CheckState;
            oglas.leasing = (byte?)cbLeasing.CheckState;

            oglasServis.UpdateOglas(oglas);
            this.Close();

        }


        private void FrmEditAds_Load(object sender, EventArgs e)
        {
            cmbMotor.DataSource = motorServis.GetMotors();
            cmbModelVozila.DataSource = modelServis.GetModels();
            cmbMarkaVozila.DataSource = markaServices.GetMarkas();
            FillOglasDetail();
        }


        private void FillOglasDetail()
        {
            //popunjavanje detalja oglasa
            cbOstecenja.Visible = false;
            cbLeasing.Visible = false;

            txtNaslovOglasa.Text = oglas.naziv;
            cmbMarkaVozila.Text = oglas.Marka.Naziv;
            cmbModelVozila.Text = oglas.Model.naziv;
            txtGodinaProizvodnje.Text = oglas.godina.ToString();
            txtCijena.Text = oglas.cijena;
            txtKilometraza.Text = oglas.kilometraza;
            cmbMotor.Text = oglas.Motor.vrsta;
            txtLokacija.Text = oglas.lokacija_vozila;
            dtpDatum.Value = oglas.datum;
        }


        private void LoadWantedModels()
        {
            var odabrano = cmbMarkaVozila.SelectedItem as Marka;
            int zeljeno;
            zeljeno = odabrano.Id_marka;
            cmbModelVozila.DataSource = modelServis.GetCertainModels(zeljeno);
        }

        private void cmbMarkaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWantedModels();
        }
    }
}
