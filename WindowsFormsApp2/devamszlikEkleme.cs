using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class devamszlikEkleme : Form
    {
        public devamszlikEkleme()
        {
            InitializeComponent();
        }
        // excel dosyasına  bağlanır
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=cSharpProje.xlsx;
            Extended Properties='Excel 12.0 Xml;HDR=YES'");

        void Veriler()
        {
            //excel dosyasındaki devamsızlık sayfası seçilir
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *FROM [devamsizlik$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void devamsızlık_Load(object sender, EventArgs e)
        {
            Veriler();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // deamsızlık kapat butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //devamsızlıktaki satır ve sütunlara yeni veriler kaydedilir
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [devamsizlik$] (ogrno,FİZİK,Kimya,BİYOLOJİ,PROGRAMLAMA,LAB) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", textogrno.Text);
            komut.Parameters.AddWithValue("@p2", textfizik.Text);
            komut.Parameters.AddWithValue("@p3", textkimya.Text);
            komut.Parameters.AddWithValue("@p4", textbiyoloji.Text);
            komut.Parameters.AddWithValue("@p5", textprogramlama.Text);
            komut.Parameters.AddWithValue("@p6", textlab.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Devamsızlık Bilgileri Kaydedildi");
            Veriler();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exceldeki satır ve sütunlara erişilir ve buralardaki veriler güncellenir
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update [devamsizlik$] set FİZİK=@p2,Kimya=@p3,BİYOLOJİ=@p4,PROGRAMLAMA=@p5,LAB=@p6 where ogrno=@p1", baglanti);
            komut.Parameters.AddWithValue("@p2", textfizik.Text);
            komut.Parameters.AddWithValue("@p3", textkimya.Text);
            komut.Parameters.AddWithValue("@p4", textbiyoloji.Text);
            komut.Parameters.AddWithValue("@p5", textprogramlama.Text);
            komut.Parameters.AddWithValue("@p6", textlab.Text);
            komut.Parameters.AddWithValue("@p1", textogrno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Devamsızlık Bilgileri 1 Güncellendi.", "Güncelleme");
            Veriler();







        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textogrno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textfizik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textkimya.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textbiyoloji.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textprogramlama.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textlab.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();


        }
    }
}
