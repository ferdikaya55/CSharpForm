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
    public enum UrunFormAcilisTipi
    {
        Listele, Secim
    }
    public partial class FrmUrunlerList : Form
    {
        UrunDal urunCls = new UrunDal();

        public UrunFormAcilisTipi AcilisTipi { get; set; }
        public int SecilenUrunId { get; set; }
       
        public FrmUrunlerList(UrunFormAcilisTipi urunFormAcilisTipi)
        {
            this.AcilisTipi = urunFormAcilisTipi;
            InitializeComponent();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            GetUrunList();
            
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            GetUrunList();
        }
        public void UrunEkle()
        {
            FrmUrun frmUrun = new FrmUrun(0);
            frmUrun.ShowDialog();
        }
        public void UrunGuncelle()
        {
            int urunId;
            DataRow row = gridViewUrunler.GetDataRow(gridViewUrunler.FocusedRowHandle);
            if (row!=null)
            {
                int.TryParse(row["UrunMalzemeId"].ToString(), out urunId);
                if (urunId != 0)
                {
                    FrmUrun frmUrun = new FrmUrun(urunId);
                    frmUrun.ShowDialog();
                }
            }
        }
        public void UrunSil()
        {
            int urunId;
            DataRow row = gridViewUrunler.GetDataRow(gridViewUrunler.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["UrunMalzemeId"].ToString(), out urunId);
                if (urunId != 0)
                {
                    urunCls.UrunDelete(urunId);
                }
            }
        }
    
        private void GetUrunList()
        {
            gridControlUrunler.DataSource = urunCls.DataTableUrunler();
        }
        private void gridViewUrunler_DoubleClick(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Seçilen Ürün Sipariş Detaya Eklenecek Emin Misiniz ?", "Sipariş Ekleme ", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            //{

            //    if (AcilisTipi == UrunFormAcilisTipi.Secim)
            //    {
            //        int urunId = 0;
            //        DataRow row = gridViewUrunler.GetDataRow(gridViewUrunler.FocusedRowHandle);
            //        if (row != null)
            //        {
            //            int.TryParse(row["UrunMalzemeId"].ToString(), out urunId);
            //        }
            //        SecilenUrunId = urunId;
            //        this.Close();
            //    }

            //}
        }

        private void gridControlUrunler_DoubleClick(object sender, EventArgs e)
        {
          
            if (AcilisTipi == UrunFormAcilisTipi.Secim)
            {
                int id = 0;
                DataRow row = gridViewUrunler.GetDataRow(gridViewUrunler.FocusedRowHandle);
                if (row != null)
                {

                    int.TryParse(row["UrunMalzemeId"].ToString(), out id);
                }
                SecilenUrunId = id;
                this.Close();
            }
            else if (AcilisTipi == UrunFormAcilisTipi.Listele)
            {
                UrunGuncelle();
            }

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle();
            GetUrunList();
        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelle();
            GetUrunList();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSil();
            GetUrunList();
        }
    }
}
