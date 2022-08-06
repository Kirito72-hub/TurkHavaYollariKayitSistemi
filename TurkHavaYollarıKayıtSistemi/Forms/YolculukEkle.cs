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
        SqlConnection db = new SqlConnection(ConstValue.connectionString);
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
            db.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //kayidetme tusu basildiginda girdileri alip databasete skalmak icin
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool flick = true;
            if (cbNerden.SelectedIndex == -1) { MessageBox.Show("Nerden Uçacağınızı seçiniz!"); flick = false; }
            else if(cbNereye.SelectedIndex == -1) { MessageBox.Show("Nereye Uçacağınızı seçiniz!"); flick = false; }
            else if (cbUcakID.SelectedIndex == -1) { MessageBox.Show("Nereye Uçacağınızı seçiniz!"); flick = false; }
            else if (cbNerden.SelectedIndex == cbNereye.SelectedIndex) { MessageBox.Show("Nerden Nereye kutuları aynı girdi alamaz!"); flick = false; }
            if (flick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    string strUcakAdi = cbUcakID.SelectedItem.ToString();
                    SqlCommand IDgetir = new SqlCommand("Select UcakID From Tbl_Ucak Where UcakModeli='" + strUcakAdi + "'", db);
                    Int32 UcakID = (Int32)IDgetir.ExecuteScalar();

                    SqlCommand sorgu = new SqlCommand("Insert into Tbl_Yolculuk (Nerden, Nereye, GidisTarihi, GidisSaati, VarisTarihi, VarisSaati, UcakID) values(@s1, @s2, @s3, @s4, @s5, @s6, @s7)", db);
                    sorgu.Parameters.AddWithValue("@s1", cbNerden.Text);
                    sorgu.Parameters.AddWithValue("@s2", cbNereye.Text);
                    sorgu.Parameters.AddWithValue("@s3", dtpKalkisTarihi.Value);
                    sorgu.Parameters.AddWithValue("@s4", dtpKalkisSaati.Value);
                    sorgu.Parameters.AddWithValue("@s5", dtpVarisTarihi.Value);
                    sorgu.Parameters.AddWithValue("@s6", dtpVarisSaati.Value);
                    sorgu.Parameters.AddWithValue("@s7", UcakID);
                    sorgu.ExecuteNonQuery();

                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi !!!");
                }
            }
        }
    }
}