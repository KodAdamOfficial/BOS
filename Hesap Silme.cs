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
    public partial class Hesap_Silme : Form
    {
        public Hesap_Silme()
        {
            InitializeComponent();
        }
        public MusteriSinifi Mu { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HesapSinifi i in Mu.HesapListesi)
            {
                if (Convert.ToInt32(txtHNo.Text) == i.Hesapno && i.Bakiye == 0m)
                {
                    Mu.HesapListesi.Remove(i);
                    MessageBox.Show("Hesabınız başarıyla silinmiştir..\nBilgileriniz gücellenmesi için tekrar giriş yapınız!");
                    goto a1;
                }
                else if (Convert.ToInt32(txtHNo.Text) == i.Hesapno)
                {
                    MessageBox.Show("Girilen Hesapta Para Bulunmaktadır Öncelikle Hesap Bakiyesini Sıfırlayınız..");
                    goto a1;
                }
            }
            MessageBox.Show("Adınıza kayıtlı böyle bir hesap bulunmamktadır.");
            a1: this.Close();
        }
    }
}
