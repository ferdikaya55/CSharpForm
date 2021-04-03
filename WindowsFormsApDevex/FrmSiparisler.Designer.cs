
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
            this.yAZDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewSiparisler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MusteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSiparisler
            // 
            this.gridControlSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControlSiparisler.Location = new System.Drawing.Point(36, 22);
            this.gridControlSiparisler.MainView = this.gridViewSiparisler;
            this.gridControlSiparisler.Name = "gridControlSiparisler";
            this.gridControlSiparisler.Size = new System.Drawing.Size(728, 379);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 76);
            // 
            // sİPARİŞSİLToolStripMenuItem
            // 
            this.sİPARİŞSİLToolStripMenuItem.Name = "sİPARİŞSİLToolStripMenuItem";
            this.sİPARİŞSİLToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.sİPARİŞSİLToolStripMenuItem.Text = "SİPARİŞ SİL";
            this.sİPARİŞSİLToolStripMenuItem.Click += new System.EventHandler(this.sİPARİŞSİLToolStripMenuItem_Click);
            // 
            // sİPARİŞDÜZENLEToolStripMenuItem
            // 
            this.sİPARİŞDÜZENLEToolStripMenuItem.Name = "sİPARİŞDÜZENLEToolStripMenuItem";
            this.sİPARİŞDÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.sİPARİŞDÜZENLEToolStripMenuItem.Text = "SİPARİŞ DÜZENLE";
            this.sİPARİŞDÜZENLEToolStripMenuItem.Click += new System.EventHandler(this.sİPARİŞDÜZENLEToolStripMenuItem_Click);
            // 
            // yAZDIRToolStripMenuItem
            // 
            this.yAZDIRToolStripMenuItem.Name = "yAZDIRToolStripMenuItem";
            this.yAZDIRToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.yAZDIRToolStripMenuItem.Text = "YAZDIR";
            this.yAZDIRToolStripMenuItem.Click += new System.EventHandler(this.yAZDIRToolStripMenuItem_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 21;
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 436);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlSiparisler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSiparisler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSiparisler)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem sİPARİŞDÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZDIRToolStripMenuItem;
    }
}