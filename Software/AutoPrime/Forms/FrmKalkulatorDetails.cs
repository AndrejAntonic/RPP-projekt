using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrime.Forms
{
    public partial class FrmKalkulatorDetails : Form
    {
        int page = 1;
        int year;
        double price;
        double mileage;
        public FrmKalkulatorDetails(int year, double price, double mileage)
        {
            InitializeComponent();
            this.year = year;
            this.price = price;
            this.mileage = mileage;
        }

        private void FrmKalkulatorDetails_Load(object sender, EventArgs e)
        {
            LoadLabels();
        }

        private void LoadLabels()
        {
            if(page == 1)
            {
                LoadFirstPage();
            }
            else if(page == 2)
            {
                LoadSecondPage();
            }
        }

        private void LoadSecondPage()
        {
            btnBack.Enabled = true;
            btnAhead.Enabled = false;
            lblMethod.Text = "Metoda 2: bazirano na cijeni po kilometru";
            
        }

        private void LoadFirstPage()
        {
            btnBack.Enabled = false;
            btnAhead.Enabled = true;
            lblMethod.Text = "Metoda 1: bazirano na starosti automobila";
            lblDescription.Text = "Ova se metoda temelji na nabavnoj cijeni vozila, njegovoj trenutnoj starosti i procijenjenim godišnjim stopama" +
                " \r\namortizacije.\r\n\r\nCijena i starost vozila su poznate vrijednosti, no njegove godišnje stope amortizacije su spekulativne i jako" +
                " \r\nvariraju od marke do modela. Stope amortizacije su procijenjene na temelju prosjeka svih izvještajnih agencija." +
                "\r\n\r\nKonsenzus je da se novi automobili amortiziraju u prosjeku 24% u prvoj godini i 15% u preostalim godinama.";
        }

        private void btnAhead_Click(object sender, EventArgs e)
        {
            page++;
            LoadLabels();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            page--;
            LoadLabels();
        }
    }
}
