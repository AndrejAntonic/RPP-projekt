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
    public partial class FrmAddPictures : Form
    {
        private SlikaServices SlikaServis = new SlikaServices();
        int trenutni;
        public FrmAddPictures(int trenutniSad)
        {
            InitializeComponent();
            trenutni = trenutniSad;
        }

        private void btnDodajSlike_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddPictures_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Trenutni id:" + trenutni);
        }
    }
}
