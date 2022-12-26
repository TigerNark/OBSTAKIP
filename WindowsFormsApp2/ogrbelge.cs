using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class ogrbelge : Form
    {
        public ogrbelge()
        {
            InitializeComponent();
        }
        public string oNumara;

        private void ogrbelge_Load(object sender, EventArgs e)
        {
            kisiselBilgi g = new kisiselBilgi();
            g.GelenOgrNo = oNumara;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kisiselBilgi g = new kisiselBilgi();
            g.GelenOgrNo = oNumara;
            ogrenciGirisi ok = new ogrenciGirisi();
            ok.Show();
            ok.girisYapmısOgrNo = oNumara;
            this.Hide();
        }
    }
}
