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
            takvim t = new takvim();
            t.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anaGiris ana = new anaGiris();
            ana.Show();
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

            notBilgileri not = new notBilgileri();
            not.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //öğrenci bilgileri butonu
            kisiselBilgi info = new kisiselBilgi();
            info.GelenOgrNo = girisYapmısOgrNo;
            info.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Transkripsiyon butonu
            trans a = new trans();
            a.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Devamsızlık Sorgulama Butonu
            devamsizlikGör dvm = new devamsizlikGör();
            dvm.Show();
            this.Close();

        }
        public string girisYapmısOgrNo;
        private void ogrenciGirisi_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
