using DevExpress.XtraEditors;
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
    public partial class FrmKurlar : Form
    {
        KurlarDal kurlarCls = new KurlarDal();

        public FrmKurlar()
        {
            InitializeComponent();
        }

        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            KurListele();
        }
        private void KurListele()
        {
            gridControlKurlar.DataSource = kurlarCls.DataTableKurlarListele();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = XtraInputBox.Show("Kur adı giriniz", "Kur Tanımlama", "").ToString();
            if (result != null)
            {
                kurlarCls.KurInsert(result);
                MessageBox.Show("Kur Eklendi");
                KurListele();
            }
        }
        private void kurGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int kurId = 0;
            string kurAdi = "";
            DataRow dr = gridViewKurlar.GetDataRow(gridViewKurlar.FocusedRowHandle);
            if (dr != null)
            {
                kurId = Convert.ToInt32(dr["KurId"]);
                kurAdi = dr["KurAdi"].ToString();
            }
            var result = XtraInputBox.Show("Kur adı giriniz", "Kur Güncelleme", kurAdi).ToString();
            if (result != null)
            {
                kurlarCls.KurUpdate(kurId, result);
                MessageBox.Show("Kur Güncellendi");
                KurListele();
            }
        }

        private void kurSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int kurId = 0;

            DataRow dr = gridViewKurlar.GetDataRow(gridViewKurlar.FocusedRowHandle);
            if (dr != null)
            {
                kurId = Convert.ToInt32(dr["KurId"]);
            }
            if (kurId != 0)
            {
                DialogResult result = MessageBox.Show("Kur Silinecek Emin misiniz ?", "Kur Silme ", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    kurlarCls.KurDelete(kurId);
                    MessageBox.Show("Kur Silindi");
                    KurListele();
                }
            }

        }
    }
}
