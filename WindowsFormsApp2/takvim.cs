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
    public partial class takvim : Form
    {
        public takvim()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // takvim kapatma butonu
            ogrenciGirisi a = new ogrenciGirisi();
            a.girisYapmısOgrNo = oNumara;
            a.Show();
            this.Close();
        }

        public string oNumara;


        private void takvim_Load(object sender, EventArgs e)
        {

        }
    }
}
