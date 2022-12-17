using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
