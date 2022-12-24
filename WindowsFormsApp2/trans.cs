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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
            file.Title = "ÖĞRENCİ BELGESİ";
            if (file.ShowDialog() == DialogResult.OK)
            {

                FileStream dosya = File.Open(file.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf, dosya);
                pdf.Open();
                pdf.AddAuthor("");
                pdf.AddCreator("");
                pdf.AddTitle("ÖĞRENCİ BELGESİ");
                pdf.AddSubject("");
                pdf.AddKeywords("öğrenci belgesi");
                pdf.AddCreationDate();
                Paragraph paragraf = new Paragraph(metin.Text);
                pdf.Add(paragraf);
                pdf.Close();
                MessageBox.Show("İşlem Başarılı");


            }
            
            
        }
    }
}
