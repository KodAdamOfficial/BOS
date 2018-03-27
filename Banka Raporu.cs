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
    public partial class Banka_Raporu : Form
    {
        public Banka_Raporu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Banka_Raporu_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;
            Banka.TotalPara = Banka.BankayaGiren - Banka.BankadanÇıkan;
            dataGridView1.Rows[0].Cells[0].Value = d.ToShortDateString();
            dataGridView1.Rows[0].Cells[1].Value = Banka.BankadanÇıkan;
            dataGridView1.Rows[0].Cells[2].Value = Banka.BankayaGiren;
            dataGridView1.Rows[0].Cells[3].Value = Banka.TotalPara;
        }
    }
}
