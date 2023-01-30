using AutoPrime.Forms;
using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.CodeDom.Compiler;
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

namespace AutoPrime
{
    public partial class FrmShowProfile : Form
    {
        //Inicijalizacija svih potrebnih vrijednosti - Andrej Antonić
        Korisnik korisnik = new Korisnik();
        Korisnik loggedKorisnik = PrijavljeniKorisnik.prijavljeniKorisnik;
        RecenzijaServices recenzijaService = new RecenzijaServices();
        OglasServices oglasService = new OglasServices();
        ZanimljiviOglasiServices zanimljiviOglasiService = new ZanimljiviOglasiServices();
        PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();
        bool loggedInKorisnik = false;
        public FrmShowProfile(Korisnik korisnik = null) //Inicijalizacija forme i spremanje prosljeđenog korisnika
        {
            InitializeComponent();
            this.korisnik = korisnik;
            if (this.korisnik.Id_korisnika == loggedKorisnik.Id_korisnika) //Provjera je li prosljeđeni korisnik isti kao prijavljeni korisnik - Andrej Antonić
                loggedInKorisnik = true;
        }

        private void btnClose_Click(object sender, EventArgs e) //Zatvaranje forme - Andrej Antonić
        {
            Close();
        }

        private void btnShowAllComments_Click(object sender, EventArgs e) //Otvaranje forme za prikaz svih recenzija korisnika - Andrej Antonić
        {
            FrmShowAllComments sviKomentari = new FrmShowAllComments(korisnik);
            sviKomentari.ShowDialog();
        }

        private void FrmShowProfile_Load(object sender, EventArgs e) //Učitavanje vrijednosti profila u formu - Andrej Antonić
        {
            if (!loggedInKorisnik) //Sakrivanje nepotrebnih vrijednosti ako se ne radi o prijavljenom korisniku
                removeZanimljivi();
            else
                LoadInterestingAds();
            LoadKorisnikData();
            LoadAllKorisnikPostings();
        }

        private void LoadInterestingAds() //Učitavanje zanimljivih oglasa - Andrej Antonić
        {
            List<Zanimljivi_oglasi> zanimljiviOglasi = zanimljiviOglasiService.GetZanimljiviOglasiByUserId(korisnik.Id_korisnika);
            List<Ogla> oglasi = new List<Ogla>();
            if(zanimljiviOglasi != null) //Dodavanje oglasa u listu ako postoje
            {
                foreach (var item in zanimljiviOglasi)
                {
                    oglasi.Add(oglasService.GetOneOglasById(item.Oglas_id));
                }
            }
            dgvUserFavourite.DataSource = oglasi;
            dgvUserFavourite.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false); //Sakrivanje svih stupaca
            //dgvUserFavourite.Rows[0].Selected = false;
            dgvUserFavourite.Columns["Id_oglas"].Visible = true;
            dgvUserFavourite.Columns["naziv"].Visible = true;
            dgvUserFavourite.Columns["datum"].Visible = true;
        }

        private void removeZanimljivi() //Sakrivanje elemenata profila koje se odnose na vlastiti profil - Andrej Antonić
        {
            dgvUserFavourite.Visible = false;
            lblUserFavourite.Visible = false;
            btnDeleteAdvertisement.Visible = false;
            btnLeaveRating.Visible = true;
            btnShowInteresting.Visible = false;
            btnDeleteInteresting.Visible = false;
            btnUrediOglas.Visible = false;
        }

