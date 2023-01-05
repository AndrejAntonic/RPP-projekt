using BusinessLogicModel.Services;
using DataAccessLayer;
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
    public partial class FrmCreateAds : Form
    {
        private OglasServices oglasServis = new OglasServices();
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private OstecenjaServices ostecenjaServis = new OstecenjaServices();
        private SlikaServices slikaServis = new SlikaServices();
        public FrmCreateAds()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Treba sakriti nepotrebne redove tamo gdje budu prikazani oglasi
        private void btnDodajOglas_Click(object sender, EventArgs e)
        {
            var oglas = new Ogla
            {
                Id_oglas = 15,   //treba napraviti inkrementaciju id-a
                korisnik_id = 1, //treba provjeriti tko je ulogiran
                naziv = txtNaslovOglasa.Text,
                Marka = cmbMarkaVozila.SelectedItem as Marka,
                Model = cmbModelVozila.SelectedItem as Model,
                lokacija_vozila = txtLokacija.Text,
                godina = Int32.Parse(txtGodinaProizvodnje.Text),
                cijena = txtCijena.Text,
                kilometraza = txtKilometraza.Text,
                Motor = cmbMotor.SelectedItem as Motor,
                ostecenje = (byte)cbOstecenja.CheckState,
                leasing = (byte)cbLeasing.CheckState,
                datum = dtpDatum.Value
            };

            var ostecenja = new Oštećenja
            {

            };

            var slika = new Slika
            {

            };

            oglasServis.AddOglas(oglas);
            ostecenjaServis.AddOstecenja(ostecenja);
            slikaServis.AddSlika(slika);
            Close();
        }

        private void FrmCreateAds_Load(object sender, EventArgs e)
        {
            LoadAllMarke();
            LoadAllMotori();
        }

        private void LoadAllModeli()
        {
            cmbModelVozila.DataSource = modelServis.GetModels();
        }

        private void LoadAllMotori()
        {
            cmbMotor.DataSource = motorServis.GetMotors();
        }

        private void LoadAllMarke()
        {
            cmbMarkaVozila.DataSource = markaServices.GetMarkas();
        }

        private void cmbMarkaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWantedModels();
        }

        private void LoadWantedModels()
        {
            var odabrano = cmbMarkaVozila.SelectedItem as Marka;
            int zeljeno;
            zeljeno = odabrano.Id_marka;
            cmbModelVozila.DataSource = modelServis.GetCertainModels(zeljeno);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
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
                    //ImageToByteArray(img);
                }
            }
            catch
            {
                MessageBox.Show("Can not upload image");
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
                    //ImageToByteArray(img);
                }
            }
            catch
            {
                MessageBox.Show("Can not upload image");
            }
        }

        //umjesto ovog myb napravit u repozitoriju za slike da spremi sliku, isto tak i za ostecenja (mozd vec i ima pogledam kasnije)
        /*public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var repo = new AutoPrimeModel())
            {
                imageIn.Save(repo, imageIn.RawFormat);
                return repo;
            }
        }*/
    }
}
