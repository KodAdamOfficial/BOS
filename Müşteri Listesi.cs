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
    public partial class Müşteri_Listesi : Form
    {
        public Müşteri_Listesi()
        {
            InitializeComponent();
        }

        private void Müşteri_Listesi_Load(object sender, EventArgs e)
        {
            foreach (MusteriSinifi item in MusteriSinifi.MusteriListesi)
            {
                listBML.Items.Add("Müşteri Adı Soyadı: " + item.Ad + "  " + item.SoyAd + "  Müşteri Kayı Tarihi: " + item.KayitTarihi.ToShortDateString() +"  Müşteri Türü: "+item.MusteriTuru);
            }
        }
    }
}
