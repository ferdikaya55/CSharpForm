﻿using DevExpress.XtraReports.Parameters;
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
    public partial class FrmSiparisler : Form
    {
        public int SiparisID { get; set; }
        SiparisDal siparisCls = new SiparisDal();
        public FrmSiparisler()
        {
            InitializeComponent();
        }

        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            GetSiparisList();
            ClearText();
        }
        private void GetSiparisList()
        {
            gridControlSiparisler.DataSource = siparisCls.DataTableSiparisListele();
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSiparisId.Text);    
            string adi= txtMusteriAdi.Text;
            string adres = txtMusteriAdresi.Text;
            string telefon = txtMusteriTelefonu.Text;
            siparisCls.SiparisUpdate(id,adi,adres,telefon);
            MessageBox.Show("Sipariş güncellendi");
        }

        private void gridViewSiparisler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewSiparisler.GetDataRow(gridViewSiparisler.FocusedRowHandle);
            if (dr!=null)
            {
               
                txtSiparisId.Text = dr["SiparisId"].ToString();
                txtSiparisNo.Text = dr["SiparisNo"].ToString();
                txtSiparisTarihi.Text = dr["SiparisTarihi"].ToString();
                txtMusteriAdi.Text = dr["MusteriAd"].ToString();
                txtMusteriAdresi.Text = dr["Adres"].ToString();
                txtMusteriTelefonu.Text = dr["Telefon"].ToString();
            }
        }
        private void ClearText()
        {
            txtSiparisId.Text = "";
            txtSiparisNo.Text = "";
            txtSiparisTarihi.Text = "";
            txtMusteriAdi.Text = "";
            txtMusteriAdresi.Text ="";
            txtMusteriTelefonu.Text = "";
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
            SiparisID = Convert.ToInt32(txtSiparisId.Text);
            FrmSatinAl frmSatinAl = new FrmSatinAl(SiparisID);
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
            int siparisID = Convert.ToInt32(txtSiparisId.Text);
            XtraReport3 xtraReport3 = new XtraReport3(siparisID);
            ReportPrintTool print = new ReportPrintTool(xtraReport3);
            print.AutoShowParametersPanel = true;
            print.ShowPreviewDialog();

            //Parameter param1 = new Parameter();
            //param1.Name = "SiparisId";
            //param1.Type = typeof(System.Int32);
            //param1.Value = Convert.ToInt32(txtSiparisId.Text);
            //param1.Description = "SiparisId";
            //param1.Visible = true;
            //xtraReport3.Parameters.Add(param1);
            //xtraReport3.FilterString = "[SiparisId]=[Parameters.SiparisId]";
            //xtraReport3.RequestParameters = false;
        }
    }
}