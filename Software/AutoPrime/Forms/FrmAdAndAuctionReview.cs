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
    public partial class FrmAdAndAuctionReview : Form
    {
        //Bruno Pavlović
        //inicijalizacija potrebnih servisa
        private OglasServices oglasServices = new OglasServices();
        private AukcijeServices aukcijeServices = new AukcijeServices();
        private MarkaServices MarkaServices = new MarkaServices();
        private ModelServices modelServices = new ModelServices();
        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();
        private Kreirao_aukcije_korisnikServices kreiraokorisnik = new Kreirao_aukcije_korisnikServices();

        public FrmAdAndAuctionReview()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdAndAuctionReview_Load(object sender, EventArgs e)
        {
            //ucitavanje na dataGradView-ove za oglase i aukcije
            ShowAds();
            ShowAuctions();
            //ucitavanje marki u comboBox za marke
            FillMarka();
        }

        private void FillModel(string marka)
        {
            //popuni model prema odabranom marki
            cmbModel.DataSource = modelServices.GetCertainModelsByName(marka);
            cmbModel.SelectedItem = null;
        }

        private void FillMarka()
        {
            //dohvati sve marke i popuni comboBox
            cmbMarka.DataSource = MarkaServices.GetMarkas();
            cmbMarka.SelectedItem = null;
        }

        private void ShowAuctions()
        {
            //dohvaćanje aukcija pomoću servisa
            dgvAukcije.DataSource = aukcijeServices.GetAukcije();

            //sakrivanje određenih stupaca
            dgvAukcije.Columns["Ponudas"].Visible = false;
            dgvAukcije.Columns["id_aukcije"].Visible = false;
            dgvAukcije.Columns["marka_id"].Visible = false;
            dgvAukcije.Columns["model_id"].Visible = false;
            dgvAukcije.Columns["motor_id"].Visible = false;
        }

        private void ShowAds()
        {
            //dohvaćanje oglasa pomoću servisa
            dgvOglasi.DataSource = oglasServices.GetOglas();
            HideOglasAtributes();
        }

        private void HideOglasAtributes()
        {
            //sakrivanje određenih stupaca
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
            dgvOglasi.Columns["Korisniks"].Visible = false;
            dgvOglasi.Columns["Slikas"].Visible = false;
            dgvOglasi.Columns["id_oglas"].Visible = false;
            dgvOglasi.Columns["ostecenje"].Visible = false;
            dgvOglasi.Columns["leasing"].Visible = false;
            dgvOglasi.Columns["iznajmljeno_id"].Visible = false;
            dgvOglasi.Columns["prodano_korisnik_id"].Visible = false;
            dgvOglasi.Columns["Korisnik1"].Visible = false;
        }

        private void btnPregledOglasa_Click(object sender, EventArgs e)
        {
            try
            {
                //provjeri je li odabran oglas
                if (dgvOglasi.CurrentRow != null)
                {
                    Ogla odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;

                    if (odabrani != null)
                    {
                        //povećaj broj_pregleda odabranog oglasa za jedan
                        odabrani.broj_pregleda = odabrani.broj_pregleda + 1;
                        oglasServices.UpdateOglasView(odabrani);
                    }
                    ShowAds();
                    this.Hide();
                    //otvori detaljni pregled odabranog oglasa
                    FrmDetailAdAndAuctionReview otvori = new FrmDetailAdAndAuctionReview(odabrani);
                    otvori.ShowDialog();
                 
                }
                else
                {
                    MessageBox.Show("Odaberite jedan oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedItem!=null)
            {
                var odabrana = cmbMarka.SelectedItem.ToString();
                FillModel(odabrana);
            }

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            //dohvati vrijednosti filtera sa forme te ih proslijedi metodi
            var marka ="";
            if (cmbMarka.SelectedItem!=null)
            {
                marka = cmbMarka.SelectedItem.ToString();
            }
            var model ="";
            if (cmbModel.SelectedItem!=null)
            {
                model = cmbModel.SelectedItem.ToString();
            }
            var godina="";
            if (cmbGodina.SelectedItem != null)
            {
                godina = cmbGodina.SelectedItem.ToString();
            }
            var kilometraza="";
            if (cmbKilometraza.SelectedItem!=null)
            {
                kilometraza = cmbKilometraza.SelectedItem.ToString();
            }
            var cijena ="";
            if (cmbCijena.SelectedItem!= null)
            {
                cijena = cmbCijena.SelectedItem.ToString();
            }

            //dodaj izvor podataka za dgvOglasi da budu filtrirani oglasi
            dgvOglasi.DataSource = oglasServices.FilterOglas(marka, model, godina, kilometraza, cijena);
            HideOglasAtributes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //obrisi filtere i prikazi sve oglase
            ShowAds();
            ShowAuctions();
            cmbGodina.SelectedItem = null;
            cmbModel.SelectedItem = null;
            cmbMarka.SelectedItem = null;
            cmbKilometraza.SelectedItem = null;
            cmbCijena.SelectedItem = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dohvati oglase i aukcije prema trenutno upisanome u textBox za Search
            dgvOglasi.DataSource = oglasServices.GetCertainOglass(txtSearch.Text);
            dgvAukcije.DataSource = aukcijeServices.GetCertainAukcije(txtSearch.Text);
        }

        private void btnPregledAukcije_Click(object sender, EventArgs e)
        {
            try
            {
                //otvori detaljni pregled odabrane aukcije te provjeri je li odabrana aukcija
                if (dgvAukcije.CurrentRow!=null)
                {
                    Aukcije odabrana = dgvAukcije.CurrentRow.DataBoundItem as Aukcije;
                    if (odabrana != null)
                    {
                        this.Hide();
                        FrmDetailAdAndAuctionReview frm = new FrmDetailAdAndAuctionReview(odabrana);
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite jednu aukciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Juraj Gaši
        private void btnObrisiAukciju_Click(object sender, EventArgs e)
        {
            //dohvati odabranu aukciju i Id korisnika te aukcije, usporedi sa prijavljenim korisnikom
            var odabranaAukcija = dgvAukcije.CurrentRow.DataBoundItem as Aukcije;
            var uzmiIdKorisnikaAukcije = kreiraokorisnik.GetKorisnikFromAukcija(odabranaAukcija.Id_aukcije);
            var prijavljen = prijavljeni.VratiPrijavljenog();
            
            //ako nije isti id, ne da obrisati (ne smije korisnik moci obrisati tuđu aukciju)
            if (uzmiIdKorisnikaAukcije.Id_korisnika != prijavljen.Id_korisnika)
            {
                MessageBox.Show("Mozete brisati samo aukcije koje ste vi kreirari!");
            }
            //sigurnosno pitanje brisanja aukcije
            else {
                DialogResult message = MessageBox.Show("Jeste li sigurni da želite obrisati aukciju?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (message == DialogResult.Yes)
                {
                    aukcijeServices.RemoveAuction(odabranaAukcija);
                }
            }
            //Refresh GUI
            ShowAds();
            ShowAuctions();
        }

        //Bruno Pavlovic
        //F1 pomoc
        private void FrmAdAndAuctionReview_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmAdAndAuctionReview.pdf";
            Process.Start(pdfPath);
        }
    }
}
