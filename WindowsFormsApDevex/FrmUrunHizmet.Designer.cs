
namespace WindowsFormsApDevex
{
    partial class FrmUrunHizmet
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
            this.txtHizmetKdvOrani = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnUrunHizmetKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunHizmetAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunHizmetBirimFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunHizmetAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetBirimFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHizmetKdvOrani
            // 
            this.txtHizmetKdvOrani.Location = new System.Drawing.Point(206, 193);
            this.txtHizmetKdvOrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHizmetKdvOrani.Name = "txtHizmetKdvOrani";
            this.txtHizmetKdvOrani.Properties.BeepOnError = false;
            this.txtHizmetKdvOrani.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtHizmetKdvOrani.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtHizmetKdvOrani.Size = new System.Drawing.Size(147, 22);
            this.txtHizmetKdvOrani.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(80, 197);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Ürün Kdv Oranı";
            // 
            // btnUrunHizmetKaydet
            // 
            this.btnUrunHizmetKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUrunHizmetKaydet.Appearance.Options.UseFont = true;
            this.btnUrunHizmetKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x164;
            this.btnUrunHizmetKaydet.Location = new System.Drawing.Point(242, 240);
            this.btnUrunHizmetKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrunHizmetKaydet.Name = "btnUrunHizmetKaydet";
            this.btnUrunHizmetKaydet.Size = new System.Drawing.Size(111, 32);
            this.btnUrunHizmetKaydet.TabIndex = 12;
            this.btnUrunHizmetKaydet.Text = "KAYDET";
            this.btnUrunHizmetKaydet.Click += new System.EventHandler(this.btnUrunHizmetKaydet_Click);
            // 
            // txtUrunHizmetAciklama
            // 
            this.txtUrunHizmetAciklama.Location = new System.Drawing.Point(206, 155);
            this.txtUrunHizmetAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunHizmetAciklama.Name = "txtUrunHizmetAciklama";
            this.txtUrunHizmetAciklama.Properties.BeepOnError = false;
            this.txtUrunHizmetAciklama.Size = new System.Drawing.Size(147, 22);
            this.txtUrunHizmetAciklama.TabIndex = 11;
            // 
            // txtUrunHizmetBirimFiyati
            // 
            this.txtUrunHizmetBirimFiyati.Location = new System.Drawing.Point(206, 114);
            this.txtUrunHizmetBirimFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunHizmetBirimFiyati.Name = "txtUrunHizmetBirimFiyati";
            this.txtUrunHizmetBirimFiyati.Properties.BeepOnError = false;
            this.txtUrunHizmetBirimFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUrunHizmetBirimFiyati.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtUrunHizmetBirimFiyati.Size = new System.Drawing.Size(147, 22);
            this.txtUrunHizmetBirimFiyati.TabIndex = 10;
            // 
            // txtUrunHizmetAdi
            // 
            this.txtUrunHizmetAdi.Location = new System.Drawing.Point(206, 69);
            this.txtUrunHizmetAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunHizmetAdi.Name = "txtUrunHizmetAdi";
            this.txtUrunHizmetAdi.Properties.BeepOnError = false;
            this.txtUrunHizmetAdi.Size = new System.Drawing.Size(147, 22);
            this.txtUrunHizmetAdi.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 158);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Ürün Açıklama";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Ürün Birim Fiyatı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 16);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Ürün Hizmet Adı";
            // 
            // FrmUrunHizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 341);
            this.Controls.Add(this.txtHizmetKdvOrani);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnUrunHizmetKaydet);
            this.Controls.Add(this.txtUrunHizmetAciklama);
            this.Controls.Add(this.txtUrunHizmetBirimFiyati);
            this.Controls.Add(this.txtUrunHizmetAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunHizmet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Hizmet ";
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetBirimFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHizmetAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtHizmetKdvOrani;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnUrunHizmetKaydet;
        private DevExpress.XtraEditors.TextEdit txtUrunHizmetAciklama;
        private DevExpress.XtraEditors.TextEdit txtUrunHizmetBirimFiyati;
        private DevExpress.XtraEditors.TextEdit txtUrunHizmetAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}