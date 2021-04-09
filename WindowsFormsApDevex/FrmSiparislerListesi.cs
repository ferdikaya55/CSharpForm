using DevExpress.XtraReports.Parameters;
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
using WindowsFormsApDevex.DataAccess;

namespace WindowsFormsApDevex
{
    public partial class FrmSiparislerListesi : Form
    {
        public int SiparisID { get; set; }
        SiparisDal siparisCls = new SiparisDal();
        public FrmSiparislerListesi()
        {
            InitializeComponent();
        }

        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            GetSiparisList();
          
        }
        private void GetSiparisList()
        {
            gridControlSiparisler.DataSource = siparisCls.DataTableSiparisListele();
        }
        private void SiparisSil()
        {
            int siparisId;
            DataRow row = gridViewSiparisler.GetDataRow(gridViewSiparisler.FocusedRowHandle);
            if (row!=null)
            {
                int.TryParse(row["SiparisId"].ToString(), out siparisId);
                if (siparisId!=0)
                {
                    DialogResult result = MessageBox.Show("Seçilen Sipariş'e Ait Tüm Bilgiler Silinecek Emin misiniz ?", "Sipariş Silme ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        siparisCls.SiparisDelete(siparisId);
                    }
                }
            
            }
        }

        private void sİPARİŞSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisSil();
            GetSiparisList();
        }

        private void sİPARİŞDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dr = gridViewSiparisler.GetDataRow(gridViewSiparisler.FocusedRowHandle);
            if (dr != null)
            {
                SiparisID = Convert.ToInt32(dr["SiparisId"]);
            }

            FrmSiparisler frmSatinAl = new FrmSiparisler(SiparisID);
            frmSatinAl.ShowDialog();
        }
        private void gridViewSiparisler_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridViewSiparisler.GetDataRow(gridViewSiparisler.FocusedRowHandle);
            if (dr != null)
            {
                SiparisID = Convert.ToInt32(dr["SiparisId"]);
            }

            FrmSiparisler frmSatinAl = new FrmSiparisler(SiparisID);
            frmSatinAl.ShowDialog();
        }
        private void gridViewSiparisler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                GetSiparisList();
                MessageBox.Show("Sipariş Listesi Yenilendi");
            }
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapor frmRapor = new FrmRapor();
            frmRapor.ShowDialog();
           

            //DataRow dr = gridViewSiparisler.GetDataRow(gridViewSiparisler.FocusedRowHandle);
            //if (dr != null)
            //{
            //    SiparisID = Convert.ToInt32(dr["SiparisId"]);
            //}
            //int siparisID = SiparisID;
           

            //XtraReport3 xtraReport3 = new XtraReport3(siparisID);
            //ReportPrintTool print = new ReportPrintTool(xtraReport3);
            //print.AutoShowParametersPanel = true;
            //print.ShowPreviewDialog();

        
        }

      
    }
}
