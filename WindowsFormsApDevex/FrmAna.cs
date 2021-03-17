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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
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

        private void navBarSiparisler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int id=0;
            string ad="";
            FrmSiparisler frmSiparisler = new FrmSiparisler();
            frmSiparisler.ShowDialog();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {

        }
    }
}
