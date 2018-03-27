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
    public partial class Havale_İşlemleri : Form
    {
        public Havale_İşlemleri()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public MusteriSinifi Mu { get; set; }
        private void btnHOnay_Click(object sender, EventArgs e)
        {
            
            foreach (MusteriSinifi i in MusteriSinifi.MusteriListesi)
            {
                foreach  (HesapSinifi it in i.HesapListesi)
                {
                    if (Convert.ToInt32(cmbHHNg.SelectedItem) == it.Hesapno)
                    {
                        if(i.MusteriTuru == "Ticari Müşteri")
                        {
                            TicariMusteri t = new TicariMusteri();
                            
                            it.Bakiye -= (Convert.ToDecimal(txtHBakiye.Text)+ t.hvl(Convert.ToDecimal(txtHBakiye.Text)));
                        }
                        else
                        {
                            BireyselMusteri b = new BireyselMusteri();
                            it.Bakiye -= (Convert.ToDecimal(txtHBakiye.Text) + b.hvl(Convert.ToDecimal(txtHBakiye.Text)));
                        }
                        
                        i.HesapOzeti.Add("Gönderen Hesap No: " + it.Hesapno.ToString() +"\tAlıcı Hesap No:"+ txtHHNa.Text + "\tHavale miktarı: " + txtHBakiye.Text + "\tHavale Tarihi: " + DateTime.Today.ToString());
                    }
                    if (Convert.ToInt32(txtHHNa.Text) == it.Hesapno)
                    {
                       it.Bakiye += Convert.ToDecimal(txtHBakiye.Text);
                        i.HesapOzeti.Add("Gönderen Hesap No: " +cmbHHNg.SelectedItem+ "\tAlıcı Hesap No:" +it.Hesapno.ToString() + "\tHavale miktarı: " + txtHBakiye.Text + "\tHavale Tarihi: " + DateTime.Today.ToString());
                    }
                }
            }
            MessageBox.Show("İşlem Başarıyla Gerçekleştirilmiştir.");
            this.Close();
        }

        private void Havale_İşlemleri_Load(object sender, EventArgs e)
        {
            foreach (HesapSinifi item in Mu.HesapListesi)
            {
                cmbHHNg.Items.Add(item.Hesapno.ToString());
            }
        }
    }
}
