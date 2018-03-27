namespace ÖDEVV
{
    partial class Para_Çekme
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
            this.txtPCBakiye = new System.Windows.Forms.TextBox();
            this.txtPCHNo = new System.Windows.Forms.TextBox();
            this.btnPCOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPCBakiye
            // 
            this.txtPCBakiye.Location = new System.Drawing.Point(191, 107);
            this.txtPCBakiye.Name = "txtPCBakiye";
            this.txtPCBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtPCBakiye.TabIndex = 0;
            this.txtPCBakiye.TextChanged += new System.EventHandler(this.txtPCBakiye_TextChanged);
            this.txtPCBakiye.Leave += new System.EventHandler(this.txtPCBakiye_Leave);
            // 
            // txtPCHNo
            // 
            this.txtPCHNo.Location = new System.Drawing.Point(191, 54);
            this.txtPCHNo.Name = "txtPCHNo";
            this.txtPCHNo.Size = new System.Drawing.Size(100, 20);
            this.txtPCHNo.TabIndex = 1;
            // 
            // btnPCOnayla
            // 
            this.btnPCOnayla.Location = new System.Drawing.Point(138, 214);
            this.btnPCOnayla.Name = "btnPCOnayla";
            this.btnPCOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnPCOnayla.TabIndex = 2;
            this.btnPCOnayla.Text = "Onayla";
            this.btnPCOnayla.UseVisualStyleBackColor = true;
            this.btnPCOnayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İşlem Yapılacak Hesap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bakiye";
            // 
            // Para_Çekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPCOnayla);
            this.Controls.Add(this.txtPCHNo);
            this.Controls.Add(this.txtPCBakiye);
            this.Name = "Para_Çekme";
            this.Text = "Para_Çekme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPCBakiye;
        private System.Windows.Forms.TextBox txtPCHNo;
        private System.Windows.Forms.Button btnPCOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}