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
    public partial class FrmShowAllComments : Form
    {
        Korisnik korisnik = new Korisnik();
        RecenzijaServices recenzijaService = new RecenzijaServices();
        public FrmShowAllComments(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowAllComments_Load(object sender, EventArgs e)
        {
            LoadAllComments();
        }

        private void LoadAllComments()
        {
            dgvAllComments.DataSource = recenzijaService.GetRecenzijasForUser(korisnik);
        }
    }
}
