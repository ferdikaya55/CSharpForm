using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
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
using WindowsFormsApDevex.DataAccess;
using WindowsFormsApDevex.Helper;

namespace WindowsFormsApDevex
{
    
    public partial class FrmSatinAl : Form
    {
        public bool CellValueChangedCalisiyor = false;

        public bool NewItemRowCalisiyor = false;
        public int SeciliMusteriId { get; set; }
        public int SeciliUrunId { get; set; }
        public int SiparisNo { get; set; }
        public int GelenSiparisId { get; set; }
        public int SiparisID { get; set; }

        MusteriDal musteri = new MusteriDal();
        UrunDal urunlerDbManager = new UrunDal();
        SatinAlDal satinAlDbManager = new SatinAlDal();
        UrunHizmetDal urunHizmetDal = new UrunHizmetDal();
        FrmUrunlerList frmUrunler;

        public FrmSatinAl(int siparisId)
        {
            InitializeComponent();     
            this.SiparisID = siparisId;
            if (SiparisID != 0) // update formu olarak açılmış, gerekli bilgileri yükle
            {
                DataRow row = satinAlDbManager.GetDataRowSiparis(SiparisID);
                if (row != null)
                {
                    if (row["MusteriId"] != DBNull.Value)
                    {
                        SeciliMusteriId = Convert.ToInt32(row["MusteriId"]);
                        btnEditMusteriler.Text = row["MusteriAd"].ToString();
                    }
                    txtSiparisNo.Text = row["SiparisNo"].ToString();
                    dateEditSiparisTarihi.Text = row["SiparisTarihi"].ToString();
                }
            }
            else
            {
                int siparisNo = satinAlDbManager.GetSiparisNo() + 1;
                txtSiparisNo.Text = siparisNo.ToString();
                SiparisNo = siparisNo;
                dateEditSiparisTarihi.Text = DateTime.Now.ToString();
            }
            LoadDetayTable();
        }
       
        private void LoadDetayTable()
        {
            gridControlSiparisDetay.DataSource = satinAlDbManager.GetDataTableDetay(SiparisID);
           
        }

        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            gridViewSiparislerDetay.OptionsNavigation.AutoFocusNewRow = true;
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
        private void urunSecimi_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataRow satir = gridViewSiparislerDetay.GetFocusedDataRow();
            if (satir != null)
            {
                if (satir["SatirTipi"] == null && satir["SatirTipi"] == DBNull.Value)
                {
                    satir["SatirTipi"] = "Malzeme";
                }
                string tip = satir["SatirTipi"].ToString();
                if (tip != null)
                {
                    if (tip == "Malzeme")
                    {
                        SelectUrunMalzeme();
                    }
                    else
                    {
                        SelectUrunHizmet();
                    }
                }
            }
        }
     
