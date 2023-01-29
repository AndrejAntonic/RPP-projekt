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
    public partial class FrmShowDamage : Form
    {
        public FrmShowDamage()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShowDamage_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string presentationLayerRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName;
            string pdfPath = presentationLayerRoot + "\\HelpDocumentation\\HelpDocumentationFrmShowDamage.pdf";
            Process.Start(pdfPath);
        }

        private void FrmShowDamage_Load(object sender, EventArgs e)
        {

        }
    }
}
