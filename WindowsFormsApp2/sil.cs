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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            //Kayıt sil butonu

            string numara = ogrno.Text;
            string sorgu = "Delete From Ogrenci_kayitlari Where ogrno=@ogrno";
            string sorgu1 = "Delete From notlar Where ogrenciNo=@ogrno";
            string sorgu2 = "Delete From Login Where ogrencino=@ogrno";
            komut = new OleDbCommand(sorgu, baglanti);
            komut1 = new OleDbCommand(sorgu1, baglanti);
            komut2 = new OleDbCommand(sorgu2, baglanti);
            komut.Parameters.AddWithValue("@ogrno", numara);
            komut1.Parameters.AddWithValue("@ogrno", numara);
            komut2.Parameters.AddWithValue("@ogrno", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut1.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Geri butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kayıt sil - bölüm butonu
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // tc kimlik no
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // öğrenci no
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // ad soyad 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Geri butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbCommand komut1;
        OleDbCommand komut2;
        void KisiListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=obstakip.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From Ogrenci_kayitlari", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            
        }


        private void sil_Load(object sender, EventArgs e)
        {
            KisiListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            tcno.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ogrno.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }
    }
}
