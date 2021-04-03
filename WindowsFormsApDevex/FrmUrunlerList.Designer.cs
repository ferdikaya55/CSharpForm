
namespace WindowsFormsApDevex
{
    partial class FrmUrunlerList
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
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.urunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.birimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunSil = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.UrunMalzemeKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUrunler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlUrunler.Location = new System.Drawing.Point(18, 84);
            this.gridControlUrunler.MainView = this.gridViewUrunler;
            this.gridControlUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.Size = new System.Drawing.Size(527, 278);
            this.gridControlUrunler.TabIndex = 0;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunler});
            this.gridControlUrunler.DoubleClick += new System.EventHandler(this.gridControlUrunler_DoubleClick);
            // 
            // gridViewUrunler
            // 
            this.gridViewUrunler.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridViewUrunler.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewUrunler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.urunId,
            this.urunAdi,
            this.birimFiyati,
            this.StokMiktari,
            this.UrunMalzemeKdvOrani});
            this.gridViewUrunler.DetailHeight = 284;
            this.gridViewUrunler.GridControl = this.gridControlUrunler;
            this.gridViewUrunler.Name = "gridViewUrunler";
            this.gridViewUrunler.OptionsBehavior.Editable = false;
            this.gridViewUrunler.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewUrunler.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewUrunler.OptionsView.ShowGroupPanel = false;
            this.gridViewUrunler.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewUrunler_RowCellStyle);
            this.gridViewUrunler.DoubleClick += new System.EventHandler(this.gridViewUrunler_DoubleClick);
            // 
            // urunId
            // 
            this.urunId.Caption = "ÜRÜN ID";
            this.urunId.FieldName = "UrunMalzemeId";
            this.urunId.MinWidth = 19;
            this.urunId.Name = "urunId";
            this.urunId.OptionsColumn.AllowEdit = false;
            this.urunId.Width = 70;
            // 
            // urunAdi
            // 
            this.urunAdi.Caption = "ÜRÜN ADI";
            this.urunAdi.FieldName = "UrunAdi";
            this.urunAdi.MinWidth = 19;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.OptionsColumn.AllowEdit = false;
            this.urunAdi.Visible = true;
            this.urunAdi.VisibleIndex = 0;
            this.urunAdi.Width = 70;
            // 
            // birimFiyati
            // 
            this.birimFiyati.Caption = "BİRİM FİYATI";
            this.birimFiyati.FieldName = "BirimFiyati";
            this.birimFiyati.MinWidth = 19;
            this.birimFiyati.Name = "birimFiyati";
            this.birimFiyati.OptionsColumn.AllowEdit = false;
            this.birimFiyati.Visible = true;
            this.birimFiyati.VisibleIndex = 1;
            this.birimFiyati.Width = 70;
            // 
            // StokMiktari
            // 
            this.StokMiktari.Caption = "STOK MİKTARI";
            this.StokMiktari.FieldName = "StokMiktari";
            this.StokMiktari.MinWidth = 19;
            this.StokMiktari.Name = "StokMiktari";
            this.StokMiktari.Visible = true;
            this.StokMiktari.VisibleIndex = 3;
            this.StokMiktari.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            this.ürünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleToolStripMenuItem_Click);
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            this.ürünSilToolStripMenuItem.Click += new System.EventHandler(this.ürünSilToolStripMenuItem_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnUrunEkle,
            this.barBtnUrunGuncelle,
            this.barBtnUrunSil,
            this.barBtnUrunCikis});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnUrunEkle, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnUrunGuncelle, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnUrunSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnUrunCikis, true)});
            this.bar1.Text = "Tools";
            // 
            // barBtnUrunEkle
            // 
            this.barBtnUrunEkle.Caption = "Ekle";
            this.barBtnUrunEkle.Id = 0;
            this.barBtnUrunEkle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.add_16x16;
            this.barBtnUrunEkle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.add_32x321;
            this.barBtnUrunEkle.Name = "barBtnUrunEkle";
            this.barBtnUrunEkle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunEkle_ItemClick);
            // 
            // barBtnUrunGuncelle
            // 
            this.barBtnUrunGuncelle.Caption = "Güncelle";
            this.barBtnUrunGuncelle.Id = 1;
            this.barBtnUrunGuncelle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x16;
            this.barBtnUrunGuncelle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.save_32x32;
            this.barBtnUrunGuncelle.Name = "barBtnUrunGuncelle";
            this.barBtnUrunGuncelle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnUrunGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunGuncelle_ItemClick);
            // 
            // barBtnUrunSil
            // 
            this.barBtnUrunSil.Caption = "Sil";
            this.barBtnUrunSil.Id = 2;
            this.barBtnUrunSil.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.removepivotfield_16x16;
            this.barBtnUrunSil.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.removepivotfield_32x32;
            this.barBtnUrunSil.Name = "barBtnUrunSil";
            this.barBtnUrunSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnUrunSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunSil_ItemClick);
            // 
            // barBtnUrunCikis
            // 
            this.barBtnUrunCikis.Caption = "Çıkış";
            this.barBtnUrunCikis.Id = 3;
            this.barBtnUrunCikis.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.cancel_16x16;
            this.barBtnUrunCikis.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.cancel_32x32;
            this.barBtnUrunCikis.Name = "barBtnUrunCikis";
            this.barBtnUrunCikis.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnUrunCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunCikis_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(566, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 368);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(566, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(566, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // UrunMalzemeKdvOrani
            // 
            this.UrunMalzemeKdvOrani.Caption = "KDV ORANI";
            this.UrunMalzemeKdvOrani.FieldName = "UrunMalzemeKdvOrani";
            this.UrunMalzemeKdvOrani.Name = "UrunMalzemeKdvOrani";
            this.UrunMalzemeKdvOrani.Visible = true;
            this.UrunMalzemeKdvOrani.VisibleIndex = 2;
            // 
            // FrmUrunlerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 388);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControlUrunler);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUrunlerList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunler;
        private DevExpress.XtraGrid.Columns.GridColumn urunId;
        private DevExpress.XtraGrid.Columns.GridColumn urunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn birimFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn StokMiktari;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunGuncelle;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunSil;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunCikis;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn UrunMalzemeKdvOrani;
    }
}