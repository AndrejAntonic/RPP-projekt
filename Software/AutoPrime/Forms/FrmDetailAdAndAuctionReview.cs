using DataAccessLayer.Repositories;
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
    public partial class FrmDetailAdAndAuctionReview : Form
    {
        private Ogla oglas = new Ogla();
        public FrmDetailAdAndAuctionReview(Ogla odabrani)
        {
            InitializeComponent();
            this.oglas = odabrani;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            FrmAdAndAuctionReview frm = new FrmAdAndAuctionReview();
            frm.ShowDialog();
        }

        private void btnSlicni_Click(object sender, EventArgs e)
        {
            FrmShowSimilar slicniOglasi = new FrmShowSimilar();
            slicniOglasi.Show();
        }

        private void btnOstecenja_Click(object sender, EventArgs e)
        {
            if (oglas.ostecenje==1)
            {
                FrmShowDamage ostecenja = new FrmShowDamage();
                ostecenja.Show();
            }
            else
            {
                MessageBox.Show("Ne može se otvoriti prikaz oštećenja jer ih nema!");
            }

        }

        private void FrmDetailAdAndAuctionReview_Load(object sender, EventArgs e)
        {
            FrmAdAndAuctionReview frm = new FrmAdAndAuctionReview();
            frm.Close();
            FillDetail();
            btnKorime.Text = oglas.Korisnik.Korimme;
        }

        private void FillDetail()
        {
            var provjeraOstecenja = oglas.ostecenje;
            if (provjeraOstecenja==1)
            {
                checkBoxOstecenja.Checked = true;
            }
            txtNazivOglasa.Text = oglas.naziv;
            txtMarka.Text = oglas.Marka.Naziv;
            txtModel.Text = oglas.Model.naziv;
            txtGodina.Text = oglas.godina.ToString();
            txtCijena.Text = oglas.cijena;
            txtKilometraza.Text = oglas.kilometraza;
            txtMotor.Text = oglas.Motor.vrsta;
            txtLokacija.Text = oglas.lokacija_vozila;
        }
    }
}
