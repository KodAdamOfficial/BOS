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
    public partial class MüsteriGiris : Form
    {
        public MüsteriGiris()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Müsteri_İslemleri mI = new Müsteri_İslemleri();
            foreach (MusteriSinifi item in MusteriSinifi.MusteriListesi)
            {
                if(txtTc.Text.ToString() == item.TC.ToString() && txtSifre.Text.ToString() == item.Sifre.ToString())
                {
                    MessageBox.Show("Giriş Başarılı !");
                    mI.M = item;
                    goto ok;

                }               
            }
            MessageBox.Show("Hatalı Giriş Yapıldı..");
            txtSifre.Clear();
            txtTc.Clear();
            
            goto no;
            ok: mI.Show();
            
            no: this.Close();



        }
    }
}
