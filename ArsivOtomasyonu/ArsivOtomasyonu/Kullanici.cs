using ArsivOtomasyonu.DOMAIN;
using ArsivOtomasyonu.SERVER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsivOtomasyonu
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new kullaniciService()).kullaniciKaydet(kullaniciIDTxt.Text,AdiTxt.Text, SoyadiTxt.Text, SifreTxt.Text, EMailTxt.Text, TelNoTxt.Text);
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            (new kullaniciService()).kullaniciKaydet(kullaniciIDTxt.Text,AdiTxt.Text, SoyadiTxt.Text, SifreTxt.Text, EMailTxt.Text, TelNoTxt.Text);
            kullanicilariOku();
        }
        void kullanicilariOku()
        {
            listBox1.Items.Clear();
            foreach (kullanici k in (new kullaniciService()).kullanicilariOku())
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new kullaniciService()).kullanicilariSil(((kullanici)listBox1.SelectedItem).KullaniciID);
            kullanicilariOku();
        }
    }
}
