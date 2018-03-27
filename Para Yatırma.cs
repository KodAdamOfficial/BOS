using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEVV
{
    public partial class Para_Yatırma : Form
    {
        public Para_Yatırma()
        {
            InitializeComponent();
        }
        public MusteriSinifi Mu { get; set; }
        private void btnPYOnayla_Click(object sender, EventArgs e)
        {
            foreach (HesapSinifi i in Mu.HesapListesi)
            {
                if (Convert.ToInt32(txtPYHNo.Text) == i.Hesapno)
                {
                    DateTime d = DateTime.Today;
                    Mu.HesapOzeti.Add("Hesap No: " + i.Hesapno.ToString() + "\tYatırılan Tutar:  " + txtPYBakiye.Text + "\tYatırma Tarihi: " + d.ToShortDateString());
                    i.Bakiye += Convert.ToDecimal(txtPYBakiye.Text);
                    Banka.BankayaGiren+= Convert.ToDecimal(txtPYBakiye.Text);
                    MessageBox.Show("Para yatırma işleminiz tamamlanmıştır.");
                }
            }
            this.Close();
        }

        private void Para_Yatırma_Load(object sender, EventArgs e)
        {

        }
    }
}
