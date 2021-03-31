
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
            this.gridControlUrunHizmetList = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunHizmetList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunHizmetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrunAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHizmetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunHizmetList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUrunHizmetList
            // 
            this.gridControlUrunHizmetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUrunHizmetList.Location = new System.Drawing.Point(40, 40);
            this.gridControlUrunHizmetList.MainView = this.gridViewUrunHizmetList;
            this.gridControlUrunHizmetList.Name = "gridControlUrunHizmetList";
            this.gridControlUrunHizmetList.Size = new System.Drawing.Size(686, 445);
            this.gridControlUrunHizmetList.TabIndex = 0;
            this.gridControlUrunHizmetList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunHizmetList});
            this.gridControlUrunHizmetList.DoubleClick += new System.EventHandler(this.gridControlUrunHizmetList_DoubleClick);
            // 
            // gridViewUrunHizmetList
            // 
            this.gridViewUrunHizmetList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunHizmetId,
            this.UrunAdi,
            this.BirimFiyati,
            this.UrunAciklama});
            this.gridViewUrunHizmetList.GridControl = this.gridControlUrunHizmetList;
            this.gridViewUrunHizmetList.Name = "gridViewUrunHizmetList";
            this.gridViewUrunHizmetList.OptionsBehavior.Editable = false;
            // 
            // UrunHizmetId
            // 
            this.UrunHizmetId.Caption = "UrunHizmetId";
            this.UrunHizmetId.FieldName = "UrunHizmetId";
            this.UrunHizmetId.Name = "UrunHizmetId";
            this.UrunHizmetId.Visible = true;
            this.UrunHizmetId.VisibleIndex = 0;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Ürün Adı";
            this.UrunAdi.FieldName = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 1;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Caption = "Birim Fiyatı";
            this.BirimFiyati.FieldName = "BirimFiyati";
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.Visible = true;
            this.BirimFiyati.VisibleIndex = 2;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.Caption = "Ürün Açıklama";
            this.UrunAciklama.FieldName = "UrunAciklama";
            this.UrunAciklama.Name = "UrunAciklama";
            this.UrunAciklama.Visible = true;
            this.UrunAciklama.VisibleIndex = 3;
            // 
            // FrmUrunHizmetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 512);
            this.Controls.Add(this.gridControlUrunHizmetList);
            this.Name = "FrmUrunHizmetList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Hizmet Ekranı";
            this.Load += new System.EventHandler(this.FrmUrunHizmetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHizmetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunHizmetList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUrunHizmetList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunHizmetList;
        private DevExpress.XtraGrid.Columns.GridColumn UrunHizmetId;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn BirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAciklama;
    }
}