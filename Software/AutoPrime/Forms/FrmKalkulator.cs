using BusinessLogicModel.Services;
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
            LoadCarModel(1);
        }

        private void LoadCarMake()
        {
            cmbMake.DataSource = markaService.GetMarkas();
            cmbMake.DisplayMember = "Naziv";
            cmbMake.ValueMember = "Id_marka";
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCarModel(SelectedCarMake());
        }

        private void LoadCarModel(int carMake)
        {
            cmbModel.DataSource = modelService.GetCertainModels(carMake);
        }

        private int SelectedCarMake()
        {
            int id;
            bool result = int.TryParse(cmbMake.SelectedValue.ToString(), out id);
            return id;
        }
    }
}
