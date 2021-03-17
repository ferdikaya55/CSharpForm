
namespace WindowsFormsApDevex
{
    partial class FrmAna
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarAnasayfa = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarMusteriler = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarUrunler = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSiparisler = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarAnasayfa;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarAnasayfa});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarMusteriler,
            this.navBarUrunler,
            this.navBarSiparisler});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 205;
            this.navBarControl1.Size = new System.Drawing.Size(205, 688);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarAnasayfa
            // 
            this.navBarAnasayfa.Caption = "Sipariş Takip ";
            this.navBarAnasayfa.Expanded = true;
            this.navBarAnasayfa.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMusteriler),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUrunler),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSiparisler)});
            this.navBarAnasayfa.Name = "navBarAnasayfa";
            // 
            // navBarMusteriler
            // 
            this.navBarMusteriler.Caption = "Müşteriler";
            this.navBarMusteriler.Name = "navBarMusteriler";
            this.navBarMusteriler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMusteriler_LinkClicked);
            // 
            // navBarUrunler
            // 
            this.navBarUrunler.Caption = "Ürünler";
            this.navBarUrunler.Name = "navBarUrunler";
            this.navBarUrunler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarUrunler_LinkClicked);
            // 
            // navBarSiparisler
            // 
            this.navBarSiparisler.Caption = "Siparişler";
            this.navBarSiparisler.Name = "navBarSiparisler";
            this.navBarSiparisler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSiparisler_LinkClicked);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 688);
            this.Controls.Add(this.navBarControl1);
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAna";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarAnasayfa;
        private DevExpress.XtraNavBar.NavBarItem navBarMusteriler;
        private DevExpress.XtraNavBar.NavBarItem navBarUrunler;
        private DevExpress.XtraNavBar.NavBarItem navBarSiparisler;
    }
}