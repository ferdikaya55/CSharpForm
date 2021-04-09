
namespace WindowsFormsApDevex
{
    partial class FrmTeslimSekliList
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
            this.contextMenuStripTEslimSekli = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControlTeslimSekli = new DevExpress.XtraGrid.GridControl();
            this.gridViewTeslimSekli = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TeslimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeslimSekliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStripTEslimSekli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTeslimSekli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeslimSekli)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripTEslimSekli
            // 
            this.contextMenuStripTEslimSekli.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStripTEslimSekli.Name = "contextMenuStripTEslimSekli";
            this.contextMenuStripTEslimSekli.Size = new System.Drawing.Size(121, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // gridControlTeslimSekli
            // 
            this.gridControlTeslimSekli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTeslimSekli.Location = new System.Drawing.Point(0, 0);
            this.gridControlTeslimSekli.MainView = this.gridViewTeslimSekli;
            this.gridControlTeslimSekli.Name = "gridControlTeslimSekli";
            this.gridControlTeslimSekli.Size = new System.Drawing.Size(464, 246);
            this.gridControlTeslimSekli.TabIndex = 1;
            this.gridControlTeslimSekli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTeslimSekli});
            // 
            // gridViewTeslimSekli
            // 
            this.gridViewTeslimSekli.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TeslimId,
            this.TeslimSekliAdi});
            this.gridViewTeslimSekli.GridControl = this.gridControlTeslimSekli;
            this.gridViewTeslimSekli.Name = "gridViewTeslimSekli";
            this.gridViewTeslimSekli.OptionsBehavior.Editable = false;
            this.gridViewTeslimSekli.OptionsView.ShowGroupPanel = false;
            this.gridViewTeslimSekli.DoubleClick += new System.EventHandler(this.gridViewTeslimSekli_DoubleClick);
            // 
            // TeslimId
            // 
            this.TeslimId.Caption = "Teslim Id";
            this.TeslimId.FieldName = "TeslimId";
            this.TeslimId.Name = "TeslimId";
            // 
            // TeslimSekliAdi
            // 
            this.TeslimSekliAdi.Caption = "Teslim Şekli";
            this.TeslimSekliAdi.FieldName = "TeslimSekliAdi";
            this.TeslimSekliAdi.Name = "TeslimSekliAdi";
            this.TeslimSekliAdi.Visible = true;
            this.TeslimSekliAdi.VisibleIndex = 0;
            // 
            // FrmTeslimSekliList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 246);
            this.ContextMenuStrip = this.contextMenuStripTEslimSekli;
            this.Controls.Add(this.gridControlTeslimSekli);
            this.Name = "FrmTeslimSekliList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teslim Şekli";
            this.Load += new System.EventHandler(this.FrmTeslimSekliList_Load);
            this.contextMenuStripTEslimSekli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTeslimSekli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeslimSekli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripTEslimSekli;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControlTeslimSekli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTeslimSekli;
        private DevExpress.XtraGrid.Columns.GridColumn TeslimId;
        private DevExpress.XtraGrid.Columns.GridColumn TeslimSekliAdi;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}