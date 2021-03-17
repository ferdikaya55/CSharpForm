using DevExpress.XtraGrid.Views.Grid;
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
    
    public partial class FrmSiparisler : Form
    {
        public int SeciliMusteriId { get; set; }
        public int SeciliUrunId { get; set; }

        MusteriDal musteri = new MusteriDal();
        UrunDal urunlerDbManager = new UrunDal();
        SiparisDal siparisDbManager = new SiparisDal();
        
        
        public FrmSiparisler()
        {
     

            InitializeComponent();
        }

        private void frmSiparisler_Load(object sender, EventArgs e)
        {


            EmptySiparisDetayList();
            
            

           // gridViewSiparislerDetay.Rows[1].Cells[0].Value = UrunAdi;

           /* DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dt);

            row.Cells[0].Value = UrunAdi;

            dt.Rows.Add(row);*/

         

           
        }
        private void EmptySiparisDetayList()
        {
            gridControlSiparisDetay.DataSource = siparisDbManager.DataTableSiparisDetayEmpty();
           
        }
        private void btnEditMusteriler_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Müşteriler form1 = new Müşteriler(FormAcilisTipi.Secim);
            form1.ShowDialog();

            int musteriId = form1.SeciliMusteriId;
            SeciliMusteriId = musteriId;

            if (musteriId > 0)
            {
                DataRow row = musteri.DataRowGetMusteri(musteriId);
                if (row != null)
                {
                    btnEditMusteriler.Text = row["MusteriAd"].ToString();
                }
            }
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmUrunlerList frmUrunler = new FrmUrunlerList(UrunFormAcilisTipi.Secim);
            frmUrunler.ShowDialog();
            int urunId = frmUrunler.SecilenUrunId;
            SeciliUrunId = urunId;
            if (urunId > 0)
            {
                DataRow row = urunlerDbManager.DataRowGetUrun(urunId);
                if (row!=null)
                {
                    //ürünadı
                }
            }
        }
        private void btnSiparisKaydet_Click_1(object sender, EventArgs e)
        {
            siparisDbManager.SiparisInsert(SeciliMusteriId, txtSiparisNo.Text, Convert.ToDateTime(dateEditSiparisTarihi.EditValue.ToString()));
            Clear();
        }
        private void Clear()
        {
            btnEditMusteriler.Text = "";
            txtSiparisNo.Text = "";
            dateEditSiparisTarihi.Text = "";
        }
        private void btnSiparisDetayKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ((DataTable)gridControlSiparisDetay.DataSource).Rows)
            {
                //int siparisDetayId =Convert.ToInt32((row["SiparisDetayId"]));
                int siparisId = Convert.ToInt32((row["SiparisId"]));
                int urunId = Convert.ToInt32((row["UrunId"]));
                string birimi = (row["Birim"].ToString());
                int miktari = Convert.ToInt32((row["Miktar"]));
                decimal birimFiyati = Convert.ToDecimal((row["BirimFiyati"]));
                string paraBirimi = (row["ParaBirimi"].ToString());
                decimal tutar = Convert.ToDecimal((row["Tutar"]));

                siparisDbManager.SiparisDetayInsert(siparisId,urunId,birimi,miktari,birimFiyati,paraBirimi,tutar);
            }
            MessageBox.Show("Sipariş Eklendi");
        }

        private void gridControlSiparisDetay_Click(object sender, EventArgs e)
        {

        }

    }
}
