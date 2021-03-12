﻿using System;
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
    public partial class frmSiparisler : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public frmSiparisler()
        {
            InitializeComponent();
        }

        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            GetSiparisler();
        }
        private void GetSiparisler()
        {
            connection = new SqlConnection(@"Data source=DESKTOP-TFKKQ1E\SQLEXPRESS;Initial Catalog=OycDB1;Integrated Security=SSPI");
            connection.Open();
            adapter = new SqlDataAdapter("Select * from Siparisler", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSiparis.DataSource = table;
            connection.Close();
        }

        private void dataGridViewSiparis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSiparisId.Text = dataGridViewSiparis.CurrentRow.Cells[0].Value.ToString();
            txtMusteriId.Text = dataGridViewSiparis.CurrentRow.Cells[1].Value.ToString();
            txtSiparisNo.Text = dataGridViewSiparis.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridViewSiparis.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dataGridViewSiparis.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dataGridViewSiparis.CurrentRow.Cells[5].Value.ToString();


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
          
        }
    }
}
