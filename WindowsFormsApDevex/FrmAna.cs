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
    public partial class FrmAna : Form
    {
        public string Yetki { get; set; }
        public FrmAna()
        {
           // this.Yetki = yetki;
            InitializeComponent();
        }
        private void navBarMusteriler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Müşteriler frmMusteriList = new Müşteriler(FormAcilisTipi.Listele);
            frmMusteriList.ShowDialog();
        }

        private void navBarUrunler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmUrunlerList frmUrunler = new FrmUrunlerList(UrunFormAcilisTipi.Listele);
            frmUrunler.ShowDialog();
        }
        private void navBarSatinAl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int id=0;
            //string ad="";
            FrmSiparisler frmSiparisler = new FrmSiparisler(id);
            frmSiparisler.ShowDialog();
        }
        private void navBarSiparisler_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSiparislerListesi frmSiparislerListesi = new FrmSiparislerListesi();
            frmSiparislerListesi.ShowDialog();
        }
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmUrunHizmetList frmUrunHizmetList = new FrmUrunHizmetList(UrunHizmetFormAcilisTipi.Listele);
            frmUrunHizmetList.ShowDialog();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
          
            //if (Yetki=="Kullanıcı")
            //{
            //    navBarMusteriler.Visible = false;
            //}
        }
        private void navBarItemKurlar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmKurlar frmKurlar = new FrmKurlar();
            frmKurlar.ShowDialog();
        }
    }
}
