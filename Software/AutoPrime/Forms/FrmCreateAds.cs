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
    public partial class FrmCreateAds : Form
    {
        private OglasServices oglasServis = new OglasServices();
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        public FrmCreateAds()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Treba sakriti nepotrebne redove tamo gdje budu prikazani oglasi
        private void btnDodajOglas_Click(object sender, EventArgs e)
        {
            var oglas = new Ogla
            {
                Id_oglas = 15,   //treba napraviti inkrementaciju id-a
                korisnik_id = 1, //treba provjeriti tko je ulogiran
                naziv = txtNaslovOglasa.Text,
                Marka = cmbMarkaVozila.SelectedItem as Marka,
                Model = cmbModelVozila.SelectedItem as Model,
                lokacija_vozila = txtLokacija.Text,
                godina = Int32.Parse(txtGodinaProizvodnje.Text),
                cijena = txtCijena.Text,
                kilometraza = txtKilometraza.Text,
                Motor = cmbMotor.SelectedItem as Motor,
                ostecenje = (byte)cbOstecenja.CheckState,
                leasing = (byte)cbLeasing.CheckState,
                datum = dtpDatum.Value
            };
            oglasServis.AddOglas(oglas);
            Close();
        }

        private void FrmCreateAds_Load(object sender, EventArgs e)
        {
            LoadAllMarke();
            LoadAllMotori();
            LoadAllModeli();
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
    }
}
