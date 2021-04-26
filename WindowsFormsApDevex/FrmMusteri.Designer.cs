
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMusteriTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriAdresi = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriFax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriEmail = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Müşteri Telefonu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x162;
            this.btnKaydet.Location = new System.Drawing.Point(373, 133);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 25);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(126, 57);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Properties.BeepOnError = false;
            this.txtMusteriTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriTelefon.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.txtMusteriTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTelefon.TabIndex = 1;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(126, 25);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Properties.BeepOnError = false;
            this.txtMusteriAdi.Properties.MaxLength = 50;
            this.txtMusteriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdi.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Müşteri Adresi";
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.Location = new System.Drawing.Point(126, 88);
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Size = new System.Drawing.Size(100, 32);
            this.txtMusteriAdresi.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(243, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Müşteri Vergi No";
            // 
            // txtMusteriVergiNo
            // 
            this.txtMusteriVergiNo.Location = new System.Drawing.Point(352, 27);
            this.txtMusteriVergiNo.Name = "txtMusteriVergiNo";
            this.txtMusteriVergiNo.Properties.BeepOnError = false;
            this.txtMusteriVergiNo.Properties.MaxLength = 50;
            this.txtMusteriVergiNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriVergiNo.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(243, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Müşteri Fax";
            // 
            // txtMusteriFax
            // 
            this.txtMusteriFax.Location = new System.Drawing.Point(352, 57);
            this.txtMusteriFax.Name = "txtMusteriFax";
            this.txtMusteriFax.Properties.BeepOnError = false;
            this.txtMusteriFax.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMusteriFax.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtMusteriFax.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.txtMusteriFax.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriFax.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(243, 96);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Müşteri Email";
            // 
            // txtMusteriEmail
            // 
            this.txtMusteriEmail.Location = new System.Drawing.Point(352, 93);
            this.txtMusteriEmail.Name = "txtMusteriEmail";
            this.txtMusteriEmail.Properties.BeepOnError = false;
            this.txtMusteriEmail.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriEmail.TabIndex = 15;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 174);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMusteriEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMusteriFax);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMusteriVergiNo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMusteriAdresi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMusteriTelefon);
            this.Controls.Add(this.txtMusteriAdi);
            this.Name = "FrmMusteri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMusteriVergiNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMusteriFax;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMusteriEmail;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}