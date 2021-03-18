using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    
    public partial class FrmSiparisler : Form
    {
        public bool CellValueChangedCalisiyor = false;
        public bool NewItemRowCalisiyor = false;
        public int SeciliMusteriId { get; set; }
        public int SeciliUrunId { get; set; }

        public int GelenSiparisId { get; set; }
        public int Adet { get; set; }
        public decimal Bfiyati { get; set; }
        public decimal ToplamTutar { get; set; }
      

        MusteriDal musteri = new MusteriDal();
        UrunDal urunlerDbManager = new UrunDal();
        SiparisDal siparisDbManager = new SiparisDal();
        
        
        public FrmSiparisler()
        {
     

            InitializeComponent();
        }

        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            EmptySiparisDetayList();
            gridViewSiparislerDetay.OptionsNavigation.AutoFocusNewRow = true;

        }

        private void EmptySiparisDetayList()
        {
            gridControlSiparisDetay.DataSource = siparisDbManager.DataTableSiparisDetayEmpty();
           
        }
        private void btnEditMusteriler_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Müşteriler form1 = new Müşteriler(FormAcilisTipi.Secim);
            form1.ShowDialog();

            int musteriId = form1.SeciliMusteriId;
            SeciliMusteriId = musteriId;

            if (musteriId > 0)
            {
                DataRow row = musteri.DataRowGetMusteri(musteriId);
                if (row != null)
                {
                    btnEditMusteriler.Text = row["MusteriAd"].ToString();
                }
            }
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmUrunlerList frmUrunler = new FrmUrunlerList(UrunFormAcilisTipi.Secim);
            frmUrunler.ShowDialog();
            int urunId = frmUrunler.SecilenUrunId;
           
            if (urunId > 0)
            {
                DataRow Urunrow = urunlerDbManager.DataRowGetUrun(urunId);
                if (Urunrow!=null)
                {
                    DataRow dr = gridViewSiparislerDetay.GetFocusedDataRow();
                    if (dr!=null)
                    {
                        dr["UrunMalzemeId"] = Urunrow["UrunMalzemeId"].ToString();
                        dr["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        dr["BirimFiyati"] = Urunrow["BirimFiyati"].ToString();
                        dr["Birim"] = "adet";
                    
                        //gridViewSiparislerDetay.SetRowCellValue(gridViewSiparislerDetay.FocusedRowHandle, gridViewSiparislerDetay.Columns["UrunMalzemeId"], Urunrow["UrunMalzemeId"].ToString());
                       

                    }
                    else
                    {
                        DataTable dt= (DataTable)gridControlSiparisDetay.DataSource;
                        DataRow drNew = dt.NewRow();
                        drNew["UrunMalzemeId"] = Urunrow["UrunMalzemeId"].ToString();
                        drNew["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        drNew["BirimFiyati"]= Urunrow["BirimFiyati"].ToString();
                        drNew["Birim"] = "adet";
                        dt.Rows.Add(drNew);
                        
                        //gridViewSiparislerDetay.FocusedRowHandle= GetLastVisibleRowHandle(gridViewSiparislerDetay);
                        //gridViewSiparislerDetay.SetRowCellValue(gridViewSiparislerDetay.FocusedRowHandle, gridViewSiparislerDetay.Columns["UrunAdi"], row["UrunAdi"].ToString());
                    }

                }
            }
        }
        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NewItemRowCalisiyor = true;
            this.gridViewSiparislerDetay.SetRowCellValue(e.RowHandle, "BirimFiyati", 0);
            this.gridViewSiparislerDetay.SetRowCellValue(e.RowHandle, "Miktar", 1);
            NewItemRowCalisiyor = false;
        }
        private void Clear()
        {
            btnEditMusteriler.Text = "";
            txtSiparisNo.Text = "";
            dateEditSiparisTarihi.Text = "";
        }
        private void btnSiparisDetayKaydet_Click(object sender, EventArgs e)
        {
            int gelenSiparisId = siparisDbManager.SiparisInsert(SeciliMusteriId, txtSiparisNo.Text, Convert.ToDateTime(dateEditSiparisTarihi.EditValue.ToString()));
            this.GelenSiparisId = gelenSiparisId;
            Clear();

            foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
            {
                //int siparisDetayId =Convert.ToInt32((row["SiparisDetayId"]));
                // GelenSiparisId = Convert.ToInt32((row["SiparisId"]));
                int urunId = Convert.ToInt32((row["UrunMalzemeId"]));
                string birimi = (row["Birim"].ToString());
                double miktari = Convert.ToDouble((row["Miktar"]));
                double birimFiyati = Convert.ToDouble((row["BirimFiyati"]));
                string paraBirimi = (row["ParaBirimi"].ToString());
                double tutar = Convert.ToDouble((row["Tutar"]));

                siparisDbManager.SiparisDetayInsert(GelenSiparisId,urunId,birimi,miktari,birimFiyati,paraBirimi,tutar);
            }
            MessageBox.Show("Sipariş Eklendi");
        }

        private void gridControlSiparisDetay_Click(object sender, EventArgs e)
        {

        }

        private void gridViewSiparislerDetay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (CellValueChangedCalisiyor==false && NewItemRowCalisiyor ==false)
            {
                CellValueChangedCalisiyor = true;

                double birimFiyatValue = 0, miktarValue = 0, birimFiyati = 0, miktari = 0, tBirimFiyati = 0, tTutar = 0;

                GridView view = sender as GridView;
                if (view == null) return;

                if (e.Column.FieldName == "BirimFiyati")
                {
                    if (e.Value != null)
                    {
                        birimFiyatValue = Convert.ToDouble(e.Value);
                    }
                    DataRow dr = view.GetDataRow(e.RowHandle);
                    if (dr != null)
                    {
                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            miktarValue = Convert.ToDouble(dr["Miktar"]);
                        }
                    }
                    double tutar = birimFiyatValue * miktarValue;
                    tutar = Math.Round(tutar, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], tutar);
                }
                if (e.Column.FieldName == "Miktar")
                {
                    if (e.Value != null)
                    {
                        miktari = Convert.ToDouble(e.Value);
                    }
                    DataRow dataRow = view.GetDataRow(e.RowHandle);
                    if (dataRow != null)
                    {
                        if (dataRow["BirimFiyati"] != null && dataRow["BirimFiyati"] != DBNull.Value)
                        {
                            birimFiyati = Convert.ToDouble(dataRow["BirimFiyati"]);
                        }

                    }
                    double toplamTutar = miktari * birimFiyati;
                    toplamTutar = Math.Round(toplamTutar, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], toplamTutar);
                }
                if (e.Column.FieldName == "Tutar")
                {
                    if (e.Value != null)
                    {
                        tTutar = Convert.ToDouble(e.Value);
                    }
                    DataRow dr = view.GetDataRow(e.RowHandle);
                    if (dr != null)
                    {
                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            tBirimFiyati = Convert.ToDouble(dr["Miktar"]);

                        }
                    }
                    double sonuc = tTutar / tBirimFiyati;
                    sonuc = Math.Round(sonuc, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["BirimFiyati"], sonuc);
                }
                CellValueChangedCalisiyor = false;
            }

        }
    }
}
