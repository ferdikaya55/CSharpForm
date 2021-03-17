
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunlerList));
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.urunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.birimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Location = new System.Drawing.Point(46, 42);
            this.gridControlUrunler.MainView = this.gridViewUrunler;
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.Size = new System.Drawing.Size(775, 437);
            this.gridControlUrunler.TabIndex = 0;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunler});
            this.gridControlUrunler.DoubleClick += new System.EventHandler(this.gridControlUrunler_DoubleClick);
            // 
            // gridViewUrunler
            // 
            this.gridViewUrunler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.urunId,
            this.urunAdi,
            this.birimFiyati,
            this.stokMiktari});
            this.gridViewUrunler.GridControl = this.gridControlUrunler;
            this.gridViewUrunler.Name = "gridViewUrunler";
            this.gridViewUrunler.OptionsBehavior.Editable = false;
            this.gridViewUrunler.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewUrunler.DoubleClick += new System.EventHandler(this.gridViewUrunler_DoubleClick);
            // 
            // urunId
            // 
            this.urunId.Caption = "Urun Malzeme Id";
            this.urunId.FieldName = "UrunMalzemeId";
            this.urunId.MinWidth = 25;
            this.urunId.Name = "urunId";
            this.urunId.Width = 94;
            // 
            // urunAdi
            // 
            this.urunAdi.Caption = "Ürün Adı";
            this.urunAdi.FieldName = "UrunAdi";
            this.urunAdi.MinWidth = 25;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Visible = true;
            this.urunAdi.VisibleIndex = 0;
            this.urunAdi.Width = 94;
            // 
            // birimFiyati
            // 
            this.birimFiyati.Caption = "Birim Fiyati";
            this.birimFiyati.FieldName = "BirimFiyati";
            this.birimFiyati.MinWidth = 25;
            this.birimFiyati.Name = "birimFiyati";
            this.birimFiyati.Visible = true;
            this.birimFiyati.VisibleIndex = 1;
            this.birimFiyati.Width = 94;
            // 
            // stokMiktari
            // 
            this.stokMiktari.Caption = "Stok Miktarı";
            this.stokMiktari.FieldName = "StokMiktari";
            this.stokMiktari.MinWidth = 25;
            this.stokMiktari.Name = "stokMiktari";
            this.stokMiktari.Visible = true;
            this.stokMiktari.VisibleIndex = 2;
            this.stokMiktari.Width = 94;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUrunEkle.Appearance.Options.UseFont = true;
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.Image")));
            this.btnUrunEkle.Location = new System.Drawing.Point(688, 488);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(133, 43);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            this.ürünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleToolStripMenuItem_Click);
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            this.ürünSilToolStripMenuItem.Click += new System.EventHandler(this.ürünSilToolStripMenuItem_Click);
            // 
            // FrmUrunlerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 543);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.gridControlUrunler);
            this.Name = "FrmUrunlerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunler;
        private DevExpress.XtraGrid.Columns.GridColumn urunId;
        private DevExpress.XtraGrid.Columns.GridColumn urunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn birimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn stokMiktari;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
    }
}