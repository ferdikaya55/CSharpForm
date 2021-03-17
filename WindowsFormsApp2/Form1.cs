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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        bool durum;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetMusteri()
        {

            connection.Open();
            adapter = new SqlDataAdapter("Select * from Musteriler", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetMusteri();
            CleanTextBox();
        }
        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMusteriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdresi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Musteriler(MusteriAd,Adres,Telefon) VALUES (@MusteriAd,@Adres,@Telefon)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriAd", txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Eklendi");
            CleanTextBox();
            GetMusteri();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM Musteriler WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("MusteriId", Convert.ToInt32(txtMusteriId.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Silindi");
            CleanTextBox();
            GetMusteri();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Musteriler SET MusteriAd=@MusteriAd,Adres=@Adres,Telefon=@Telefon WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", Convert.ToInt32(txtMusteriId.Text));
            command.Parameters.AddWithValue("@MusteriAd", txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Güncellendi");
            CleanTextBox();
            GetMusteri();
        }
        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            GetMusteri();

        }
        private void CleanTextBox()
        {
            txtMusteriId.Text = "";
            txtMusteriAdi.Text = "";
            txtAdresi.Text = "";
            txtTelefon.Text = "";
        }     
        private void cmbUrunTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbUrunTipi.Text == "Hizmet")
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
        private void dataGridViewUrunler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridViewUrunler.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridViewUrunler.CurrentRow.Cells[1].Value.ToString();
            txtBirimFiyati.Text = dataGridViewUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dataGridViewUrunler.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int siparisNo = random.Next(1, 1000);

            string query = "INSERT INTO Siparisler(MusteriId,SiparisNo,SiparisTarihi,Adet,Fiyat) VALUES (@MusteriId,@SiparisNo,@SiparisTarihi,@Adet,@Fiyat)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", txtMusteriId.Text);
            command.Parameters.AddWithValue("@SiparisNo", Convert.ToString(siparisNo));
            command.Parameters.AddWithValue("@SiparisTarihi", DateTime.Now);
            command.Parameters.AddWithValue("@Adet", Convert.ToInt32(txtUrunAdeti.Text));
            command.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(txtBirimFiyati.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün Satın Alma İşlemi Gerçekleştirildi");


        }
        private void dataGridViewSiparisListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSiparisId.Text = dataGridViewSiparisListesi.CurrentRow.Cells[0].Value.ToString();
            txtAdet.Text = dataGridViewSiparisListesi.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dataGridViewSiparisListesi.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSiparisListele_Click(object sender, EventArgs e)
        {
            SiparisListesi();
            // Veritabanında vardır
            IdKontrol();
            if (durum==true)
            {
                int adet = Convert.ToInt32(txtUrunAdeti.Text);
                decimal tutar = Convert.ToDecimal(txtBirimFiyati.Text);

                var querySiparisDetay = "INSERT INTO Siparis_Detay (SiparisId,UrunId,Adet,Tutar) VALUES (@SiparisId,@UrunId,@Adet,@Tutar)";
                command = new SqlCommand(querySiparisDetay, connection);
                command.Parameters.AddWithValue("@SiparisId", txtSiparisId.Text);
                command.Parameters.AddWithValue("@UrunId", txtUrunId.Text);
                command.Parameters.AddWithValue("@Adet", adet);
                command.Parameters.AddWithValue("@Tutar", adet * tutar);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
               
            }
        }
        private void IdKontrol()
        {

            connection.Open();
            var idKontrol = "select * from Siparis_Detay where SiparisId=@SiparisId";
            command = new SqlCommand(idKontrol, connection);
            command.Parameters.AddWithValue("@SiparisId", txtSiparisId.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            connection.Close();
        }
        private void SiparisListesi()
        {
            connection.Open();
            adapter = new SqlDataAdapter("select SiparisId,SiparisNo,MusteriAd,Fiyat as [Birim Fiyatı], sum(Adet)" +
                " as [Sipariş Adeti],sum(Adet*Fiyat) as [Toplam Tutar] " +
                "from Musteriler m " +
                "inner join Siparisler s on m.MusteriId = s.MusteriId group by SiparisId,SiparisNo, MusteriAd,Fiyat order by s.SiparisId desc; ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSiparisListesi.DataSource = table;
            connection.Close();
            dataGridViewSiparisListesi.Visible = true;

        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Siparisler WHERE SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("SiparisId", Convert.ToInt32(txtSiparisId.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sipariş Silindi");
            CleanTextBox();
            SiparisListesi();
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Siparisler SET Adet=@Adet WHERE SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", Convert.ToInt32(txtSiparisId.Text));
            command.Parameters.AddWithValue("@Adet", txtAdet.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sipariş Güncellendi");
            CleanTextBox();
            SiparisListesi();
        }

        private void dataGridViewSiparisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSiparisDetay frmSiparisDetay = new frmSiparisDetay();
            frmSiparisDetay.ShowDialog();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMusteriListele_Click_1(object sender, EventArgs e)
        {

        }
    }
}
