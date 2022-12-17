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
    public partial class dersEkle : Form
    {
        public dersEkle()
        {
            InitializeComponent();
        }

        private void dersEkle_Load(object sender, EventArgs e)
        {

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
