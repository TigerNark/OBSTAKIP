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
    public partial class dersProgrami : Form
    {



        public dersProgrami()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ders programı kapatma butonu 
            ogrenciGirisi drs = new ogrenciGirisi();
            drs.girisYapmısOgrNo = oNumara;
            drs.Show();
            this.Close();
        }

        public string oNumara;

        private void dersProgrami_Load(object sender, EventArgs e)
        {
            Veriler(); 
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
