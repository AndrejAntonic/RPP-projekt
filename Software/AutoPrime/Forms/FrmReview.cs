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
    public partial class FrmReview : Form
    {
        Korisnik selectedKorisnik = new Korisnik();
        public FrmReview(Korisnik korisnik)
        {
            InitializeComponent();
            selectedKorisnik = korisnik;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
