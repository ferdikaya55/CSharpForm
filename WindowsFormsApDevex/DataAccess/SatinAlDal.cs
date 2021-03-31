﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApDevex
{
    public class SatinAlDal
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter;
        public int SiparisInsert(int musteriId,int siparisNo, DateTime siparisTarihi)
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
        public DataTable GetDataTableDetay(int siparisId)
        {
            connection.Open();
            adapter = new SqlDataAdapter();
            string query = "select SiparisDetayId,SiparisId,(Case SatirTipi when 'Malzeme' then(select UrunAdi from Urun_Malzeme where sd.UrunMalzemeId = UrunMalzemeId) " +
                            "when 'Hizmet' then(select UrunAdi from Urun_Hizmet where sd.UrunHizmetId = UrunHizmetId)end) " +
                             "as UrunAdi,SatirTipi,uh.UrunHizmetId,um.UrunMalzemeId,sd.BirimFiyati,Tutar,sd.Miktar,Birim,ParaBirimi from Siparis_Detay sd " +
                             "left join Urun_Malzeme um on sd.UrunMalzemeId = um.UrunMalzemeId " +
                             "left join Urun_Hizmet uh on sd.UrunHizmetId = uh.UrunHizmetId where SiparisId = @SiparisId; ";
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
            string query = "select m.MusteriId,m.MusteriAd,m.Adres,m.Telefon,s.SiparisNo,s.SiparisTarihi from Siparisler s left join Musteriler m on s.MusteriId = m.MusteriId where SiparisId = @id";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = command;
            connection.Open();

            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            return table.Rows[0];
        }

        public int GetSiparisNo()
        {
            string query = "select top 1 SiparisNo from Siparisler order by SiparisNo desc";
            command = new SqlCommand(query, connection);
            connection.Open();
            int siparisNo = 0;
            object oResult = command.ExecuteScalar();
            if (oResult!=null)
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
    
        public void SiparisDetayInsert(int siparisId,int? urunId,int? urunhizmetId, double miktar,double birimFiyati,double tutar, string birim, string paraBirimi,string satirTipi)
        {
            string query = "INSERT INTO Siparis_Detay(SiparisId,UrunMalzemeId,UrunHizmetId,Miktar,Tutar,BirimFiyati,Birim,ParaBirimi,SatirTipi) VALUES (@SiparisId,@UrunMalzemeId,@UrunHizmetId,@Miktar,@Tutar,@BirimFiyati,@Birim,@ParaBirimi,@SatirTipi)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            if (urunId == null)
            {
                command.Parameters.AddWithValue("@UrunMalzemeId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunMalzemeId", urunId);
            if (urunhizmetId==null)
            {
                command.Parameters.AddWithValue("@UrunHizmetId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunHizmetId", urunhizmetId);
      
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.Parameters.AddWithValue("@Tutar", tutar);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@Birim", birim);
            command.Parameters.AddWithValue("@ParaBirimi", paraBirimi);
            command.Parameters.AddWithValue("@SatirTipi", satirTipi);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SiparisDetayUpdate(int siparisDetayId, int? urunId,int? urunHizmetId, string birim, double miktar, double birimFiyati, string paraBirimi, double tutar,string satirTipi)
        {
            string query = "UPDATE Siparis_Detay set UrunMalzemeId = @UrunMalzemeId,UrunHizmetId=@UrunHizmetId, Miktar = @Miktar, Tutar = @Tutar, BirimFiyati = @BirimFiyati, Birim = @Birim, ParaBirimi = @ParaBirimi,SatirTipi=@SatirTipi where Siparis_Detay.SiparisDetayId = @SiparisDetayId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisDetayId", siparisDetayId);
            if (urunId == null)
            {
                command.Parameters.AddWithValue("@UrunMalzemeId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunMalzemeId", urunId);
            if (urunHizmetId == null)
            {
                command.Parameters.AddWithValue("@UrunHizmetId", DBNull.Value);
            }
            else command.Parameters.AddWithValue("@UrunHizmetId", urunHizmetId);
           
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.Parameters.AddWithValue("@Tutar", tutar);
            command.Parameters.AddWithValue("@BirimFiyati", birimFiyati);
            command.Parameters.AddWithValue("@Birim", birim);
            command.Parameters.AddWithValue("@ParaBirimi", paraBirimi);
            command.Parameters.AddWithValue("@SatirTipi", satirTipi);

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
        public void SiparisUpdate(int siparisId,int musteriId, int siparisNo, DateTime siparisTarihi)
        {
            string query = "Update Siparisler set MusteriId=@MusteriId,SiparisNo=@SiparisNo,SiparisTarihi=@SiparisTarihi where SiparisId=@SiparisId";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SiparisId", siparisId);
            command.Parameters.AddWithValue("@MusteriId", musteriId);
            command.Parameters.AddWithValue("@SiparisNo", siparisNo);
            command.Parameters.AddWithValue("@SiparisTarihi", siparisTarihi);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}