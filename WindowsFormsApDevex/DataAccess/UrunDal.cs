using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApDevex
{
    public class UrunDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;

        public DataTable DataTableUrunler()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Urun_Malzeme", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connection.Close();
            return table;
        }
        public DataRow DataRowGetUrun(int urunId)
        {
            adapter = new SqlDataAdapter();
            string query = "Select UrunMalzemeId,UrunAdi,BirimFiyati,StokMiktari from Urun_Malzeme where UrunMalzemeId=@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", urunId);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table.Rows[0];
        }
        public void UrunInsert(string urunAdi, decimal birimFiyati, int stokMiktari)
        {
            string query = "INSERT INTO Urun_Malzeme(UrunAdi,BirimFiyati,StokMiktari) VALUES (@UrunAdi,@BirimFiyati,@StokMiktari)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunAdi", urunAdi);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@StokMiktari", stokMiktari);
    
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void UrunUpdate(int id, string urunAd,decimal birimFiyati, int stokMiktari)
        {
            string query = "UPDATE Urun_Malzeme SET UrunAdi=@UrunAdi,BirimFiyati=@BirimFiyati,StokMiktari=@StokMiktari WHERE UrunMalzemeId=@UrunMalzemeId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunMalzemeId", id);
            command.Parameters.AddWithValue("@UrunAdi", urunAd);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@StokMiktari", stokMiktari);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           
        }
        public void UrunDelete(int urunId)
        {
            string query = "DELETE FROM Urun_Malzeme WHERE UrunMalzemeId=@UrunMalzemeId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunMalzemeId", urunId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
