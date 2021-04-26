using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApDevex.Objects;

namespace WindowsFormsApDevex
{
    public partial class FrmMusteri : Form
    {
        MusteriMan musteriMan = new MusteriMan();
        public int musteriId { get; set; }
        Musteri musteriObj = new Musteri();
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
                DataRow row = musteriMan.DataRowGetMusteri(musteriId);
                if (row != null)
                {
                    txtMusteriAdi.Text = row["MusteriAd"].ToString();
                    txtMusteriTelefon.Text = row["Telefon"].ToString();
                    txtMusteriAdresi.Text = row["Adres"].ToString();

                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKontrol())
            {
                musteriObj.MusteriAd = txtMusteriAdi.Text;
                musteriObj.Telefon = txtMusteriTelefon.Text;
                musteriObj.Adres = txtMusteriAdresi.Text;
                musteriObj.VergiNo = txtMusteriVergiNo.Text;
                musteriObj.Email = txtMusteriEmail.Text;
                musteriObj.Fax = txtMusteriFax.Text;
                musteriObj.MusteriId = musteriId;
                if (musteriId > 0)
                {
                    musteriMan.MusteriUpdate(musteriObj);
                    MessageBox.Show("Müşteri Güncellendi");
                    this.Close();
                }
                else
                {
                    musteriMan.MusteriInsert(musteriObj);
                    MessageBox.Show("Müşteri Eklendi");
                    this.Close();
                }

            }
           
        }
        private bool TxtKontrol()
        {
            if (txtMusteriAdi.Text=="")
            {
                MessageBox.Show("Müşteri Adı Giriniz.");
                return false;
            }
            if (txtMusteriTelefon.Text=="")
            {
                MessageBox.Show("Müşteri Telefonu Giriniz.");
                return false;
            }
            if (txtMusteriAdresi.Text == "")
            {
                MessageBox.Show("Müşteri Adresi Giriniz.");
                return false;
            }
            if (txtMusteriVergiNo.Text == "")
            {
                MessageBox.Show("Vergi Numarası Giriniz.");
                return false;
            }
            if (txtMusteriFax.Text == "")
            {
                MessageBox.Show("Fax Numarası Giriniz.");
                return false;
            }
            if (txtMusteriEmail.Text == "")
            {
                MessageBox.Show("Email Adresi Giriniz.");
                return false;
            }
          
            return true;
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }

}
