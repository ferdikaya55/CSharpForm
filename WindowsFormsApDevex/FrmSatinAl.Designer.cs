
namespace WindowsFormsApDevex
{
    partial class FrmSatinAl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatinAl));
            this.gridControlSiparisDetay = new DevExpress.XtraGrid.GridControl();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişDetaySilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.urunSecimi = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.UrunHizmetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisDetayId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SatirTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnEditMusteriler = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
            this.dateEditSiparisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnSiparisDetayKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisDetay)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparislerDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSecimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMusteriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSiparisDetay
            // 
            this.gridControlSiparisDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSiparisDetay.ContextMenuStrip = this.ctxMenu;
            this.gridControlSiparisDetay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSiparisDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControlSiparisDetay.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlSiparisDetay.Location = new System.Drawing.Point(6, 136);
            this.gridControlSiparisDetay.MainView = this.gridViewSiparislerDetay;
            this.gridControlSiparisDetay.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlSiparisDetay.Name = "gridControlSiparisDetay";
            this.gridControlSiparisDetay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemComboBox1,
            this.urunSecimi});
            this.gridControlSiparisDetay.Size = new System.Drawing.Size(635, 303);
            this.gridControlSiparisDetay.TabIndex = 0;
            this.gridControlSiparisDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSiparislerDetay});
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişDetaySilToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(157, 26);
            // 
            // siparişDetaySilToolStripMenuItem
            // 
            this.siparişDetaySilToolStripMenuItem.Name = "siparişDetaySilToolStripMenuItem";
            this.siparişDetaySilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.siparişDetaySilToolStripMenuItem.Text = "Sipariş Detay Sil";
            this.siparişDetaySilToolStripMenuItem.Click += new System.EventHandler(this.siparişDetaySilToolStripMenuItem_Click);
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
            this.UrunHizmetId,
            this.SiparisDetayId,
            this.SatirTipi});
            this.gridViewSiparislerDetay.DetailHeight = 284;
            this.gridViewSiparislerDetay.GridControl = this.gridControlSiparisDetay;
            this.gridViewSiparislerDetay.Name = "gridViewSiparislerDetay";
            this.gridViewSiparislerDetay.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewSiparislerDetay.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewSiparislerDetay.OptionsView.ShowFooter = true;
            this.gridViewSiparislerDetay.OptionsView.ShowGroupPanel = false;
            this.gridViewSiparislerDetay.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView1_InitNewRow);
            this.gridViewSiparislerDetay.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSiparislerDetay_CellValueChanged);
            this.gridViewSiparislerDetay.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewSiparislerDetay_ValidateRow);
            // 
            // SiparisId
            // 
            this.SiparisId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SiparisId.AppearanceHeader.Options.UseFont = true;
            this.SiparisId.Caption = "Sipariş Id";
            this.SiparisId.FieldName = "SiparisId";
            this.SiparisId.MinWidth = 15;
            this.SiparisId.Name = "SiparisId";
            this.SiparisId.Width = 56;
            // 
            // UrunMalzemeId
            // 
            this.UrunMalzemeId.Caption = "ÜRÜN ID";
            this.UrunMalzemeId.ColumnEdit = this.repositoryItemButtonEdit1;
            this.UrunMalzemeId.FieldName = "UrunMalzemeId";
            this.UrunMalzemeId.MinWidth = 15;
            this.UrunMalzemeId.Name = "UrunMalzemeId";
            this.UrunMalzemeId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "UrunMalzemeId", "{0}")});
            this.UrunMalzemeId.Width = 60;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AccessibleDescription = "Ürün Seçiniz";
            this.repositoryItemButtonEdit1.AccessibleName = "";
            this.repositoryItemButtonEdit1.AdvancedModeOptions.Label = "ÜRÜN SEÇ";
            this.repositoryItemButtonEdit1.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.repositoryItemButtonEdit1.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.repositoryItemButtonEdit1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.repositoryItemButtonEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.repositoryItemButtonEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemButtonEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "ÜRÜN SEÇ", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // Birim
            // 
            this.Birim.AppearanceCell.Options.UseTextOptions = true;
            this.Birim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Birim.Caption = "BİRİM";
            this.Birim.DisplayFormat.FormatString = "N2";
            this.Birim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Birim.FieldName = "Birim";
            this.Birim.MinWidth = 15;
            this.Birim.Name = "Birim";
            this.Birim.Visible = true;
            this.Birim.VisibleIndex = 2;
            this.Birim.Width = 73;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.AppearanceCell.Options.UseTextOptions = true;
            this.BirimFiyati.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BirimFiyati.Caption = "BİRİM FİYATI";
            this.BirimFiyati.DisplayFormat.FormatString = "N2";
            this.BirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BirimFiyati.FieldName = "BirimFiyati";
            this.BirimFiyati.MinWidth = 15;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Visible = true;
            this.BirimFiyati.VisibleIndex = 3;
            this.BirimFiyati.Width = 84;
            // 
            // Miktar
            // 
            this.Miktar.AppearanceCell.Options.UseTextOptions = true;
            this.Miktar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Miktar.Caption = "MİKTAR";
            this.Miktar.DisplayFormat.FormatString = "N2";
            this.Miktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Miktar.FieldName = "Miktar";
            this.Miktar.MinWidth = 15;
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 4;
            this.Miktar.Width = 84;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.AppearanceCell.Options.UseTextOptions = true;
            this.ParaBirimi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ParaBirimi.Caption = "PARA BİRİMİ";
            this.ParaBirimi.FieldName = "ParaBirimi";
            this.ParaBirimi.MinWidth = 15;
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ParaBirimi", "Toplam={0:0.## }")});
            this.ParaBirimi.Visible = true;
            this.ParaBirimi.VisibleIndex = 6;
            this.ParaBirimi.Width = 104;
            // 
            // Tutar
            // 
            this.Tutar.AppearanceCell.Options.UseTextOptions = true;
            this.Tutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Tutar.Caption = "TUTAR";
            this.Tutar.FieldName = "Tutar";
            this.Tutar.MinWidth = 15;
            this.Tutar.Name = "Tutar";
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 5;
            this.Tutar.Width = 89;
            // 
            // urunAdi
            // 
            this.urunAdi.AppearanceCell.Options.UseTextOptions = true;
            this.urunAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.urunAdi.Caption = "ÜRÜN ADI";
            this.urunAdi.ColumnEdit = this.urunSecimi;
            this.urunAdi.FieldName = "UrunAdi";
            this.urunAdi.MinWidth = 19;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Visible = true;
            this.urunAdi.VisibleIndex = 1;
            this.urunAdi.Width = 87;
            // 
            // urunSecimi
            // 
            this.urunSecimi.AutoHeight = false;
            this.urunSecimi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.urunSecimi.Name = "urunSecimi";
            this.urunSecimi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.urunSecimi_ButtonClick);
            // 
            // UrunHizmetId
            // 
            this.UrunHizmetId.Caption = "Urun Hizmet Id";
            this.UrunHizmetId.FieldName = "UrunHizmetId";
            this.UrunHizmetId.Name = "UrunHizmetId";
            this.UrunHizmetId.Width = 56;
            // 
            // SiparisDetayId
            // 
            this.SiparisDetayId.Caption = "SiparisDetayId";
            this.SiparisDetayId.FieldName = "SiparisDetayId";
            this.SiparisDetayId.Name = "SiparisDetayId";
            // 
            // SatirTipi
            // 
            this.SatirTipi.Caption = "Satır Tipi";
            this.SatirTipi.ColumnEdit = this.repositoryItemComboBox1;
            this.SatirTipi.FieldName = "SatirTipi";
            this.SatirTipi.Name = "SatirTipi";
            this.SatirTipi.Visible = true;
            this.SatirTipi.VisibleIndex = 0;
            this.SatirTipi.Width = 89;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Malzeme",
            "Hizmet"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.SelectedIndexChanged += new System.EventHandler(this.repositoryItemComboBox1_SelectedIndexChanged);
            // 
            // btnEditMusteriler
            // 
            this.btnEditMusteriler.EditValue = "Müşteriler";
            this.btnEditMusteriler.Location = new System.Drawing.Point(94, 10);
            this.btnEditMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMusteriler.Name = "btnEditMusteriler";
            this.btnEditMusteriler.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEditMusteriler.Properties.Appearance.Options.UseFont = true;
            this.btnEditMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditMusteriler.Properties.ReadOnly = true;
            this.btnEditMusteriler.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditMusteriler_Properties_ButtonClick);
            this.btnEditMusteriler.Size = new System.Drawing.Size(151, 18);
            this.btnEditMusteriler.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 12);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 43);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 12);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sipariş No";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 72);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 12);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sipariş Tarihi";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(94, 38);
            this.txtSiparisNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(151, 20);
            this.txtSiparisNo.TabIndex = 5;
            // 
            // dateEditSiparisTarihi
            // 
            this.dateEditSiparisTarihi.EditValue = null;
            this.dateEditSiparisTarihi.Location = new System.Drawing.Point(94, 67);
            this.dateEditSiparisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dateEditSiparisTarihi.Name = "dateEditSiparisTarihi";
            this.dateEditSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSiparisTarihi.Size = new System.Drawing.Size(151, 20);
            this.dateEditSiparisTarihi.TabIndex = 8;
            // 
            // btnSiparisDetayKaydet
            // 
            this.btnSiparisDetayKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisDetayKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSiparisDetayKaydet.Appearance.Options.UseFont = true;
            this.btnSiparisDetayKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x161;
            this.btnSiparisDetayKaydet.Location = new System.Drawing.Point(557, 443);
            this.btnSiparisDetayKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisDetayKaydet.Name = "btnSiparisDetayKaydet";
            this.btnSiparisDetayKaydet.Size = new System.Drawing.Size(74, 24);
            this.btnSiparisDetayKaydet.TabIndex = 9;
            this.btnSiparisDetayKaydet.Text = "KAYDET";
            this.btnSiparisDetayKaydet.Click += new System.EventHandler(this.btnSiparisDetayKaydet_Click);
            // 
            // FrmSatinAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 475);
            this.Controls.Add(this.btnSiparisDetayKaydet);
            this.Controls.Add(this.dateEditSiparisTarihi);
            this.Controls.Add(this.txtSiparisNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnEditMusteriler);
            this.Controls.Add(this.gridControlSiparisDetay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSatinAl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satın Alma";
            this.Load += new System.EventHandler(this.frmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisDetay)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparislerDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSecimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditMusteriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSiparisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisDetayId;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem siparişDetaySilToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn SatirTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit urunSecimi;
    }
}