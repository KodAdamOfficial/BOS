namespace ÖDEVV
{
    partial class Müşteri_Listesi
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
            this.listBML = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBML
            // 
            this.listBML.FormattingEnabled = true;
            this.listBML.Location = new System.Drawing.Point(44, 53);
            this.listBML.Name = "listBML";
            this.listBML.Size = new System.Drawing.Size(813, 355);
            this.listBML.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Listesi";
            // 
            // Müşteri_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBML);
            this.Name = "Müşteri_Listesi";
            this.Text = "Müşteri_Listesi";
            this.Load += new System.EventHandler(this.Müşteri_Listesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBML;
        private System.Windows.Forms.Label label1;
    }
}