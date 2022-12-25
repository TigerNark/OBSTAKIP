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
using iTextSharp.text;
using iTextSharp.text.pdf;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciGirisi belge = new ogrenciGirisi();
            
            belge.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ogrenciGirisi belge = new ogrenciGirisi();

            belge.Show();
            this.Close();
        }
    }
}
