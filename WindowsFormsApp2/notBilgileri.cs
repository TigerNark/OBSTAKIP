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
    public partial class notBilgileri : Form
    {
        public notBilgileri()
        {
            InitializeComponent();
        }

        public string oNumara;

        private void button7_Click(object sender, EventArgs e)
        {
            // not bilgileri çıkış butonu
            ogrenciGirisi not = new ogrenciGirisi();
            not.girisYapmısOgrNo = oNumara;
            not.Show();
            this.Close();
        }

        private void notBilgileri_Load(object sender, EventArgs e)
        {

            MessageBox.Show(oNumara);
        }
    }
}
