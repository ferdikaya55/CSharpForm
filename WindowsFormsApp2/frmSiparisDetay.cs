using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class frmSiparisDetay : Form
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        public frmSiparisDetay()
        {
            InitializeComponent();
        }

        private void frmSiparisDetay_Load(object sender, EventArgs e)
        {
            GetSiparisDetay();
        }
        private void GetSiparisDetay()
        {

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select MusteriAd,Adres,Telefon,SiparisNo,SiparisTarihi,s.Adet,Tutar,uh.UrunAdi,UrunAciklama,um.UrunAdi,um.StokMiktari" +
                " from Musteriler m inner join Siparisler s on m.MusteriId = s.MusteriId " +
                "inner join Siparis_Detay sd on s.SiparisId = sd.SiparisId " +
                "inner join Urun_Hizmet uh on sd.UrunId = uh.UrunHizmetId " +
                "inner join Urun_Malzeme um on sd.UrunId = um.UrunMalzemeId", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSiparisDetayi.DataSource = table;
            connection.Close();
        }
    }
}
