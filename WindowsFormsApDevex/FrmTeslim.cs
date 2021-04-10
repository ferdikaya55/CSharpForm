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
    public partial class FrmTeslim : Form
    {
        TeslimSekliMan teslimSekliMan = new TeslimSekliMan();
        public int TeslimSekliID { get; set; }
        public FrmTeslim(int teslimSekliId)
        {
            InitializeComponent();
            this.TeslimSekliID = teslimSekliId;
            if (TeslimSekliID==0)
            {
                txtTeslimatSekli.Text = "";
            }
            else
            {
                DataRow row = teslimSekliMan.DataRowGetTeslimSekli(TeslimSekliID);
                if (row!=null)
                {
                    txtTeslimatSekli.Text = row["TeslimSekliAdi"].ToString();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TeslimSekliID>0)
            {
                teslimSekliMan.TeslimSekliUpdate(TeslimSekliID, txtTeslimatSekli.Text);
                MessageBox.Show("Teslimat Şekli Güncellendi");
                this.Close();
            }
            else
            {
                teslimSekliMan.TeslimSekliInsert(txtTeslimatSekli.Text);
                MessageBox.Show("Teslimat Şekli Eklendi");
                this.Close();
            }
        }
    }
}
