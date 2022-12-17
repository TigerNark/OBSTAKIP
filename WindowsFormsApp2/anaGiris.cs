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
    public partial class anaGiris : Form
    {
        public anaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //akademisyen login butonu

            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //öğrenci login butonu

            ogrenciGirisi frm = new ogrenciGirisi();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //kapat butonu
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Şİfremi unuttum butonu
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //akademisyen k.adı 


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //akademisyen şifre


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //öğrenci k.adı 


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //öğrenci şifre 


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //öğrenci groupbox
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //akademisyen groupbox
        }
    }
}
