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
            FrmSatinAl frmSatinAl = new FrmSatinAl(id);
            frmSatinAl.ShowDialog();
        }
        private void navBarSiparisler_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmSiparisler frmSiparisler = new FrmSiparisler();
            frmSiparisler.ShowDialog();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmUrunHizmetList frmUrunHizmetList = new FrmUrunHizmetList();
            frmUrunHizmetList.ShowDialog();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
          
            //if (Yetki=="Kullanıcı")
            //{
            //    navBarMusteriler.Visible = false;
            //}
        }
    }
}
