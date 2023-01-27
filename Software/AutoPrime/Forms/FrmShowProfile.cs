using BusinessLogicModel.Services;
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

namespace AutoPrime
{
    public partial class FrmShowProfile : Form
    {
        Korisnik korisnik = new Korisnik();
        RecenzijaServices recenzijaService = new RecenzijaServices();
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
            FrmShowAllComments sviKomentari = new FrmShowAllComments();
            sviKomentari.Show();
        }

        private void FrmShowProfile_Load(object sender, EventArgs e)
        {
            LoadKorisnikData();
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
            string comment;
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijas();
            for(int i = 0; i < recenzijas.Count; i++)
            {

            }
            return "temp";
        }

        private string GetAverageRating()
        {
            double averageRating = 0, numberOfRatings = 0;
            List<Recenzija> recenzijas = recenzijaService.GetRecenzijas();
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
