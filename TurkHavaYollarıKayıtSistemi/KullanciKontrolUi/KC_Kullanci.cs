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
using TurkHavaYollarıKayıtSistemi.Forms;

namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    public partial class KC_Kullanci : UserControl
    {
        public KC_Kullanci()
        {
            InitializeComponent();
        }
        //sql baglantisini kurmak
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-7RAAP8M\\SQLEXPRESS;Initial Catalog=THY;Integrated Security=True");
        private void btnKullanciEkle_Click(object sender, EventArgs e)
        {

        }
        //tablodan bir cell uzerinde basarsak silmek butonu cikar silme basarsak kayit siliniyor
        int Scell;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnKullanciSil.Visible = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;
        }
        private void btnKullanciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("delete from Tbl_Kullanci where KullanciID=@s1", db);
                sorguSil.Parameters.AddWithValue("@s1", Scell);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Kullancı Kaydı Silindi");
                this.OnLoad(e);
            }
        }

        
    }
}
