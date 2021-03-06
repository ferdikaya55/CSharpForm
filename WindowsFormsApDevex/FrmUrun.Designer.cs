
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
            this.txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(63, 126);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ürün Birim Fiyatı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(63, 167);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ürün Stok Miktarı";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUrunKaydet.Appearance.Options.UseFont = true;
            this.btnUrunKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x164;
            this.btnUrunKaydet.Location = new System.Drawing.Point(225, 249);
            this.btnUrunKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(111, 32);
            this.btnUrunKaydet.TabIndex = 3;
            this.btnUrunKaydet.Text = "KAYDET";
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // txtUrunStokMiktari
            // 
            this.txtUrunStokMiktari.Location = new System.Drawing.Point(189, 164);
            this.txtUrunStokMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunStokMiktari.Name = "txtUrunStokMiktari";
            this.txtUrunStokMiktari.Properties.BeepOnError = false;
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunStokMiktari.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunStokMiktari.Size = new System.Drawing.Size(147, 22);
            this.txtUrunStokMiktari.TabIndex = 2;
            // 
            // txtUrunBirimFiyati
            // 
            this.txtUrunBirimFiyati.Location = new System.Drawing.Point(189, 123);
            this.txtUrunBirimFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunBirimFiyati.Name = "txtUrunBirimFiyati";
            this.txtUrunBirimFiyati.Properties.BeepOnError = false;
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunBirimFiyati.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunBirimFiyati.Size = new System.Drawing.Size(147, 22);
            this.txtUrunBirimFiyati.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(189, 78);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.BeepOnError = false;
            this.txtUrunAdi.Size = new System.Drawing.Size(147, 22);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(189, 202);
            this.txtKdvOrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Properties.BeepOnError = false;
            this.txtKdvOrani.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtKdvOrani.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtKdvOrani.Size = new System.Drawing.Size(147, 22);
            this.txtKdvOrani.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(63, 206);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ürün Kdv Oranı";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 354);
            this.Controls.Add(this.txtKdvOrani);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtUrunStokMiktari);
            this.Controls.Add(this.txtUrunBirimFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUrun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun";
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunStokMiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunBirimFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}