using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApDevex
{
    public class MusteriDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command ;
        SqlDataAdapter adapter;
        bool durum;
        public DataTable DataTableMusteriListele()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Musteriler", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
           
            connection.Close();
            return table;
        }
        public DataRow DataRowGetMusteri(int id)
        {
            adapter = new SqlDataAdapter();
            string query = "Select MusteriAd,Adres,Telefon from Musteriler where MusteriId=@id";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = command;
            connection.Open();
            
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table.Rows[0];
        }

        public void MusteriInsert(string ad,string adres,string tel)
        {
            string query = "INSERT INTO Musteriler(MusteriAd,Adres,Telefon) VALUES (@MusteriAd,@Adres,@Telefon)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriAd",ad);
            command.Parameters.AddWithValue("@Adres",adres);
            command.Parameters.AddWithValue("@Telefon", tel);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           

        }
        public void MusteriUpdate(int id,string ad,string adres,string telefon)
        {
            string query = "UPDATE Musteriler SET MusteriAd=@MusteriAd,Adres=@Adres,Telefon=@Telefon WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId",id );
            command.Parameters.AddWithValue("@MusteriAd",ad );
            command.Parameters.AddWithValue("@Adres",adres );
            command.Parameters.AddWithValue("@Telefon",telefon);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
          
        } 
        public void MusteriDelete(int musteriId)
        {
            string query = "DELETE FROM Musteriler WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("MusteriId", musteriId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
         
        }
        public bool MusteriKontrol(int musteriId)
        {
            connection.Open();
            var idKontrol = "select MusteriId from Siparisler where MusteriId=@MusteriId";
            command = new SqlCommand(idKontrol, connection);
            command.Parameters.AddWithValue("@MusteriId", musteriId);
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
            return durum;
        }
     
    }
    
}
