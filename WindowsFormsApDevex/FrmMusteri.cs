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
        MusteriMan musteriMan = new MusteriMan();
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
                if (musteriId > 0)
                {
                    musteriMan.MusteriUpdate(musteriId, txtMusteriAdi.Text, txtMusteriTelefon.Text, txtMusteriAdresi.Text);
                    MessageBox.Show("Müşteri Güncellendi");
                    this.Close();
                }
                else
                {
                    musteriMan.MusteriInsert(txtMusteriAdi.Text, txtMusteriTelefon.Text, txtMusteriAdresi.Text);
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
            return true;
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }

}
