using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            frmMusteriler frmMusteriler = new frmMusteriler();
            frmMusteriler.ShowDialog();
        }

        private void btnSiparisIslemleri_Click(object sender, EventArgs e)
        {
            frmSiparisler frmSiparisler = new frmSiparisler();
            frmSiparisler.ShowDialog();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            frmUrunler frmUrunler = new frmUrunler();
            frmUrunler.ShowDialog();
        }
    }
}
