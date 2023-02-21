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
    public partial class SlikaTester : Form
    {
        private SlikaServices slikaServis = new SlikaServices();
        public SlikaTester()
        {
            InitializeComponent();
        }

        private void SlikaTester_Load(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            int idOglasa = 2;

            // Retrieve the list of Slika objects for the specified oglas ID
            List<Slika> slike = slikaServis.GetCertainSlikas(idOglasa);

            // Check if the list contains any images
            if (slike.Count > 0)
            {
                // Get the first Slika object in the list and retrieve the image data as a byte array
                Slika slika = slike[0];
                byte[] imageBytes = slika.slika1;

                // Create an Image object from the byte array
                Image image;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    image = Image.FromStream(ms);
                }

                // Display the image in your PictureBox
                pbSlikaTester.Image = image;
            }
        }
    }
}
