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

        private void btnYazdir_Click(object sender, EventArgs e)
        {
           
            //OycRapor oycRapor = new OycRapor(SiparisId);
            //ReportPrintTool print = new ReportPrintTool(oycRapor);
            //print.AutoShowParametersPanel = true;
            //print.ShowPreviewDialog();
        }

        private void btnTariheGoreYazdir_Click(object sender, EventArgs e)
        {

        }
    }
}
