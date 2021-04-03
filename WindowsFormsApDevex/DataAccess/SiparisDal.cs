using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApDevex.DataAccess
{
    public class SiparisDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlDataAdapter adapter;
        SqlCommand command;
        public DataTable DataTableSiparisListele()
        {
            connection.Open();
            adapter = new SqlDataAdapter("select s.SiparisId,m.MusteriAd,m.Adres,m.Telefon,s.SiparisNo,s.SiparisTarihi from Siparisler s left join Musteriler m on s.MusteriId = m.MusteriId order by s.SiparisId desc", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public void SiparisUpdate(int siparisId, string ad, string adres, string telefon)
        {
            string query = "UPDATE Musteriler SET MusteriAd=@MusteriAd,Adres=@Adres,Telefon=@Telefon from Musteriler inner join Siparisler " +
                            "on Musteriler.MusteriId = Siparisler.MusteriId where Siparisler.SiparisId = @SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            command.Parameters.AddWithValue("@MusteriAd", ad);
            command.Parameters.AddWithValue("@Adres", adres);
            command.Parameters.AddWithValue("@Telefon", telefon);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void SiparisDelete(int siparisId)
        {
            string query = "DELETE FROM Siparisler WHERE SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
