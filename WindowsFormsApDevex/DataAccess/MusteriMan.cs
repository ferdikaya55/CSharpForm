using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApDevex.Objects;

namespace WindowsFormsApDevex
{
    public class MusteriMan
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
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

        public void MusteriInsert(Musteri musteri)
        {
            string query = "INSERT INTO Musteriler(MusteriAd,Adres,Telefon,Fax,Email,VergiNo) VALUES (@MusteriAd,@Adres,@Telefon,@Fax,@Email,@VergiNo)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriAd",musteri.MusteriAd);
            command.Parameters.AddWithValue("@Adres",musteri.Adres);
            command.Parameters.AddWithValue("@Telefon", musteri.Telefon);
            command.Parameters.AddWithValue("@Fax", musteri.Fax);
            command.Parameters.AddWithValue("@Email", musteri.Email);
            command.Parameters.AddWithValue("@VergiNo", musteri.VergiNo);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           

        }
        public void MusteriUpdate(Musteri musteri)
        {
            string query = "UPDATE Musteriler SET MusteriAd=@MusteriAd,Adres=@Adres,Telefon=@Telefon,Fax=@Fax,Email=@Email,VergiNo=@VergiNo WHERE MusteriId=@MusteriId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", musteri.MusteriId);
            command.Parameters.AddWithValue("@MusteriAd", musteri.MusteriAd);
            command.Parameters.AddWithValue("@Adres", musteri.Adres);
            command.Parameters.AddWithValue("@Telefon", musteri.Telefon);
            command.Parameters.AddWithValue("@Fax", musteri.Fax);
            command.Parameters.AddWithValue("@Email", musteri.Email);
            command.Parameters.AddWithValue("@VergiNo", musteri.VergiNo);
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
