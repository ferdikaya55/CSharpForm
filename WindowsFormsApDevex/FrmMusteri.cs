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
    public partial class FrmMusteri : Form
    {
        MusteriDal musteri = new MusteriDal();
        public int musteriId { get; set; }
        public FrmMusteri(int musteriId)
        {
            InitializeComponent();
            this.musteriId = musteriId;
            if (musteriId == 0)
            {
                txtMusteriAdi.Text = "";
                txtMusteriTelefon.Text = "";
                txtMusteriAdresi.Text = "";
                
            }
            else
            {
                DataRow row = musteri.DataRowGetMusteri(musteriId);
                if (row != null)
                {
                    txtMusteriAdi.Text = row["MusteriAd"].ToString();
                    txtMusteriTelefon.Text = row["Adres"].ToString();
                    txtMusteriAdresi.Text = row["Telefon"].ToString();

                }

            }
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (musteriId>0)
            {
                musteri.MusteriUpdate(musteriId, txtMusteriAdi.Text, txtMusteriTelefon.Text, txtMusteriAdresi.Text);
                MessageBox.Show("Müşteri Güncellendi");
                this.Close();
            }
            else
            {
                musteri.MusteriInsert(txtMusteriAdi.Text, txtMusteriTelefon.Text, txtMusteriAdresi.Text);
                MessageBox.Show("Müşteri Eklendi");
                this.Close();
            }
        }
    }
      
}
