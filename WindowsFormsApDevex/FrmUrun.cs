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
    public partial class FrmUrun : Form
    {
        UrunMalzemeMan urunMalzemeMan = new UrunMalzemeMan();
        public int urunId { get; set; }
        public FrmUrun(int urunId)
        {
            this.urunId = urunId;
            InitializeComponent();
            if (urunId == 0)
            {
                txtUrunAdi.Text = "";
                txtUrunBirimFiyati.Text = "";
                txtUrunStokMiktari.Text = "";
                txtKdvOrani.Text = "";
            }
            else
            {
                DataRow row = urunMalzemeMan.DataRowGetUrun(urunId);
                if (row != null)
                {
                    txtUrunAdi.Text = row["UrunAdi"].ToString();
                    txtUrunBirimFiyati.Text = row["BirimFiyati"].ToString();
                    txtUrunStokMiktari.Text = row["StokMiktari"].ToString();
                    txtKdvOrani.Text = row["UrunMalzemeKdvOrani"].ToString();
                }
            }
        }
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKontrol())
            {
                if (urunId > 0)
                {
                    urunMalzemeMan.UrunUpdate(urunId, txtUrunAdi.Text, Convert.ToDecimal(txtUrunBirimFiyati.Text), Convert.ToInt32(txtUrunStokMiktari.Text), Convert.ToInt32(txtKdvOrani.Text));
                    MessageBox.Show("Ürün Güncellendi");
                    this.Close();
                }
                else
                {
                    urunMalzemeMan.UrunInsert(txtUrunAdi.Text, Convert.ToDecimal(txtUrunBirimFiyati.Text), Convert.ToInt32(txtUrunStokMiktari.Text), Convert.ToInt32(txtKdvOrani.Text));
                    MessageBox.Show("Ürün Eklendi");
                    this.Close();
                }
            }
        }
        private bool TxtKontrol()
        {
            if (txtUrunAdi.Text=="")
            {
                MessageBox.Show("Ürün Adı Giriniz.");
                return false;
            }
            if (txtUrunBirimFiyati.Text == "")
            {
                MessageBox.Show("Ürün BirimFiyati Giriniz.");
                return false;
            }
            if (txtUrunStokMiktari.Text == "")
            {
                MessageBox.Show("Ürün Stok Miktarı Giriniz.");
                return false;
            }
            if (txtKdvOrani.Text == "")
            {
                MessageBox.Show("Ürün Kdv Oranı Giriniz.");
                return false;
            }
            return true;
        }
    }
}
