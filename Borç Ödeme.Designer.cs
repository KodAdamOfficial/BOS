namespace ÖDEVV
{
    partial class Borç_Ödeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOM = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borçlu Hesap";
            // 
            // lblBH
            // 
            this.lblBH.AutoSize = true;
            this.lblBH.Location = new System.Drawing.Point(159, 58);
            this.lblBH.Name = "lblBH";
            this.lblBH.Size = new System.Drawing.Size(0, 13);
            this.lblBH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeneceek Miktar";
            // 
            // txtOM
            // 
            this.txtOM.Location = new System.Drawing.Point(162, 124);
            this.txtOM.Name = "txtOM";
            this.txtOM.Size = new System.Drawing.Size(100, 20);
            this.txtOM.TabIndex = 3;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(96, 178);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 4;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ödeme Yapacak Hesap";
            // 
            // txtOH
            // 
            this.txtOH.Location = new System.Drawing.Point(162, 83);
            this.txtOH.Name = "txtOH";
            this.txtOH.Size = new System.Drawing.Size(100, 20);
            this.txtOH.TabIndex = 6;
            // 
            // Borç_Ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 230);
            this.Controls.Add(this.txtOH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBH);
            this.Controls.Add(this.label1);
            this.Name = "Borç_Ödeme";
            this.Text = "Borç_Ödeme";
            this.Load += new System.EventHandler(this.Borç_Ödeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOM;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOH;
    }
}