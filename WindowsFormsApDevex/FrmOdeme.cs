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
    public partial class FrmOdeme : Form
    {
        OdemeSekliMan odemeSekliMan = new OdemeSekliMan();
        public int OdemeSekliId { get; set; }
        public FrmOdeme(int odemeId)
        {
            InitializeComponent();
            this.OdemeSekliId = odemeId;
            if (OdemeSekliId == 0)
            {
                txtOdemeSekli.Text = "";
            }
            else
            {
                DataRow row = odemeSekliMan.DataRowGetOdemeSekli(OdemeSekliId);
                if (row != null)
                {
                    txtOdemeSekli.Text = row["OdemeAdi"].ToString();
                }

            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (OdemeSekliId > 0)
            {
                odemeSekliMan.OdemeSekliUpdate(OdemeSekliId, txtOdemeSekli.Text);
                MessageBox.Show("Ödeme Şekli Güncellendi");
                this.Close();
            }
            else
            {
                odemeSekliMan.OdemeSekliInsert(txtOdemeSekli.Text);
                MessageBox.Show("Ödeme Şekli Eklendi");
                this.Close();
            }
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {

        }
    }
}
