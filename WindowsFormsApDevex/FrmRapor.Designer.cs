
namespace WindowsFormsApDevex
{
    partial class FrmRapor
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
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnTariheGoreYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.report_32x321;
            this.btnYazdir.Location = new System.Drawing.Point(36, 34);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(104, 67);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTariheGoreYazdir
            // 
            this.btnTariheGoreYazdir.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.report_32x32;
            this.btnTariheGoreYazdir.Location = new System.Drawing.Point(167, 34);
            this.btnTariheGoreYazdir.Name = "btnTariheGoreYazdir";
            this.btnTariheGoreYazdir.Size = new System.Drawing.Size(118, 70);
            this.btnTariheGoreYazdir.TabIndex = 0;
            this.btnTariheGoreYazdir.Text = "TARİHE GÖRE\r\nYAZDIR";
            this.btnTariheGoreYazdir.Click += new System.EventHandler(this.btnTariheGoreYazdir_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 232);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTariheGoreYazdir);
            this.Name = "FrmRapor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTariheGoreYazdir;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
    }
}