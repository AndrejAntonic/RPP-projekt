using BusinessLogicModel.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrime.Forms
{
    public partial class FrmaOstecenjaPictures : Form
    {

        //Juraj Gaši
        private OglasServices oglasServis = new OglasServices();
        private ModelServices modelServis = new ModelServices();
        private MotorServices motorServis = new MotorServices();
        private MarkaServices markaServices = new MarkaServices();
        private SlikaServices SlikaServis = new SlikaServices();
        private OstecenjaServices ostecenjaServis = new OstecenjaServices();
        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();

        int trenutni;

        public FrmaOstecenjaPictures(int trenutniSad)
        {
            InitializeComponent();
            this.trenutni = trenutniSad;
        }

        private void btnDodajSlike_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);

                // Convert the Image object to a byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pbSlika.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }

                DialogResult result = MessageBox.Show("Jeste li sigurni?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Oštećenja ostecenja = new Oštećenja
                    {
                        opis_ostecenja = txtOpisOstecenja.Text
                    };

                    ostecenjaServis.AddOstecenja(ostecenja);

                    int privremeniIdOstecenja = VratiOglasId();
                    MessageBox.Show("Id ostecenja: " + privremeniIdOstecenja);

                    Slika slikaOstecenja = new Slika
                    {
                        oglas_id = trenutni,
                        slika1 = imageBytes,
                        ostecenje_id = privremeniIdOstecenja
                    };

                    SlikaServis.AddSlika(slikaOstecenja);
                    MessageBox.Show("Slika oštećenja je dodana!");
                }
                else
                {
                    MessageBox.Show("Slika oštećenja nije dodana.");
                }
            }
        }

        private int VratiOglasId()
        {
            var prijavljeniKorisnik = prijavljeni.VratiPrijavljeniId();
            int zadnjiId = ostecenjaServis.GetLastOstecenje();
            return zadnjiId;
        }
    }
}
