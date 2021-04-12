
namespace WindowsFormsApDevex
{
    partial class FrmUrunHizmetList
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
            this.gridControlUrunHizmetList = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunHizmetList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunHizmetKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunHizmetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemHizmetEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemhizmetGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHizmetSil = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHizmetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunHizmetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUrunHizmetList
            // 
            this.gridControlUrunHizmetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUrunHizmetList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlUrunHizmetList.Location = new System.Drawing.Point(13, 67);
            this.gridControlUrunHizmetList.MainView = this.gridViewUrunHizmetList;
            this.gridControlUrunHizmetList.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlUrunHizmetList.Name = "gridControlUrunHizmetList";
            this.gridControlUrunHizmetList.Size = new System.Drawing.Size(730, 341);
            this.gridControlUrunHizmetList.TabIndex = 0;
            this.gridControlUrunHizmetList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunHizmetList});
            this.gridControlUrunHizmetList.DoubleClick += new System.EventHandler(this.gridControlUrunHizmetList_DoubleClick);
            // 
            // gridViewUrunHizmetList
            // 
            this.gridViewUrunHizmetList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunHizmetKdvOrani,
            this.UrunHizmetId,
            this.UrunAdi,
            this.BirimFiyati,
            this.UrunAciklama});
            this.gridViewUrunHizmetList.DetailHeight = 431;
            this.gridViewUrunHizmetList.GridControl = this.gridControlUrunHizmetList;
            this.gridViewUrunHizmetList.Name = "gridViewUrunHizmetList";
            this.gridViewUrunHizmetList.OptionsBehavior.Editable = false;
            this.gridViewUrunHizmetList.OptionsView.ShowGroupPanel = false;
            // 
            // UrunHizmetKdvOrani
            // 
            this.UrunHizmetKdvOrani.Caption = "KDV ORANI";
            this.UrunHizmetKdvOrani.FieldName = "UrunHizmetKdvOrani";
            this.UrunHizmetKdvOrani.MinWidth = 27;
            this.UrunHizmetKdvOrani.Name = "UrunHizmetKdvOrani";
            this.UrunHizmetKdvOrani.Visible = true;
            this.UrunHizmetKdvOrani.VisibleIndex = 2;
            this.UrunHizmetKdvOrani.Width = 109;
            // 
            // UrunHizmetId
            // 
            this.UrunHizmetId.Caption = "UrunHizmetId";
            this.UrunHizmetId.FieldName = "UrunHizmetId";
            this.UrunHizmetId.MinWidth = 27;
            this.UrunHizmetId.Name = "UrunHizmetId";
            this.UrunHizmetId.Width = 100;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Ürün Adı";
            this.UrunAdi.FieldName = "UrunAdi";
            this.UrunAdi.MinWidth = 27;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 0;
            this.UrunAdi.Width = 132;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Caption = "Birim Fiyatı";
            this.BirimFiyati.FieldName = "BirimFiyati";
            this.BirimFiyati.MinWidth = 27;
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Visible = true;
            this.BirimFiyati.VisibleIndex = 1;
            this.BirimFiyati.Width = 96;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.Caption = "Ürün Açıklama";
            this.UrunAciklama.FieldName = "UrunAciklama";
            this.UrunAciklama.MinWidth = 27;
            this.UrunAciklama.Name = "UrunAciklama";
            this.UrunAciklama.Visible = true;
            this.UrunAciklama.VisibleIndex = 3;
            this.UrunAciklama.Width = 314;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(756, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(756, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemHizmetEkle,
            this.barButtonItemhizmetGuncelle,
            this.barButtonItemHizmetSil,
            this.barButtonItemCikis});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemHizmetEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemhizmetGuncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemHizmetSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCikis)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemHizmetEkle
            // 
            this.barButtonItemHizmetEkle.Caption = "Ekle";
            this.barButtonItemHizmetEkle.Id = 0;
            this.barButtonItemHizmetEkle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.add_16x161;
            this.barButtonItemHizmetEkle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.add_32x322;
            this.barButtonItemHizmetEkle.Name = "barButtonItemHizmetEkle";
            this.barButtonItemHizmetEkle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemHizmetEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHizmetEkle_ItemClick);
            // 
            // barButtonItemhizmetGuncelle
            // 
            this.barButtonItemhizmetGuncelle.Caption = "Güncelle";
            this.barButtonItemhizmetGuncelle.Id = 1;
            this.barButtonItemhizmetGuncelle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x165;
            this.barButtonItemhizmetGuncelle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.save_32x321;
            this.barButtonItemhizmetGuncelle.Name = "barButtonItemhizmetGuncelle";
            this.barButtonItemhizmetGuncelle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemhizmetGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemhizmetGuncelle_ItemClick);
            // 
            // barButtonItemHizmetSil
            // 
            this.barButtonItemHizmetSil.Caption = "Sil";
            this.barButtonItemHizmetSil.Id = 2;
            this.barButtonItemHizmetSil.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.delete_16x16;
            this.barButtonItemHizmetSil.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.delete_32x32;
            this.barButtonItemHizmetSil.Name = "barButtonItemHizmetSil";
            this.barButtonItemHizmetSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemHizmetSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHizmetSil_ItemClick);
            // 
            // barButtonItemCikis
            // 
            this.barButtonItemCikis.Caption = "Çıkış";
            this.barButtonItemCikis.Id = 3;
            this.barButtonItemCikis.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.cancel_16x161;
            this.barButtonItemCikis.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.cancel_32x321;
            this.barButtonItemCikis.Name = "barButtonItemCikis";
            this.barButtonItemCikis.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCikis_ItemClick);
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
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(756, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(756, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 371);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(756, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 371);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 371);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl4.Location = new System.Drawing.Point(0, 30);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(756, 0);
            // 
            // FrmUrunHizmetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 421);
            this.Controls.Add(this.gridControlUrunHizmetList);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUrunHizmetList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Hizmet Ekranı";
            this.Load += new System.EventHandler(this.FrmUrunHizmetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHizmetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunHizmetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrunHizmetList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunHizmetList;
        private DevExpress.XtraGrid.Columns.GridColumn UrunHizmetId;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn UrunHizmetKdvOrani;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemHizmetEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemhizmetGuncelle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemHizmetSil;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCikis;
    }
}