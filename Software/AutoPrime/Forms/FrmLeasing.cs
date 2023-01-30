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

namespace AutoPrime.Forms
{
    public partial class FrmLeasing : Form
    {

        //Danijel Žebčević
        public FrmLeasing()
        {
            //inicijalizacija forme
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            //zatvaranje forme
            Close();
        }

        private void FrmLeasing_Load(object sender, EventArgs e)
        {
            //učitavanje svih oglasa za iznajmljivanje
            OglasServices servis = new OglasServices();
            //sakrivanje nepotrebnih stupaca
            dgvOglasi.DataSource = servis.GetLeasingOglas();
            dgvOglasi.Columns["slikas"].Visible = false;
            dgvOglasi.Columns["korisniks"].Visible = false;
            dgvOglasi.Columns["Id_oglas"].Visible = false;
            dgvOglasi.Columns["korisnik_id"].Visible = false;
            dgvOglasi.Columns["marka_id"].Visible = false;
            dgvOglasi.Columns["model_id"].Visible = false;
            dgvOglasi.Columns["motor_id"].Visible = false;
            dgvOglasi.Columns["iznajmljeno_id"].Visible = false;
            dgvOglasi.Columns["prodano_korisnik_id"].Visible = false;
            dgvOglasi.Columns["Korisnik1"].Visible = false;
            dgvOglasi.Columns["leasing"].Visible = false;
            dgvOglasi.Columns["ostecenje"].Visible = false;


        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            //otvaranje forme za detaljan prikaz podataka o oglasu
            Ogla odabrani = new Ogla();
            odabrani = dgvOglasi.CurrentRow.DataBoundItem as Ogla;
            FrmDetailAdAndAuctionReview detaljnaForma = new FrmDetailAdAndAuctionReview(odabrani);
            detaljnaForma.Show();

        }

        private void FrmLeasing_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //dodatne upute za pomoć u radu s aplikacijom
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmLeasing.pdf";
            Process.Start(pdfPath);
        }
    }
}
