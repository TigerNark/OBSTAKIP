﻿using System;
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
    public partial class ogrenciSorgulama : Form
    {
        public ogrenciSorgulama()
        {
            InitializeComponent();
        }

        private void ogr_gor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // öğrenci sorgulama çıkış butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }
    }
}
