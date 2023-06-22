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
    public partial class Evrak : Form
    {
        public Evrak()
        {
            InitializeComponent();
        }

        private void Evrak_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new evrakService()).evrakKaydet(evrakIDTxt.Text, evrakAdiTxt.Text, evrakTuruTxt.Text, evrakYiliTxt.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new evrakService()).evrakKaydet(evrakIDTxt.Text, evrakAdiTxt.Text, evrakTuruTxt.Text, evrakYiliTxt.Text);

            evraklariOku();
        }
        void evraklariOku()
        {
            listBox1.Items.Clear();
            foreach (evrak e in (new evrakService()).evraklariOku())
            {
                listBox1.Items.Add(e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new evrakService()).evraklariSil(((evrak)listBox1.SelectedItem).EvrakID);
            evraklariOku();
        }
    }
}
