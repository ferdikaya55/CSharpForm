
namespace WindowsFormsApp1
{
    partial class frmAnasayfa
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
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnSiparisIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(100, 60);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(199, 40);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // btnSiparisIslemleri
            // 
            this.btnSiparisIslemleri.Location = new System.Drawing.Point(100, 128);
            this.btnSiparisIslemleri.Name = "btnSiparisIslemleri";
            this.btnSiparisIslemleri.Size = new System.Drawing.Size(200, 38);
            this.btnSiparisIslemleri.TabIndex = 1;
            this.btnSiparisIslemleri.Text = "Sipariş İşlemleri";
            this.btnSiparisIslemleri.UseVisualStyleBackColor = true;
            this.btnSiparisIslemleri.Click += new System.EventHandler(this.btnSiparisIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.Location = new System.Drawing.Point(100, 189);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(200, 37);
            this.btnUrunIslemleri.TabIndex = 2;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = true;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.btnUrunIslemleri);
            this.Controls.Add(this.btnSiparisIslemleri);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "frmAnasayfa";
            this.Text = "frmAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnSiparisIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
    }
}