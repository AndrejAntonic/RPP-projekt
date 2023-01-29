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
    public partial class FrmCreateAuction : Form
    {
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private AukcijeServices aukcijeServis = new AukcijeServices();
        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();
        private Kreirao_aukcije_korisnikServices kreiraj = new Kreirao_aukcije_korisnikServices();
        private PonudaServices ponudaServices = new PonudaServices();
        public FrmCreateAuction()
        {
            InitializeComponent();
        }

        

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FrmCreateAuction_Load(object sender, EventArgs e)
        {
            LoadAllModeli();
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

        private void btnDodajAukciju_Click(object sender, EventArgs e)
        {
            var aukcija = new Aukcije
            {
                naziv = txtNaslovOglasa.Text,
                Marka = cmbMarkaVozila.SelectedItem as Marka,
                Model = cmbModelVozila.SelectedItem as Model,
                godina = Int32.Parse(txtGodinaProizvodnje.Text),
                kilometraza = txtKilometraza.Text,
                cijena = txtCijena.Text,
                lokacija_vozila = txtLokacija.Text,
                Motor = cmbMotor.SelectedItem as Motor,
                datum_aukcije = dtpDatum.Value,
                rok = dtpRok.Value
            };

            aukcijeServis.AddAuction(aukcija);

            var prijavljen = prijavljeni.VratiPrijavljeniId();

            var zadnja = aukcijeServis.GetLastAukcije();

            var aukkor = new Kreirao_aukcije_korisnik
            {
                Aukcija_id = zadnja.Id_aukcije,
                Korisnik_id = prijavljen
            };

            kreiraj.AddKreiraoAukcijeKorisnik(aukkor);

            var pripremaZaPonude = new Ponuda
            {
                Aukcije_id = zadnja.Id_aukcije,
                Korisnik_id = prijavljen,
                Ponuda1 = Int32.Parse(txtCijena.Text)
            };

            ponudaServices.AddPonuda(pripremaZaPonude);


            this.Close();
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
                    //converterDemo(img);
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
                    //converterDemo(img);
                }
            }
            catch
            {
                MessageBox.Show("Can not upload image");
            }
        }

        //umjesto ovog myb napravit u repozitoriju za slike da spremi sliku, isto tak i za ostecenja (mozd vec i ima pogledam kasnije)
        public static byte converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte xByte = (byte)_imageConverter.ConvertTo(x, typeof(byte));
            return xByte;
        }

        private void FrmCreateAuction_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmCreateAuction.pdf";
            Process.Start(pdfPath);
        }
    }
}
