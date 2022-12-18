using System;
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

            akademisyen frm = new akademisyen();
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
            
            sifreUnuttum sifre = new sifreUnuttum();
            sifre.Show();
            this.Hide();
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
           
                textBox3.PasswordChar = '*';
         

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //öğrenci groupbox
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //akademisyen groupbox
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // şifremi unuttum
            sifreUnuttum sfr = new sifreUnuttum();
            sfr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //akademisyen giriş
            akademisyen aka = new akademisyen();
            aka.Show();
            this.Hide();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // öğrenci giriş
            ogrenciGirisi ogr = new ogrenciGirisi();
            ogr.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // akademisyen giriş butonu
            akademisyen grs = new akademisyen();
            grs.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox3.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox3.PasswordChar = '*';
            }
        }
    }
}
