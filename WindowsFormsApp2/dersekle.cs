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
    public partial class dersEkle : Form
    {
        public dersEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=cSharpProje.xlsx;
            Extended Properties='Excel 12.0 Xml;HDR=YES'");
        void Veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *FROM [dersProgrami$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }


        private void dersEkle_Load(object sender, EventArgs e)
        {
            Veriler();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ders ekle kapatma butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ders ekle kapatma butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE [dersProgrami$] set BİRİNCİDERS=@p2,İKİNCİDERS=@p3,ÜÇÜNCÜDERS=@p4,DÖRDÜNCÜDERS=@p5,ÖGLEARASI=@p0,BEŞİNCİDERS=@p6,ALTINCIDERS=@p7,YEDİNCİDERS=@p8,SEKİZİNCİDERS=@p9 WHERE GÜNLER=@p1", baglanti);
            komut.Parameters.AddWithValue("@p2", sekiz.Text);
            komut.Parameters.AddWithValue("@p3", dokuz.Text);
            komut.Parameters.AddWithValue("@p4", on.Text);
            komut.Parameters.AddWithValue("@p5", onbir.Text);
            komut.Parameters.AddWithValue("@p0", oniki.Text);
            komut.Parameters.AddWithValue("@p6", bir.Text);
            komut.Parameters.AddWithValue("@p7", iki.Text);
            komut.Parameters.AddWithValue("@p8", üç.Text);
            komut.Parameters.AddWithValue("@p9", dört.Text);
            komut.Parameters.AddWithValue("@p1", gun.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            gun.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sekiz.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            dokuz.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            on.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            onbir.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            oniki.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            bir.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            iki.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            üç.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            dört.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }
    }
}
