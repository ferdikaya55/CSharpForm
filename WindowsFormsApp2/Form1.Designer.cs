
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMusteriler = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdresi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSiparisler = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiparisId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnSiparisListele = new System.Windows.Forms.Button();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.txtSiparisMusteriId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewSiparisListesi = new System.Windows.Forms.DataGridView();
            this.groupBoxUrunler = new System.Windows.Forms.GroupBox();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrunAdeti = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisListesi)).BeginInit();
            this.groupBoxUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMusteriler
            // 
            this.groupBoxMusteriler.Controls.Add(this.dataGridView1);
            this.groupBoxMusteriler.Controls.Add(this.btnMusteriListele);
            this.groupBoxMusteriler.Controls.Add(this.txtMusteriId);
            this.groupBoxMusteriler.Controls.Add(this.label4);
            this.groupBoxMusteriler.Controls.Add(this.btnGuncelle);
            this.groupBoxMusteriler.Controls.Add(this.btnSil);
            this.groupBoxMusteriler.Controls.Add(this.btnEkle);
            this.groupBoxMusteriler.Controls.Add(this.txtAdresi);
            this.groupBoxMusteriler.Controls.Add(this.txtTelefon);
            this.groupBoxMusteriler.Controls.Add(this.txtMusteriAdi);
            this.groupBoxMusteriler.Controls.Add(this.label3);
            this.groupBoxMusteriler.Controls.Add(this.label2);
            this.groupBoxMusteriler.Controls.Add(this.label1);
            this.groupBoxMusteriler.Location = new System.Drawing.Point(23, 2);
            this.groupBoxMusteriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusteriler.Name = "groupBoxMusteriler";
            this.groupBoxMusteriler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusteriler.Size = new System.Drawing.Size(1048, 251);
            this.groupBoxMusteriler.TabIndex = 0;
            this.groupBoxMusteriler.TabStop = false;
            this.groupBoxMusteriler.Text = "Müşteriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(632, 194);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListele.Location = new System.Drawing.Point(280, 158);
            this.btnMusteriListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(105, 32);
            this.btnMusteriListele.TabIndex = 29;
            this.btnMusteriListele.Text = "Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click_1);
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Enabled = false;
            this.txtMusteriId.Location = new System.Drawing.Point(129, 53);
            this.txtMusteriId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriId.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Müşteri Id";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(280, 116);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 34);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(280, 78);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 32);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(280, 41);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 31);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // txtAdresi
            // 
            this.txtAdresi.Location = new System.Drawing.Point(129, 118);
            this.txtAdresi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdresi.Name = "txtAdresi";
            this.txtAdresi.Size = new System.Drawing.Size(100, 22);
            this.txtAdresi.TabIndex = 23;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 148);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 22;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(129, 86);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriAdi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Müşteri Adı";
            // 
            // groupBoxSiparisler
            // 
            this.groupBoxSiparisler.Controls.Add(this.dateTimePicker1);
            this.groupBoxSiparisler.Controls.Add(this.txtFiyat);
            this.groupBoxSiparisler.Controls.Add(this.label6);
            this.groupBoxSiparisler.Controls.Add(this.txtAdet);
            this.groupBoxSiparisler.Controls.Add(this.label5);
            this.groupBoxSiparisler.Controls.Add(this.txtSiparisId);
            this.groupBoxSiparisler.Controls.Add(this.label7);
            this.groupBoxSiparisler.Controls.Add(this.btnSiparisGuncelle);
            this.groupBoxSiparisler.Controls.Add(this.btnSiparisSil);
            this.groupBoxSiparisler.Controls.Add(this.btnSiparisListele);
            this.groupBoxSiparisler.Controls.Add(this.txtSiparisNo);
            this.groupBoxSiparisler.Controls.Add(this.txtSiparisMusteriId);
            this.groupBoxSiparisler.Controls.Add(this.label8);
            this.groupBoxSiparisler.Controls.Add(this.label9);
            this.groupBoxSiparisler.Controls.Add(this.label10);
            this.groupBoxSiparisler.Controls.Add(this.dataGridViewSiparisListesi);
            this.groupBoxSiparisler.Location = new System.Drawing.Point(23, 476);
            this.groupBoxSiparisler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSiparisler.Name = "groupBoxSiparisler";
            this.groupBoxSiparisler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSiparisler.Size = new System.Drawing.Size(1043, 290);
            this.groupBoxSiparisler.TabIndex = 1;
            this.groupBoxSiparisler.TabStop = false;
            this.groupBoxSiparisler.Text = "Siparişler";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 145);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(139, 204);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fiyat";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(139, 174);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 22);
            this.txtAdet.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Adet";
            // 
            // txtSiparisId
            // 
            this.txtSiparisId.Enabled = false;
            this.txtSiparisId.Location = new System.Drawing.Point(139, 62);
            this.txtSiparisId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiparisId.Name = "txtSiparisId";
            this.txtSiparisId.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisId.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sipariş Id";
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(295, 206);
            this.btnSiparisGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(96, 31);
            this.btnSiparisGuncelle.TabIndex = 37;
            this.btnSiparisGuncelle.Text = "Güncelle";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = true;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Location = new System.Drawing.Point(295, 176);
            this.btnSiparisSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(96, 23);
            this.btnSiparisSil.TabIndex = 36;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisListele
            // 
            this.btnSiparisListele.Location = new System.Drawing.Point(295, 142);
            this.btnSiparisListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisListele.Name = "btnSiparisListele";
            this.btnSiparisListele.Size = new System.Drawing.Size(96, 28);
            this.btnSiparisListele.TabIndex = 35;
            this.btnSiparisListele.Text = "Listele";
            this.btnSiparisListele.UseVisualStyleBackColor = true;
            this.btnSiparisListele.Click += new System.EventHandler(this.btnSiparisListele_Click);
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Enabled = false;
            this.txtSiparisNo.Location = new System.Drawing.Point(139, 116);
            this.txtSiparisNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisNo.TabIndex = 34;
            // 
            // txtSiparisMusteriId
            // 
            this.txtSiparisMusteriId.Location = new System.Drawing.Point(139, 89);
            this.txtSiparisMusteriId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiparisMusteriId.Name = "txtSiparisMusteriId";
            this.txtSiparisMusteriId.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisMusteriId.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sipariş No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sipariş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Müşteri Id";
            // 
            // dataGridViewSiparisListesi
            // 
            this.dataGridViewSiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisListesi.Location = new System.Drawing.Point(411, 11);
            this.dataGridViewSiparisListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSiparisListesi.Name = "dataGridViewSiparisListesi";
            this.dataGridViewSiparisListesi.RowHeadersWidth = 51;
            this.dataGridViewSiparisListesi.RowTemplate.Height = 24;
            this.dataGridViewSiparisListesi.Size = new System.Drawing.Size(627, 274);
            this.dataGridViewSiparisListesi.TabIndex = 0;
            this.dataGridViewSiparisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparisListesi_CellClick);
            this.dataGridViewSiparisListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparisListesi_CellEnter);
            // 
            // groupBoxUrunler
            // 
            this.groupBoxUrunler.Controls.Add(this.dataGridViewUrunler);
            this.groupBoxUrunler.Controls.Add(this.txtStokMiktari);
            this.groupBoxUrunler.Controls.Add(this.lblStokMiktari);
            this.groupBoxUrunler.Controls.Add(this.btnSatinAl);
            this.groupBoxUrunler.Controls.Add(this.txtUrunId);
            this.groupBoxUrunler.Controls.Add(this.label11);
            this.groupBoxUrunler.Controls.Add(this.txtUrunAdeti);
            this.groupBoxUrunler.Controls.Add(this.lblAdet);
            this.groupBoxUrunler.Controls.Add(this.txtBirimFiyati);
            this.groupBoxUrunler.Controls.Add(this.txtUrunAdi);
            this.groupBoxUrunler.Controls.Add(this.label12);
            this.groupBoxUrunler.Controls.Add(this.label13);
            this.groupBoxUrunler.Controls.Add(this.cmbUrunTipi);
            this.groupBoxUrunler.Controls.Add(this.label14);
            this.groupBoxUrunler.Location = new System.Drawing.Point(23, 258);
            this.groupBoxUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUrunler.Name = "groupBoxUrunler";
            this.groupBoxUrunler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxUrunler.Size = new System.Drawing.Size(1043, 190);
            this.groupBoxUrunler.TabIndex = 2;
            this.groupBoxUrunler.TabStop = false;
            this.groupBoxUrunler.Text = "Ürünler";
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AllowUserToAddRows = false;
            this.dataGridViewUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(437, 14);
            this.dataGridViewUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.RowHeadersWidth = 51;
            this.dataGridViewUrunler.RowTemplate.Height = 24;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(589, 166);
            this.dataGridViewUrunler.TabIndex = 29;
            this.dataGridViewUrunler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellEnter);
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(172, 164);
            this.txtStokMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(149, 22);
            this.txtStokMiktari.TabIndex = 28;
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(65, 162);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(81, 17);
            this.lblStokMiktari.TabIndex = 27;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.Location = new System.Drawing.Point(327, 151);
            this.btnSatinAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(104, 30);
            this.btnSatinAl.TabIndex = 26;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // txtUrunId
            // 
            this.txtUrunId.Enabled = false;
            this.txtUrunId.Location = new System.Drawing.Point(172, 44);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(149, 22);
            this.txtUrunId.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ürün Id";
            // 
            // txtUrunAdeti
            // 
            this.txtUrunAdeti.Location = new System.Drawing.Point(172, 135);
            this.txtUrunAdeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdeti.Name = "txtUrunAdeti";
            this.txtUrunAdeti.Size = new System.Drawing.Size(149, 22);
            this.txtUrunAdeti.TabIndex = 23;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(107, 135);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(37, 17);
            this.lblAdet.TabIndex = 22;
            this.lblAdet.Text = "Adet";
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(172, 106);
            this.txtBirimFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(149, 22);
            this.txtBirimFiyati.TabIndex = 21;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(172, 78);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(149, 22);
            this.txtUrunAdi.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Birim Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ürün Adı";
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Items.AddRange(new object[] {
            "Malzeme",
            "Hizmet"});
            this.cmbUrunTipi.Location = new System.Drawing.Point(172, 14);
            this.cmbUrunTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(149, 24);
            this.cmbUrunTipi.TabIndex = 17;
            this.cmbUrunTipi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunTipi_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Ürün Tipi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 779);
            this.Controls.Add(this.groupBoxUrunler);
            this.Controls.Add(this.groupBoxSiparisler);
            this.Controls.Add(this.groupBoxMusteriler);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMusteriler.ResumeLayout(false);
            this.groupBoxMusteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSiparisler.ResumeLayout(false);
            this.groupBoxSiparisler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisListesi)).EndInit();
            this.groupBoxUrunler.ResumeLayout(false);
            this.groupBoxUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMusteriler;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAdresi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxSiparisler;
        private System.Windows.Forms.DataGridView dataGridViewSiparisListesi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiparisId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnSiparisListele;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.TextBox txtSiparisMusteriId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxUrunler;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUrunAdeti;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewUrunler;
    }
}

