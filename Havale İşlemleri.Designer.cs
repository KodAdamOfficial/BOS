namespace ÖDEVV
{
    partial class Havale_İşlemleri
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
            this.btnHOnay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHHNa = new System.Windows.Forms.TextBox();
            this.txtHBakiye = new System.Windows.Forms.TextBox();
            this.cmbHHNg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHOnay
            // 
            this.btnHOnay.Location = new System.Drawing.Point(243, 237);
            this.btnHOnay.Name = "btnHOnay";
            this.btnHOnay.Size = new System.Drawing.Size(91, 37);
            this.btnHOnay.TabIndex = 0;
            this.btnHOnay.Text = "Onayla";
            this.btnHOnay.UseVisualStyleBackColor = true;
            this.btnHOnay.Click += new System.EventHandler(this.btnHOnay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Havale Yapacak Hesap No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Havale Yapılacak Hesap No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Havale Yapılacak Miktar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHHNa
            // 
            this.txtHHNa.Location = new System.Drawing.Point(41, 130);
            this.txtHHNa.Name = "txtHHNa";
            this.txtHHNa.Size = new System.Drawing.Size(100, 20);
            this.txtHHNa.TabIndex = 5;
            // 
            // txtHBakiye
            // 
            this.txtHBakiye.Location = new System.Drawing.Point(41, 215);
            this.txtHBakiye.Name = "txtHBakiye";
            this.txtHBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtHBakiye.TabIndex = 6;
            // 
            // cmbHHNg
            // 
            this.cmbHHNg.FormattingEnabled = true;
            this.cmbHHNg.Location = new System.Drawing.Point(41, 72);
            this.cmbHHNg.Name = "cmbHHNg";
            this.cmbHHNg.Size = new System.Drawing.Size(121, 21);
            this.cmbHHNg.TabIndex = 7;
            // 
            // Havale_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 313);
            this.Controls.Add(this.cmbHHNg);
            this.Controls.Add(this.txtHBakiye);
            this.Controls.Add(this.txtHHNa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOnay);
            this.Name = "Havale_İşlemleri";
            this.Text = "Havale İşlemleri";
            this.Load += new System.EventHandler(this.Havale_İşlemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHOnay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHHNa;
        private System.Windows.Forms.TextBox txtHBakiye;
        private System.Windows.Forms.ComboBox cmbHHNg;
    }
}