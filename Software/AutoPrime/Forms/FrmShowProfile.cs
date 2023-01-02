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
    public partial class FrmShowProfile : Form
    {
        Korisnik korisnik;
        public FrmShowProfile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowAllComments_Click(object sender, EventArgs e)
        {
            FrmShowAllComments sviKomentari = new FrmShowAllComments();
            sviKomentari.Show();
        }

        private void FrmShowProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
