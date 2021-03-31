
namespace WindowsFormsApDevex
{
    partial class FrmSiparisler
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
            this.components = new System.ComponentModel.Container();
            this.gridControlSiparisler = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİPARİŞSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİPARİŞDÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewSiparisler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MusteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriAdresi = new DevExpress.XtraEditors.MemoEdit();
            this.txtSiparisId = new DevExpress.XtraEditors.TextEdit();
            this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
            this.txtSiparisTarihi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriTelefonu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSiparisGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.yAZDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSiparisler
            // 
            this.gridControlSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControlSiparisler.Location = new System.Drawing.Point(12, 236);
            this.gridControlSiparisler.MainView = this.gridViewSiparisler;
            this.gridControlSiparisler.Name = "gridControlSiparisler";
            this.gridControlSiparisler.Size = new System.Drawing.Size(698, 348);
            this.gridControlSiparisler.TabIndex = 0;
            this.gridControlSiparisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSiparisler});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİPARİŞSİLToolStripMenuItem,
            this.sİPARİŞDÜZENLEToolStripMenuItem,
            this.yAZDIRToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 70);
            // 
            // sİPARİŞSİLToolStripMenuItem
            // 
            this.sİPARİŞSİLToolStripMenuItem.Name = "sİPARİŞSİLToolStripMenuItem";
            this.sİPARİŞSİLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sİPARİŞSİLToolStripMenuItem.Text = "SİPARİŞ SİL";
            this.sİPARİŞSİLToolStripMenuItem.Click += new System.EventHandler(this.sİPARİŞSİLToolStripMenuItem_Click);
            // 
            // sİPARİŞDÜZENLEToolStripMenuItem
            // 
            this.sİPARİŞDÜZENLEToolStripMenuItem.Name = "sİPARİŞDÜZENLEToolStripMenuItem";
            this.sİPARİŞDÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sİPARİŞDÜZENLEToolStripMenuItem.Text = "SİPARİŞ DÜZENLE";
            this.sİPARİŞDÜZENLEToolStripMenuItem.Click += new System.EventHandler(this.sİPARİŞDÜZENLEToolStripMenuItem_Click);
            // 
            // gridViewSiparisler
            // 
            this.gridViewSiparisler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MusteriAd,
            this.SiparisNo,
            this.SiparisTarihi,
            this.Adres,
            this.Telefon,
            this.SiparisId});
            this.gridViewSiparisler.GridControl = this.gridControlSiparisler;
            this.gridViewSiparisler.Name = "gridViewSiparisler";
            this.gridViewSiparisler.OptionsBehavior.Editable = false;
            this.gridViewSiparisler.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewSiparisler.OptionsView.ShowGroupPanel = false;
            this.gridViewSiparisler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSiparisler_FocusedRowChanged);
            this.gridViewSiparisler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSiparisler_KeyDown);
            // 
            // MusteriAd
            // 
            this.MusteriAd.Caption = "MÜŞTERİ ADI";
            this.MusteriAd.FieldName = "MusteriAd";
            this.MusteriAd.MinWidth = 25;
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.OptionsColumn.AllowEdit = false;
            this.MusteriAd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MusteriAd", "{0}")});
            this.MusteriAd.Visible = true;
            this.MusteriAd.VisibleIndex = 0;
            this.MusteriAd.Width = 146;
            // 
            // SiparisNo
            // 
            this.SiparisNo.Caption = "SİPARİŞ NO";
            this.SiparisNo.FieldName = "SiparisNo";
            this.SiparisNo.MinWidth = 25;
            this.SiparisNo.Name = "SiparisNo";
            this.SiparisNo.OptionsColumn.AllowEdit = false;
            this.SiparisNo.Visible = true;
            this.SiparisNo.VisibleIndex = 1;
            this.SiparisNo.Width = 155;
            // 
            // SiparisTarihi
            // 
            this.SiparisTarihi.Caption = "SİPARİŞ TARİHİ";
            this.SiparisTarihi.FieldName = "SiparisTarihi";
            this.SiparisTarihi.MinWidth = 25;
            this.SiparisTarihi.Name = "SiparisTarihi";
            this.SiparisTarihi.OptionsColumn.AllowEdit = false;
            this.SiparisTarihi.Visible = true;
            this.SiparisTarihi.VisibleIndex = 2;
            this.SiparisTarihi.Width = 155;
            // 
            // Adres
            // 
            this.Adres.Caption = "ADRES";
            this.Adres.FieldName = "Adres";
            this.Adres.MinWidth = 25;
            this.Adres.Name = "Adres";
            this.Adres.OptionsColumn.AllowEdit = false;
            this.Adres.Visible = true;
            this.Adres.VisibleIndex = 3;
            this.Adres.Width = 173;
            // 
            // Telefon
            // 
            this.Telefon.Caption = "TELEFON";
            this.Telefon.FieldName = "Telefon";
            this.Telefon.MinWidth = 25;
            this.Telefon.Name = "Telefon";
            this.Telefon.OptionsColumn.AllowEdit = false;
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 4;
            this.Telefon.Width = 149;
            // 
            // SiparisId
            // 
            this.SiparisId.Caption = "SİPARİŞ ID";
            this.SiparisId.FieldName = "SiparisId";
            this.SiparisId.MinWidth = 25;
            this.SiparisId.Name = "SiparisId";
            this.SiparisId.OptionsColumn.AllowEdit = false;
            this.SiparisId.Width = 90;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 21;
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.Location = new System.Drawing.Point(458, 120);
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Properties.BeepOnError = false;
            this.txtMusteriAdresi.Size = new System.Drawing.Size(193, 37);
            this.txtMusteriAdresi.TabIndex = 19;
            // 
            // txtSiparisId
            // 
            this.txtSiparisId.Location = new System.Drawing.Point(110, 32);
            this.txtSiparisId.Name = "txtSiparisId";
            this.txtSiparisId.Size = new System.Drawing.Size(193, 20);
            this.txtSiparisId.TabIndex = 15;
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(110, 77);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(193, 20);
            this.txtSiparisNo.TabIndex = 16;
            // 
            // txtSiparisTarihi
            // 
            this.txtSiparisTarihi.Location = new System.Drawing.Point(110, 120);
            this.txtSiparisTarihi.Name = "txtSiparisTarihi";
            this.txtSiparisTarihi.Size = new System.Drawing.Size(193, 20);
            this.txtSiparisTarihi.TabIndex = 17;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(458, 35);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Properties.BeepOnError = false;
            this.txtMusteriAdi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriAdi.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriAdi.Properties.MaskSettings.Set("mask", "[a-zA-Z]+");
            this.txtMusteriAdi.Size = new System.Drawing.Size(193, 20);
            this.txtMusteriAdi.TabIndex = 18;
            // 
            // txtMusteriTelefonu
            // 
            this.txtMusteriTelefonu.Location = new System.Drawing.Point(458, 74);
            this.txtMusteriTelefonu.Name = "txtMusteriTelefonu";
            this.txtMusteriTelefonu.Properties.BeepOnError = false;
            this.txtMusteriTelefonu.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriTelefonu.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriTelefonu.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.txtMusteriTelefonu.Size = new System.Drawing.Size(193, 20);
            this.txtMusteriTelefonu.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 12);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Sipariş Id";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 12);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Sipariş No";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 12);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Sipariş Tarihi";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(334, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 12);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Müşteri Adı";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(334, 126);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 12);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Müşteri Adresi";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(334, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 12);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Müşteri Telefonu";
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSiparisGuncelle.Appearance.Options.UseFont = true;
            this.btnSiparisGuncelle.Appearance.Options.UseTextOptions = true;
            this.btnSiparisGuncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSiparisGuncelle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x163;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(577, 173);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(74, 24);
            this.btnSiparisGuncelle.TabIndex = 28;
            this.btnSiparisGuncelle.Text = "Kaydet";
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // yAZDIRToolStripMenuItem
            // 
            this.yAZDIRToolStripMenuItem.Name = "yAZDIRToolStripMenuItem";
            this.yAZDIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yAZDIRToolStripMenuItem.Text = "YAZDIR";
            this.yAZDIRToolStripMenuItem.Click += new System.EventHandler(this.yAZDIRToolStripMenuItem_Click);
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 596);
            this.Controls.Add(this.btnSiparisGuncelle);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMusteriTelefonu);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.txtSiparisTarihi);
            this.Controls.Add(this.txtSiparisNo);
            this.Controls.Add(this.txtSiparisId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlSiparisler);
            this.Controls.Add(this.txtMusteriAdresi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSiparisler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSiparisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSiparisler;
        private DevExpress.XtraGrid.Columns.GridColumn MusteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Adres;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİPARİŞSİLToolStripMenuItem;
        private DevExpress.XtraEditors.MemoEdit txtMusteriAdresi;
        private DevExpress.XtraEditors.TextEdit txtSiparisId;
        private DevExpress.XtraEditors.TextEdit txtSiparisNo;
        private DevExpress.XtraEditors.TextEdit txtSiparisTarihi;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private DevExpress.XtraEditors.TextEdit txtMusteriTelefonu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSiparisGuncelle;
        private System.Windows.Forms.ToolStripMenuItem sİPARİŞDÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZDIRToolStripMenuItem;
    }
}