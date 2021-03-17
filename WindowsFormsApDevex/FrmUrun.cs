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
        UrunDal urun = new UrunDal();
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

            }
            else
            {
                DataRow row = urun.DataRowGetUrun(urunId);
                if (row != null)
                {
                    txtUrunAdi.Text = row["UrunAdi"].ToString();
                    txtUrunBirimFiyati.Text = row["BirimFiyati"].ToString();
                    txtUrunStokMiktari.Text = row["StokMiktari"].ToString();

                }

            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (urunId > 0)
            {
                urun.UrunUpdate(urunId, txtUrunAdi.Text, Convert.ToDecimal(txtUrunBirimFiyati.Text), Convert.ToInt32(txtUrunStokMiktari.Text));
                MessageBox.Show("Ürün Güncellendi");
                this.Close();
            }
            else
            {
                urun.UrunInsert(txtUrunAdi.Text, Convert.ToDecimal(txtUrunBirimFiyati.Text), Convert.ToInt32(txtUrunStokMiktari.Text));
                MessageBox.Show("Ürün Eklendi");
                this.Close();
            }
        }
    }
}
