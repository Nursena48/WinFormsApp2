using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.admin
{
    public partial class frmText : Form
    {
        public frmText()
        {
            InitializeComponent();
        }

        private void btnKareHesaplama_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();

        }

        private void btnTekmiciftmi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                label1.Text = "Çift";

            }
            else
            {
                label1.Text = "Tek";
            }
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
            int sayi,birler, onlar, yuzler, toplam;
            sayi = Convert.ToInt32(textBox1.Text);
            birler = sayi % 10;
            yuzler = sayi / 100;
            onlar = (sayi / 10) % 10;
            toplam = birler + onlar + yüzler;
            label1.Text = toplam.ToString();
        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {
             
        }
    }
}
