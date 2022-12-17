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
    public partial class ogrenciGirisi : Form
    {
        public ogrenciGirisi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Akadenik takvim butonu
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ders Programı Butonu
            dersProgrami f = new dersProgrami();
            f.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Not bilgileri butonu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ÖĞrenci görüntüleme butonu
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Transkripsiyon butonu
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Devamsızlık Butonu
        }
    }
}
