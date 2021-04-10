
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
            this.btnTariheGoreYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnTariheGoreYazdir
            // 
            this.btnTariheGoreYazdir.ImageOptions.Image = global::WindowsFormsApDevex.Properties.Resources.report_32x32;
            this.btnTariheGoreYazdir.Location = new System.Drawing.Point(47, 33);
            this.btnTariheGoreYazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTariheGoreYazdir.Name = "btnTariheGoreYazdir";
            this.btnTariheGoreYazdir.Size = new System.Drawing.Size(157, 86);
            this.btnTariheGoreYazdir.TabIndex = 0;
            this.btnTariheGoreYazdir.Text = "TARİHE GÖRE\r\nYAZDIR";
            this.btnTariheGoreYazdir.Click += new System.EventHandler(this.btnTariheGoreYazdir_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 286);
            this.Controls.Add(this.btnTariheGoreYazdir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRapor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTariheGoreYazdir;
    }
}