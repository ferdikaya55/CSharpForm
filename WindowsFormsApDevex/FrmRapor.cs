using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApDevex
{
    public partial class FrmRapor : Form
    {
        public int SiparisId { get; set; }
        public FrmRapor()
        {
           
            InitializeComponent();
        }
        private void btnTariheGoreYazdir_Click(object sender, EventArgs e)
        {
            RaporSiparis raporSiparis = new RaporSiparis();
            ReportPrintTool print = new ReportPrintTool(raporSiparis);
            print.AutoShowParametersPanel = true;
            print.ShowPreviewDialog();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {

        }
    }
}
