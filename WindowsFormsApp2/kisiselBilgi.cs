using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class kisiselBilgi : Form
    {
        public kisiselBilgi()
        {
            InitializeComponent();
        }

        public string GelenOgrNo;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void kisiselBilgi_Load(object sender, EventArgs e)
        {
            labelOgrno.Text = GelenOgrNo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //İSİM
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //SOYİSİM
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //TELEFON
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //ADRES
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //BÖLÜM
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //DOĞUM TARİHİ

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //KİMLİK NO
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //KAYIT TARİHİ
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //MAİL
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // pakatma butonu

            ogrenciGirisi o = new ogrenciGirisi();
            o.girisYapmısOgrNo = labelOgrno.Text;
            o.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
