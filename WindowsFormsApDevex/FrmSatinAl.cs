﻿using DevExpress.XtraEditors;
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
                        dr["KdvOrani"] = Urunrow["UrunMalzemeKdvOrani"];
                        dr["Birim"] = "Adet";
                        dr["ParaBirimi"] = "TL";
                        dr["Miktar"]=1;
                        dr["Tutar"] = Convert.ToDouble(dr["Miktar"]) * Convert.ToDouble(dr["BirimFiyati"]);
                        dr["KdvToplamTutari"] = (Convert.ToDouble(dr["Tutar"]) * Convert.ToDouble(dr["KdvOrani"]))/100;
                        dr["AraToplam"] = Convert.ToDouble(dr["KdvToplamTutari"]) + Convert.ToDouble(dr["Tutar"]);
                        dr["IndirimOrani"] = 0;
                        dr["IndirimKazanci"] = 0;
                        dr["Toplam"] = dr["AraToplam"];

                        gridViewSiparislerDetay.UpdateCurrentRow();
                    }
                    else
                    {
                        DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                        DataRow drNew = dt.NewRow();

                        drNew["UrunMalzemeId"] = Urunrow["UrunMalzemeId"].ToString();
                        drNew["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        drNew["BirimFiyati"] = Urunrow["BirimFiyati"];
                        dr["KdvOrani"] = Urunrow["UrunMalzemeKdvOrani"];
                        drNew["Birim"] = "Adet";
                        drNew["ParaBirimi"] = "TL";
                        dr["Tutar"] = Convert.ToDouble(dr["Miktar"]) * Convert.ToDouble(dr["BirimFiyati"]);
                        dr["KdvToplamTutari"] = (Convert.ToDouble(dr["Tutar"]) * Convert.ToDouble(dr["KdvOrani"])) / 100;
                        dr["AraToplam"] = Convert.ToDouble(dr["KdvToplamTutari"]) + Convert.ToDouble(dr["Tutar"]);
                        dr["IndirimOrani"] = 0;
                        dr["IndirimKazanci"] = 0;
                        dr["Toplam"] = dr["AraToplam"];
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
                        dr["KdvOrani"] = Urunrow["UrunHizmetKdvOrani"];
                        dr["Birim"] = "Adet";
                        dr["ParaBirimi"] = "TL";
                        dr["Miktar"] = 1;
                        dr["Tutar"] = Convert.ToDouble(dr["Miktar"]) * Convert.ToDouble(dr["BirimFiyati"]);
                        dr["KdvToplamTutari"] = (Convert.ToDouble(dr["Tutar"]) * Convert.ToDouble(dr["KdvOrani"])) / 100;
                        dr["AraToplam"] = Convert.ToDouble(dr["KdvToplamTutari"]) + Convert.ToDouble(dr["Tutar"]);
                        gridViewSiparislerDetay.UpdateCurrentRow();
                    }
                    else
                    {
                        DataTable dt = (DataTable)gridControlSiparisDetay.DataSource;
                        DataRow drNew = dt.NewRow();

                        drNew["UrunHizmetId"] = Urunrow["UrunHizmetId"].ToString();
                        drNew["UrunAdi"] = Urunrow["UrunAdi"].ToString();
                        drNew["BirimFiyati"] = Urunrow["BirimFiyati"];
                        dr["KdvOrani"] = Urunrow["UrunHizmetKdvOrani"];
                        drNew["Birim"] = "Adet";
                        drNew["ParaBirimi"] = "TL";
                        dr["Tutar"] = Convert.ToDouble(dr["Miktar"]) * Convert.ToDouble(dr["BirimFiyati"]);
                        dr["KdvToplamTutari"] = (Convert.ToDouble(dr["Tutar"]) * Convert.ToDouble(dr["KdvOrani"])) / 100;
                        dr["AraToplam"] = Convert.ToDouble(dr["KdvToplamTutari"]) + Convert.ToDouble(dr["Tutar"]);
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
        private bool YeniSiparisEkle()
        {
            int musteriId, siparisNo,kdvOrani,indirimOrani;
            int? urunId, urunhizmetId;
            double miktar, tutar, birimFiyati,kdvToplamTutar, araToplam,indirimKazanci,toplam;
            string birim, paraBirimi,satirTipi;
            DateTime siparisTarihi;
            bool siparisDurum = false;
            

            if (TxtSiparisKontrol() && SiparisDetayKontrol())
            {
                musteriId = SeciliMusteriId;
                siparisNo = Convert.ToInt32(txtSiparisNo.Text);
                siparisTarihi = Convert.ToDateTime(dateEditSiparisTarihi.EditValue);
                SiparisID = satinAlDbManager.SiparisInsert(musteriId, siparisNo, siparisTarihi);
                foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
                {
                    urunId = null;
                    urunhizmetId = null;
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
                    kdvOrani = Convert.ToInt32(row["KdvOrani"]);
                    kdvToplamTutar = Convert.ToDouble(row["KdvToplamTutari"]);
                    araToplam = Convert.ToDouble(row["AraToplam"]);
                    indirimOrani= Convert.ToInt32(row["IndirimOrani"]);
                    indirimKazanci = Convert.ToDouble(row["IndirimKazanci"]);
                    toplam = Convert.ToDouble(row["Toplam"]);

                    satinAlDbManager.SiparisDetayInsert(SiparisID, urunId, urunhizmetId, miktar, birimFiyati, tutar, birim, paraBirimi, satirTipi,kdvOrani,kdvToplamTutar, araToplam,indirimOrani,indirimKazanci,toplam);

                }
                siparisDurum = true;
                return siparisDurum;
            }

            return siparisDurum;

        }
        private bool SiparisGuncelle()
        {
            int musteriId, siparisNo, sDetayId,kdvOrani,indirimOrani;
            int? urunId, urunhizmetId;
            double miktar, tutar, birimFiyati, kdvToplamTutar, araToplam,indirimKazanci, toplam;
            string birim, paraBirimi,satirTipi;
            DateTime siparisTarihi;
            bool siparisGuncelleDurum = false;
            if (TxtSiparisKontrol() && SiparisDetayKontrol())
            {
                musteriId = SeciliMusteriId;
                siparisNo = Convert.ToInt32(txtSiparisNo.Text);
                siparisTarihi = Convert.ToDateTime(dateEditSiparisTarihi.EditValue);
                satinAlDbManager.SiparisUpdate(SiparisID, musteriId, siparisNo, siparisTarihi);

                foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
                {
                    urunId = null;
                    urunhizmetId = null;
                    
                    if (row["SiparisDetayId"] != DBNull.Value)
                    {
                        if (row["SatirTipi"].ToString()=="Malzeme")
                        {
                            urunId = Convert.ToInt32(row["UrunMalzemeId"]);
                            urunhizmetId = null;
                        }
                        if (row["SatirTipi"].ToString() == "Hizmet")
                        {
                            urunhizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                            urunId = null;
                        }
                        sDetayId = Convert.ToInt32(row["SiparisDetayId"]);
                        miktar = Convert.ToDouble(row["Miktar"]);
                        birimFiyati = Convert.ToDouble(row["BirimFiyati"]);
                        tutar = Convert.ToDouble(row["Tutar"]);
                        birim = row["Birim"].ToString();
                        paraBirimi = row["ParaBirimi"].ToString();
                        satirTipi = row["SatirTipi"].ToString();
                        kdvOrani = Convert.ToInt32(row["KdvOrani"]);
                        kdvToplamTutar = Convert.ToDouble(row["KdvToplamTutari"]);
                        araToplam = Convert.ToDouble(row["AraToplam"]);
                        indirimOrani = Convert.ToInt32(row["IndirimOrani"]);
                        indirimKazanci = Convert.ToDouble(row["IndirimKazanci"]);
                        toplam = Convert.ToDouble(row["Toplam"]);
                        satinAlDbManager.SiparisDetayUpdate(sDetayId, urunId, urunhizmetId, birim, miktar, birimFiyati, paraBirimi, tutar, satirTipi,kdvOrani,kdvToplamTutar, araToplam, indirimOrani, indirimKazanci, toplam);
                    }
                    else
                    {
                        if (row["SatirTipi"].ToString() == "Malzeme")
                        {
                            urunId = Convert.ToInt32(row["UrunMalzemeId"]);
                            urunhizmetId = null;
                        }
                        if (row["SatirTipi"].ToString() == "Hizmet")
                        {
                            urunhizmetId = Convert.ToInt32(row["UrunHizmetId"]);
                            urunId = null;
                        }
                       
                        miktar = Convert.ToDouble(row["Miktar"]);
                        birimFiyati = Convert.ToDouble(row["BirimFiyati"]);
                        tutar = Convert.ToDouble(row["Tutar"]);
                        birim = row["Birim"].ToString();
                        paraBirimi = row["ParaBirimi"].ToString();
                        satirTipi = row["SatirTipi"].ToString();
                        kdvOrani = Convert.ToInt32(row["KdvOrani"]);
                        kdvToplamTutar = Convert.ToDouble(row["KdvToplamTutari"]);
                        araToplam = Convert.ToDouble(row["AraToplam"]);
                        indirimOrani = Convert.ToInt32(row["IndirimOrani"]);
                        indirimKazanci = Convert.ToDouble(row["IndirimKazanci"]);
                        toplam = Convert.ToDouble(row["Toplam"]);
                        satinAlDbManager.SiparisDetayInsert(SiparisID, urunId, urunhizmetId, miktar, birimFiyati, tutar, birim, paraBirimi, satirTipi,kdvOrani,kdvToplamTutar, araToplam, indirimOrani, indirimKazanci, toplam);
                    }

                }
                siparisGuncelleDurum = true;
                return siparisGuncelleDurum;
            
            }
            return siparisGuncelleDurum;
        
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
                if (YeniSiparisEkle())
                {
                    MessageBox.Show("Sipariş Eklendi");
                     LoadDetayTable();
                } 
            }
            else 
            {
                if (SiparisGuncelle())
                {
                    MessageBox.Show("İşlem Başaralı");
                    
                }
            }
        }
        private bool SiparisDetayKontrol()
        {
            int satir = 0;
            if (gridViewSiparislerDetay.RowCount>1)
            {
                foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
                {
                    satir++;
                    if (row["SatirTipi"] == null)
                    {
                        MessageBox.Show("Satır Tipi Seçiniz");
                        return false;
                    }
                    if (row["SatirTipi"].ToString() == "Malzeme")
                    {
                        if (row["UrunMalzemeId"] == null)
                        {
                            MessageBox.Show("Ürün seçiniz.");
                            return false;
                        }
                    }
                    if (row["SatirTipi"].ToString() == "Hizmet")
                    {
                        if (row["UrunHizmetId"] == null)
                        {
                            MessageBox.Show("Ürün seçiniz.");
                            return false;
                        }
                    }
                    if (Convert.ToDouble(row["Miktar"]) == 0)
                    {
                        MessageBox.Show(satir+". Satır'a Miktar Giriniz");
                        return false;
                    }
                }
                return true;
            }
            MessageBox.Show("Sipariş Eklenmedi.Satır Seçiniz");
            return false;
        }
        private bool TxtSiparisKontrol()
        {
            int siparisNo;
            if (SeciliMusteriId==0)
            {
                MessageBox.Show("Müşteri Seçiniz");
                return false;
            }
            if (txtSiparisNo.Text == "")
            {
                MessageBox.Show("Sipariş No Boş Geçilemez");
                return false;
            }
            else
            {
                
                    siparisNo = Convert.ToInt32(txtSiparisNo.Text);
                    bool sonuc = satinAlDbManager.SiparisNoVarmi(siparisNo,SiparisID);
                    if (sonuc)
                    {
                        MessageBox.Show("Bu Sipariş Numarasına ait sipariş Var");
                        return false;
                    }
                
               
            }
            if (dateEditSiparisTarihi.EditValue==null)
            {
                MessageBox.Show("Sipariş Tarihi Boş Geçilemez");
                return false;
            }
            return true;
        }
        private void gridViewSiparislerDetay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (CellValueChangedCalisiyor==false && NewItemRowCalisiyor ==false)
            {
                CellValueChangedCalisiyor = true;

                double bFiyatValue=0 , miktarValue=0, tutarValue=0, toplamValue=0, birimFiyati=0, miktari=0,tutar=0,toplamTutar=0,kdvTutari=0,kdvToplamTutar=0,indirimKazanci=0,toplam=0,araToplam=0;
                int kdvOrani=0,kdvOraniValue=0,indirimOrani=0;
                GridView view = sender as GridView;
                DataRow dr = view.GetDataRow(e.RowHandle);
                if (view == null) return;
               
                if (e.Column.FieldName == "BirimFiyati")
                {
                    if (e.Value != null)
                    {
                        bFiyatValue = Convert.ToDouble(e.Value);
                    }
                    
                    if (dr != null)
                    {
                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            miktarValue = Convert.ToDouble(dr["Miktar"]);
                        }
                        if (dr["KdvOrani"] != null && dr["KdvOrani"] != DBNull.Value)
                        {
                            kdvOrani = Convert.ToInt32(dr["KdvOrani"]);
                        }
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                    }
                    tutar = Math.Round(bFiyatValue * miktarValue, 1);
                    kdvToplamTutar = Math.Round(((tutar * kdvOrani) / 100), 1);
                    araToplam = Math.Round(tutar + kdvToplamTutar,1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], tutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["AraToplam"], araToplam);
                    indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                    toplam = Math.Round((araToplam - indirimKazanci), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                }
                if (e.Column.FieldName == "Miktar")
                {
                    if (e.Value != null)
                    {
                        miktarValue = Convert.ToDouble(e.Value);
                    }
                    
                    if (dr != null)
                    {
                        if (dr["BirimFiyati"] != null && dr["BirimFiyati"] != DBNull.Value)
                        {
                            birimFiyati = Convert.ToDouble(dr["BirimFiyati"]);
                        }
                        if (dr["KdvOrani"] != null && dr["KdvOrani"] != DBNull.Value)
                        {
                            kdvOrani = Convert.ToInt32(dr["KdvOrani"]);
                        }
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                    }
                    tutar = Math.Round((miktarValue * birimFiyati), 1);
                    kdvToplamTutar = Math.Round(((tutar * kdvOrani) / 100), 1);
                    araToplam = Math.Round((tutar + kdvToplamTutar), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], tutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["AraToplam"], araToplam);
                    indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                    toplam = Math.Round((araToplam - indirimKazanci), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                }
                if (e.Column.FieldName == "Tutar")
                { 
                     if (e.Value != null)
                    {
                        tutarValue = Convert.ToDouble(e.Value);
                    }
                   
                    if (dr != null)
                    {
                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            miktari = Convert.ToDouble(dr["Miktar"]);
                        }
                        if (dr["KdvOrani"] != null && dr["KdvOrani"] != DBNull.Value)
                        {
                            kdvOrani = Convert.ToInt32(dr["KdvOrani"]);
                        }
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                    }
                    if (miktari==0)
                    {
                        MessageBox.Show("Birim Fiyat Belli Değil Ürünü Tekrar Seçiniz");
                        
                        view.SetRowCellValue(e.RowHandle, view.Columns["BirimFiyati"], 0);
                        view.SetRowCellValue(e.RowHandle, view.Columns["Miktar"], 0);
                    }
                    else
                    {
                        birimFiyati = tutarValue / miktari;
                        birimFiyati = Math.Round(birimFiyati,1);
                        kdvToplamTutar = Math.Round((tutarValue * kdvOrani) / 100, 1);
                        araToplam = Math.Round((kdvToplamTutar + tutarValue),1);
                        view.SetRowCellValue(e.RowHandle, view.Columns["BirimFiyati"], birimFiyati);
                        view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                        view.SetRowCellValue(e.RowHandle, view.Columns["AraToplam"], araToplam);
                        indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                        toplam = Math.Round((araToplam - indirimKazanci), 1);
                        view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                        view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                    }
                }
                if (e.Column.FieldName=="KdvOrani")
                {
                    if (e.Value != null)
                    {
                        kdvOraniValue = Convert.ToInt32(e.Value);
                       
                    }
                    
                    if (dr != null)
                    {
                        if (dr["Tutar"] != null && dr["Tutar"] != DBNull.Value)
                        {
                            tutar = Convert.ToDouble(dr["Tutar"]);
                        }
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                    }
                    kdvToplamTutar = Math.Round(((tutar * kdvOraniValue) / 100), 1);
                    araToplam = Math.Round(tutar + kdvToplamTutar, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["AraToplam"], araToplam);
                    indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                    toplam = Math.Round((araToplam - indirimKazanci), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                }
                if (e.Column.FieldName=="AraToplam")
                {
                    if (e.Value!=null)
                    {
                        araToplam = Convert.ToDouble(e.Value);
                    }
                  
                    if (dr != null)
                    {
                        if (dr["KdvOrani"] != null && dr["KdvOrani"] != DBNull.Value)
                        {
                            kdvOrani = Convert.ToInt32(dr["KdvOrani"]);
                        }

                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            miktari = Convert.ToDouble(dr["Miktar"]);
                        }
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                    }
                    tutar = Math.Round(((araToplam * 100) / (100 + kdvOrani)),1);
                    birimFiyati = Math.Round(tutar / miktari,1);
                    kdvToplamTutar = Math.Round(((tutar * kdvOrani) / 100),1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], tutar);
                    view.SetRowCellValue(e.RowHandle, view.Columns["BirimFiyati"], birimFiyati);
                    view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                    indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                    toplam = Math.Round((araToplam - indirimKazanci), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                }
                if (e.Column.FieldName=="IndirimOrani")
                {
                    if (e.Value!=null)
                    {
                        indirimOrani = Convert.ToInt32(e.Value);
                    }
                   
                    if (dr!=null)
                    {
                        if (dr["AraToplam"] != null && dr["AraToplam"] != DBNull.Value)
                        {
                            araToplam = Convert.ToDouble(dr["AraToplam"]);
                        }
                    }
                    if (indirimOrani==0)
                    {
                        view.SetRowCellValue(e.RowHandle, view.Columns["IndirimOrani"], 0);
                        view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], 0);
                        view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], araToplam);
                    }
                    else
                    {
                        indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                        toplam = Math.Round((araToplam - indirimKazanci), 1);
                        view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                        view.SetRowCellValue(e.RowHandle, view.Columns["Toplam"], toplam);
                    }
                   
                }
                if (e.Column.FieldName=="Toplam")
                {
                    if (e.Value != null)
                    {
                        toplam = Convert.ToDouble(e.Value);
                    }
                    if (dr!=null)
                    {
                        if (dr["IndirimOrani"] != null && dr["IndirimOrani"] != DBNull.Value)
                        {
                            indirimOrani = Convert.ToInt32(dr["IndirimOrani"]);
                        }
                        if (dr["KdvOrani"] != null && dr["KdvOrani"] != DBNull.Value)
                        {
                            kdvOrani = Convert.ToInt32(dr["KdvOrani"]);
                        }
                        if (dr["Miktar"] != null && dr["Miktar"] != DBNull.Value)
                        {
                            miktari = Convert.ToDouble(dr["Miktar"]);
                        }
                    }
                    araToplam = (toplam * 100) / (100 - indirimOrani);
                    view.SetRowCellValue(e.RowHandle, view.Columns["AraToplam"], araToplam);
                    tutar = (araToplam * 100) / (100 + kdvOrani);
                    view.SetRowCellValue(e.RowHandle, view.Columns["Tutar"], tutar);
                    birimFiyati = Math.Round(tutar / miktari, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["BirimFiyati"], birimFiyati);
                    kdvToplamTutar = Math.Round((tutar * kdvOrani) / 100, 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["KdvToplamTutari"], kdvToplamTutar);
                    indirimKazanci = Math.Round(((araToplam * indirimOrani) / 100), 1);
                    view.SetRowCellValue(e.RowHandle, view.Columns["IndirimKazanci"], indirimKazanci);
                    
                   
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
            ////dr = gridViewSiparislerDetay.GetDataRow(gridViewSiparislerDetay.FocusedRowHandle);
            ////((DataTable)gridControlSiparisDetay.DataSource).Rows.Clear();


            if (combo.SelectedItem.ToString() == "Malzeme")
            {
                dr["UrunHizmetId"] = DBNull.Value;
                dr["UrunAdi"] = DBNull.Value;
                dr["BirimFiyati"] = DBNull.Value;
                dr["Miktar"] = DBNull.Value;
                dr["Tutar"] = DBNull.Value;
            }
            if (combo.SelectedItem.ToString() == "Hizmet")
            {
                dr["UrunMalzemeId"] = DBNull.Value;
                dr["UrunAdi"] = DBNull.Value;
                dr["BirimFiyati"] = DBNull.Value;
                dr["Miktar"] = DBNull.Value;
                dr["Tutar"] = DBNull.Value;
            }
        }

        private void repoComboKdvOrani_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
