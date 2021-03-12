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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void GetMusteri()
        {
            connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=DenemeDB;Integrated Security=SSPI");
            connection.Open();
            adapter = new SqlDataAdapter("Select * from TBL_Musteriler",connection);
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
            string query = "INSERT INTO TBL_Musteriler(MusteriAdi,Adres,Telefon) VALUES (@MusteriAdi,@Adres,@Telefon)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriAdi",txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            GetMusteri();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TBL_Musteriler WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("MusteriId", Convert.ToInt32(txtMusteriId.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            GetMusteri();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TBL_Musteriler SET MusteriAdi=@MusteriAdi,Adres=@Adres,Telefon=@Telefon WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@MusteriId",Convert.ToInt32(txtMusteriId.Text));
            command.Parameters.AddWithValue("@MusteriAdi", txtMusteriAdi.Text);
            command.Parameters.AddWithValue("@Adres", txtAdresi.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            GetMusteri();
        }
    }
}
