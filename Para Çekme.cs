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
    public partial class Para_Çekme : Form
    {
        public Para_Çekme()
        {
            InitializeComponent();
        }
        HesapSinifi hS = new HesapSinifi();
        public MusteriSinifi Mu { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (HesapSinifi i in Mu.HesapListesi)
            {
                
                if (Convert.ToInt32(txtPCHNo.Text) == i.Hesapno && i.Bakiye >= Convert.ToDecimal(txtPCBakiye.Text))
                {
                    if((i.Limit+ Convert.ToDecimal(txtPCBakiye.Text)) <= 750m)
                    {
                        DateTime d = DateTime.Today;
                        Mu.HesapOzeti.Add("Hesap No: "+i.Hesapno.ToString()+"\tÇekilen Tutar: "+txtPCBakiye.Text+"                 Çekim Tarihi: "+ d.ToShortDateString());                   
                          i.Bakiye -= Convert.ToDecimal(txtPCBakiye.Text);
                          i.Limit += Convert.ToDecimal(txtPCBakiye.Text);
                          Banka.BankadanÇıkan+= Convert.ToDecimal(txtPCBakiye.Text);
                        MessageBox.Show("Para çekme işleminiz tamamlanmıştır.");
                    }
                    else
                    {
                        
                        MessageBox.Show("Günlük Para Çekim Limitinizin Dolmasına "+ (750m - i.Limit)  + " Lira Kalmıştır.");
                        goto g;
                    }
                    
                }
                else if(Convert.ToInt32(txtPCHNo.Text) == i.Hesapno && i.Bakiye < Convert.ToDecimal(txtPCBakiye.Text))
                {
                    
                    if(Mu.EkHesap.Count != 0)
                    {
                        goto usak;
                    }
                    hS.HesapNumarasiAtama();
                    Mu.EkHesap.Add(hS);
                    usak: foreach (HesapSinifi item in Mu.EkHesap)
                    {
                        DateTime d = DateTime.Today;
                        Mu.HesapOzeti.Add("Ek Hesap No: " + item.Hesapno.ToString() + "\tÇekilen Tutar: " + txtPCBakiye.Text + "                 Çekim Tarihi: " + d.ToShortDateString());
                        Banka.BankadanÇıkan += Convert.ToDecimal(txtPCBakiye.Text);
                        item.Bakiye -= Convert.ToDecimal(txtPCBakiye.Text) - i.Bakiye;
                        i.Bakiye = 0m;
                        break;
                    }
                    
                }
                
            }
            g: this.Close();
        }

        private void btnPYatır_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void txtPCBakiye_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPCBakiye_Leave(object sender, EventArgs e)
        {
            
            if (txtPCBakiye.Text != "")
            {
                try
                {
                    if (Convert.ToDecimal(txtPCBakiye.Text) < 0 || Convert.ToDecimal(txtPCBakiye.Text) > 750)
                    {
                        MessageBox.Show("Günlük Para Çekim Limiti 750 Türk Lirasıdır..");
                        txtPCBakiye.Text = "";
                        txtPCBakiye.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Sayısal bir değer girin");
                    txtPCBakiye.Text = "";
                    txtPCBakiye.Focus();
                }
            }
        }
    }
}
