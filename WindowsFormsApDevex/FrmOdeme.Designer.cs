
namespace WindowsFormsApDevex
{
    partial class FrmOdeme
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
            this.lblOdemeSekli = new DevExpress.XtraEditors.LabelControl();
            this.txtOdemeSekli = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeSekli.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOdemeSekli.Appearance.Options.UseFont = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(76, 44);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(70, 13);
            this.lblOdemeSekli.TabIndex = 8;
            this.lblOdemeSekli.Text = "Ödeme Şekli";
            // 
            // txtOdemeSekli
            // 
            this.txtOdemeSekli.Location = new System.Drawing.Point(178, 40);
            this.txtOdemeSekli.Name = "txtOdemeSekli";
            this.txtOdemeSekli.Properties.BeepOnError = false;
            this.txtOdemeSekli.Size = new System.Drawing.Size(100, 20);
            this.txtOdemeSekli.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x162;
            this.btnKaydet.Location = new System.Drawing.Point(199, 77);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 25);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 114);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.txtOdemeSekli);
            this.Name = "FrmOdeme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeSekli.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOdemeSekli;
        private DevExpress.XtraEditors.TextEdit txtOdemeSekli;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}