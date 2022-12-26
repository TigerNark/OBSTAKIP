using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class notGiris : Form
    {
        public notGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void not_bil_Load(object sender, EventArgs e)
        {





        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // not bilgileri çıkış butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        OleDbConnection con1;
        OleDbCommand cmd1;
        OleDbDataReader dr1;

        private void button3_Click(object sender, EventArgs e)
        {
            string no = sorgulananOgrenciNo.Text;
            string no2 = sorgulananOgrenciNo.Text;

            con1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");
            cmd1 = new OleDbCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT * FROM Ogrenci_kayitlari where ogrno='" + no + "' AND ogrno='" + no2 + "'";
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                // Veritabanına bağlanmak için bir OleDbConnection nesnesi oluşturun
                OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
                string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
                OleDbCommand command = new OleDbCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
                baglanti.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                sorgulananİsim.Text = reader["ogrenciIsim"].ToString();
                sorgulananSoyisim.Text = reader["ogrenciSoyisim"].ToString();

                //eğer öğrenciyi bulursa verilerini yazdırır 
            }
            else
            {
                //ama böyle bir öğrenci yoksa mesaj yazdırır
                MessageBox.Show("Böyle bir öğrenci yok");
            }

            con1.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Veritabanına bağlanmak için bir OleDbConnection nesnesi oluşturun
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            fv.Text = reader["fizik1"].ToString();
            ff.Text = reader["fizik2"].ToString();


            

           

            

            

            /*int Vnotu = (int)reader["fizik1"];
            int Fnotu = (int)reader["fizik2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                fizso.Text = "GEÇTİ";
            }
            else
            {
                fizso.Text = "KALDI";
            }
            fizort.Text = Sonuc.ToString();*/
        }

        private void kimya_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            kv.Text = reader["kimya1"].ToString();
            kf.Text = reader["kimya2"].ToString();

            

            
            /*
                        int Vnotu = (int)reader["kimya1"];
                        int Fnotu = (int)reader["kimya2"];

                        double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
                        if (Sonuc > 60)
                        {
                            fizso.Text = "GEÇTİ";
                        }
                        else
                        {
                            fizso.Text = "KALDI";
                        }
                        fizort.Text = Sonuc.ToString();*/
        }

        public void biyo_Click(object sender, EventArgs e)
        {

            

                    

                   
                    //-------------------------------



                    
                
            
            
        }
        

        private void lab_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            lv.Text = reader["lab1"].ToString();
            lf.Text = reader["lab2"].ToString();


            

            

            

        }

        private void prog_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            pv.Text = reader["prog1"].ToString();
            pf.Text = reader["prog2"].ToString();
           
            
        }

        private void sorgulananİsim_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            // kaydet butonu



            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update notlar set mat1='" + mv.Text + "',mat2='" + mf.Text + "',fizik1='" + fv.Text + "',fizik2='" + ff.Text + "',kimya1='" + kv.Text + "',kimya2='" + kf.Text + "',lab1='" + lv.Text + "',lab2='" + lf.Text + "',prog1='" + pv.Text + "',prog2='" + pf.Text + "' where ogrenciNo='" + sorgulananOgrenciNo.Text + "'";


            


            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Not Bilgisi Güncellendi");





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            mv.Text = reader["mat1"].ToString();
            mf.Text = reader["mat2"].ToString();
        }
    }
}
