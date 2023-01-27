using BusinessLogicModel.Services;
using EntitiesLayer.Entities;
using System;
using System.CodeDom.Compiler;
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
    public partial class FrmShowProfile : Form
    {
        Korisnik korisnik = new Korisnik();
        RecenzijaServices recenzijaService = new RecenzijaServices();
        OglasServices oglasService = new OglasServices();
        public FrmShowProfile(Korisnik korisnik = null)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowAllComments_Click(object sender, EventArgs e)
        {
            FrmShowAllComments sviKomentari = new FrmShowAllComments(korisnik);
            sviKomentari.ShowDialog();
        }

        private void FrmShowProfile_Load(object sender, EventArgs e)
        {
            LoadKorisnikData();
            LoadAllKorisnikPostings();
        }

        private void LoadAllKorisnikPostings()
        {
            dgvUserAdvertisement.DataSource = oglasService.GetOglasByKorisnikId(korisnik.Id_korisnika);
            dgvUserAdvertisement.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            dgvUserAdvertisement.Columns["Id_oglas"].Visible = true;
            dgvUserAdvertisement.Columns["naziv"].Visible = true;
            dgvUserAdvertisement.Columns["datum"].Visible = true;
        }

        private void LoadKorisnikData()
        {
            
            txtUsername.Text = korisnik.Korimme;
            txtPhoneNumber.Text = korisnik.Broj_telefona;
            txtAverageRating.Text = GetAverageRating();
            txtLastComment.Text = GetLastComment();
            
        }

        private string GetLastComment()
        {
            string comment = "Ne postoje recenzije";
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijasForUser(korisnik);
            DateTime datum = recenzijas.Max(r => r.Datum);
            foreach (var item in recenzijas)
            {
                if (item.Datum == datum) {
                    comment = item.Komentar;
                    break;
                }
            }
            return comment;
        }

        private string GetAverageRating()
        {
            double averageRating = 0, numberOfRatings = 0;
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijasForUser(korisnik);
            for(int i = 0; i < recenzijas.Count; i++)
            {
                if (recenzijas[i].Za_korisnik_id == korisnik.Id_korisnika)
                {
                    averageRating += recenzijas[i].Ocjena;
                    numberOfRatings++;
                }
            }
            averageRating /= numberOfRatings;
            return averageRating.ToString();
        }
    }
}
