
namespace FormExamples
{
    partial class Form1
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
            this.txtParagraf = new DevExpress.XtraEditors.TextEdit();
            this.btnSonuc = new DevExpress.XtraEditors.SimpleButton();
            this.listSonuc = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtParagraf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParagraf
            // 
            this.txtParagraf.Location = new System.Drawing.Point(47, 54);
            this.txtParagraf.Name = "txtParagraf";
            this.txtParagraf.Size = new System.Drawing.Size(227, 20);
            this.txtParagraf.TabIndex = 0;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(199, 107);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 1;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // listSonuc
            // 
            this.listSonuc.Location = new System.Drawing.Point(324, 57);
            this.listSonuc.Name = "listSonuc";
            this.listSonuc.Size = new System.Drawing.Size(120, 95);
            this.listSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 384);
            this.Controls.Add(this.listSonuc);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.txtParagraf);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtParagraf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtParagraf;
        private DevExpress.XtraEditors.SimpleButton btnSonuc;
        private DevExpress.XtraEditors.ListBoxControl listSonuc;
    }
}

