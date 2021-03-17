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
namespace WindowsFormsApp1
{
    public partial class frmUrunler : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public frmUrunler()
        {
            InitializeComponent();
        }
        private void GetUrunHizmet()
        {
            connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Urun_Hizmet", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewUrunler.DataSource = table;
            connection.Close();
        }
        private void GetUrunMalzeme()
        {
            connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Urun_Malzeme", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewUrunler.DataSource = table;
            connection.Close();
        }

        private void cmbUrunTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunTipi.Text=="Hizmet")
            {
                lblStokMiktari.Text = "Ürün Açıklaması";
                GetUrunHizmet();
            }
            else
            {
                lblStokMiktari.Text = "Stok Miktarı";
                GetUrunMalzeme();
            }
        }
        private void dataGridViewUrunler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridViewUrunler.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridViewUrunler.CurrentRow.Cells[1].Value.ToString();
            txtBirimFiyati.Text = dataGridViewUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dataGridViewUrunler.CurrentRow.Cells[3].Value.ToString();
        }
        private void frmUrunler_Load(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int siparisNo = random.Next(1,1000);
            int adet = Convert.ToInt32(txtAdet.Text);
            decimal birimFiyati = Convert.ToDecimal(txtBirimFiyati.Text);
            string query = "INSERT INTO Siparisler(MusteriId,SiparisNo,SiparisTarihi,Adet,Fiyat) VALUES (@MusteriId,@SiparisNo,@SiparisTarihi,@Adet,@Fiyat)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", 2);
            command.Parameters.AddWithValue("@SiparisNo",Convert.ToString(siparisNo));
            command.Parameters.AddWithValue("@SiparisTarihi",DateTime.Now);
            command.Parameters.AddWithValue("@Adet",adet);
            command.Parameters.AddWithValue("@Fiyat",birimFiyati);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            frmSiparisler frmSiparisler = new frmSiparisler();
            frmSiparisler.ShowDialog();
            //string querySiparisDetay = "INSERT INTO Siparis_Detay(SiparisId,UrunId,Adet,Tutar) VALUES (@SiparisId,@UrunId,@Adet,@Tutar)";
            //command = new SqlCommand(querySiparisDetay, connection);
            //command.Parameters.AddWithValue("@SiparisId", );
            //command.Parameters.AddWithValue("@UrunId", );
            //command.Parameters.AddWithValue("@Adet", );
            //command.Parameters.AddWithValue("@Tutar", );

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
