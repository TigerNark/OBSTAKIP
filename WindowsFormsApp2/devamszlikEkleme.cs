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
    public partial class devamszlikEkleme : Form
    {
        public devamszlikEkleme()
        {
            InitializeComponent();
        }

        private void devamsızlık_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // deamsızlık kapat butonu
            akademisyen a = new akademisyen();
            a.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
