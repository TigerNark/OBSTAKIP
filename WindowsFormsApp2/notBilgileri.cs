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
            ders1.Text = "MATEMATİK";
            ders2.Text = "FİZİK";
            ders3.Text = "KİMYA";
            ders4.Text = "LAB";
            ders5.Text = "PROGRAMLAMA";

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

                while (reader.Read())
                {
                    dersBirVize.Text = reader["mat1"].ToString();
                    dersBirFinal.Text = reader["mat2"].ToString();
                    dersIkiVize.Text = reader["fizik1"].ToString();
                    dersIkiFinal.Text = reader["fizik2"].ToString();
                    dersUcVize.Text = reader["kimya1"].ToString();
                    dersUcFinal.Text = reader["kimya2"].ToString();
                    dersDortVize.Text = reader["lab1"].ToString();
                    dersDortFinal.Text = reader["lab2"].ToString();
                    dersBesVize.Text = reader["prog1"].ToString();
                    dersBesFinal.Text = reader["prog2"].ToString();

                }


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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
