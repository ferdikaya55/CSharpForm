
namespace WindowsFormsApDevex
{
    partial class FrmKurlar
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
            this.gridControlKurlar = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripKurlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewKurlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KurId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KurAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKurlar)).BeginInit();
            this.contextMenuStripKurlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKurlar
            // 
            this.gridControlKurlar.ContextMenuStrip = this.contextMenuStripKurlar;
            this.gridControlKurlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKurlar.Location = new System.Drawing.Point(0, 0);
            this.gridControlKurlar.MainView = this.gridViewKurlar;
            this.gridControlKurlar.Name = "gridControlKurlar";
            this.gridControlKurlar.Size = new System.Drawing.Size(297, 140);
            this.gridControlKurlar.TabIndex = 15;
            this.gridControlKurlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKurlar});
            // 
            // contextMenuStripKurlar
            // 
            this.contextMenuStripKurlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.kurGüncelleToolStripMenuItem,
            this.kurSilToolStripMenuItem});
            this.contextMenuStripKurlar.Name = "contextMenuStripKurlar";
            this.contextMenuStripKurlar.Size = new System.Drawing.Size(142, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ekleToolStripMenuItem.Text = "Kur Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // kurGüncelleToolStripMenuItem
            // 
            this.kurGüncelleToolStripMenuItem.Name = "kurGüncelleToolStripMenuItem";
            this.kurGüncelleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kurGüncelleToolStripMenuItem.Text = "Kur Güncelle";
            this.kurGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kurGüncelleToolStripMenuItem_Click);
            // 
            // kurSilToolStripMenuItem
            // 
            this.kurSilToolStripMenuItem.Name = "kurSilToolStripMenuItem";
            this.kurSilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kurSilToolStripMenuItem.Text = "Kur Sil";
            this.kurSilToolStripMenuItem.Click += new System.EventHandler(this.kurSilToolStripMenuItem_Click);
            // 
            // gridViewKurlar
            // 
            this.gridViewKurlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KurId,
            this.KurAdi});
            this.gridViewKurlar.GridControl = this.gridControlKurlar;
            this.gridViewKurlar.Name = "gridViewKurlar";
            this.gridViewKurlar.OptionsBehavior.Editable = false;
            this.gridViewKurlar.OptionsView.ShowGroupPanel = false;
            // 
            // KurId
            // 
            this.KurId.Caption = "Kur Id";
            this.KurId.FieldName = "KurId";
            this.KurId.Name = "KurId";
            this.KurId.Width = 60;
            // 
            // KurAdi
            // 
            this.KurAdi.Caption = "Kur Adı";
            this.KurAdi.FieldName = "KurAdi";
            this.KurAdi.Name = "KurAdi";
            this.KurAdi.Visible = true;
            this.KurAdi.VisibleIndex = 0;
            this.KurAdi.Width = 152;
            // 
            // FrmKurlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 140);
            this.Controls.Add(this.gridControlKurlar);
            this.Name = "FrmKurlar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurlar";
            this.Load += new System.EventHandler(this.FrmKurlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKurlar)).EndInit();
            this.contextMenuStripKurlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKurlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlKurlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKurlar;
        private DevExpress.XtraGrid.Columns.GridColumn KurId;
        private DevExpress.XtraGrid.Columns.GridColumn KurAdi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKurlar;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurSilToolStripMenuItem;
    }
}