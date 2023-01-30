using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private OglasServices oglasServices = new OglasServices();
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
            btnSlicni.Visible = false;


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

            var korisnikPobjeda = korisnikServices.GetKorisnikById(najvecaPonuda.Korisnik_id);
            txtPobjednikPonude.Text = korisnikPobjeda.Korimme;
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
            label9.Visible = false;
            txtPobjednikPonude.Visible = false;
            btnPonudi.Visible = false;
            

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

            //dohvati sve korisnikove oglase i provjeri je li odabrani oglas njegov
            var korisnikoviOglasi = oglasServices.GetOglasByKorisnikId(korisnik.Id_korisnika);

            foreach (var item in korisnikoviOglasi)
            {
                if (item.Id_oglas == oglas.Id_oglas)
                {
                    MessageBox.Show("Ne možete dodati vlastiti oglas u listu zanimljivih oglasa!");
                    return;
                }
            }

            //dohvati sve korisnikove zanimljive oglase i provjeri je li odabrani oglas već postoji u listi
            var zanimljiviOglasiKorisnika = zanimljivi.GetZanimljiviOglasiByUserId(korisnik.Id_korisnika);
            foreach (var item in zanimljiviOglasiKorisnika)
            {
                if (item.Oglas_id == oglas.Id_oglas)
                {
                    MessageBox.Show("Ne možete dodati oglas u listu zanimljivih oglasa jer se već nalazi tamo!");
                    return;
                }
            }

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

        //Juraj Gaši
        private void btnPonudi_Click(object sender, EventArgs e)
        {
            var najvecaPonuda = ponudeServisi.GetHighestPonuda(ponuda.Aukcije_id);

            var prijavljen = prijavljeniKorisnik.VratiPrijavljeniId();

            var brojcina = Int32.Parse(txtPonudaBid.Text);

            //ako je korisnik pokusao ponuditi manje od najvece ponude izbacuje mbox
            if(brojcina < najvecaPonuda.Ponuda1)
            {
                MessageBox.Show("Morate ponuditi veću ponudu od trenutne najveće ponude.");
            }
            else
            {
                //provjera da li je aukcija istekla
                if(Aukcije.rok >= DateTime.Now) {

                Ponuda novaNajvecaPonuda = new Ponuda
                {
                    Aukcije_id = Aukcije.Id_aukcije,
                    Korisnik_id = prijavljen,
                    Ponuda1 = brojcina
                };

                ponudeServisi.AddPonuda(novaNajvecaPonuda);
                FillAukcijeDetail();
                }
                else
                {
                    MessageBox.Show("Ova aukcija je istekla.");
                }
            }
        }

        private void FrmDetailAdAndAuctionReview_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmDetailAdAndAuctionReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
