using DevExpress.XtraGrid;
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
    public enum FormAcilisTipi
    {
        Listele, Secim
    }
    public partial class Müşteriler : Form
    {
        MusteriDal musteriCls = new MusteriDal();
        public FormAcilisTipi Acilistipi { get; set; }
        public int SeciliMusteriId { get; set; }
        public Müşteriler(FormAcilisTipi acilisTipi)
        { 
            this.Acilistipi = acilisTipi;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetMusteriList();
        }
        private void GetMusteriList()
        {
            gridControlMusteriler.DataSource = musteriCls.DataTableMusteriListele();
        }
        public void MusteriEkle()
        {
            FrmMusteri frmMusteriler = new FrmMusteri(0);
            frmMusteriler.ShowDialog();
        }
        public void MusteriGuncelle()
        {
            int musteriId;
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["MusteriId"].ToString(), out musteriId);
                if (musteriId != 0)
                {
                    FrmMusteri frmMusteriler = new FrmMusteri(musteriId);
                    frmMusteriler.ShowDialog();
                }
            }
        }
        public void MusteriSil()
        {
            int musteriId;
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row!=null)
            {
                int.TryParse(row["MusteriId"].ToString(),out musteriId);
                if (musteriId!=0)
                {
                    DialogResult result = MessageBox.Show("Müşteri Silinecek Emin misiniz ?", "Müşteri Silme ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {

                        bool sonuc = musteriCls.MusteriKontrol(musteriId);
                        if (sonuc == true)
                        {
                            musteriCls.MusteriDelete(musteriId);
                        }
                        else
                        {
                            DialogResult dgResult = MessageBox.Show("Müşteriye Ait Sipariş Var Tüm Bilgiler Silinecek Emin misiniz ?", "Müşteri Silme ", MessageBoxButtons.OKCancel);
                            if (dgResult == DialogResult.OK)
                            {

                                musteriCls.MusteriDelete(musteriId);


                            }
                        }
                    }                 
                }
            }        
        }
        private void gridControlMusteriler_DoubleClick(object sender, EventArgs e)
        {
            if (Acilistipi==FormAcilisTipi.Secim)
            {
                int id=0;
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (row!=null)
                {
                    
                    int.TryParse(row["MusteriId"].ToString(), out id);
                }
                SeciliMusteriId = id;
                this.Close();
            }else if(Acilistipi==FormAcilisTipi.Listele)
            {
                MusteriGuncelle();
            }

           
        }
        private void gridControlMusteriler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==System.Windows.Forms.Keys.F5)
            {
                GetMusteriList();
                MessageBox.Show("Müşteriler Listesi Yenilendi");
            }
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle();
            GetMusteriList();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
            GetMusteriList();

        }
        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriSil();
            GetMusteriList();
        }

        private void barBtnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriEkle();
            GetMusteriList();
        }

        private void barBtnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriGuncelle();
            GetMusteriList();
        }

        private void barBtnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriSil();
            GetMusteriList();
        }

        private void barBtnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
