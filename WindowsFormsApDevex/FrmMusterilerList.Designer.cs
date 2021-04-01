
namespace WindowsFormsApDevex
{
    partial class Müşteriler
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
            this.gridControlMusteriler = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMusteriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMusteriAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMusteriTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMusteriler
            // 
            this.gridControlMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMusteriler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlMusteriler.Location = new System.Drawing.Point(22, 67);
            this.gridControlMusteriler.MainView = this.gridView1;
            this.gridControlMusteriler.Name = "gridControlMusteriler";
            this.gridControlMusteriler.Size = new System.Drawing.Size(501, 381);
            this.gridControlMusteriler.TabIndex = 0;
            this.gridControlMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlMusteriler.DoubleClick += new System.EventHandler(this.gridControlMusteriler_DoubleClick);
            this.gridControlMusteriler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControlMusteriler_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ekleToolStripMenuItem.Text = "Müşteri Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.güncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMusteriId,
            this.gridColumn2,
            this.gridMusteriAdres,
            this.gridMusteriTelefon});
            this.gridView1.GridControl = this.gridControlMusteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridMusteriId
            // 
            this.gridMusteriId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriId.AppearanceCell.Options.UseFont = true;
            this.gridMusteriId.Caption = "Musteri Id";
            this.gridMusteriId.Name = "gridMusteriId";
            this.gridMusteriId.OptionsColumn.AllowEdit = false;
            this.gridMusteriId.Width = 59;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridColumn2.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "MÜŞTERİ ADI";
            this.gridColumn2.FieldName = "MusteriAd";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MusteriAd", "{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 93;
            // 
            // gridMusteriAdres
            // 
            this.gridMusteriAdres.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridMusteriAdres.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridMusteriAdres.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriAdres.AppearanceCell.Options.UseBackColor = true;
            this.gridMusteriAdres.AppearanceCell.Options.UseFont = true;
            this.gridMusteriAdres.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridMusteriAdres.AppearanceHeader.Options.UseFont = true;
            this.gridMusteriAdres.Caption = "MÜŞTERİ ADRESİ";
            this.gridMusteriAdres.FieldName = "Adres";
            this.gridMusteriAdres.Name = "gridMusteriAdres";
            this.gridMusteriAdres.OptionsColumn.AllowEdit = false;
            this.gridMusteriAdres.Visible = true;
            this.gridMusteriAdres.VisibleIndex = 1;
            this.gridMusteriAdres.Width = 132;
            // 
            // gridMusteriTelefon
            // 
            this.gridMusteriTelefon.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridMusteriTelefon.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridMusteriTelefon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriTelefon.AppearanceCell.Options.UseBackColor = true;
            this.gridMusteriTelefon.AppearanceCell.Options.UseFont = true;
            this.gridMusteriTelefon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridMusteriTelefon.AppearanceHeader.Options.UseFont = true;
            this.gridMusteriTelefon.Caption = "MÜŞTERİ TELEFONU";
            this.gridMusteriTelefon.FieldName = "Telefon";
            this.gridMusteriTelefon.Name = "gridMusteriTelefon";
            this.gridMusteriTelefon.OptionsColumn.AllowEdit = false;
            this.gridMusteriTelefon.Visible = true;
            this.gridMusteriTelefon.VisibleIndex = 2;
            this.gridMusteriTelefon.Width = 103;
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
            this.barBtnEkle,
            this.barBtnGuncelle,
            this.barBtnSil,
            this.barBtnCikis});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEkle, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGuncelle, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCikis, true)});
            this.bar1.Text = "Tools";
            // 
            // barBtnEkle
            // 
            this.barBtnEkle.Caption = "Ekle";
            this.barBtnEkle.Id = 0;
            this.barBtnEkle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.add_16x16;
            this.barBtnEkle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.add_32x321;
            this.barBtnEkle.Name = "barBtnEkle";
            this.barBtnEkle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEkle_ItemClick);
            // 
            // barBtnGuncelle
            // 
            this.barBtnGuncelle.Caption = "Güncelle";
            this.barBtnGuncelle.Id = 1;
            this.barBtnGuncelle.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x16;
            this.barBtnGuncelle.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.save_32x32;
            this.barBtnGuncelle.Name = "barBtnGuncelle";
            this.barBtnGuncelle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGuncelle_ItemClick);
            // 
            // barBtnSil
            // 
            this.barBtnSil.Caption = "Sil";
            this.barBtnSil.Id = 2;
            this.barBtnSil.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.removepivotfield_16x16;
            this.barBtnSil.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.removepivotfield_32x32;
            this.barBtnSil.Name = "barBtnSil";
            this.barBtnSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSil_ItemClick);
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 3;
            this.barBtnCikis.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.cancel_16x16;
            this.barBtnCikis.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.cancel_32x32;
            this.barBtnCikis.Name = "barBtnCikis";
            this.barBtnCikis.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCikis_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(546, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 448);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(546, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(546, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 468);
            this.Controls.Add(this.gridControlMusteriler);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Müşteriler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriTelefon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnEkle;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnGuncelle;
        private DevExpress.XtraBars.BarButtonItem barBtnSil;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
    }
}

