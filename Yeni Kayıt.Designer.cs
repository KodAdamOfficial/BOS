namespace ÖDEVV
{
    partial class Yeni_Kayıt
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKAd = new System.Windows.Forms.TextBox();
            this.txtKSAd = new System.Windows.Forms.TextBox();
            this.txtKTc = new System.Windows.Forms.TextBox();
            this.txtKTarih = new System.Windows.Forms.TextBox();
            this.txtKSifre = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Müşteri Kayıt Tarihi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri Türü:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC Kimlik Numarası:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifre Oluştur:";
            // 
            // txtKAd
            // 
            this.txtKAd.Location = new System.Drawing.Point(209, 45);
            this.txtKAd.Name = "txtKAd";
            this.txtKAd.Size = new System.Drawing.Size(100, 20);
            this.txtKAd.TabIndex = 11;
            // 
            // txtKSAd
            // 
            this.txtKSAd.Location = new System.Drawing.Point(209, 79);
            this.txtKSAd.Name = "txtKSAd";
            this.txtKSAd.Size = new System.Drawing.Size(100, 20);
            this.txtKSAd.TabIndex = 12;
            this.txtKSAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKTc
            // 
            this.txtKTc.Location = new System.Drawing.Point(209, 115);
            this.txtKTc.Name = "txtKTc";
            this.txtKTc.Size = new System.Drawing.Size(100, 20);
            this.txtKTc.TabIndex = 13;
            // 
            // txtKTarih
            // 
            this.txtKTarih.Location = new System.Drawing.Point(209, 180);
            this.txtKTarih.Name = "txtKTarih";
            this.txtKTarih.Size = new System.Drawing.Size(100, 20);
            this.txtKTarih.TabIndex = 15;
            // 
            // txtKSifre
            // 
            this.txtKSifre.Location = new System.Drawing.Point(209, 211);
            this.txtKSifre.Name = "txtKSifre";
            this.txtKSifre.PasswordChar = '*';
            this.txtKSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKSifre.TabIndex = 16;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(149, 272);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 17;
            this.btnKayit.Text = "Kayıt Oluştur";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ticari",
            "Bireysel"});
            this.comboBox1.Location = new System.Drawing.Point(209, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ÖDEVV.Properties.Resources._6260754_55691952;
            this.button1.Location = new System.Drawing.Point(327, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 53);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yeni_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtKSifre);
            this.Controls.Add(this.txtKTarih);
            this.Controls.Add(this.txtKTc);
            this.Controls.Add(this.txtKSAd);
            this.Controls.Add(this.txtKAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yeni_Kayıt";
            this.Text = "Yeni Kayıt";
            this.Load += new System.EventHandler(this.Yeni_Kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKAd;
        private System.Windows.Forms.TextBox txtKSAd;
        private System.Windows.Forms.TextBox txtKTc;
        private System.Windows.Forms.TextBox txtKTarih;
        private System.Windows.Forms.TextBox txtKSifre;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}