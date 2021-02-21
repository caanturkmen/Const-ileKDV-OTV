using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Const
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV_ORANI=0.18, OTV_ORANI=0.45;
            double fiyat = 0, kdv_tutari = 0, ötv_tutari = 0, toplam = 0;
            fiyat = Convert.ToDouble(textBox1.Text);
            kdv_tutari = fiyat * KDV_ORANI;
            ötv_tutari = fiyat * OTV_ORANI;
            toplam = fiyat + kdv_tutari + ötv_tutari;
            textBox2.Text = Convert.ToString(kdv_tutari);
            textBox3.Text = Convert.ToString(ötv_tutari);
            textBox4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
