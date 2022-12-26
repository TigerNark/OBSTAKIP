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
    public partial class devamsizlikGör : Form
    {
        public devamsizlikGör()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // devamsızlık görüntüleme kapatma butonu
            ogrenciGirisi a = new ogrenciGirisi();
            a.girisYapmısOgrNo = oNumara;
            a.Show();
            this.Close();
        }

        public string oNumara;
        public int num;
        private void devamsizlikGör_Load(object sender, EventArgs e)
        {
            string filePath = @"cSharpProje.xlsx";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                // Excel dosyası açıldı
                string sheetName = "devamsizlik";
                string query = "SELECT * FROM [" + sheetName + "$] WHERE [ogrno] = @studentNumber";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentNumber", oNumara);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Öğrenci numarasına eşit olan satır bulundu
                            string cellValue = reader["A1"].ToString();
                            MessageBox.Show("a1: " + cellValue);
                        }
                    }
                }

            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void matdev_Click(object sender, EventArgs e)
        {

        }
    }
}
