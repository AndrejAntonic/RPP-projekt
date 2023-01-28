using AutoPrime.Forms;
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

namespace AutoPrime
{
    public partial class FrmKalkulator : Form
    {
        MarkaServices markaService = new MarkaServices();
        ModelServices modelService = new ModelServices();
        bool isChecked = false;
        public FrmKalkulator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmKalkulator_Load(object sender, EventArgs e)
        {
            LoadCarMake();
            LoadCarModel();
            LoadCarPrice();
        }

        private void LoadCarMake()
        {
            cmbMake.DataSource = markaService.GetMarkas();
            cmbMake.DisplayMember = "Naziv";
            cmbMake.ValueMember = "Id_marka";
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCarModel();
        }

        private void LoadCarModel()
        {
            cmbModel.DataSource = modelService.GetCertainModels(SelectedCarMake());
            cmbModel.DisplayMember = "naziv";
            cmbModel.ValueMember = "Id_model";
        }

        private int SelectedCarMake()
        {
            int id;
            bool result = int.TryParse(cmbMake.SelectedValue.ToString(), out id);
            return id;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtMileage.Text) || (isChecked == true && string.IsNullOrEmpty(txtInsertedPrice.Text)))
                MessageBox.Show("Molimo popunite sve potrebne podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var year = Int32.Parse(txtYear.Text.ToString());
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

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCarPrice();
        }

        private double GetDatabasePrice(int model_id)
        {
            double price = modelService.GetModelPrice(model_id).FirstOrDefault();
            return price;
        }

        private void LoadCarPrice()
        {
            txtEstimatedPrice.Text = GetDatabasePrice(SelectedCarModel()) + "€";
        }

        private int SelectedCarModel()
        {
            int id;
            bool result = int.TryParse(cmbModel.SelectedValue.ToString(), out id);
            return id;
        }

        private void chbxChoice_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            txtInsertedPrice.Enabled = isChecked;
        }
    }
}
