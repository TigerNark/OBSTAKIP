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
    public partial class notBilgileri : Form
    {
        public notBilgileri()
        {
            InitializeComponent();
        }

        public string oNumara;

        private void button7_Click(object sender, EventArgs e)
        {
            // not bilgileri çıkış butonu
            ogrenciGirisi not = new ogrenciGirisi();
            not.girisYapmısOgrNo = oNumara;
            not.Show();
            this.Close();
        }

        private void notBilgileri_Load(object sender, EventArgs e)
        {

            // Veritabanına bağlanmak için bir OleDbConnection nesnesi oluşturun
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");

            // Öğrenci numarası girişini değişkene atayın
            string ogrenciNo = oNumara;

            // Öğrenci numarasına göre sınav notlarını sorgulayın
            string sorgu = "SELECT * FROM notlar WHERE ogrenciNo = @ogrenciNo";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);

            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();

            // Öğrenci numarasına göre sınav notlarını ekrana yazdırın
            if (reader.HasRows)
            {
                string notlar = "";
                while (reader.Read())
                {
                    string dersAdi = reader["mat1"].ToString();
                    //string not = reader["not"].ToString();
                    notlar += dersAdi + ": " + "" + "\n";
                }
                MessageBox.Show(notlar, "Sınav Notları", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Öğrenci numarasına göre kayıtlı sınav notları bulunamadı
                MessageBox.Show("Girilen öğrenci numarasına göre kayıtlı sınav notları bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
