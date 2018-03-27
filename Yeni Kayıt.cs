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
    public partial class Yeni_Kayıt : Form
    {

        //MusteriSinifi mL = new MusteriSinifi();
        HesapSinifi hS = new HesapSinifi();
        public Yeni_Kayıt()
        {
            InitializeComponent();
        }

        private void Yeni_Kayıt_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;
            txtKTarih.Text = d.ToShortDateString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
#pragma warning disable CS0252 // İstenmeden yapılmış olabilecek başvuru karşılaştırması, sol taraf için atama gerekiyor
            if (comboBox1.SelectedItem == "Ticari")
#pragma warning restore CS0252 // İstenmeden yapılmış olabilecek başvuru karşılaştırması, sol taraf için atama gerekiyor
            {
                TicariMusteri tm = new TicariMusteri();
                
                if(txtKTc.TextLength == 11 && txtKSifre.TextLength == 4)
                {
                    tm.KayitTarihi = DateTime.Today;
                    tm.Ad = txtKAd.Text.ToString();
                    tm.SoyAd = txtKSAd.Text.ToString();
                    tm.TC = Convert.ToInt64(txtKTc.Text);
                    tm.Sifre = Convert.ToInt32(txtKSifre.Text);
                    hS.HesapNumarasiAtama();
                    tm.HesapListesi.Add(hS);
                    tm.YeniMusteri(tm);
                    tm.MusteriTuru = "Ticari Müşteri";
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız.\nLütfen Bilgilerinizi Kontrol Ediniz.");
                    this.Close();
                    Yeni_Kayıt Yk = new Yeni_Kayıt();
                    Yk.Show();
                }
                
            }
            else
            {
                BireyselMusteri bm = new BireyselMusteri();
                
                if (txtKTc.TextLength == 11 && txtKSifre.TextLength == 4)
                {
                    bm.KayitTarihi = DateTime.Today;
                    bm.Ad = txtKAd.Text.ToString();
                    bm.SoyAd = txtKSAd.Text.ToString();
                    bm.TC = Convert.ToInt64(txtKTc.Text);
                    bm.Sifre = Convert.ToInt32(txtKSifre.Text);
                    hS.HesapNumarasiAtama();
                    bm.HesapListesi.Add(hS);
                    bm.YeniMusteri(bm);
                    bm.MusteriTuru = "Bireysel Müşteri";
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız.\nLütfen Bilgilerinizi Kontrol Ediniz.");
                    this.Close();
                    Yeni_Kayıt Yk = new Yeni_Kayıt();
                    Yk.Show();
                }
            }
            
            

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz tam bir şekilde eksiksiz doldurmalısınız.\n" +
                "Belirleyeceğiniz şifre 4 haneli olmalı ve yalnızca sayılardan oluşmalıdır.\n" +
                "Kayıt oluşturulduğunda bankamız otomatik olarak adınıza bir hesap açacaktır.");
        }
    }
}
