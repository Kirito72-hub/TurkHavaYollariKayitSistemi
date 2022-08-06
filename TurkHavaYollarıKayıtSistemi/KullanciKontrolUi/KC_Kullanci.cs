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
        SqlConnection db = new SqlConnection(ConstValue.connectionString);

        private void KC_Kullanci_Load(object sender, EventArgs e)
        {
            //tabloyu ekrana yazmak
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select ID,Kullanci from Tbl_Kullanci", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();

            //yolculuk sayisi toplayip label icinde yazmak
            SqlCommand YolculukSayisi = new SqlCommand("Select count(*) from Tbl_Kullanci", db);
            labelKullanciSayisi.Text = YolculukSayisi.ExecuteScalar().ToString();
            db.Close();
        }
        //datagridview1 headers basliklari degistirmek
        private void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Kullancı Numerası";
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Kullancı Adı";
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClearSelection();
        }
        //formun font style degitirmek icin
        private void UpdateFont()
        {
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }

        private void btnKullanciEkle_Click(object sender, EventArgs e)
        {
            //Ucak Ekle kodu formu cagirmak
            using (KullanciEkle KullanciEkle = new KullanciEkle())
            {
                KullanciEkle.ShowDialog();
                this.OnLoad(e);
            }
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
                SqlCommand sorguSil = new SqlCommand("delete from Tbl_Kullanci where ID=@s1", db);
                sorguSil.Parameters.AddWithValue("@s1", Scell);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Kullancı Kaydı Silindi");
                this.OnLoad(e);
            }
        }

        
    }
}
