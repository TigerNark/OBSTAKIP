using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Linq;

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
        private void button3_Click_1(object sender, EventArgs e)
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
                ogrenciGirisi f2 = new ogrenciGirisi();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();

            /* öğrenci giriş
            ogrenciGirisi ogr = new ogrenciGirisi();
            ogr.Show();
            this.Hide();*/
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
