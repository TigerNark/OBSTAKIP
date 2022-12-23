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
    }
}
