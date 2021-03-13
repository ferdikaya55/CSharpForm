
namespace WindowsFormsApp2
{
    partial class frmSiparisDetay
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
            this.dataGridViewSiparisDetayi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetayi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisDetayi
            // 
            this.dataGridViewSiparisDetayi.AllowUserToAddRows = false;
            this.dataGridViewSiparisDetayi.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisDetayi.AllowUserToOrderColumns = true;
            this.dataGridViewSiparisDetayi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparisDetayi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisDetayi.Location = new System.Drawing.Point(20, 76);
            this.dataGridViewSiparisDetayi.Name = "dataGridViewSiparisDetayi";
            this.dataGridViewSiparisDetayi.ReadOnly = true;
            this.dataGridViewSiparisDetayi.RowHeadersWidth = 51;
            this.dataGridViewSiparisDetayi.RowTemplate.Height = 24;
            this.dataGridViewSiparisDetayi.Size = new System.Drawing.Size(1058, 408);
            this.dataGridViewSiparisDetayi.TabIndex = 0;
            // 
            // frmSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 538);
            this.Controls.Add(this.dataGridViewSiparisDetayi);
            this.Name = "frmSiparisDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiparisDetaycs";
            this.Load += new System.EventHandler(this.frmSiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSiparisDetayi;
    }
}