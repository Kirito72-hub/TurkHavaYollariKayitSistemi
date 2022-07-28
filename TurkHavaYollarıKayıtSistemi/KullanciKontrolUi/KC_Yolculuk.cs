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

namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    public partial class KC_Yolculuk : UserControl
    {
        public KC_Yolculuk()
        {
            InitializeComponent();
        }
        //sql baglantisini kurmak
        SqlConnection db = new SqlConnection("Data Source=LAPTOP-SCMK2VA2\\MSSQLSERVER01;Initial Catalog=THY;Integrated Security=True");

        //datagridview1 headers basliklari degistirmek
        private void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClearSelection();
        }
        //formun font style degitirmek icin
        private void UpdateFont()
        {
            foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }


        private void btnYolculukEkle_Click(object sender, EventArgs e)
        {

        }

        private void KC_Yolculuk_Load(object sender, EventArgs e)
        {
            //tabloyu ekrana yazmak
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("select * From Tbl_Yolculuk",db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();

            //yolculuk sayisi toplayip label icinde yazmak
            SqlCommand YolculukSayisi = new SqlCommand("Select count(*) from Tbl_Yolculuk",db);
            labelYolculukSayisi.Text = YolculukSayisi.ExecuteScalar().ToString();
        }
    }
}
