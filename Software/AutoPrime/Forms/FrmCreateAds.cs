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

        private void btnDodajOglas_Click(object sender, EventArgs e)
        {

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
