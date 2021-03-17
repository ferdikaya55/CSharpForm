
namespace WindowsFormsApDevex
{
    partial class FrmMusteri
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
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriTelefon = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriAdresi = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(263, 123);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Properties.BeepOnError = false;
            this.txtMusteriAdi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriAdi.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriAdi.Properties.MaskSettings.Set("mask", "[a-zA-Z]+");
            this.txtMusteriAdi.Size = new System.Drawing.Size(133, 20);
            this.txtMusteriAdi.TabIndex = 0;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(263, 163);
            this.txtMusteriTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Properties.BeepOnError = false;
            this.txtMusteriTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriTelefon.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.txtMusteriTelefon.Size = new System.Drawing.Size(133, 20);
            this.txtMusteriTelefon.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(338, 251);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(58, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(154, 130);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(127, 166);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Müşteri Telefonu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(140, 205);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Müşteri Adresi";
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.Location = new System.Drawing.Point(263, 203);
            this.txtMusteriAdresi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Size = new System.Drawing.Size(133, 40);
            this.txtMusteriAdresi.TabIndex = 1;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 518);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMusteriTelefon);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.txtMusteriAdresi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private DevExpress.XtraEditors.TextEdit txtMusteriTelefon;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtMusteriAdresi;
    }
}