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
    public partial class sifreUnuttum : Form
    {
        public sifreUnuttum()
        {
            InitializeComponent();
        }

        private void sifreUnuttum_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM Login WHERE ogrencino = @girilenVeri1 AND kimlik = @girilenVeri2";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@girilenVeri1", nomail.Text);
            command.Parameters.AddWithValue("@girilenVeri2", tcno.Text);

            // Öğrenci numarası ve TC kimlik numarası giriş alanlarını temizleyin

            nomail.Clear();
            tcno.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        public string veritabaniSif = "";

        private void button1_Click(object sender, EventArgs e)
        {
            // şifremi getir
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb");
            string sorgu = "SELECT * FROM Login WHERE ogrencino = @girilenVeri1 AND kimlik = @girilenVeri2";
            OleDbCommand command = new OleDbCommand(sorgu, baglanti);
            command.Parameters.AddWithValue("@girilenVeri1",nomail.Text);
            command.Parameters.AddWithValue("@girilenVeri2", tcno.Text);


            baglanti.Open();
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // Veri bulundu, formdan girilen veriler ile veritabanındaki tablo eşleşti

                reader.Read();
                string veritabaniSif = reader["sifre"].ToString();
                MessageBox.Show("Şifreniz: " + veritabaniSif, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Veri bulunamadı, formdan girilen veriler ile veritabanındaki tablo eşleşmedi
                MessageBox.Show("Formdan girilen veriler ile veritabanındaki tablo eşleşmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            reader.Close();
            baglanti.Close();

            //MessageBox.Show(nomail + " " + tcno);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            anaGiris basla = new anaGiris();
            basla.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
