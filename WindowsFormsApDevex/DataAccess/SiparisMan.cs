using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApDevex.Objects;

namespace WindowsFormsApDevex
{
    public class SiparisMan
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
   
        public int SiparisInsert(Siparis siparis)
        {
            string query = "INSERT INTO Siparisler(MusteriId,SiparisNo,SiparisTarihi,KurId,KurDegeri,OdemeId,TeslimId) VALUES (@MusteriId,@SiparisNo,@SiparisTarihi,@KurId,@KurDegeri,@OdemeId,@TeslimId) Select @@IDENTITY ";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MusteriId", siparis.MusteriId);
            command.Parameters.AddWithValue("@SiparisNo", siparis.SiparisNo);
            command.Parameters.AddWithValue("@SiparisTarihi", siparis.SiparisTarihi);
            command.Parameters.AddWithValue("@KurId", siparis.KurId);
            command.Parameters.AddWithValue("@KurDegeri", siparis.KurDegeri);
            command.Parameters.AddWithValue("@OdemeId", siparis.OdemeId);
            command.Parameters.AddWithValue("@TeslimId", siparis.TeslimId);

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
        public void SiparisUpdate(Siparis siparis)
        {
            string query = "Update Siparisler set MusteriId=@MusteriId,SiparisNo=@SiparisNo,SiparisTarihi=@SiparisTarihi,KurId=@KurId,KurDegeri=@KurDegeri,OdemeId=@OdemeId,TeslimId=@TeslimId where SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparis.SiparisId);
            command.Parameters.AddWithValue("@MusteriId", siparis.MusteriId);
            command.Parameters.AddWithValue("@SiparisNo", siparis.SiparisNo);
            command.Parameters.AddWithValue("@SiparisTarihi", siparis.SiparisTarihi);
            command.Parameters.AddWithValue("@KurId", siparis.KurId);
            command.Parameters.AddWithValue("@KurDegeri", siparis.KurDegeri);
            command.Parameters.AddWithValue("@OdemeId", siparis.OdemeId);
            command.Parameters.AddWithValue("@TeslimId", siparis.TeslimId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable GetDataTableDetay(int siparisId)
        {
            connection.Open();
            adapter = new SqlDataAdapter();
            string query = "select * from SiparisDetayBilgileri where SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
           
            return table;
        }
        public DataRow GetDataRowSiparis(int id)
        {
            adapter = new SqlDataAdapter();
            string query = "select s.SiparisId,m.MusteriId,m.MusteriAd,m.Adres,m.Telefon,s.SiparisNo,s.SiparisTarihi,KurAdi,s.KurId,s.KurDegeri,TeslimSekli.TeslimId,TeslimSekli.TeslimSekliAdi,OdemeSekli.OdemeId,OdemeAdi from Siparisler s left join Musteriler m on s.MusteriId = m.MusteriId left join Kurlar on s.KurId = Kurlar.KurId inner join  OdemeSekli on s.OdemeId = OdemeSekli.OdemeId inner join TeslimSekli on s.TeslimId = TeslimSekli.TeslimId where SiparisId =@id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            return table.Rows[0];
        }
        public bool SiparisNoVarmi(int siparisNo,int siparisId)
        {
            bool kontrol = false;
            connection.Open();
            command = new SqlCommand("select SiparisId,SiparisNo from Siparisler where SiparisNo=" + siparisNo.ToString() + " and SiparisId<>" + siparisId.ToString() + "", connection);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                kontrol = true;
            }
            connection.Close();
            if (kontrol == true)
            {
                return kontrol;
            }
            else return kontrol;
        }
        public int GetSiparisNo()
        {
            string query = "select top 1 SiparisNo from Siparisler order by SiparisNo desc";
            command = new SqlCommand(query, connection);
            connection.Open();
            int siparisNo = 0;
            object oResult = command.ExecuteScalar();
            if (oResult != null)
            {
                siparisNo = Convert.ToInt32(oResult);
            }
            connection.Close();
            return siparisNo;
        }
        public int GetMusteriId(int siparisId)
        {
            string query = "select MusteriId from Siparisler where SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            connection.Open();
            int id = 0;
            object oResult = command.ExecuteScalar();
            if (oResult != null)
            {
                id = Convert.ToInt32(oResult);
            }
            connection.Close();
            return id;
        }
        public void StokMiktariGuncelleme(int urunMalzemeId,double miktar)
        {
            string query = "update Urun_Malzeme set StokMiktari=StokMiktari - '"+miktar+"' where UrunMalzemeId=@UrunMalzemeId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UrunMalzemeId", urunMalzemeId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    
        public void SiparisDetayInsert(SiparisD siparisD)
        {
            string query = "INSERT INTO Siparis_Detay(SiparisId,UrunMalzemeId,UrunHizmetId,Miktar,Tutar,BirimFiyati,Birim,KurId,KurDegeri,SatirTipi,KdvOrani,KdvToplamTutari,AraToplam,IndirimOrani,IndirimKazanci,Toplam)" +
                " VALUES (@SiparisId,@UrunMalzemeId,@UrunHizmetId,@Miktar,@Tutar,@BirimFiyati,@Birim,@KurId,@KurDegeri,@SatirTipi,@KdvOrani,@KdvToplamTutari,@AraToplam,@IndirimOrani,@IndirimKazanci,@Toplam)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisD.SiparisId);
            if (siparisD.UrunMalzemeId==null)
            {
                command.Parameters.AddWithValue("@UrunMalzemeId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunMalzemeId", siparisD.UrunMalzemeId);
            if (siparisD.UrunHizmetId==null)
            {
                command.Parameters.AddWithValue("@UrunHizmetId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunHizmetId", siparisD.UrunHizmetId);
      
            command.Parameters.AddWithValue("@Miktar", siparisD.Miktar);
            command.Parameters.AddWithValue("@Tutar", siparisD.Tutar);
            command.Parameters.AddWithValue("@BirimFiyati", siparisD.BirimFiyati);
            command.Parameters.AddWithValue("@Birim", siparisD.Birim);
            command.Parameters.AddWithValue("@KurId", siparisD.KurId);
            command.Parameters.AddWithValue("@KurDegeri", siparisD.KurDegeri);
            command.Parameters.AddWithValue("@SatirTipi", siparisD.SatirTipi);
            command.Parameters.AddWithValue("@KdvOrani", siparisD.KdvOrani);
            command.Parameters.AddWithValue("@KdvToplamTutari", siparisD.KdvToplamTutari);
            command.Parameters.AddWithValue("@AraToplam", siparisD.AraToplam);
            command.Parameters.AddWithValue("@IndirimOrani", siparisD.IndirimOrani);
            command.Parameters.AddWithValue("@IndirimKazanci", siparisD.IndirimKazanci);
            command.Parameters.AddWithValue("@Toplam", siparisD.Toplam);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SiparisDetayUpdate(SiparisD siparisD)
        {
            string query = "UPDATE Siparis_Detay set UrunMalzemeId = @UrunMalzemeId,UrunHizmetId=@UrunHizmetId, Miktar = @Miktar, Tutar = @Tutar, BirimFiyati = @BirimFiyati, Birim = @Birim, KurId = @KurId,Kurdegeri=@KurDegeri,SatirTipi=@SatirTipi,KdvOrani=@KdvOrani,KdvToplamTutari=@KdvToplamTutari,AraToplam=@AraToplam,IndirimOrani=@IndirimOrani,IndirimKazanci=@IndirimKazanci,Toplam=@Toplam where Siparis_Detay.SiparisDetayId = @SiparisDetayId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisDetayId", siparisD.SiparisDetayId);
            if (siparisD.UrunMalzemeId == null)
            {
                command.Parameters.AddWithValue("@UrunMalzemeId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunMalzemeId", siparisD.UrunMalzemeId);
            if (siparisD.UrunHizmetId == null)
            {
                command.Parameters.AddWithValue("@UrunHizmetId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunHizmetId", siparisD.UrunHizmetId);

            command.Parameters.AddWithValue("@Miktar", siparisD.Miktar);
            command.Parameters.AddWithValue("@Tutar", siparisD.Tutar);
            command.Parameters.AddWithValue("@BirimFiyati", siparisD.BirimFiyati);
            command.Parameters.AddWithValue("@Birim", siparisD.Birim);
            command.Parameters.AddWithValue("@KurId", siparisD.KurId);
            command.Parameters.AddWithValue("@KurDegeri", siparisD.KurDegeri);
            command.Parameters.AddWithValue("@SatirTipi", siparisD.SatirTipi);
            command.Parameters.AddWithValue("@KdvOrani", siparisD.KdvOrani);
            command.Parameters.AddWithValue("@KdvToplamTutari", siparisD.KdvToplamTutari);
            command.Parameters.AddWithValue("@AraToplam", siparisD.AraToplam);
            command.Parameters.AddWithValue("@IndirimOrani", siparisD.IndirimOrani);
            command.Parameters.AddWithValue("@IndirimKazanci", siparisD.IndirimKazanci);
            command.Parameters.AddWithValue("@Toplam", siparisD.Toplam);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SiparisDetayDelete(int siparisDetayId)
        {
            string query = "delete from Siparis_Detay where SiparisDetayId = @SiparisDetayId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisDetayId", siparisDetayId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
  
    }
}
