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
    public partial class FrmEditAds : Form
    {
        public FrmEditAds()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditAds_Load(object sender, EventArgs e)
        {

        }

        private void FrmEditAds_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowProfile.pdf";
            Process.Start(pdfPath);
        }
    }
}
