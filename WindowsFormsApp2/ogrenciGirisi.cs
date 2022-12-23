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
    public partial class ogrenciGirisi : Form
    {
        public ogrenciGirisi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Akadenik takvim butonu
            takvim t = new takvim();
            t.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anaGiris ana = new anaGiris();
            ana.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ders Programı Butonu
            dersProgrami f = new dersProgrami();
            f.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Not bilgileri butonu

            notBilgileri not = new notBilgileri();
            not.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //öğrenci bilgileri butonu
            kisiselBilgi info = new kisiselBilgi();
            info.GelenOgrNo = girisYapmısOgrNo;
            info.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Transkripsiyon butonu
            trans a = new trans();
            a.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Devamsızlık Sorgulama Butonu
            devamsizlikGör dvm = new devamsizlikGör();
            dvm.Show();
            this.Close();

        }
        public string girisYapmısOgrNo = "";
        private void ogrenciGirisi_Load(object sender, EventArgs e)
        {
            // Veritabanına bağlanmak için OleDbConnection nesnesi oluşturun
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb;Persist Security Info=False;";

            // Veritabanından öğrenci bilgilerini çekmek için OleDbCommand nesnesi oluşturun
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT * FROM Ogrenci_kayitlari WHERE ogrno = @ girisYapmısOgrNo";
            command.Parameters.AddWithValue("@ogrno", girisYapmısOgrNo);
            command.Connection = connection;

            // Veritabanına bağlanıp sorgu çalıştırmak için Connection nesnesini açın ve OleDbCommand nesnesini çalıştırın
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            kisiselBilgi aktarr = new kisiselBilgi();
            

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

                aktarr.ad.Text = name;
                aktarr.soyad.Text = surname;
                aktarr.tel.Text = phone;
                aktarr.adres.Text = address;
                aktarr.mail.Text = email;
                aktarr.bolum.Text = fakulte;
                aktarr.dTarih.Text = data;
                aktarr.tc.Text = id;
                aktarr.kTarihi.Text = kTatih;

            }

            // İşlem bittikten sonra veritabanı bağlantısını kapatın ve OleDbDataReader nesnesini kapatın
            reader.Close();
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
