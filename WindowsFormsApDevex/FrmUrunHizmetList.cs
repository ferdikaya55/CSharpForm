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
    public enum UrunHizmetFormAcilisTipi
    {
        Listele, Secim
    }
    public partial class FrmUrunHizmetList : Form
    {
        public UrunHizmetFormAcilisTipi AcilisTipi { get; set; }
        UrunHizmetMan urunhizmetMan = new UrunHizmetMan();
        public int SecilenUrunHizmetId { get; set; }
        public FrmUrunHizmetList(UrunHizmetFormAcilisTipi urunHizmetFormAcilisTipi)
        {
            this.AcilisTipi = urunHizmetFormAcilisTipi;
            InitializeComponent();
        }

        private void FrmUrunHizmetList_Load(object sender, EventArgs e)
        {
            GetUrunHizmetList();
        }
        private void GetUrunHizmetList()
        {
            gridControlUrunHizmetList.DataSource = urunhizmetMan.DataTableUrunHizmet();
        }
        private void gridControlUrunHizmetList_DoubleClick(object sender, EventArgs e)
        {
            if (AcilisTipi==UrunHizmetFormAcilisTipi.Secim)
            {
                int id = 0;
                DataRow row = gridViewUrunHizmetList.GetDataRow(gridViewUrunHizmetList.FocusedRowHandle);
                if (row != null)
                {
                    int.TryParse(row["UrunHizmetId"].ToString(), out id);
                }
                SecilenUrunHizmetId = id;
                this.Close();
            }else if (AcilisTipi == UrunHizmetFormAcilisTipi.Listele)
            {
                UrunHizmetGuncelle();
            }
           
        }
        private void UrunHizmetEkle()
        {
            FrmUrunHizmet frmUrunHizmet = new FrmUrunHizmet(0);
            frmUrunHizmet.ShowDialog();
        }
        private void barButtonItemHizmetEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunHizmetEkle();
            GetUrunHizmetList();
        }
        private void UrunHizmetGuncelle()
        {
            int urunId;
            DataRow row = gridViewUrunHizmetList.GetDataRow(gridViewUrunHizmetList.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["UrunHizmetId"].ToString(), out urunId);
                if (urunId != 0)
                {
                    FrmUrunHizmet frmUrunHizmet = new FrmUrunHizmet(urunId);
                    frmUrunHizmet.ShowDialog();
                }
            }
        }
        private void barButtonItemhizmetGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunHizmetGuncelle();
            GetUrunHizmetList();
        }
        public void UrunHizmetSil()
        {
            int urunId;
            DataRow row = gridViewUrunHizmetList.GetDataRow(gridViewUrunHizmetList.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["UrunHizmetId"].ToString(), out urunId);
                if (urunId != 0)
                {
                    urunhizmetMan.UrunhizmetDelete(urunId);
                }
            }
        }
        private void barButtonItemHizmetSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunHizmetSil();
            GetUrunHizmetList();
        }

        private void barButtonItemCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
