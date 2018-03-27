namespace ÖDEVV
{
    partial class Para_Yatırma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPYOnayla = new System.Windows.Forms.Button();
            this.txtPYHNo = new System.Windows.Forms.TextBox();
            this.txtPYBakiye = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bakiye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İşlem Yapılacak Hesap";
            // 
            // btnPYOnayla
            // 
            this.btnPYOnayla.Location = new System.Drawing.Point(157, 213);
            this.btnPYOnayla.Name = "btnPYOnayla";
            this.btnPYOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnPYOnayla.TabIndex = 8;
            this.btnPYOnayla.Text = "Onayla";
            this.btnPYOnayla.UseVisualStyleBackColor = true;
            this.btnPYOnayla.Click += new System.EventHandler(this.btnPYOnayla_Click);
            // 
            // txtPYHNo
            // 
            this.txtPYHNo.Location = new System.Drawing.Point(210, 53);
            this.txtPYHNo.Name = "txtPYHNo";
            this.txtPYHNo.Size = new System.Drawing.Size(100, 20);
            this.txtPYHNo.TabIndex = 7;
            // 
            // txtPYBakiye
            // 
            this.txtPYBakiye.Location = new System.Drawing.Point(210, 106);
            this.txtPYBakiye.Name = "txtPYBakiye";
            this.txtPYBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtPYBakiye.TabIndex = 6;
            // 
            // Para_Yatırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPYOnayla);
            this.Controls.Add(this.txtPYHNo);
            this.Controls.Add(this.txtPYBakiye);
            this.Name = "Para_Yatırma";
            this.Text = "Para_Yatırma";
            this.Load += new System.EventHandler(this.Para_Yatırma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPYOnayla;
        private System.Windows.Forms.TextBox txtPYHNo;
        private System.Windows.Forms.TextBox txtPYBakiye;
    }
}