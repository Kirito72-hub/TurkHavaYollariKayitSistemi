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
    public partial class YolculukEkle : Form
    {
        public YolculukEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=LAPTOP-SCMK2VA2\\MSSQLSERVER01;Initial Catalog=THY;Integrated Security=True");
        private void YolculukEkle_Load(object sender, EventArgs e)
        {
            //Ucak modelleri databaseten alip comboboxa atmak
            string name;
            db.Open();
            SqlDataAdapter getUcakID = new SqlDataAdapter("Select UcakModeli From Tbl_Ucak", db);
            DataTable dt = new DataTable();
            getUcakID.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {

                name = dt.Rows[i]["UcakModeli"].ToString();
                if(!cbUcakID.Items.Contains(name))
                    cbUcakID.Items.Add(name);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool flick = true;
            if (cbNerden.SelectedIndex == -1) { MessageBox.Show("Nerden Uçacağınızı seçiniz!"); flick = false; }
            else if(cbNereye.SelectedIndex == -1) { MessageBox.Show("Nereye Uçacağınızı seçiniz!"); flick = false; }
            else if (cbUcakID.SelectedIndex == -1) { MessageBox.Show("Nereye Uçacağınızı seçiniz!"); flick = false; }
            if (flick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Insert into Tbl_Yolculuk (Nerden, Nereye, GidisTarihi, GidisZamani, VarisTarihi, VarisZamani, UcakID) values(@s1, @s2, @s3, @s4, @s5, @s6, @s7)", db);
                    sorgu.Parameters.AddWithValue("@s1", cbNerden.Text);
                    sorgu.Parameters.AddWithValue("@s2", cbNereye.Text);
                    sorgu.Parameters.AddWithValue("@s3", dtpKalkisTarihi.Value);
                    sorgu.Parameters.AddWithValue("@s4", dtpKalkisSaati.Value);
                    sorgu.Parameters.AddWithValue("@s5", dtpVarisTarihi.Value);
                    sorgu.Parameters.AddWithValue("@s6", dtpVarisSaati.Value);
                    sorgu.Parameters.AddWithValue("@s7", cbUcakID);
                    sorgu.ExecuteNonQuery();

                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi !!!");
                }
            }
        }
    }
}