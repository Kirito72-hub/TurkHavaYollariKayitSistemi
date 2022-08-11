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
    public partial class KC_Yolcu : UserControl
    {
        public KC_Yolcu()
        {
            InitializeComponent();
        }
        //sql baglantisini kurmak
        SqlConnection db = new SqlConnection(ConstValue.connectionString);

        //datagridview1 headers basliklari degistirecek kod
        private void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Yolcu No";
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderText = "E-posta";
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].HeaderText = "Kayıt Tarihi";
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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

        private void KC_Yolcu_Load(object sender, EventArgs e)
        {
            //tabloyu ekrana yazmak
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Tbl_Yolcu", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();

            //Yolcu Sayısı toplayip label icinde yazmak
            SqlCommand YolcuSayisi = new SqlCommand("Select count(*) from Tbl_Yolcu", db);
            labelYolcuSayisi.Text = "Yolcu Sayısı: " + YolcuSayisi.ExecuteScalar().ToString();
            db.Close();
        }
        private void btnYolcuEkle_Click(object sender, EventArgs e)
        {
            //Yolcu Ekle formu cagirmak
            using (YolcuEkle YolcuEkle = new YolcuEkle())
            {
                YolcuEkle.ShowDialog();
                this.OnLoad(e);
            }
        }
        //tablodan bir cell uzerinde basarsak silmek butonu cikar silme basarsak kayit siliniyor
        //Secilen cell'in hangi satirda oldugunu ogrencmek icin
        int Scell;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnYolcuSil.Visible = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;
        }
        //Delete butonda SP kullanildi cell numerasi Scell degiskeninde atilir ve SP'ye gonderilir
        private void btnYolcuSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("Exec DeleteYolcu '" +Scell+ "'", db);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Yolcu Kaydı Silindi");
                this.OnLoad(e);
            }
        }
    }
}
