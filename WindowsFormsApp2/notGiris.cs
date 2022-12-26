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
            v1.Text = reader["fizik1"].ToString();
            f1.Text = reader["fizik2"].ToString();

            int Vnotu = (int)reader["fizik1"];
            int Fnotu = (int)reader["fizik2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                s1.Text = "GEÇTİ";
            }
            else
            {
                s1.Text = "KALDI";
            }
            o1.Text = Sonuc.ToString();
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
            v1.Text = reader["kimya1"].ToString();
            f1.Text = reader["kimya2"].ToString();


            int Vnotu = (int)reader["kimya1"];
            int Fnotu = (int)reader["kimya2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                s1.Text = "GEÇTİ";
            }
            else
            {
                s1.Text = "KALDI";
            }
            o1.Text = Sonuc.ToString();
        }

        public void biyo_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            v1.Text = reader["biyo1"].ToString();
            f1.Text = reader["biyo2"].ToString();


            int Vnotu = (int)reader["biyo1"];
            int Fnotu = (int)reader["biyo2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                s1.Text = "GEÇTİ";
            }
            else
            {
                s1.Text = "KALDI";
            }
            o1.Text = Sonuc.ToString();
            void button2_Click()
            {

                // kaydet butonu


                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb;";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO notlar (ogrenciNo, biyo1, biyo2) VALUES (@ogrenciNo, @biyo1, @biyo2)";

                    using (OleDbCommand command1 = new OleDbCommand(query, connection))
                    {

                        command1.Parameters.AddWithValue("@biyo1", v1.Text);
                        command1.Parameters.AddWithValue("@biyo2", f1.Text);
                        command1.ExecuteNonQuery();
                    }
                }






                /*
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");


                baglanti.Open();// bağlantı açıldı
                //sorgu komut yapısı oluşturuldu
                 OleDbCommand sorgu = new OleDbCommand()
                {

                }

                sorgu.Connection = baglanti;


                string vize = v1.Text;
                string final = f1.Text;


                sorgu.CommandType = CommandType.Text;
                //string query = "INSERT INTO notlar (ogrenciNo, biyo1,biyo2,fizik1,fizik2,kimya1,kimya2,lab1,lab2,prog1,prog2) values (@ogrenciNo, @biyo1,@biyo2,@fizik1,@fizik2,@kimya1,@kimya2,@lab1,@lab2,@prog1,@prog2)";


                if (biyo.Enabled == true && v1.Enabled == true && f1.Enabled == true)
                {
                    sorgu.CommandText = "insert into notlar (ogrenciNo, biyo1,biyo2) values (@ogrenciNo,@biyo1,@biyo2)";
                    sorgu.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
                    sorgu.Parameters.AddWithValue("@biyo1", vize);
                    sorgu.Parameters.AddWithValue("@biyo2", final);
                    //sorgu.ExecuteNonQuery();
                }

                else if(fizik.Enabled == true && v1.Enabled==true && f1.Enabled==true)
                {
                    sorgu.Parameters.AddWithValue("@fizik1", vize);
                    sorgu.Parameters.AddWithValue("@fizik2", final);
                }
                else if(kimya.Enabled == true)
                {
                    sorgu.Parameters.AddWithValue("@kimya1", vize);
                    sorgu.Parameters.AddWithValue("@kimya2", final);
                }
                else if(lab.Enabled== true)
                {
                    sorgu.Parameters.AddWithValue("@lab1", vize);
                    sorgu.Parameters.AddWithValue("@lab2", final);
                }
                else if(prog.Enabled == true)
                {
                    sorgu.Parameters.AddWithValue("@prog1", vize);
                    sorgu.Parameters.AddWithValue("@prog2", final);
                }



                MessageBox.Show("Not Değişiklikleri Yapılmıştır.");
                baglanti.Close();// bağlantı kapatıldı.

                */
            }
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
            v1.Text = reader["lab1"].ToString();
            f1.Text = reader["lab2"].ToString();


            int Vnotu = (int)reader["lab1"];
            int Fnotu = (int)reader["lab2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                s1.Text = "GEÇTİ";
            }
            else
            {
                s1.Text = "KALDI";
            }
            o1.Text = Sonuc.ToString();
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
            v1.Text = reader["prog1"].ToString();
            f1.Text = reader["prog2"].ToString();


            int Vnotu = (int)reader["prog1"];
            int Fnotu = (int)reader["prog2"];

            double Sonuc = ((Vnotu * 0.4) + (Fnotu * 0.6));
            if (Sonuc > 60)
            {
                s1.Text = "GEÇTİ";
            }
            else
            {
                s1.Text = "KALDI";
            }
            o1.Text = Sonuc.ToString();
        }

        private void sorgulananİsim_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            // kaydet butonu


            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO notlar (ogrenciNo, biyo1, biyo2) VALUES (@ogrenciNo, @biyo1, @biyo2)";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@biyo1", v1.Text);
                    command.Parameters.AddWithValue("@biyo2", f1.Text);
                    command.ExecuteNonQuery();
                }
            }






            /*
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");
            
           
            baglanti.Open();// bağlantı açıldı
            //sorgu komut yapısı oluşturuldu
             OleDbCommand sorgu = new OleDbCommand()
            {

            }
            
            sorgu.Connection = baglanti;


            string vize = v1.Text;
            string final = f1.Text;
           

            sorgu.CommandType = CommandType.Text;
            //string query = "INSERT INTO notlar (ogrenciNo, biyo1,biyo2,fizik1,fizik2,kimya1,kimya2,lab1,lab2,prog1,prog2) values (@ogrenciNo, @biyo1,@biyo2,@fizik1,@fizik2,@kimya1,@kimya2,@lab1,@lab2,@prog1,@prog2)";


            if (biyo.Enabled == true && v1.Enabled == true && f1.Enabled == true)
            {
                sorgu.CommandText = "insert into notlar (ogrenciNo, biyo1,biyo2) values (@ogrenciNo,@biyo1,@biyo2)";
                sorgu.Parameters.AddWithValue("@ogrenciNo", sorgulananOgrenciNo.Text);
                sorgu.Parameters.AddWithValue("@biyo1", vize);
                sorgu.Parameters.AddWithValue("@biyo2", final);
                //sorgu.ExecuteNonQuery();
            }
            
            else if(fizik.Enabled == true && v1.Enabled==true && f1.Enabled==true)
            {
                sorgu.Parameters.AddWithValue("@fizik1", vize);
                sorgu.Parameters.AddWithValue("@fizik2", final);
            }
            else if(kimya.Enabled == true)
            {
                sorgu.Parameters.AddWithValue("@kimya1", vize);
                sorgu.Parameters.AddWithValue("@kimya2", final);
            }
            else if(lab.Enabled== true)
            {
                sorgu.Parameters.AddWithValue("@lab1", vize);
                sorgu.Parameters.AddWithValue("@lab2", final);
            }
            else if(prog.Enabled == true)
            {
                sorgu.Parameters.AddWithValue("@prog1", vize);
                sorgu.Parameters.AddWithValue("@prog2", final);
            }
           


            MessageBox.Show("Not Değişiklikleri Yapılmıştır.");
            baglanti.Close();// bağlantı kapatıldı.

            */
        }
    }
}
