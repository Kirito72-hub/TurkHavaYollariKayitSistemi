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
    public partial class KullanciEkle : Form
    {
        public KullanciEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(ConstValue.connectionString);

        private void KullanciEkle_Load(object sender, EventArgs e)
        {
            labelKullanciAdi.Text = ConstValue.KullanciAdi + " şifresi";
        }

        //pencere kapatmak icin
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool flick = true;
            if (txtBoxKullanci.Text == "") { MessageBox.Show("Kullancı Adını yazınız!"); flick = false; }
            else if (txtBoxSifre.Text == "") { MessageBox.Show("Kullancı şifresi yazınız!"); flick = false; }
            else if (txtBoxEskiSifre.Text == "") { MessageBox.Show("Kullandığınız Kullancı şifresi yazınız!"); flick = false; }
            else if (txtBoxEskiSifre.Text != ConstValue.KullanciSifre) { MessageBox.Show("Kullandığınız Kullancı şifresi Hatalıdır!"); flick = false; }
            if (flick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Exec InsertKullanci '" +txtBoxKullanci.Text+ "','" +txtBoxSifre.Text+ "'", db);
                    sorgu.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi !!!");
                }
            }
        }

        
    }
}
