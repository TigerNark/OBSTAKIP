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
    public partial class ogrenciSorgulama : Form
    {
        public ogrenciSorgulama()
        {
            InitializeComponent();
        }


        private void ogr_gor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // öğrenci sorgulama çıkış butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }
        OleDbConnection con1;
        OleDbCommand cmd1;
        OleDbDataReader dr1;
        private void button2_Click_1(object sender, EventArgs e)
        {
            //öğrenci numaralarına erişir 
            string ad = textakogrno.Text;
            string sifre = textakogrno.Text;
            con1 = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=obstakip.accdb");
            cmd1 = new OleDbCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT * FROM Ogrenci_kayitlari where ogrno='" + ad + "' AND ogrno='" + sifre + "'";
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                //eğer aranan öğrenci numarası sistemde kayıtlı ise akademiöğrencigör formuna gider
                akademiöğrencigör frm = new akademiöğrencigör();
                frm.GelenOgrNo = textakogrno.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                //eğer aranan öğrenci numarası sistemde yoksa akademiöğrenci sayfasına geçmez ve ekrana mesaj verir
                MessageBox.Show("Böyle bir öğrenci yok");
            }

            con1.Close();


        }

        private void textakogrno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
