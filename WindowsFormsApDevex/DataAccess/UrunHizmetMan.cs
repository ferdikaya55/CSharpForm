using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApDevex.DataAccess
{
    
    public class UrunHizmetMan
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public DataTable DataTableUrunHizmet()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Urun_Hizmet", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connection.Close();
            return table;
        }
        public DataRow DataRowGetUrunHizmet(int urunId)
        {
            adapter = new SqlDataAdapter();
            string query = "Select UrunHizmetId,UrunAdi,BirimFiyati,UrunAciklama,UrunHizmetKdvOrani from Urun_Hizmet where UrunHizmetId=@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", urunId);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table.Rows[0];
        }
        public void UrunHizmetInsert(string urunAdi, decimal birimFiyati, string aciklama, int kdvOrani)
        {
            string query = "INSERT INTO Urun_Hizmet (UrunAdi,BirimFiyati,UrunAciklama,UrunHizmetKdvOrani) VALUES (@UrunAdi,@BirimFiyati,@UrunAciklama,@UrunHizmetKdvOrani)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunAdi", urunAdi);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@UrunAciklama", aciklama);
            command.Parameters.AddWithValue("@UrunHizmetKdvOrani", kdvOrani);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void UrunHizmetUpdate(int id, string urunAd, decimal birimFiyati, string aciklama, int kdvOrani)
        {
            string query = "UPDATE Urun_Hizmet SET UrunAdi=@UrunAdi,BirimFiyati=@BirimFiyati,UrunAciklama=@UrunAciklama,UrunHizmetKdvOrani=@UrunHizmetKdvOrani WHERE UrunHizmetId=@UrunHizmetId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunHizmetId", id);
            command.Parameters.AddWithValue("@UrunAdi", urunAd);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@UrunAciklama", aciklama);
            command.Parameters.AddWithValue("@UrunHizmetKdvOrani", kdvOrani);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void UrunhizmetDelete(int urunId)
        {
            string query = "DELETE FROM Urun_Hizmet WHERE UrunHizmetId=@UrunHizmetId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunHizmetId", urunId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
