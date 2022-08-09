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
    public partial class YolculukBul : Form
    {
        public YolculukBul()
        {
            InitializeComponent();
        }
        //sql baglantisini kurmak
        SqlConnection db = new SqlConnection(ConstValue.connectionString);
        private void YolculukBul_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select YolcuID, TC, Ad+' '+Soyad as 'Ad Soyad', Tel From Tbl_Yolcu where TC='" + txtBoxTc.Text + "'", db) ;
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
            DialogResult dialogResult = MessageBox.Show("Yolcu kaydı doğru mu ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ConstValue.YolcuBulID = Convert.ToInt32(dt.Rows[0][0]);
                db.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into Tbl_YolcuYolculuk(YolcuID, YolculukID, KullanciID) Values(@s1, @s2, @s3)", db);
                sorgu1.Parameters.AddWithValue("@s1", ConstValue.YolcuBulID);
                sorgu1.Parameters.AddWithValue("@s2", ConstValue.YolculukID);
                sorgu1.Parameters.AddWithValue("@s3", ConstValue.KullanciID);
                sorgu1.ExecuteNonQuery();
                db.Close();
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
