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
    public partial class FrmShowDamage : Form
    {
        private SlikaServices slikaServis = new SlikaServices();
        public FrmShowDamage()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

        }
    }
}
