using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

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
           
                ogrsif.PasswordChar = '*';
         

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

        
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        
        public void button3_Click_1(object sender, EventArgs e)
        {
            string ad = ogrno.Text;
            string sifre = ogrsif.Text;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login where ogrencino='" + ogrno.Text + "' AND sifre='" + ogrsif.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                kisiselBilgi obj = new kisiselBilgi();
                obj.GelenOgrNo = ad;
                obj.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();

            
            
            
        }
        
        
        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        OleDbConnection con1;
        OleDbCommand cmd1;
        OleDbDataReader dr1;

        private void button1_Click_2(object sender, EventArgs e)
        {
            string ad = akamail.Text;
            string sifre = akasif.Text;
            con1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");
            cmd1 = new OleDbCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT * FROM Login where akademikmail='" + akamail.Text + "' AND akademiksifre='" + akasif.Text + "'";
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                akademisyen aka2 = new akademisyen();
                aka2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con1.Close();


            /*// akademisyen giriş butonu
            akademisyen grs = new akademisyen();
            grs.Show();
            */ 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                ogrsif.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                ogrsif.PasswordChar = '*';
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 )  || (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void anaGiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            akasif.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                //karakteri göster.
                akasif.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                akasif.PasswordChar = '*';
            }
        }

        private void akamail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
