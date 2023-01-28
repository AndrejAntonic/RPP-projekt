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
    public partial class FrmShowSimilar : Form

    {
        private Ogla oglas = new Ogla();

        public FrmShowSimilar(Ogla odabran)
        {
            oglas = odabran;
            InitializeComponent();
        }

        private void btnDetaljan_Click(object sender, EventArgs e)
        {
            var odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;
            FrmDetailAdAndAuctionReview detaljni = new FrmDetailAdAndAuctionReview(odabrani);
            detaljni.Show();
        }

        private void btnLeasing_Click(object sender, EventArgs e)
        {
            FrmLeasing leasing = new FrmLeasing();
            leasing.Show();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowSimilar_Load(object sender, EventArgs e)
        {
            OglasServices servis = new OglasServices();
            dgvOglasi.DataSource = servis.GetSimilarOglas(oglas);
        }
    }
}
