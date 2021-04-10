using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApDevex.DataAccess
{
    public enum FormAcilisTipiOdeme
    {
        Listele, Secim
    }
    public partial class FrmOdemeSekli : Form
    {
        OdemeSekliMan odemeSekliMan = new OdemeSekliMan();
        public FormAcilisTipiOdeme Acilistipi { get; set; }
        public int SeciliOdemeId { get; set; }
        public FrmOdemeSekli(FormAcilisTipiOdeme acilisTipi)
        {
            this.Acilistipi = acilisTipi;
            InitializeComponent();
        }
        private void FrmOdemeSekli_Load(object sender, EventArgs e)
        {
            OdemeSekliListesi();
        }
        private void OdemeSekliListesi()
        {
            gridControlOdemeSekli.DataSource = odemeSekliMan.DataTableOdemeSekliListele();
          
        }
        private void gridViewOdemeSekli_DoubleClick(object sender, EventArgs e)
        {
            if (Acilistipi == FormAcilisTipiOdeme.Secim)
            {
                int id = 0;
                DataRow row = gridViewOdemeSekli.GetDataRow(gridViewOdemeSekli.FocusedRowHandle);
                if (row != null)
                {

                    int.TryParse(row["OdemeId"].ToString(), out id);
                }
                SeciliOdemeId = id;
                this.Close();
            }
            else if (Acilistipi == FormAcilisTipiOdeme.Listele)
            {
                OdemeSekliGuncelle();
            }

        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdeme frmOdeme = new FrmOdeme(0);
            frmOdeme.ShowDialog();
            OdemeSekliListesi();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeSekliGuncelle(); 
            OdemeSekliListesi();
        }
        private void OdemeSekliGuncelle()
        {
            int odemeId;
            DataRow row = gridViewOdemeSekli.GetDataRow(gridViewOdemeSekli.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["OdemeId"].ToString(), out odemeId);
                if (odemeId != 0)
                {
                    FrmOdeme frmOdeme = new FrmOdeme(odemeId);
                    frmOdeme.ShowDialog();
                }
            }
        }
        private void OdemeSekliSil()
        {
            int odemeId;
            DataRow row = gridViewOdemeSekli.GetDataRow(gridViewOdemeSekli.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["OdemeId"].ToString(), out odemeId);
                if (odemeId != 0)
                {
                    DialogResult result = MessageBox.Show("Ödeme Şekli Silinecek Emin misiniz ?", "Ödeme Şekli Silme ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        odemeSekliMan.OdemeSekliDelete(odemeId);
                    }
                }
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeSekliSil();
            MessageBox.Show("Ödeme Şekli Silindi");
            OdemeSekliListesi();
        }
        private void FrmOdemeSekli_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
