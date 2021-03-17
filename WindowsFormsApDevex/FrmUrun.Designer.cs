
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
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunBirimFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunStokMiktari = new DevExpress.XtraEditors.TextEdit();
            this.btnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(183, 182);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(138, 224);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ürün Birim Fiyatı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(134, 265);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ürün Stok Miktarı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(283, 179);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.BeepOnError = false;
            this.txtUrunAdi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunAdi.Properties.MaskSettings.Set("mask", "[a-zA-Z]+");
            this.txtUrunAdi.Size = new System.Drawing.Size(125, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtUrunBirimFiyati
            // 
            this.txtUrunBirimFiyati.Location = new System.Drawing.Point(283, 221);
            this.txtUrunBirimFiyati.Name = "txtUrunBirimFiyati";
            this.txtUrunBirimFiyati.Properties.BeepOnError = false;
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunBirimFiyati.Size = new System.Drawing.Size(125, 22);
            this.txtUrunBirimFiyati.TabIndex = 4;
            // 
            // txtUrunStokMiktari
            // 
            this.txtUrunStokMiktari.Location = new System.Drawing.Point(283, 262);
            this.txtUrunStokMiktari.Name = "txtUrunStokMiktari";
            this.txtUrunStokMiktari.Properties.BeepOnError = false;
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunStokMiktari.Size = new System.Drawing.Size(125, 22);
            this.txtUrunStokMiktari.TabIndex = 5;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUrunKaydet.Appearance.Options.UseFont = true;
            this.btnUrunKaydet.Location = new System.Drawing.Point(328, 302);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(80, 32);
            this.btnUrunKaydet.TabIndex = 6;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 564);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtUrunStokMiktari);
            this.Controls.Add(this.txtUrunBirimFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun";
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).EndInit();
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