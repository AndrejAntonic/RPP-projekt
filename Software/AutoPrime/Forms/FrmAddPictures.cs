using BusinessLogicModel.Services;
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
    public partial class FrmAddPictures : Form
    {
        private SlikaServices SlikaServis = new SlikaServices();
        int trenutni;
        public FrmAddPictures(int trenutniSad)
        {
            InitializeComponent();
            trenutni = trenutniSad;
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
                    Slika slika = new Slika
                    {
                        oglas_id = trenutni,
                        slika1 = imageBytes
                    };

                    SlikaServis.AddSlika(slika);
                    MessageBox.Show("Slika je dodana!");
                }
                else
                {
                    MessageBox.Show("Slika nije dodana.");
                }               
            }
        }

        private void FrmAddPictures_Load(object sender, EventArgs e)
        {

        }
    }
}
