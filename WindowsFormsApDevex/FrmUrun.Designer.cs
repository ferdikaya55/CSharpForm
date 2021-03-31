
namespace WindowsFormsApDevex
{
    partial class FrmUrun
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunStokMiktari = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunBirimFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 68);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 12);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 102);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 12);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ürün Birim Fiyatı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 136);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 12);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ürün Stok Miktarı";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUrunKaydet.Appearance.Options.UseFont = true;
            this.btnUrunKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x164;
            this.btnUrunKaydet.Location = new System.Drawing.Point(170, 166);
            this.btnUrunKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(83, 26);
            this.btnUrunKaydet.TabIndex = 3;
            this.btnUrunKaydet.Text = "KAYDET";
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // txtUrunStokMiktari
            // 
            this.txtUrunStokMiktari.Location = new System.Drawing.Point(142, 133);
            this.txtUrunStokMiktari.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunStokMiktari.Name = "txtUrunStokMiktari";
            this.txtUrunStokMiktari.Properties.BeepOnError = false;
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunStokMiktari.Size = new System.Drawing.Size(110, 20);
            this.txtUrunStokMiktari.TabIndex = 2;
            // 
            // txtUrunBirimFiyati
            // 
            this.txtUrunBirimFiyati.Location = new System.Drawing.Point(142, 100);
            this.txtUrunBirimFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunBirimFiyati.Name = "txtUrunBirimFiyati";
            this.txtUrunBirimFiyati.Properties.BeepOnError = false;
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunBirimFiyati.Size = new System.Drawing.Size(110, 20);
            this.txtUrunBirimFiyati.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(142, 63);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.BeepOnError = false;
            this.txtUrunAdi.Size = new System.Drawing.Size(110, 20);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 288);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtUrunStokMiktari);
            this.Controls.Add(this.txtUrunBirimFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun";
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunBirimFiyati;
        private DevExpress.XtraEditors.TextEdit txtUrunStokMiktari;
        private DevExpress.XtraEditors.SimpleButton btnUrunKaydet;
    }
}