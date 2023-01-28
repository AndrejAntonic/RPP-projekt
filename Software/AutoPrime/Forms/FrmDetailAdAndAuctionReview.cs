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
        private Aukcije Aukcije = new Aukcije();
        private int provjera = 0;
        public FrmDetailAdAndAuctionReview(Ogla odabrani)
        {
            InitializeComponent();
            this.oglas = odabrani;
        }

        public FrmDetailAdAndAuctionReview(Aukcije aukcije)
        {
            InitializeComponent();
            this.Aukcije = aukcije;
            this.provjera = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
            if (provjera==1)
            {
                FillAukcijeDetail();
                btnKorime.Text = Aukcije.Id_aukcije.ToString();
            }
            else
            {
                FillDetail();
                btnKorime.Text = oglas.Korisnik.Korimme;
            }
        }

        private void FillAukcijeDetail()
        {
            checkBoxOstecenja.Visible = false;

            txtNazivOglasa.Text = Aukcije.naziv;
            txtMarka.Text = Aukcije.Marka.Naziv;
            txtModel.Text = Aukcije.Model.naziv;
            txtGodina.Text = Aukcije.godina.ToString();
            txtCijena.Text = Aukcije.cijena;
            txtKilometraza.Text = Aukcije.kilometraza;
            txtMotor.Text = Aukcije.Motor.vrsta;
            txtLokacija.Text = Aukcije.lokacija_vozila;
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
