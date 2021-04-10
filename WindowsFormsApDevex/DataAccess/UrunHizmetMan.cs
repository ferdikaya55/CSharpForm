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
    }
}
