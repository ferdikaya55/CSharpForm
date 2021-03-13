
namespace WindowsFormsApp1
{
    partial class SiparisDetay
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
            this.dataGridViewSiparisDetay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisDetay
            // 
            this.dataGridViewSiparisDetay.AllowUserToAddRows = false;
            this.dataGridViewSiparisDetay.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisDetay.AllowUserToOrderColumns = true;
            this.dataGridViewSiparisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisDetay.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewSiparisDetay.Name = "dataGridViewSiparisDetay";
            this.dataGridViewSiparisDetay.ReadOnly = true;
            this.dataGridViewSiparisDetay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewSiparisDetay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSiparisDetay.RowHeadersWidth = 51;
            this.dataGridViewSiparisDetay.RowTemplate.Height = 24;
            this.dataGridViewSiparisDetay.Size = new System.Drawing.Size(776, 277);
            this.dataGridViewSiparisDetay.TabIndex = 0;
            // 
            // SiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 481);
            this.Controls.Add(this.dataGridViewSiparisDetay);
            this.Name = "SiparisDetay";
            this.Text = "SiparisDetay";
            this.Load += new System.EventHandler(this.SiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSiparisDetay;
    }
}