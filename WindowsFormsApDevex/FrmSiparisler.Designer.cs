
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
            this.gridControlSiparisDetay = new DevExpress.XtraGrid.GridControl();
            this.gridViewSiparislerDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SiparisId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Birim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParaBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditMusteriler = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
            this.btnSiparisKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditSiparisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnSiparisDetayKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparislerDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMusteriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSiparisDetay
            // 
            this.gridControlSiparisDetay.Location = new System.Drawing.Point(24, 197);
            this.gridControlSiparisDetay.MainView = this.gridViewSiparislerDetay;
            this.gridControlSiparisDetay.Name = "gridControlSiparisDetay";
            this.gridControlSiparisDetay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControlSiparisDetay.Size = new System.Drawing.Size(799, 249);
            this.gridControlSiparisDetay.TabIndex = 0;
            this.gridControlSiparisDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSiparislerDetay});
            this.gridControlSiparisDetay.Click += new System.EventHandler(this.gridControlSiparisDetay_Click);
            // 
            // gridViewSiparislerDetay
            // 
            this.gridViewSiparislerDetay.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSiparislerDetay.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSiparislerDetay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SiparisId,
            this.UrunId,
            this.Birim,
            this.BirimFiyati,
            this.Miktar,
            this.ParaBirimi,
            this.Tutar,
            this.urunAdi});
            this.gridViewSiparislerDetay.GridControl = this.gridControlSiparisDetay;
            this.gridViewSiparislerDetay.Name = "gridViewSiparislerDetay";
            this.gridViewSiparislerDetay.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // SiparisId
            // 
            this.SiparisId.Caption = "Sipariş Id";
            this.SiparisId.FieldName = "SiparisId";
            this.SiparisId.Name = "SiparisId";
            this.SiparisId.Visible = true;
            this.SiparisId.VisibleIndex = 0;
            // 
            // UrunId
            // 
            this.UrunId.Caption = "Ürün Id";
            this.UrunId.ColumnEdit = this.repositoryItemButtonEdit1;
            this.UrunId.FieldName = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = true;
            this.UrunId.VisibleIndex = 1;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // Birim
            // 
            this.Birim.Caption = "Birimi";
            this.Birim.FieldName = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.Visible = true;
            this.Birim.VisibleIndex = 3;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Caption = "Birim Fiyatı";
            this.BirimFiyati.FieldName = "BirimFiyati";
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Visible = true;
            this.BirimFiyati.VisibleIndex = 4;
            // 
            // Miktar
            // 
            this.Miktar.Caption = "Miktarı";
            this.Miktar.FieldName = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 5;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.Caption = "Para Birimi";
            this.ParaBirimi.FieldName = "ParaBirimi";
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.Visible = true;
            this.ParaBirimi.VisibleIndex = 6;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutarı";
            this.Tutar.FieldName = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 7;
            // 
            // urunAdi
            // 
            this.urunAdi.Caption = "Ürün Adı";
            this.urunAdi.FieldName = "UrunAdi";
            this.urunAdi.MinWidth = 25;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Visible = true;
            this.urunAdi.VisibleIndex = 2;
            this.urunAdi.Width = 94;
            // 
            // btnEditMusteriler
            // 
            this.btnEditMusteriler.EditValue = "Müşteriler";
            this.btnEditMusteriler.Location = new System.Drawing.Point(125, 12);
            this.btnEditMusteriler.Name = "btnEditMusteriler";
            this.btnEditMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditMusteriler.Properties.ReadOnly = true;
            this.btnEditMusteriler.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditMusteriler_Properties_ButtonClick);
            this.btnEditMusteriler.Size = new System.Drawing.Size(201, 22);
            this.btnEditMusteriler.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sipariş No";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sipariş Tarihi";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(125, 47);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisNo.TabIndex = 5;
            // 
            // btnSiparisKaydet
            // 
            this.btnSiparisKaydet.Location = new System.Drawing.Point(150, 115);
            this.btnSiparisKaydet.Name = "btnSiparisKaydet";
            this.btnSiparisKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisKaydet.TabIndex = 7;
            this.btnSiparisKaydet.Text = "Kaydet";
            this.btnSiparisKaydet.Click += new System.EventHandler(this.btnSiparisKaydet_Click_1);
            // 
            // dateEditSiparisTarihi
            // 
            this.dateEditSiparisTarihi.EditValue = null;
            this.dateEditSiparisTarihi.Location = new System.Drawing.Point(125, 73);
            this.dateEditSiparisTarihi.Name = "dateEditSiparisTarihi";
            this.dateEditSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Size = new System.Drawing.Size(100, 22);
            this.dateEditSiparisTarihi.TabIndex = 8;
            // 
            // btnSiparisDetayKaydet
            // 
            this.btnSiparisDetayKaydet.Location = new System.Drawing.Point(748, 471);
            this.btnSiparisDetayKaydet.Name = "btnSiparisDetayKaydet";
            this.btnSiparisDetayKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisDetayKaydet.TabIndex = 9;
            this.btnSiparisDetayKaydet.Text = "Kaydet";
            this.btnSiparisDetayKaydet.Click += new System.EventHandler(this.btnSiparisDetayKaydet_Click);
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 506);
            this.Controls.Add(this.btnSiparisDetayKaydet);
            this.Controls.Add(this.dateEditSiparisTarihi);
            this.Controls.Add(this.btnSiparisKaydet);
            this.Controls.Add(this.txtSiparisNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnEditMusteriler);
            this.Controls.Add(this.gridControlSiparisDetay);
            this.Name = "FrmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.frmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparislerDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMusteriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSiparisDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSiparislerDetay;
        private DevExpress.XtraEditors.ButtonEdit btnEditMusteriler;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSiparisNo;
        private DevExpress.XtraEditors.SimpleButton btnSiparisKaydet;
        private DevExpress.XtraEditors.DateEdit dateEditSiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisId;
        private DevExpress.XtraGrid.Columns.GridColumn UrunId;
        private DevExpress.XtraGrid.Columns.GridColumn Birim;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn ParaBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraEditors.SimpleButton btnSiparisDetayKaydet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn urunAdi;
    }
}