using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApDevex
{
    public class SiparisDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public int SiparisInsert(int musteriId,string siparisNo, DateTime siparisTarihi)
        {
            string query = "INSERT INTO Siparisler(MusteriId,SiparisNo,SiparisTarihi) VALUES (@MusteriId,@SiparisNo,@SiparisTarihi) Select @@IDENTITY ";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", musteriId);
            command.Parameters.AddWithValue("@SiparisNo", siparisNo);
            command.Parameters.AddWithValue("@SiparisTarihi", siparisTarihi);
            
            connection.Open();
            int siparisId = 0;
            object oResult = command.ExecuteScalar();
            if (oResult != null)
            {
                siparisId = Convert.ToInt32(oResult);
            }
            connection.Close();

            return siparisId;
           
        }
        public int GetSiparisId()
        {
            return 0;
        }
        public DataTable DataTableSiparisDetayEmpty()
        {
            connection.Open();
            adapter = new SqlDataAdapter("select SiparisDetayId,SiparisId,UrunId,um.UrunAdi,Tutar,um.BirimFiyati,sd.Miktar,Birim,ParaBirimi from Siparis_Detay sd inner join Urun_Malzeme um on sd.UrunId = um.UrunMalzemeId where SiparisId = 0; ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public void SiparisDetayInsert(int siparisId, int urunId, string birim, int miktar,decimal birimFiyati, string paraBirimi,decimal tutar)
        {
            string query = "INSERT INTO Siparis_Detay(SiparisId,UrunId,Miktar,Tutar,BirimFiyati,Birim,ParaBirimi) VALUES (@SiparisId,@UrunId,@Miktar,@Tutar,@BirimFiyati,@Birim,@ParaBirimi)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            command.Parameters.AddWithValue("@UrunId", urunId);
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.Parameters.AddWithValue("@Tutar", tutar);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@Birim", birim);
            command.Parameters.AddWithValue("@ParaBirimi", paraBirimi);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           

        }
    }
}
