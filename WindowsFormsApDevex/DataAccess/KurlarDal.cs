using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApDevex.DataAccess
{
    public class KurlarDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public DataTable DataTableKurlarListele()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Kurlar", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public void KurInsert(string kurAdi)
        {
            string query = "INSERT INTO Kurlar(KurAdi) VALUES (@KurAdi)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@KurAdi", kurAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void KurUpdate(int id, string kurAdi)
        {
            string query = "UPDATE Kurlar SET KurAdi=@KurAdi WHERE KurId=@KurId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@KurId", id);
            command.Parameters.AddWithValue("@KurAdi", kurAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void KurDelete(int kurId)
        {
            string query = "DELETE FROM Kurlar WHERE KurId=@KurId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("KurId", kurId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}