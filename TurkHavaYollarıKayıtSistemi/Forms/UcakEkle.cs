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
    public partial class UcakEkle : Form
    {
        public UcakEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(ConstValue.connectionString);
        //pencere kapatmak icin
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool flick = true;
            if (txtBoxUcakModeli.Text == "") { MessageBox.Show("Uçak modelini yazınız!"); flick = false; }
            else if (txtBoxKapasite.Text == "") { MessageBox.Show("Uçak kapasitesi yazınız!"); flick = false; }
            else if (txtBoxGar.Text == "") { MessageBox.Show("Uçak bulundugu garda yazınız!"); flick = false; }
            if (flick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Exec InsertUcak '" + txtBoxUcakModeli.Text + "','" + txtBoxKapasite.Text + "','" + txtBoxGar.Text + "','" + dtpSonBakimTarihi.Value + "'", db) ;
                    sorgu.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi !!!");
                }
            }
        }
    }
}

