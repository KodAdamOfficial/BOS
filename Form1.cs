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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüsteriGiris mG = new MüsteriGiris();
            mG.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yeni_Kayıt yK = new Yeni_Kayıt();
            yK.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Müşteri_Listesi mL = new Müşteri_Listesi();
            mL.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Banka_Raporu bR = new Banka_Raporu();
            bR.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
