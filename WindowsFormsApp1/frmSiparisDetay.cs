using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class SiparisDetay : Form
    {
        SqlConnection connection= new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
         
        public SiparisDetay()
        {
            InitializeComponent();
        }

        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            GetSiparisDetay();
        }
        private void GetSiparisDetay()
        {
            
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select UrunAdi,BirimFiyati,Adet,Tutar from Siparis_Detay sd inner join Urun_Malzeme um on sd.UrunId = um.UrunMalzemeId ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSiparisDetay.DataSource = table;
            connection.Close();
        }
    }
}
