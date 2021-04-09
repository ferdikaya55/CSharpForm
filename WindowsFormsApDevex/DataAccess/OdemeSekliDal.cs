using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApDevex.DataAccess
{
    public class OdemeSekliDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public DataTable DataTableOdemeSekliListele()
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * from OdemeSekli", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public DataRow DataRowGetOdemeSekli(int id)
        {
            adapter = new SqlDataAdapter();
            string query = "Select OdemeId,OdemeAdi from OdemeSekli where OdemeId=@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            return table.Rows[0];
        }

        public void OdemeSekliInsert(string odemeAdi)
        {
            string query = "INSERT INTO OdemeSekli(OdemeAdi) VALUES (@OdemeAdi)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OdemeAdi", odemeAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void OdemeSekliUpdate(int id, string odemeAdi)
        {
            string query = "UPDATE OdemeSekli SET OdemeAdi=@OdemeAdi WHERE OdemeId=@OdemeId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OdemeId", id);
            command.Parameters.AddWithValue("@OdemeAdi", odemeAdi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void OdemeSekliDelete(int odemeId)
        {
            string query = "DELETE FROM OdemeSekli WHERE OdemeId=@OdemeId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OdemeId", odemeId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }


    }
}
