using BusinessLogicModel.Services;
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
        //Bruno Pavlović
        //inicijalizacija potrebnih Entiteta, Servisa i varijabli
        private Ogla oglas = new Ogla();
        private Aukcije Aukcije = new Aukcije();
        private Kreirao_aukcije_korisnikServices kreirao_ = new Kreirao_aukcije_korisnikServices();
        private KorisnikServices korisnikServices = new KorisnikServices();
        private PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        private ZanimljiviOglasiServices zanimljivi = new ZanimljiviOglasiServices();
        private PonudaServices ponudeServisi = new PonudaServices();
        private AukcijeServices aukcijeServisi = new AukcijeServices();
        private Ponuda ponuda = new Ponuda();

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
            FrmShowSimilar slicniOglasi = new FrmShowSimilar(oglas);
            slicniOglasi.Show();
        }

        private void btnOstecenja_Click(object sender, EventArgs e)
        {
            //ako postoji ostecenje moguce je otvoriti formu ostecenja
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
            //ako je provjera == 1 značiti da je forma primila aukciju
            if (provjera==1)
            {
                FillAukcijeDetail();
                var korisnik = kreirao_.GetKorisnikFromAukcija(Aukcije.Id_aukcije);
                if (korisnik!=null)
                {
                    btnKorime.Text = korisnik.Korimme;
                }
            }
            else
            {
                FillDetail();
                btnKorime.Text = oglas.Korisnik.Korimme;
            }
        }

        private void FillAukcijeDetail()
        {
            //popunjavanje detalja aukcije
            checkBoxOstecenja.Visible = false;
            btnZanimljivi.Visible = false;


            ponuda.Aukcije_id = Aukcije.Id_aukcije;

            var najvecaPonuda = ponudeServisi.GetHighestPonuda(ponuda.Aukcije_id);

            txtNazivOglasa.Text = Aukcije.naziv;
            txtMarka.Text = Aukcije.Marka.Naziv;
            txtModel.Text = Aukcije.Model.naziv;
            txtGodina.Text = Aukcije.godina.ToString();
            txtCijena.Text = Aukcije.cijena;
            txtKilometraza.Text = Aukcije.kilometraza;
            txtMotor.Text = Aukcije.Motor.vrsta;
            txtLokacija.Text = Aukcije.lokacija_vozila;
            txtNajvecaPonuda.Text = najvecaPonuda.ToString();
        }

        private void FillDetail()
        {
            //popunjavanje detalja oglasa
            var provjeraOstecenja = oglas.ostecenje;
            if (provjeraOstecenja==1)
            {
                checkBoxOstecenja.Checked = true;
            }
            txtNajvecaPonuda.Visible = false;
            txtPonudaBid.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtNazivOglasa.Text = oglas.naziv;
            txtMarka.Text = oglas.Marka.Naziv;
            txtModel.Text = oglas.Model.naziv;
            txtGodina.Text = oglas.godina.ToString();
            txtCijena.Text = oglas.cijena;
            txtKilometraza.Text = oglas.kilometraza;
            txtMotor.Text = oglas.Motor.vrsta;
            txtLokacija.Text = oglas.lokacija_vozila;
        }

        private void btnKorime_Click(object sender, EventArgs e)
        {
            //ako je provjera == 1 značiti da je forma primila aukciju
            Korisnik korisnik;
            if (provjera==1)
            {
                korisnik = kreirao_.GetKorisnikFromAukcija(Aukcije.Id_aukcije);
            }
            else
            {
                korisnik = korisnikServices.GetKorisnikById(oglas.korisnik_id);
            }
            //proslijedi korisnika formi profila
            FrmShowProfile profil = new FrmShowProfile(korisnik);
            profil.Show();
        }

        private void btnZanimljivi_Click(object sender, EventArgs e)
        {
            var korisnik = prijavljeniKorisnik.VratiPrijavljenog();

            //napravi novi zanimljivi oglas
            var noviZanimljivi = new Zanimljivi_oglasi
            {
                Oglas_id = oglas.Id_oglas,
                Korisnik_id = korisnik.Id_korisnika
            };
            //dodaj novi kreirani zanimljivi oglas
            zanimljivi.AddZanimljiviOglas(noviZanimljivi);
            MessageBox.Show("Dodan oglas: "+oglas.naziv+" u listu zanimljivih oglasa.");

        }

        private void btnPonudi_Click(object sender, EventArgs e)
        {
            var najvecaPonuda = ponudeServisi.GetHighestPonuda(ponuda.Aukcije_id);

            var prijavljen = prijavljeniKorisnik.VratiPrijavljeniId();

            var brojcina = Int32.Parse(txtPonudaBid.Text);

            if(brojcina < najvecaPonuda.Ponuda1)
            {
                MessageBox.Show("Morate ponuditi veću ponudu od trenutne najveće ponude!");
            }
            else
            {
                Ponuda novaNajvecaPonuda = new Ponuda
                {
                    Aukcije_id = Aukcije.Id_aukcije,
                    Korisnik_id = prijavljen,
                    Ponuda1 = brojcina
                };

                ponudeServisi.AddPonuda(novaNajvecaPonuda);
                FillAukcijeDetail();
            }
        }
    }
}
