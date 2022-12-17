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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // geri butonu
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // kaydet butonu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // yeni kayıt kapatma butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }
    }
}
