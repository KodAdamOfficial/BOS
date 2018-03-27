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
    public partial class Borç_Ödeme : Form
    {
        public Borç_Ödeme()
        {
            InitializeComponent();
        }
        public MusteriSinifi Mu;
        private void Borç_Ödeme_Load(object sender, EventArgs e)
        {
            foreach (HesapSinifi item in Mu.EkHesap)
            {
                lblBH.Text = item.Hesapno.ToString();
                break;
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            foreach (HesapSinifi item in Mu.EkHesap)
            {
                item.Bakiye += Convert.ToDecimal(txtOM.Text);
                foreach (HesapSinifi i in Mu.HesapListesi)
                {
                    if(Convert.ToInt32(txtOH.Text) == i.Hesapno)
                    {
                         i.Bakiye -= Convert.ToDecimal(txtOM.Text);
                    }
                    
                }
                Mu.HesapOzeti.Add("Ek Hesap No: " + item.Hesapno.ToString() + "\tÖdenen Tutar: " + txtOM.Text + "\tÖdeme Tarihi: " + DateTime.Today.ToString());
                Banka.BankayaGiren += Convert.ToDecimal(txtOM.Text);
                if (item.Bakiye == 0)
                {
                    Mu.EkHesap.Clear();
                }
                break;
            }
            this.Close();
        }
    }
}
