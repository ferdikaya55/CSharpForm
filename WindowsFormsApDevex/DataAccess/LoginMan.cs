using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApDevex.DataAccess
{
    public class LoginMan
    {
        SqlConnection connection = new SqlConnection(@"Data source=.\MSSQLSERVERDEV;Initial Catalog=OycDB1;Integrated Security=SSPI");
        SqlCommand command;
        SqlDataReader reader;
        bool kontrol = false;
        public string yetki;
        public bool Login(string kullaniciAdi,string sifre)
        {
            connection.Open();
            command = new SqlCommand("select * from Kullanicilar where KullaniciAdi='"+kullaniciAdi+"' and Sifre='"+sifre+"'", connection);
            
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                kontrol = true;
                yetki = reader["Yetki"].ToString();
            }
            connection.Close();
            if (kontrol == true)
            {
                
                //FrmAna frmAna = new FrmAna(yetki);
                //frmAna.ShowDialog();
                return kontrol; 
            }
            else  return kontrol;
        }
    }
}
