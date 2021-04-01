
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAna));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarAnasayfa = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarMusteriler = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarUrunler = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSatinAl = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSiparisler = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
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
            this.navBarSatinAl,
            this.navBarSiparisler,
            this.navBarItem1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 218;
            this.navBarControl1.Size = new System.Drawing.Size(218, 601);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
           
            // 
            // navBarAnasayfa
            // 
            this.navBarAnasayfa.Appearance.BackColor = System.Drawing.Color.Gray;
            this.navBarAnasayfa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarAnasayfa.Appearance.Options.UseBackColor = true;
            this.navBarAnasayfa.Appearance.Options.UseFont = true;
            this.navBarAnasayfa.Caption = "SİPARİŞ TAKİP";
            this.navBarAnasayfa.Expanded = true;
            this.navBarAnasayfa.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMusteriler),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUrunler),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSatinAl),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSiparisler),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarAnasayfa.Name = "navBarAnasayfa";
            // 
            // navBarMusteriler
            // 
            this.navBarMusteriler.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.navBarMusteriler.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarMusteriler.Appearance.Options.UseBackColor = true;
            this.navBarMusteriler.Appearance.Options.UseFont = true;
            this.navBarMusteriler.Caption = "MÜŞTERİLER";
            this.navBarMusteriler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarMusteriler.ImageOptions.SvgImage")));
            this.navBarMusteriler.Name = "navBarMusteriler";
            this.navBarMusteriler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMusteriler_LinkClicked);
            // 
            // navBarUrunler
            // 
            this.navBarUrunler.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarUrunler.Appearance.Options.UseFont = true;
            this.navBarUrunler.Caption = "ÜRÜNLER";
            this.navBarUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarUrunler.ImageOptions.SvgImage")));
            this.navBarUrunler.Name = "navBarUrunler";
            this.navBarUrunler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarUrunler_LinkClicked);
            // 
            // navBarSatinAl
            // 
            this.navBarSatinAl.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarSatinAl.Appearance.Options.UseFont = true;
            this.navBarSatinAl.Caption = "SATIN AL";
            this.navBarSatinAl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarSatinAl.ImageOptions.SvgImage")));
            this.navBarSatinAl.Name = "navBarSatinAl";
            this.navBarSatinAl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSatinAl_LinkClicked);
            // 
            // navBarSiparisler
            // 
            this.navBarSiparisler.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.navBarSiparisler.Appearance.Options.UseFont = true;
            this.navBarSiparisler.Caption = "SİPARİŞLER";
            this.navBarSiparisler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarSiparisler.ImageOptions.SvgImage")));
            this.navBarSiparisler.Name = "navBarSiparisler";
            this.navBarSiparisler.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSiparisler_LinkClicked_1);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "ÜRÜN HİZMET";
            this.navBarItem1.ImageOptions.LargeImage = global::WindowsFormsApDevex.Properties.Resources.boproductgroup_32x32;
            this.navBarItem1.ImageOptions.SmallImage = global::WindowsFormsApDevex.Properties.Resources.boproductgroup_16x16;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(881, 601);
            this.Controls.Add(this.navBarControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmAna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarAnasayfa;
        private DevExpress.XtraNavBar.NavBarItem navBarMusteriler;
        private DevExpress.XtraNavBar.NavBarItem navBarUrunler;
        private DevExpress.XtraNavBar.NavBarItem navBarSatinAl;
        private DevExpress.XtraNavBar.NavBarItem navBarSiparisler;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
    }
}