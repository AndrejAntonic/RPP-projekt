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
    public partial class FrmEditAds : Form
    {
        private Ogla oglas = new Ogla();
        private OglasServices oglasServis = new OglasServices();
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private OstecenjaServices ostecenjaServis = new OstecenjaServices();
        private SlikaServices slikaServis = new SlikaServices();
        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();
        public FrmEditAds(Ogla odabrani)
        {
            InitializeComponent();
            this.oglas = odabrani;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            oglas.naziv = txtNaslovOglasa.Text;
            oglas.Marka = cmbMarkaVozila.SelectedItem as Marka;
            oglas.Model = cmbModelVozila.SelectedItem as Model;
            oglas.Motor = cmbMotor.SelectedItem as Motor;
            oglas.godina = Int32.Parse(txtGodinaProizvodnje.Text);
            oglas.cijena = txtCijena.Text;
            oglas.kilometraza = txtKilometraza.Text;
            oglas.lokacija_vozila = txtLokacija.Text;
            oglas.datum = dtpDatum.Value;
            oglas.ostecenje = (byte)cbOstecenja.CheckState;
            oglas.leasing = (byte?)cbLeasing.CheckState;

            oglasServis.UpdateOglas(oglas);
            this.Close();

        }


        private void FrmEditAds_Load(object sender, EventArgs e)
        {
            cmbMotor.DataSource = motorServis.GetMotors();
            cmbModelVozila.DataSource = modelServis.GetModels();
            cmbMarkaVozila.DataSource = markaServices.GetMarkas();
            FillOglasDetail();
        }


        private void FillOglasDetail()
        {
            //popunjavanje detalja oglasa
            cbOstecenja.Visible = false;
            cbLeasing.Visible = false;

            txtNaslovOglasa.Text = oglas.naziv;
            cmbMarkaVozila.Text = oglas.Marka.Naziv;
            cmbModelVozila.Text = oglas.Model.naziv;
            txtGodinaProizvodnje.Text = oglas.godina.ToString();
            txtCijena.Text = oglas.cijena;
            txtKilometraza.Text = oglas.kilometraza;
            cmbMotor.Text = oglas.Motor.vrsta;
            txtLokacija.Text = oglas.lokacija_vozila;
            dtpDatum.Value = oglas.datum;
        }


        private void LoadWantedModels()
        {
            var odabrano = cmbMarkaVozila.SelectedItem as Marka;
            int zeljeno;
            zeljeno = odabrano.Id_marka;
            cmbModelVozila.DataSource = modelServis.GetCertainModels(zeljeno);
        }

        private void cmbMarkaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWantedModels();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                // kreiranje objekta OpenFileDialog za pretragu slike

                OpenFileDialog open = new OpenFileDialog();

                // filtriranje dialogboxa kako bi korisnik mogao izabrati samo određene vrste slike

                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //kreiraj objekt Image klase i pridruzi ime slike, dodaj sliku u bazu pomocu funkcije

                    Image img = new Bitmap(open.FileName);
                    //converterDemo(img);
                }

                /*var sliketina = new Slika
                {
                    Id_slike = 1,
                    oglas_id = 1,
                    slika1 = result,
                    ostecenje_id = 1
                };*/

                /*using (var repo = new AutoPrimeModel())
                {
                    Image.Save(repo, sliketina);
                }*/

                //slikaServis.AddSlika(sliketina);
            }
            catch
            {
                MessageBox.Show("Nije moguce izabrati takvu sliku.");
            }
        }

        private void btnDodajOstecenja_Click(object sender, EventArgs e)
        {
            try
            {

                // kreiranje objekta OpenFileDialog za pretragu slike

                OpenFileDialog open = new OpenFileDialog();

                // filtriranje dialogboxa kako bi korisnik mogao izabrati samo određene vrste slike

                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                //ako je korisnik odabrao neku sliku radi sljedece

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //kreiraj objekt Image klase i pridruzi ime slike, dodaj sliku u bazu pomocu funkcije

                    Image img = new Bitmap(open.FileName);
                    //converterDemo(img);
                }
            }
            catch
            {
                MessageBox.Show("Nije moguce izabrati takvu sliku.");
            }
        }

        //umjesto ovog myb napravit u repozitoriju za slike da spremi sliku, isto tak i za ostecenja (mozd vec i ima pogledam kasnije)
        public static byte converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte xByte = (byte)_imageConverter.ConvertTo(x, typeof(byte));
            return xByte;
        }
    }
}
