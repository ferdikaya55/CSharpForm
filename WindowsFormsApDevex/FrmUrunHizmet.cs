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
    public partial class FrmUrunHizmet : Form
    {
        UrunHizmetMan urunHizmetMan = new UrunHizmetMan();
        public int UrunHizmetId { get; set; }
        public FrmUrunHizmet(int hizmetId)
        {
            this.UrunHizmetId = hizmetId;
            InitializeComponent();
            if (hizmetId == 0)
            {
                txtUrunHizmetAdi.Text = "";
                txtUrunHizmetBirimFiyati.Text = "";
                txtUrunHizmetAciklama.Text = "";
                txtHizmetKdvOrani.Text = "";
            }
            else
            {
                DataRow row = urunHizmetMan.DataRowGetUrunHizmet(hizmetId);
                if (row != null)
                {
                    txtUrunHizmetAdi.Text = row["UrunAdi"].ToString();
                    txtUrunHizmetBirimFiyati.Text = row["BirimFiyati"].ToString();
                    txtUrunHizmetAciklama.Text = row["UrunAciklama"].ToString();
                    txtHizmetKdvOrani.Text = row["UrunHizmetKdvOrani"].ToString();
                }
            }
        }
        private void btnUrunHizmetKaydet_Click(object sender, EventArgs e)
        {

            if (TxtKontrol())
            {
                if (UrunHizmetId > 0)
                {
                    urunHizmetMan.UrunHizmetUpdate(UrunHizmetId, txtUrunHizmetAdi.Text, Convert.ToDecimal(txtUrunHizmetBirimFiyati.Text), txtUrunHizmetAciklama.Text, Convert.ToInt32(txtHizmetKdvOrani.Text));
                    MessageBox.Show("Ürün Hizmet Güncellendi");
                    this.Close();
                }
                else
                {
                    urunHizmetMan.UrunHizmetInsert(txtUrunHizmetAdi.Text, Convert.ToDecimal(txtUrunHizmetBirimFiyati.Text), txtUrunHizmetAciklama.Text, Convert.ToInt32(txtHizmetKdvOrani.Text));
                    MessageBox.Show("Ürün Hizmet Eklendi");
                    this.Close();
                }
            }
        }
        private bool TxtKontrol()
        {
            if (txtUrunHizmetAdi.Text == "")
            {
                MessageBox.Show("Ürün Adı Giriniz.");
                return false;
            }
            if (txtUrunHizmetBirimFiyati.Text == "")
            {
                MessageBox.Show("Ürün BirimFiyati Giriniz.");
                return false;
            }
            if (txtUrunHizmetAciklama.Text == "")
            {
                MessageBox.Show("Ürün Stok Miktarı Giriniz.");
                return false;
            }
            if (txtHizmetKdvOrani.Text == "")
            {
                MessageBox.Show("Ürün Kdv Oranı Giriniz.");
                return false;
            }
            return true;
        }
    }
}
