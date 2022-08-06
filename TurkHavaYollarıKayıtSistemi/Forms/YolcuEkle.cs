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

namespace TurkHavaYollarıKayıtSistemi.Forms
{
    public partial class YolcuEkle : Form
    {
        public YolcuEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(ConstValue.connectionString);
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime dNow = DateTime.Now;
            bool flick = true;
            if (txtBoxAd.Text == "") { MessageBox.Show("Yolcu Adını yazınız!"); flick = false; }
            else if (txtBoxSoyad.Text == "") { MessageBox.Show("Yolcu Soyadını yazınız!"); flick = false; }
            else if (txtBoxEposta.Text == "") { MessageBox.Show("Eposta yazınız!"); flick = false; }
            else if (txtBoxTel.Text == "") { MessageBox.Show("11 haneli telefon numerası yazınız!"); flick = false; }
            else if (txtBoxTel.TextLength != 11) { MessageBox.Show("11 haneli telefon numerası yazınız!"); flick = false; }

            if (flick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Insert into Tbl_Yolcu (Ad, Soyad, Eposta, Tel, KayitTarihi) values(@s1, @s2, @s3, @s4, @s5)", db);
                    sorgu.Parameters.AddWithValue("@s1", txtBoxAd.Text);
                    sorgu.Parameters.AddWithValue("@s2", txtBoxSoyad.Text);
                    sorgu.Parameters.AddWithValue("@s3", txtBoxEposta.Text);
                    sorgu.Parameters.AddWithValue("@s4", txtBoxTel.Text);
                    sorgu.Parameters.AddWithValue("@s5", dNow);
                    sorgu.ExecuteNonQuery();

                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi !!!");
                }
            }
        }
        
        //pencere kapatmak icin
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
