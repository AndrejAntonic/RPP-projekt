using AutoPrime.Forms;
using BusinessLogicModel.Services;
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

namespace AutoPrime
{
    public partial class FrmShowAllComments : Form
    {
        //Andrej Antonić
        //Inicijalizacija svih potrebnih klasa
        Korisnik korisnik = new Korisnik();
        RecenzijaServices recenzijaService = new RecenzijaServices();
        public FrmShowAllComments(Korisnik korisnik) //Spremanje korisnika kojemu gledamo sve recenzije
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void btnClose_Click(object sender, EventArgs e) //Zatvaranje forme
        {
            Close();
        }

        private void FrmShowAllComments_Load(object sender, EventArgs e) //Učitavanje forme
        {
            LoadAllComments();
        }

        private void LoadAllComments() //Učitavanje svih recenziju u datagridview
        {
            dgvAllComments.DataSource = recenzijaService.GetRecenzijasForUser(korisnik);
            dgvAllComments.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false); //Sakrivanje svih stupaca
            dgvAllComments.Columns["Id_recenzije"].Visible = true;
            dgvAllComments.Columns["Komentar"].Visible = true;
            dgvAllComments.Columns["Datum"].Visible = true;
        }

        private void btnShowComment_Click(object sender, EventArgs e) //Otvaranje forme za detaljni pregled recenzije
        {
            Recenzija recenzija = GetSelectedRecenzija();
            FrmShowDetailReview form = new FrmShowDetailReview(recenzija);
            form.ShowDialog();
        }

        private Recenzija GetSelectedRecenzija() //Dohvaćanje odabrane recenzije
        {
            return dgvAllComments.CurrentRow.DataBoundItem as Recenzija;
        }

        private void FrmShowAllComments_HelpRequested(object sender, HelpEventArgs hlpevent) //F1 pomoć
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowAllComments.pdf";
            Process.Start(pdfPath);
        }
    }
}
