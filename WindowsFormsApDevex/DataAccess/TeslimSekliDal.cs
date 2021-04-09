using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApDevex.DataAccess
{
    public class TeslimSekliDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public DataTable DataTableTeslimSekliListele()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from TeslimSekli", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public DataRow DataRowGetTeslimSekli(int id)
        {
            adapter = new SqlDataAdapter();
            string query = "Select TeslimId,TeslimSekliAdi from TeslimSekli where TeslimId=@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            return table.Rows[0];
        }

        public void TeslimSekliInsert(string teslimSekliAdi)
        {
            string query = "INSERT INTO TeslimSekli(TeslimSekliAdi) VALUES (@TeslimSekliAdi)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TeslimSekliAdi", teslimSekliAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void TeslimSekliUpdate(int id, string teslimSekliAdi)
        {
            string query = "UPDATE TeslimSekli SET TeslimSekliAdi=@TeslimSekliAdi WHERE TeslimId=@TeslimId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TeslimId", id);
            command.Parameters.AddWithValue("@TeslimSekliAdi", teslimSekliAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void TeslimSekliDelete(int id)
        {
            string query = "DELETE FROM TeslimSekli WHERE TeslimId=@TeslimId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TeslimId", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
