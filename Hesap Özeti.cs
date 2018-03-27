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
    public partial class Hesap_Özeti : Form
    {
        public Hesap_Özeti()
        {
            InitializeComponent();
        }
        public MusteriSinifi Mu { get; set; }
        private void Hesap_Özeti_Load(object sender, EventArgs e)
        {
            foreach (string item in Mu.HesapOzeti)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
