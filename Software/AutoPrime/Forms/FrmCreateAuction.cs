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
    public partial class FrmCreateAuction : Form
    {
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private AukcijeServices aukcijeServis = new AukcijeServices();
        public FrmCreateAuction()
        {
            InitializeComponent();
        }

        

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMarkaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWantedModels();
        }

        private void LoadWantedModels()
        {
            var odabrano = cmbMarkaVozila.SelectedItem as Marka;
            int zeljeno;
            zeljeno = odabrano.Id_marka;
            cmbModelVozila.DataSource = modelServis.GetCertainModels(zeljeno);
        }

        private void FrmCreateAuction_Load(object sender, EventArgs e)
        {
            LoadAllMarke();
            LoadAllMotori();
        }

        private void LoadAllModeli()
        {
            cmbModelVozila.DataSource = modelServis.GetModels();
        }

        private void LoadAllMotori()
        {
            cmbMotor.DataSource = motorServis.GetMotors();
        }

        private void LoadAllMarke()
        {
            cmbMarkaVozila.DataSource = markaServices.GetMarkas();
        }

        private void btnDodajAukciju_Click(object sender, EventArgs e)
        {
            var aukcija = new Aukcije
            {
                Id_aukcije = 23,
                naziv = txtNaslovOglasa.Text,
                Marka = cmbMarkaVozila.SelectedItem as Marka,
                Model = cmbModelVozila.SelectedItem as Model,
                godina = Int32.Parse(txtGodinaProizvodnje.Text),
                kilometraza = txtKilometraza.Text,
                cijena = txtCijena.Text,
                lokacija_vozila = txtLokacija.Text,
                Motor = cmbMotor.SelectedItem as Motor,
                datum_aukcije = dtpTrajanjeAukcije.Value,
                rok = dtpIstekAukcije.Value
            };

            aukcijeServis.AddAuction(aukcija);
        }
    }
}
