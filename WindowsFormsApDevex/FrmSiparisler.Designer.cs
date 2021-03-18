
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControlSiparisDetay = new DevExpress.XtraGrid.GridControl();
            this.gridViewSiparislerDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SiparisId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunMalzemeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Birim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParaBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunHizmetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditMusteriler = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
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
            this.gridControlSiparisDetay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            gridLevelNode1.RelationName = "Level1";
            this.gridControlSiparisDetay.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlSiparisDetay.Location = new System.Drawing.Point(18, 160);
            this.gridControlSiparisDetay.MainView = this.gridViewSiparislerDetay;
            this.gridControlSiparisDetay.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSiparisDetay.Name = "gridControlSiparisDetay";
            this.gridControlSiparisDetay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControlSiparisDetay.Size = new System.Drawing.Size(599, 202);
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
            this.UrunMalzemeId,
            this.Birim,
            this.BirimFiyati,
            this.Miktar,
            this.ParaBirimi,
            this.Tutar,
            this.urunAdi,
            this.UrunHizmetId});
            this.gridViewSiparislerDetay.DetailHeight = 284;
            this.gridViewSiparislerDetay.GridControl = this.gridControlSiparisDetay;
            this.gridViewSiparislerDetay.Name = "gridViewSiparislerDetay";
            this.gridViewSiparislerDetay.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewSiparislerDetay.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView1_InitNewRow);
            this.gridViewSiparislerDetay.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSiparislerDetay_CellValueChanged);
            // 
            // SiparisId
            // 
            this.SiparisId.Caption = "Sipariş Id";
            this.SiparisId.FieldName = "SiparisId";
            this.SiparisId.MinWidth = 15;
            this.SiparisId.Name = "SiparisId";
            this.SiparisId.Visible = true;
            this.SiparisId.VisibleIndex = 0;
            this.SiparisId.Width = 56;
            // 
            // UrunMalzemeId
            // 
            this.UrunMalzemeId.Caption = "Urun Malzeme Id";
            this.UrunMalzemeId.ColumnEdit = this.repositoryItemButtonEdit1;
            this.UrunMalzemeId.FieldName = "UrunMalzemeId";
            this.UrunMalzemeId.MinWidth = 15;
            this.UrunMalzemeId.Name = "UrunMalzemeId";
            this.UrunMalzemeId.Visible = true;
            this.UrunMalzemeId.VisibleIndex = 1;
            this.UrunMalzemeId.Width = 56;
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
            this.Birim.Caption = "Birim";
            this.Birim.FieldName = "Birim";
            this.Birim.MinWidth = 15;
            this.Birim.Name = "Birim";
            this.Birim.Visible = true;
            this.Birim.VisibleIndex = 4;
            this.Birim.Width = 56;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Caption = "Birim Fiyatı";
            this.BirimFiyati.FieldName = "BirimFiyati";
            this.BirimFiyati.MinWidth = 15;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Visible = true;
            this.BirimFiyati.VisibleIndex = 5;
            this.BirimFiyati.Width = 56;
            // 
            // Miktar
            // 
            this.Miktar.Caption = "Miktar";
            this.Miktar.FieldName = "Miktar";
            this.Miktar.MinWidth = 15;
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 6;
            this.Miktar.Width = 56;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.Caption = "Para Birimi";
            this.ParaBirimi.FieldName = "ParaBirimi";
            this.ParaBirimi.MinWidth = 15;
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.Visible = true;
            this.ParaBirimi.VisibleIndex = 7;
            this.ParaBirimi.Width = 56;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "Tutar";
            this.Tutar.MinWidth = 15;
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 8;
            this.Tutar.Width = 56;
            // 
            // urunAdi
            // 
            this.urunAdi.Caption = "UrunAdi";
            this.urunAdi.FieldName = "UrunAdi";
            this.urunAdi.MinWidth = 19;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Visible = true;
            this.urunAdi.VisibleIndex = 3;
            this.urunAdi.Width = 70;
            // 
            // UrunHizmetId
            // 
            this.UrunHizmetId.Caption = "Urun Hizmet Id";
            this.UrunHizmetId.FieldName = "UrunHizmetId";
            this.UrunHizmetId.Name = "UrunHizmetId";
            this.UrunHizmetId.Visible = true;
            this.UrunHizmetId.VisibleIndex = 2;
            // 
            // btnEditMusteriler
            // 
            this.btnEditMusteriler.EditValue = "Müşteriler";
            this.btnEditMusteriler.Location = new System.Drawing.Point(94, 10);
            this.btnEditMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMusteriler.Name = "btnEditMusteriler";
            this.btnEditMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditMusteriler.Properties.ReadOnly = true;
            this.btnEditMusteriler.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditMusteriler_Properties_ButtonClick);
            this.btnEditMusteriler.Size = new System.Drawing.Size(151, 20);
            this.btnEditMusteriler.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 41);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sipariş No";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 62);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sipariş Tarihi";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(94, 38);
            this.txtSiparisNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(75, 20);
            this.txtSiparisNo.TabIndex = 5;
            // 
            // dateEditSiparisTarihi
            // 
            this.dateEditSiparisTarihi.EditValue = null;
            this.dateEditSiparisTarihi.Location = new System.Drawing.Point(94, 59);
            this.dateEditSiparisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dateEditSiparisTarihi.Name = "dateEditSiparisTarihi";
            this.dateEditSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Size = new System.Drawing.Size(75, 20);
            this.dateEditSiparisTarihi.TabIndex = 8;
            // 
            // btnSiparisDetayKaydet
            // 
            this.btnSiparisDetayKaydet.Location = new System.Drawing.Point(561, 383);
            this.btnSiparisDetayKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisDetayKaydet.Name = "btnSiparisDetayKaydet";
            this.btnSiparisDetayKaydet.Size = new System.Drawing.Size(56, 19);
            this.btnSiparisDetayKaydet.TabIndex = 9;
            this.btnSiparisDetayKaydet.Text = "Kaydet";
            this.btnSiparisDetayKaydet.Click += new System.EventHandler(this.btnSiparisDetayKaydet_Click);
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.btnSiparisDetayKaydet);
            this.Controls.Add(this.dateEditSiparisTarihi);
            this.Controls.Add(this.txtSiparisNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnEditMusteriler);
            this.Controls.Add(this.gridControlSiparisDetay);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private DevExpress.XtraEditors.DateEdit dateEditSiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisId;
        private DevExpress.XtraGrid.Columns.GridColumn UrunMalzemeId;
        private DevExpress.XtraGrid.Columns.GridColumn Birim;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn ParaBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraEditors.SimpleButton btnSiparisDetayKaydet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn urunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn UrunHizmetId;
    }
}