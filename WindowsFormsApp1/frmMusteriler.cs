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
    public partial class frmMusteriler : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void GetMusteri()
        {
            connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Musteriler",connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetMusteri();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
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
            command.Parameters.AddWithValue("@MusteriAd",txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
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
            GetMusteri();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Musteriler SET MusteriAd=@MusteriAd,Adres=@Adres,Telefon=@Telefon WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@MusteriId",Convert.ToInt32(txtMusteriId.Text));
            command.Parameters.AddWithValue("@MusteriAd", txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            GetMusteri();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            frmSiparisler frmSiparisler = new frmSiparisler();
            frmSiparisler.ShowDialog();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {

            frmUrunler frmUrunler = new frmUrunler();
            frmUrunler.ShowDialog();
        }
    }
}
