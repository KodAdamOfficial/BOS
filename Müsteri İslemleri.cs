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
    public partial class Müsteri_İslemleri : Form
    {
        public Müsteri_İslemleri()
        {
            InitializeComponent();
        }
        public MusteriSinifi M { get; set; }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Çekmek İstenilen Hesap Yeterli Miktara Sahip Değilse Müşteri Adına Ek Hesap Açılır ve Buradan Borç Olarak Miktar Çekilir");
            Para_Çekme pC = new Para_Çekme();
            pC.Mu = M;
            pC.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Para_Yatırma pY = new Para_Yatırma();
            pY.Mu = M;
            pY.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Havale_İşlemleri hI = new Havale_İşlemleri();
            hI.Mu = M;
            hI.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hesap_Silme hS = new Hesap_Silme();
            hS.Mu = M;
            hS.ShowDialog();
            this.Close();
        }

        private void Müsteri_İslemleri_Load(object sender, EventArgs e)
        {
            lblAd.Text = M.Ad.ToString();
            lblSad.Text = M.SoyAd.ToString();
            lblTc.Text = M.TC.ToString();
            lblMtür.Text = M.MusteriTuru.ToString();
            lblTarih.Text=M.KayitTarihi.ToShortDateString();
            foreach (HesapSinifi i in M.HesapListesi)
            {
                comboBox1.Items.Add(i.Hesapno);
            }
            foreach (HesapSinifi item in M.EkHesap)
            {
                txtEkHesap.Text = item.Hesapno.ToString();
                lblEk.Text = item.Bakiye.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hesap_Özeti hO = new Hesap_Özeti();
            hO.Mu = M;
            hO.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b;
            b = Convert.ToInt32(comboBox1.SelectedItem);
            foreach (HesapSinifi i in M.HesapListesi)
            {
                if(b == i.Hesapno)
                {
                    lblBkiye.Text = i.Bakiye.ToString();
                }
            }
        }

        private void btnHAçma_Click(object sender, EventArgs e)
        {
            HesapSinifi h = new HesapSinifi();
            h.HesapNumarasiAtama();
            M.HesapListesi.Add(h);
            MessageBox.Show("Yeni Hesabınız Oluşturulmuştur\nBilgilerinizin Güncelleştirilmesi Adına Lütfen Yeniden Giriş Yapınız..");
            this.Close();
            MüsteriGiris mG = new MüsteriGiris();
            mG.ShowDialog();
        }

        private void btnBO_Click(object sender, EventArgs e)
        {
            Borç_Ödeme bO = new Borç_Ödeme();
            bO.Mu = M;
            bO.ShowDialog();
        }
    }
}
