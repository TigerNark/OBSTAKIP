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

            // Veritabanına bağlanmak için OleDbConnection nesnesi oluşturun
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb;Persist Security Info=False;";

            // Veritabanından öğrenci bilgilerini çekmek için OleDbCommand nesnesi oluşturun
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT * FROM Ogrenci_kayitlari WHERE ogrno = @";
            command.Parameters.AddWithValue("@ogrno", GelenOgrNo);

            command.Connection = connection;

            // Veritabanına bağlanıp sorgu çalıştırmak için Connection nesnesini açın ve OleDbCommand nesnesini çalıştırın
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            // OleDbDataReader nesnesinden öğrenci bilgilerini okuyun ve forma yazdırın
            while (reader.Read())
            {
                string name = reader["İsim"].ToString();
                string surname = reader["Soyisim"].ToString();
                string phone = reader["cep_no"].ToString();
                string address = reader["adres"].ToString();
                string email = reader["mail"].ToString();
                string id = reader["kimlik_no"].ToString();
                string data = reader["dogum_tarihi"].ToString();
                string fakulte = reader["bolum"].ToString();
                string kTatih = reader["kayit_tarihi"].ToString();

                
                // Burada forma yazdırma işlemini gerçekleştirin

                ad.Text = name;
                soyad.Text = surname;
                tel.Text = phone;
                adres.Text = address;
                mail.Text = email;
                bolum.Text = fakulte;
                dTarih.Text = data;
                tc.Text = id;
                kTarihi.Text = kTatih; 


            }

        // İşlem bittikten sonra veritabanı bağlantısını kapatın ve OleDbDataReader nesnesini kapatın
        reader.Close();
        connection.Close();
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
            // bilgilerim sayfasına ogr no gönder
            ogrenciGirisi o = new ogrenciGirisi();
            o.girisYapmısOgrNo = labelOgrno.Text;
            o.Show();
            this.Hide();
            //not bilgilerim sayfasına ogr no gönder
            notBilgileri notee = new notBilgileri();
            notee.oNumara = labelOgrno.Text;
            // ders programı sayfasına ogr no gönder
            dersProgrami dee = new dersProgrami();
            dee.oNumara = labelOgrno.Text;
            // transkrip sayfasına ogr np gönder
            trans trranskr = new trans();
            trranskr.oNumara = labelOgrno.Text;
            //devamsızlık gör sayfasına ogt no gönder
            devamsizlikGör devamsizlik = new devamsizlikGör();
            devamsizlik.oNumara= labelOgrno.Text;
            // takvime ögr no gönder
            takvim tt = new takvim();
            tt.oNumara = labelOgrno.Text;

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
