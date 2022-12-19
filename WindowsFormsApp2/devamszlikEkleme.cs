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
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=cSharpProje.xlsx;
            Extended Properties='Excel 12.0 Xml;HDR=YES'");

        void Veriler()
        {
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
    }
}
