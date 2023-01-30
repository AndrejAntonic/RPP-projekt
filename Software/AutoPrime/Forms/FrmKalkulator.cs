using AutoPrime.Forms;
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

namespace AutoPrime
{
    public partial class FrmKalkulator : Form
    {
        //Andrej Antonić
        //Inicijalizacija svih potrebnih klasa
        MarkaServices markaService = new MarkaServices();
        ModelServices modelService = new ModelServices();
        bool isChecked = false;
        public FrmKalkulator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) //Zatvaranje forme
        {
            Close();
        }
        
        private void FrmKalkulator_Load(object sender, EventArgs e) //Poziv funkcija koje učitavaju sve potrebne vrijednosti
        {
            LoadCarMake();
            LoadCarModel();
            LoadCarPrice();
        }

        private void LoadCarMake() //Učitavanje podataka o markama automobila iz baze
        {
            cmbMake.DataSource = markaService.GetMarkas();
            cmbMake.DisplayMember = "Naziv";
            cmbMake.ValueMember = "Id_marka";
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e) //Promjena učitanih modela sa obzirom na odabranu marku
        {
            LoadCarModel();
        }

        private void LoadCarModel() //Učitavanje podataka o modelima za odabranu marku iz baze
        {
            cmbModel.DataSource = modelService.GetCertainModels(SelectedCarMake());
            cmbModel.DisplayMember = "naziv";
            cmbModel.ValueMember = "Id_model";
        }

        private int SelectedCarMake() //Dohvaćanje odabrane marke automobila
        {
            int id;
            bool result = int.TryParse(cmbMake.SelectedValue.ToString(), out id);
            return id;
        }

        private void btnCalculate_Click(object sender, EventArgs e) //Otvaranje forme za detaljni prikaz kalkulacija ako su svi podaci dobro uneseni
        {
            bool correct = CheckInsertedValues();
            if (correct)
                MessageBox.Show("Molimo popunite sve potrebne podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); //Greška ako nisu unesene sve vrijednosti
            else
            {
                var year = Int32.Parse(txtYear.Text.ToString()); //Dohvaćanje svih podataka sa forme
                var mileage = double.Parse(txtMileage.Text.ToString());
                double insertedPrice = 0;
                if (!isChecked)
                    insertedPrice = GetDatabasePrice(SelectedCarModel());
                else
                    insertedPrice = double.Parse(txtInsertedPrice.Text.ToString());
                FrmKalkulatorDetails frmKalkulatorDetails = new FrmKalkulatorDetails(year, insertedPrice, mileage);
                frmKalkulatorDetails.ShowDialog();
            }
        }

        private bool CheckInsertedValues() //Provjera unesenih vrijednosti
        {
            return string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtMileage.Text) || (isChecked == true && string.IsNullOrEmpty(txtInsertedPrice.Text));
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e) //Promjena cijene automobila sa obzirom na marku i model
        {
            LoadCarPrice();
        }

        private double GetDatabasePrice(int model_id) //Dohvaćanje cijene iz baze podataka
        {
            double price = modelService.GetModelPrice(model_id).FirstOrDefault();
            return price;
        }

        private void LoadCarPrice() //Učitavanje dohvaćene cijene
        {
            txtEstimatedPrice.Text = GetDatabasePrice(SelectedCarModel()) + "€";
        }

        private int SelectedCarModel() //Dohvaćanje odabranog modela
        {
            int id;
            bool result = int.TryParse(cmbModel.SelectedValue.ToString(), out id);
            return id;
        }

        private void chbxChoice_Click(object sender, EventArgs e) //Promjena omogućenosti unosa vlastite cijene
        {
            isChecked = !isChecked;
            txtInsertedPrice.Enabled = isChecked;
        }

        private void FrmKalkulator_HelpRequested(object sender, HelpEventArgs hlpevent) //F1 pomoć
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmKalkulator.pdf";
            Process.Start(pdfPath);
        }
    }
}
