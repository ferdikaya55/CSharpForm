
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteriler));
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
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMusteriler
            // 
            this.gridControlMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMusteriler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlMusteriler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlMusteriler.Location = new System.Drawing.Point(43, 30);
            this.gridControlMusteriler.MainView = this.gridView1;
            this.gridControlMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlMusteriler.Name = "gridControlMusteriler";
            this.gridControlMusteriler.Size = new System.Drawing.Size(696, 484);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 76);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.ekleToolStripMenuItem.Text = "Müşteri Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.güncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMusteriId,
            this.gridColumn2,
            this.gridMusteriAdres,
            this.gridMusteriTelefon});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControlMusteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridMusteriId
            // 
            this.gridMusteriId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriId.AppearanceCell.Options.UseFont = true;
            this.gridMusteriId.Caption = "Musteri Id";
            this.gridMusteriId.MinWidth = 27;
            this.gridMusteriId.Name = "gridMusteriId";
            this.gridMusteriId.Width = 79;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.Caption = "Musteri Adı";
            this.gridColumn2.FieldName = "MusteriAd";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MusteriAd", "{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 124;
            // 
            // gridMusteriAdres
            // 
            this.gridMusteriAdres.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridMusteriAdres.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriAdres.AppearanceCell.Options.UseBackColor = true;
            this.gridMusteriAdres.AppearanceCell.Options.UseFont = true;
            this.gridMusteriAdres.Caption = "Musteri Adresi";
            this.gridMusteriAdres.FieldName = "Adres";
            this.gridMusteriAdres.MinWidth = 27;
            this.gridMusteriAdres.Name = "gridMusteriAdres";
            this.gridMusteriAdres.Visible = true;
            this.gridMusteriAdres.VisibleIndex = 1;
            this.gridMusteriAdres.Width = 176;
            // 
            // gridMusteriTelefon
            // 
            this.gridMusteriTelefon.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridMusteriTelefon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridMusteriTelefon.AppearanceCell.Options.UseBackColor = true;
            this.gridMusteriTelefon.AppearanceCell.Options.UseFont = true;
            this.gridMusteriTelefon.Caption = "Müsteri Telefonu";
            this.gridMusteriTelefon.FieldName = "Telefon";
            this.gridMusteriTelefon.MinWidth = 27;
            this.gridMusteriTelefon.Name = "gridMusteriTelefon";
            this.gridMusteriTelefon.Visible = true;
            this.gridMusteriTelefon.VisibleIndex = 2;
            this.gridMusteriTelefon.Width = 137;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(630, 522);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEkle.Size = new System.Drawing.Size(109, 42);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gridControlMusteriler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Müşteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridMusteriTelefon;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
    }
}

