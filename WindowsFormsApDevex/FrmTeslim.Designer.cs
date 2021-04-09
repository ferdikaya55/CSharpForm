
namespace WindowsFormsApDevex
{
    partial class FrmTeslim
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
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblOdemeSekli = new DevExpress.XtraEditors.LabelControl();
            this.txtTeslimatSekli = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimatSekli.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.save_16x162;
            this.btnKaydet.Location = new System.Drawing.Point(214, 88);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 25);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOdemeSekli.Appearance.Options.UseFont = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(91, 55);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(79, 13);
            this.lblOdemeSekli.TabIndex = 11;
            this.lblOdemeSekli.Text = "Teslimat Şekli";
            // 
            // txtTeslimatSekli
            // 
            this.txtTeslimatSekli.Location = new System.Drawing.Point(193, 51);
            this.txtTeslimatSekli.Name = "txtTeslimatSekli";
            this.txtTeslimatSekli.Properties.BeepOnError = false;
            this.txtTeslimatSekli.Size = new System.Drawing.Size(100, 20);
            this.txtTeslimatSekli.TabIndex = 10;
            // 
            // FrmTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 147);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.txtTeslimatSekli);
            this.Name = "FrmTeslim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teslimat";
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimatSekli.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblOdemeSekli;
        private DevExpress.XtraEditors.TextEdit txtTeslimatSekli;
    }
}