        private void LoadAllKorisnikPostings() //Učitavanje svih korisnikovih oglasa - Andrej Antonić
        {
            dgvUserAdvertisement.DataSource = oglasService.GetOglasByKorisnikId(korisnik.Id_korisnika);
            dgvUserAdvertisement.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false); //Sakrivanje svih stupaca
            dgvUserAdvertisement.Columns["Id_oglas"].Visible = true;
            dgvUserAdvertisement.Columns["naziv"].Visible = true;
            dgvUserAdvertisement.Columns["datum"].Visible = true;
        }

        private void LoadKorisnikData() //Učitavanje svih podataka korisnika - Andrej Antonić
        {
            
            txtUsername.Text = korisnik.Korimme;
            txtPhoneNumber.Text = korisnik.Broj_telefona;
            txtAverageRating.Text = GetAverageRating();
            txtLastComment.Text = GetLastComment();
            
        }

        private string GetLastComment() //Dohvaćanje komentara iz zadnje recenzije - Andrej Antonić
        {
            string comment = "Ne postoje recenzije";
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijasForUser(korisnik);
            if (recenzijas.Count > 0)
            {
                DateTime datum = recenzijas.Max(r => r.Datum); //Dohvaćanje najnovijeg datuma
                foreach (var item in recenzijas)
                {
                    if (item.Datum == datum)
                    {
                        comment = item.Komentar; //Pronalaženje najnovijeg komentara po datumu
                        break;
                    }
                }
            }
            return comment;

        }

        private string GetAverageRating() //Učitavanje prosječne ocjene korisnika - Andrej Antonić
        {
            double averageRating = 0, numberOfRatings = 0;
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijasForUser(korisnik);
            for(int i = 0; i < recenzijas.Count; i++) //Brojenje recenzija i svih ocjena
            {
                if (recenzijas[i].Za_korisnik_id == korisnik.Id_korisnika)
                {
                    averageRating += recenzijas[i].Ocjena;
                    numberOfRatings++;
                }
            }
            averageRating /= numberOfRatings; //Dobivanje prosječne ocjene
            return averageRating.ToString();
        }

        private void btnLeaveRating_Click(object sender, EventArgs e) //Otvaranje forme za pisanje recenzije - Andrej Antonić
        {
            bool korisnikBought = determineIfBought();
            if(korisnikBought)
            {
                FrmReview form = new FrmReview(korisnik);
                form.ShowDialog();

                LoadKorisnikData();
            }
            else
                MessageBox.Show("Ne možete ostaviti recenziju korisniku od kojeg niste ništa kupili", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool determineIfBought() //Provjera je li korisnik kupio od korisnika kojemu želi ostaviti recenziju - Andrej Antonić
        {
            List<Ogla> korisnikOglas = oglasService.GetOglasByKorisnikId(korisnik.Id_korisnika);
            bool korisnikBought = false;
            foreach (var item in korisnikOglas)
            {
                if (item.prodano_korisnik_id == loggedKorisnik.Id_korisnika)
                {
                    korisnikBought = true;
                    break;
                }
            }

            return korisnikBought;
        }

        private void btnShowInteresting_Click(object sender, EventArgs e) //Prikaz detalja zanimljivog oglasa - Andrej Antonić
        {
            Ogla ogla = getSelectedInterestingOglas();

            if (ogla != null)
            {
                FrmDetailAdAndAuctionReview form = new FrmDetailAdAndAuctionReview(ogla);
                form.ShowDialog();
            }
        }

        private Ogla getSelectedInterestingOglas() //Dohvaćanje odabranog zanimljivog oglasa - Andrej Antonić
        {
            try
            {
                if (dgvUserFavourite.CurrentRow != null)
                {
                    return dgvUserFavourite.CurrentRow.DataBoundItem as Ogla;
                }
                else
                {
                    MessageBox.Show("Odaberite jedan oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); //Prikazivanje greške ako ni jedan oglas nije odabran
                    return null;
                }
            }
            catch (Exception ex) //Prikazivanje greške ukoliko dođe do greške
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnShowAdvertisement_Click(object sender, EventArgs e) //Učitavanje forme za detaljni prikaz korisnikovog oglasa - Andrej Antonić
        {
            Ogla ogla = getSelectedAdvertisement();

            if (ogla != null)
            {
                FrmDetailAdAndAuctionReview form = new FrmDetailAdAndAuctionReview(ogla);
                form.ShowDialog();
            }
        }

        private Ogla getSelectedAdvertisement() //Dohvaćanje odabranog korisnikovog oglasa - Andrej Antonić
        {
            if (dgvUserAdvertisement.SelectedRows.Count > 0 || dgvUserAdvertisement.SelectedCells.Count > 0)
                return dgvUserAdvertisement.CurrentRow.DataBoundItem as Ogla;
            else
                MessageBox.Show("Odaberite jedan oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        //Juraj Gaši
        private void btnDeleteAdvertisement_Click(object sender, EventArgs e)
        {
            //dohvati selektirani oglas
            Ogla ogla = getSelectedAdvertisement();

            if (ogla != null)
            {
                //sigurnosni upit za brisanje odabranog oglasa
                DialogResult message = MessageBox.Show("Jeste li sigurni da želite obrisati oglas?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(message == DialogResult.Yes)
                {
                    List<Zanimljivi_oglasi> zanimljivi_Oglasi = zanimljiviOglasiService.GetZanimljiviOglasiByOglasId(ogla.Id_oglas);
                    if (zanimljivi_Oglasi != null)
                    {
                        //brisanje zanimljivog oglasa vezanog za taj oglas
                        foreach (var item in zanimljivi_Oglasi)
                        {
                            zanimljiviOglasiService.RemoveZanimljiviOglas(item);
                        }
                    }
                    oglasService.RemoveOglas(ogla);
                    LoadAllKorisnikPostings();
                }
            }
        }

        private void btnDeleteInteresting_Click(object sender, EventArgs e) //Brisanje zanimljivog oglasa iz liste zanimljivih oglasa - Andrej Antonić
        {
            Ogla ogla = getSelectedInterestingOglas();

            if (ogla!=null)
            {
                Zanimljivi_oglasi zanimljivi_Oglas = zanimljiviOglasiService.GetZanimljiviOglasiByOglasUserId(ogla.Id_oglas, loggedKorisnik.Id_korisnika);
                if (zanimljivi_Oglas != null)
                {
                    zanimljiviOglasiService.RemoveZanimljiviOglas(zanimljivi_Oglas);
                }
                else
                {
                    MessageBox.Show("Morate odabrati zanimljivi oglas koji želite obrisati!");
                }
            }

            LoadInterestingAds();
        }

        //Juraj Gaši
        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            //Dohvati selektirani oglas
            Ogla ogla = getSelectedAdvertisement();

            if (ogla != null)
            {
                //sigurnosni upit za uredivanje odabranog oglasa
                DialogResult message = MessageBox.Show("Jeste li sigurni da želite urediti oglas?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (message == DialogResult.Yes)
                {
                    //otvaranje forme za uredivanje oglasa i proslijedivanje selektiranog oglasa na novu formu
                    FrmEditAds urediOglas = new FrmEditAds(ogla);
                    urediOglas.ShowDialog();
                    LoadAllKorisnikPostings();
                }
            }
        }

        private void FrmShowProfile_HelpRequested(object sender, HelpEventArgs hlpevent) //F1 pomoć - Andrej Antonić
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowProfile.pdf";
            Process.Start(pdfPath);
        }
    }
}