        private void SelectUrunMalzeme()
        {
            frmUrunler = new FrmUrunlerList(UrunFormAcilisTipi.Secim);
            frmUrunler.ShowDialog();
            int urunId = frmUrunler.SecilenUrunId;
            SeciliUrunId = frmUrunler.SecilenUrunId;
            if (urunId > 0)
            {

                DataRow Urunrow = urunlerDbManager.DataRowGetUrun(urunId);
                if (Urunrow != null)
                {

                    DataRow dr = gridViewSiparislerDetay.GetFocusedDataRow();
                    if (dr != null)
                    {

                        dr["UrunMalzemeId"] = Urunrow["UrunMalzemeId"];
                        dr["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        dr["BirimFiyati"] = Urunrow["BirimFiyati"];
                        dr["Birim"] = "Adet";
                        dr["ParaBirimi"] = "TL";
                        dr["Miktar"] = 0;
                        dr["Tutar"] = 0;

                        gridViewSiparislerDetay.UpdateCurrentRow();
                    }
                    else
                    {
                        DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                        DataRow drNew = dt.NewRow();

                        drNew["UrunMalzemeId"] = Urunrow["UrunMalzemeId"].ToString();
                        drNew["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        drNew["BirimFiyati"] = Urunrow["BirimFiyati"].ToString();
                        drNew["Birim"] = "Adet";
                        drNew["ParaBirimi"] = "TL";
                        dt.Rows.Add(drNew);
                    }
                }
            }
      
        }
        private void SelectUrunHizmet()
        {
            FrmUrunHizmetList frmurunHizmet = new FrmUrunHizmetList();
            frmurunHizmet.ShowDialog();
            int urunHizmetId = frmurunHizmet.SecilenUrunHizmetId;
            if (urunHizmetId > 0)
            {

                DataRow Urunrow = urunHizmetDal.DataRowGetUrunHizmet(urunHizmetId);
                if (Urunrow != null)
                {

                    DataRow dr = gridViewSiparislerDetay.GetFocusedDataRow();
                    if (dr != null)
                    {

                        dr["UrunHizmetId"] = Urunrow["UrunHizmetId"];
                        dr["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        dr["BirimFiyati"] = Urunrow["BirimFiyati"];
                        dr["Birim"] = "Adet";
                        dr["ParaBirimi"] = "TL";
                        dr["Miktar"] = 0;
                        dr["Tutar"] = 0;

                        gridViewSiparislerDetay.UpdateCurrentRow();
                    }
                    else
                    {
                        DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                        DataRow drNew = dt.NewRow();

                        drNew["UrunHizmetId"] = Urunrow["UrunHizmetId"].ToString();
                        drNew["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        drNew["BirimFiyati"] = Urunrow["BirimFiyati"].ToString();
                        drNew["Birim"] = "Adet";
                        drNew["ParaBirimi"] = "TL";
                        dt.Rows.Add(drNew);
                    }
                }
            }
        }
        private void gridViewSiparislerDetay_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            int urunMalzemeid = 0,urunHizmetId=0;

            if (e.Row is DataRowView)
            {
                DataRowView row = (DataRowView)e.Row;
                if (row["UrunMalzemeId"]!= DBNull.Value)
                {
                    urunMalzemeid = Convert.ToInt32(row["UrunMalzemeId"]);
                   
                }
                else if(row["UrunHizmetId"] != DBNull.Value)
                {
                    urunHizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                }
            }

            if (urunMalzemeid == 0 && urunHizmetId==0)
            {
                e.Valid = false;
                e.ErrorText = "Ürün Seçiniz. " + urunMalzemeid.ToString() + urunHizmetId.ToString();
            }
        }
        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            NewItemRowCalisiyor = true;
            this.gridViewSiparislerDetay.SetRowCellValue(e.RowHandle, "BirimFiyati", 0);
            this.gridViewSiparislerDetay.SetRowCellValue(e.RowHandle, "Miktar", 1);
            NewItemRowCalisiyor = false;
        }
        private void YeniSiparisEkle()
        {
            int musteriId, siparisNo, siparisId;
            int? urunId, urunhizmetId;
            double miktar, tutar, birimFiyati;
            string birim, paraBirimi,satirTipi;
            DateTime siparisTarihi;
            musteriId = SeciliMusteriId;
            siparisNo = Convert.ToInt32(txtSiparisNo.Text);
            siparisTarihi = Convert.ToDateTime(dateEditSiparisTarihi.Text);
            siparisId = satinAlDbManager.SiparisInsert(musteriId, siparisNo, siparisTarihi);

            foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
            {
                urunId = null;
                urunhizmetId = null;
                if (row["UrunMalzemeId"]!=null && row["UrunMalzemeId"]!=DBNull.Value)
                {
                    urunId = Convert.ToInt32(row["UrunMalzemeId"]);
                }

                if (row["UrunHizmetId"] != null && row["UrunHizmetId"] != DBNull.Value)
                {
                    urunhizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                }
              
                miktar = Convert.ToDouble(row["Miktar"]);
                birimFiyati = Convert.ToDouble(row["BirimFiyati"]);
                tutar = Convert.ToDouble(row["Tutar"]);
                birim = row["Birim"].ToString();
                paraBirimi = row["ParaBirimi"].ToString();
                satirTipi = row["SatirTipi"].ToString();
                satinAlDbManager.SiparisDetayInsert(siparisId, urunId, urunhizmetId, miktar, birimFiyati, tutar, birim, paraBirimi,satirTipi);
            }
            MessageBox.Show("Sipariş Eklendi");
            
        }
        private void SiparisGuncelle()
        {
            int musteriId, siparisNo, sDetayId;
            int? urunId, urunhizmetId;
            double miktar, tutar, birimFiyati;
            string birim, paraBirimi,satirTipi;
            DateTime siparisTarihi;
            musteriId = SeciliMusteriId;
            siparisNo = Convert.ToInt32(txtSiparisNo.Text);
            siparisTarihi = Convert.ToDateTime(dateEditSiparisTarihi.Text);
            satinAlDbManager.SiparisUpdate(SiparisID, musteriId, siparisNo, siparisTarihi);

            foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
            {
                urunId = null;
                urunhizmetId = null;
                if (row["SiparisDetayId"] != DBNull.Value)
                {
                    if (row["UrunMalzemeId"] != null && row["UrunMalzemeId"] != DBNull.Value)
                    {
                        urunId = Convert.ToInt32(row["UrunMalzemeId"]);
                    }
                    if (row["UrunHizmetId"] != null && row["UrunHizmetId"] != DBNull.Value)
                    {
                        urunhizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                    }
                    sDetayId = Convert.ToInt32(row["SiparisDetayId"]);                 
                    miktar = Convert.ToDouble(row["Miktar"]);
                    birimFiyati = Convert.ToDouble(row["BirimFiyati"]);
                    tutar = Convert.ToDouble(row["Tutar"]);
                    birim = row["Birim"].ToString();
                    paraBirimi = row["ParaBirimi"].ToString();
                    satirTipi = row["SatirTipi"].ToString();
                    satinAlDbManager.SiparisDetayUpdate(sDetayId, urunId,urunhizmetId, birim, miktar, birimFiyati, paraBirimi, tutar,satirTipi);
                }
                else
                {
                    if (row["UrunMalzemeId"] != null && row["UrunMalzemeId"] != DBNull.Value)
                    {
                        urunId = Convert.ToInt32(row["UrunMalzemeId"]);
                    }
                    if (row["UrunHizmetId"] != null && row["UrunHizmetId"] != DBNull.Value)
                    {
                        urunhizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                    }
                    miktar = Convert.ToDouble(row["Miktar"]);
                    birimFiyati = Convert.ToDouble(row["BirimFiyati"]);
                    tutar = Convert.ToDouble(row["Tutar"]);
                    birim = row["Birim"].ToString();
                    paraBirimi = row["ParaBirimi"].ToString();
                    satirTipi = row["SatirTipi"].ToString();
                    satinAlDbManager.SiparisDetayInsert(SiparisID, urunId,urunhizmetId, miktar, birimFiyati, tutar, birim, paraBirimi,satirTipi);
                }
            }
            MessageBox.Show("İşlem Başaralı");
            
        }
        private void SiparisDetaySil()
        {
            int siparisDetayId;
            if (SiparisID>0)
            {
                DataRow dr = gridViewSiparislerDetay.GetFocusedDataRow();
                if (dr["SiparisDetayId"] != DBNull.Value)
                {
                    siparisDetayId = Convert.ToInt32(dr["SiparisDetayId"]);
                    DialogResult result = MessageBox.Show("Müşteri Silinecek Emin misiniz ?", "Müşteri Silme ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        satinAlDbManager.SiparisDetayDelete(siparisDetayId);
                    }
                }
            }
           
        }
        private void btnSiparisDetayKaydet_Click(object sender, EventArgs e)
        {
            if (SiparisID == 0)
            {
                YeniSiparisEkle();
            }
            else 
            {
                SiparisGuncelle();
            }

        }

        private void gridViewSiparislerDetay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (CellValueChangedCalisiyor==false && NewItemRowCalisiyor ==false)
            {
                CellValueChangedCalisiyor = true;

                double birimFiyatValue = 0, miktarValue = 0, birimFiyati = 0, miktari = 0, tBirimFiyati = 0, tTutar = 0;

                GridView view = sender as GridView;
                if (view == null) return;
                //view.GetRowCellValue(e.RowHandle, "Miktar");
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

        private void siparişDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisDetaySil();
            LoadDetayTable();
        }

        private void repositoryItemComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBoxEdit;
            
            DataRow dr = gridViewSiparislerDetay.GetFocusedDataRow();
            if (combo.SelectedItem.ToString()=="Malzeme")
            {
                if (dr!=null)
                {
                    dr["SatirTipi"] = combo.SelectedItem.ToString();
                }
                else
                {
                    DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                    DataRow drNew = dt.NewRow();
                    drNew["SatirTipi"] = combo.SelectedItem.ToString();
                    dt.Rows.Add(drNew);
                }
            }
            else if(combo.SelectedItem.ToString() == "Hizmet")
            {
                if (dr != null)
                {
                    dr["SatirTipi"] = combo.SelectedItem.ToString();
                }
                else
                {
                    DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                    DataRow drNew = dt.NewRow();
                    drNew["SatirTipi"] = combo.SelectedItem.ToString();
                    dt.Rows.Add(drNew);
                }

            }
        }

 
    }
}
