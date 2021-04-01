using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApDevex.DataAccess
{
    public partial class FrmLogin : Form
    {
        LoginDal loginDal = new LoginDal();
        bool durum = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
           
            if (ad!=null && sifre!=null)
            {
               durum= loginDal.Login(ad, sifre);
                if (durum)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
                }
            }
            if (durum==false)
            {
                txtKullaniciAdi.Text = "";
                txtSifre.Text="";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}
