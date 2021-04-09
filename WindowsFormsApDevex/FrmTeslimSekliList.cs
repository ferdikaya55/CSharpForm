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
    public enum FormAcilisTipiTeslim
    {
        Listele,
        Secim
    }
    public partial class FrmTeslimSekliList : Form
    {
        TeslimSekliDal teslimSekliDal =new  TeslimSekliDal();
        public FormAcilisTipiTeslim FormAcilisTipiTeslim { get; set; }
        public int SeciliTeslimId { get; set; }
        public FrmTeslimSekliList(FormAcilisTipiTeslim formAcilisTipiTeslim)
        {
            this.FormAcilisTipiTeslim = formAcilisTipiTeslim;
            InitializeComponent();
        }
        private void FrmTeslimSekliList_Load(object sender, EventArgs e)
        {
            TeslimSekliListele();
        }

        private void TeslimSekliListele()
        {
            gridControlTeslimSekli.DataSource = teslimSekliDal.DataTableTeslimSekliListele();
        }
        private void gridViewTeslimSekli_DoubleClick(object sender, EventArgs e)
        {
            if (FormAcilisTipiTeslim == FormAcilisTipiTeslim.Secim)
            {
                int id = 0;
                DataRow row = gridViewTeslimSekli.GetDataRow(gridViewTeslimSekli.FocusedRowHandle);
                if (row != null)
                {

                    int.TryParse(row["TeslimId"].ToString(), out id);
                }
                SeciliTeslimId = id;
                this.Close();
            }
            else if (FormAcilisTipiTeslim == FormAcilisTipiTeslim.Listele)
            {
                TeslimSekliGuncelle();
            }
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslim frmTeslim = new FrmTeslim(0);
            frmTeslim.ShowDialog();
            TeslimSekliListele();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeslimSekliGuncelle();
            TeslimSekliListele();
        }
        private void TeslimSekliGuncelle()
        {
            int teslimId;
            DataRow row = gridViewTeslimSekli.GetDataRow(gridViewTeslimSekli.FocusedRowHandle);
            if (row!=null)
            {
                int.TryParse(row["TeslimId"].ToString(), out teslimId);
                if (teslimId!=0)
                {
                    FrmTeslim frmTeslim = new FrmTeslim(teslimId);
                    frmTeslim.ShowDialog();
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeslimSekliSil();
            TeslimSekliListele();
        }
        private void TeslimSekliSil()
        {
            int teslimId;
            DataRow row = gridViewTeslimSekli.GetDataRow(gridViewTeslimSekli.FocusedRowHandle);
            if (row!=null)
            {
                int.TryParse(row["TeslimId"].ToString(),out teslimId);
                if (teslimId!=0)
                {
                    DialogResult result = MessageBox.Show("Teslim Şekli Silinecek Emin misiniz?", "Teslim Şekli Silme", MessageBoxButtons.OKCancel);
                    teslimSekliDal.TeslimSekliDelete(teslimId);
                }
            }
        }
    }
}
