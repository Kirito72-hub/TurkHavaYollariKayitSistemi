using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TurkHavaYollarıKayıtSistemi;

namespace TurkHavaYollarıKayıtSistemi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        //databasein nesnesi olusturmasi
        SqlConnection db = new SqlConnection(ConstValue.connectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            //butonun arka rengini ddegitirmek icin
            button1.BackColor = Color.FromArgb(232, 25, 50);
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Giris bilgileri kontrol edip hataise hata vercek dogru ise yeni form cagiracak
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select Count(*) From Tbl_Kullanci Where Kullanci='" + txtboxKullanci.Text + "' And Sifre='" + txtboxSifre.Text + "'", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //Sifre dogru ise
                ConstValue.KullanciAdi = txtboxKullanci.Text;
                ConstValue.KullanciSifre = txtboxSifre.Text;
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }
            else
                MessageBox.Show("Kullanci Adı ve Şifresi giriniz !!", "Bütün boşlukları doldurun", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //X butuno pencere kapatmak icin
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
//Sifremi unuttum kismi