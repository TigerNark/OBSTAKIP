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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            // kaydet butonu

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");

            OleDbCommand sorgu = new OleDbCommand();
            OleDbCommand sorgu1 = new OleDbCommand();//sorgu komut yapısı oluşturuldu
            OleDbCommand sorgu2 = new OleDbCommand();
            baglanti.Open();// bağlantı açıldı
            sorgu.Connection = baglanti;
            sorgu1.Connection = baglanti;//hangi bağlantıda kullanılacak
            sorgu2.Connection = baglanti;

            string isim = isimtext.Text;
            string Soyisim = soyisimtext.Text;
            string dogum_tarihi = dogumtext.Text;
            string mail = mailtext.Text;
            string kimlik_no = tctext.Text;
            string bolum = bolumtext.Text;
            string kayit_tarihi = kayıttext.Text;
            string cep_no = notext.Text;
            string adres = adrestext.Text;
            string ogrno = ogrnotext.Text;
            string sifre = ogrsif.Text;

            sorgu.CommandType = CommandType.Text;
            sorgu.CommandText = "insert into Ogrenci_kayitlari (isim,Soyisim,dogum_tarihi,mail,kimlik_no,bolum,kayit_tarihi,cep_no,adres,ogrno) values (@İsim,@Soyisim,@dogum_tarihi,@mail,@kimlik_no,@bolum,@kayit_tarihi,@cep_no,@adres,@ogrno)";



            sorgu.Parameters.AddWithValue("@isim", isim);
            sorgu.Parameters.AddWithValue("@Soyisim", Soyisim);
            sorgu.Parameters.AddWithValue("@dogum_tarihi", dogum_tarihi);
            sorgu.Parameters.AddWithValue("@mail", mail);
            sorgu.Parameters.AddWithValue("@kimlik_no", kimlik_no);
            sorgu.Parameters.AddWithValue("@bolum", bolum);
            sorgu.Parameters.AddWithValue("@kayit_tarihi", kayit_tarihi);
            sorgu.Parameters.AddWithValue("@cep_no", cep_no);
            sorgu.Parameters.AddWithValue("@adres", adres);
            sorgu.Parameters.AddWithValue("@ogrno", ogrno);

            int rowsAffected = sorgu.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows were updated.");

            string ogrencino = ogrnotext.Text;

            sorgu1.CommandType = CommandType.Text;
            sorgu1.CommandText = "insert into Login (ogrencino,sifre) values (@ogrencino,@sifre)";

            sorgu1.Parameters.AddWithValue("@ogrencino", ogrencino);
            sorgu1.Parameters.AddWithValue("@sifre", sifre);

            int rowsAffected1 = sorgu1.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows were updated.");

            sorgu2.CommandType = CommandType.Text;
            sorgu2.CommandText = "insert into notlar (ogrencino,ogrenciIsim,ogrenciSoyisim) values (@ogrencino,@isim,@soyisim)";

            sorgu2.Parameters.AddWithValue("@ogrencino", ogrencino);
            sorgu2.Parameters.AddWithValue("@isim", isim);
            sorgu2.Parameters.AddWithValue("@soyisim", Soyisim);

            int rowsAffected2 = sorgu2.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} rows were updated.");


            //sorgu.ExecuteNonQuery();//update,insert,delete sorgularını çalıştırır ve geriye kaç satırlık işlem yapıldığı ile ilgili bilgi int türünde geri döner.

            MessageBox.Show("Kaydınız gerçekleştirilmiştir.", "Kayır İşlemi");
            baglanti.Close();// bağlantı kapatıldı.

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // yeni kayıt kapatma butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void yeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
