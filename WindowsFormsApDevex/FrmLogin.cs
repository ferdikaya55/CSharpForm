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
        LoginMan loginMan = new LoginMan();
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
               durum= loginMan.Login(ad, sifre);
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
            txtKullaniciAdi.Text = "Ferdi";
            txtSifre.Text = "123";
            FrmAna frmAna = new FrmAna();
            frmAna.ShowDialog();
            this.Close();
        }
        private void btnGirisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                string ad = txtKullaniciAdi.Text.Trim();
                string sifre = txtSifre.Text.Trim();

                if (ad != null && sifre != null)
                {
                    durum = loginMan.Login(ad, sifre);
                    if (durum)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
                    }
                }
                if (durum == false)
                {
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                }
            }
        }
    }
}
