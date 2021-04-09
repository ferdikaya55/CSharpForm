
namespace WindowsFormsApDevex.DataAccess
{
    partial class FrmOdemeSekli
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
            this.gridControlOdemeSekli = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripOdemeSekli = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewOdemeSekli = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OdemeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeSekli)).BeginInit();
            this.contextMenuStripOdemeSekli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOdemeSekli)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOdemeSekli
            // 
            this.gridControlOdemeSekli.ContextMenuStrip = this.contextMenuStripOdemeSekli;
            this.gridControlOdemeSekli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOdemeSekli.Location = new System.Drawing.Point(0, 0);
            this.gridControlOdemeSekli.MainView = this.gridViewOdemeSekli;
            this.gridControlOdemeSekli.Name = "gridControlOdemeSekli";
            this.gridControlOdemeSekli.Size = new System.Drawing.Size(392, 186);
            this.gridControlOdemeSekli.TabIndex = 0;
            this.gridControlOdemeSekli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOdemeSekli});
            // 
            // contextMenuStripOdemeSekli
            // 
            this.contextMenuStripOdemeSekli.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStripOdemeSekli.Name = "contextMenuStripOdemeSekli";
            this.contextMenuStripOdemeSekli.Size = new System.Drawing.Size(121, 70);
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
            // gridViewOdemeSekli
            // 
            this.gridViewOdemeSekli.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OdemeAdi,
            this.OdemeId});
            this.gridViewOdemeSekli.GridControl = this.gridControlOdemeSekli;
            this.gridViewOdemeSekli.Name = "gridViewOdemeSekli";
            this.gridViewOdemeSekli.OptionsBehavior.Editable = false;
            this.gridViewOdemeSekli.OptionsView.ShowGroupPanel = false;
            this.gridViewOdemeSekli.DoubleClick += new System.EventHandler(this.gridViewOdemeSekli_DoubleClick);
            // 
            // OdemeAdi
            // 
            this.OdemeAdi.Caption = "Ödeme Şekli";
            this.OdemeAdi.FieldName = "OdemeAdi";
            this.OdemeAdi.Name = "OdemeAdi";
            this.OdemeAdi.Visible = true;
            this.OdemeAdi.VisibleIndex = 0;
            // 
            // OdemeId
            // 
            this.OdemeId.Caption = "Ödeme Id";
            this.OdemeId.FieldName = "OdemeId";
            this.OdemeId.Name = "OdemeId";
            // 
            // FrmOdemeSekli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 186);
            this.Controls.Add(this.gridControlOdemeSekli);
            this.Name = "FrmOdemeSekli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Şekli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOdemeSekli_FormClosed);
            this.Load += new System.EventHandler(this.FrmOdemeSekli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeSekli)).EndInit();
            this.contextMenuStripOdemeSekli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOdemeSekli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOdemeSekli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeAdi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOdemeSekli;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeId;
    }
}