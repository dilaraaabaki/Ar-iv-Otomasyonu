using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArsivOtomasyonu.DOMAIN;
using ArsivOtomasyonu.SERVER;
using static System.Net.Mime.MediaTypeNames;

namespace ArsivOtomasyonu
{
    public partial class Departman : Form
    {
        public Departman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            (new departmanService()).departmanKaydet(departmanAdiTxt.Text, departmanIDTxt.Text);
        }

        private void DepartmanEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new departmanService()).departmanKaydet(departmanAdiTxt.Text, departmanIDTxt.Text);

            departmanlariOku();
        }
        void departmanlariOku()
        {
            listBox1.Items.Clear();
            foreach (departman d in (new departmanService()).departmanlariOku())
            {
                listBox1.Items.Add(d);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new departmanService()).departmanlariSil( ((departman)listBox1.SelectedItem).Id);
            departmanlariOku();
        }

        private void departmanAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
