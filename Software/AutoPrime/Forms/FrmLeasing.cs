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
    public partial class FrmLeasing : Form
    {
        public FrmLeasing()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLeasing_Load(object sender, EventArgs e)
        {
            OglasServices servis = new OglasServices();
            dgvOglasi.DataSource = servis.GetLeasingOglas();
            dgvOglasi.Columns["slikas"].Visible = false;
            dgvOglasi.Columns["korisniks"].Visible = false;
           
        }
    }
}
