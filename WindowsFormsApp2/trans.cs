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
    public partial class trans : Form
    {
        public trans()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // transkript kapatma butonu
            ogrenciGirisi a = new ogrenciGirisi();
            a.girisYapmısOgrNo = oNumara;
            a.Show();
            this.Close();
        }
        public string oNumara;
        private void trans_Load(object sender, EventArgs e)
        {

        }
    }
}
