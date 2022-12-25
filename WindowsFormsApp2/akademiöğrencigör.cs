using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class akademiöğrencigör : Form
    {
        public akademiöğrencigör()
        {
            InitializeComponent();
        }
        public string GelenOgrNo;
        private void akademiöğrencigör_Load(object sender, EventArgs e)
        {
            labelOgrno.Text = GelenOgrNo;
            MessageBox.Show("girilen no: " + GelenOgrNo);

            // Veritabanına bağlanmak için OleDbConnection nesnesi oluşturun
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=obstakip.accdb;Persist Security Info=False;";

            // Veritabanından öğrenci bilgilerini çekmek için OleDbCommand nesnesi oluşturun
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT * FROM Ogrenci_kayitlari WHERE ogrno = @GelenOgrNo";
            command.Parameters.AddWithValue("@ogrno", GelenOgrNo);

            command.Connection = connection;

            // Veritabanına bağlanıp sorgu çalıştırmak için Connection nesnesini açın ve OleDbCommand nesnesini çalıştırın
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            // OleDbDataReader nesnesinden öğrenci bilgilerini okuyun ve forma yazdırın
            while (reader.Read())
            {
                string name = reader["İsim"].ToString();
                string surname = reader["Soyisim"].ToString();
                string phone = reader["cep_no"].ToString();
                string address = reader["adres"].ToString();
                string email = reader["mail"].ToString();
                string id = reader["kimlik_no"].ToString();
                string data = reader["dogum_tarihi"].ToString();
                string fakulte = reader["bolum"].ToString();
                string kTatih = reader["kayit_tarihi"].ToString();


                // Burada forma yazdırma işlemini gerçekleştirin

                isim.Text = name;
                soyisim.Text = surname;
                tel.Text = phone;
                adres.Text = address;
                mail.Text = email;
                bolum.Text = fakulte;
                dTarih.Text = data;
                tc.Text = id;
                kTarihi.Text = kTatih;


            }

            // İşlem bittikten sonra veritabanı bağlantısını kapatın ve OleDbDataReader nesnesini kapatın
            reader.Close();
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ogrenciSorgulama frm = new ogrenciSorgulama();
            frm.Show();
            this.Close();
        }
    }
}
