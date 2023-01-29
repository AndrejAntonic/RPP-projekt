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
    public partial class FrmCreateAuction : Form
    {
        public FrmCreateAuction()
        {
            InitializeComponent();
        }

        private void btnDodajOglas_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCreateAuction_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowProfile.pdf";
            Process.Start(pdfPath);
        }

        private void FrmCreateAuction_Load(object sender, EventArgs e)
        {

        }
    }
}
