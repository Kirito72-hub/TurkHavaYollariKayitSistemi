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
    public partial class KC_BiletAl : UserControl
    {
        public KC_BiletAl()
        {
            InitializeComponent();
        }
        //sql baglantisini kurmak
        SqlConnection db = new SqlConnection(ConstValue.connectionString);

        //datagridview1 headers basliklari degistirmek
        private void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Yolculuk Numerası";
            dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Nerden";
            dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Nereye";
            dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Gidiş Tarihi";
            dataGridView1.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Gidiş Zamanı";
            dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Varış Tarihi";
            dataGridView1.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderText = "Varış Zamanı";
            dataGridView1.Columns[6].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        private void KC_BiletAl_Load(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * From Tbl_Yolculuk ", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();
            db.Close();
            counters();
        }
        //filtirleme yapan fonsksiyon dtpTarih deger aldigi durumunda
        private void getir()
        {
            labelYolculukSayisi.Text = dtpTarih.Text;
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("SELECT * FROM Tbl_Yolculuk WHERE GidisTarihi = '" + dtpTarih.Value + "' And Nerden like '" + cbNerden.Text + "%' And Nereye like '" + cbNereye.Text + "%'", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();
            db.Close();
        }
        //filtirleme yapan fonsksiyon dtpTarih deger almadigi durumunda
        private void getir1()
        {
            labelYolculukSayisi.Text = dtpTarih.Text;
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("SELECT * FROM Tbl_Yolculuk WHERE Nerden like '" + cbNerden.Text + "%' And Nereye like '" + cbNereye.Text + "%'", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();
            db.Close();
        }
        //yolculuk sayisi toplayip label icinde yazmak
        private void counters()
        {
            int counter = dataGridView1.DisplayedRowCount(true);
            labelYolculukSayisi.Text = counter.ToString();
        }
        //dtpTarih deger alip almadigini kontrol etmek icin
        bool control = false;
        //dtpTarih degeri degistirildigi zaman filtirleme yenileniyor 
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            control = true;
            getir();
            counters();
        }
        //nerden comboboxi degeri degistirildigi zaman liste yenileniyor
        private void cbNerden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (control == false) { getir1(); counters(); }
            else { getir(); counters(); }
        }
        //nereye comboboxi degeri degistirildigi zaman liste yenileniyor
        private void cbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (control == false) { getir1(); counters(); }
            else { getir(); counters(); }
        }
        //filtirleme sifirlamak icin
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now;
            control = false;
            cbNerden.SelectedIndex = -1;
            cbNereye.SelectedIndex = -1;
            KC_BiletAl_Load(this, null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int YolculukID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Yolcu kaydı var mı ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("Lütfen yolcu kaydı olusturunuz!");
                using (YolcuEkle YolcuEkle = new YolcuEkle())
                {
                    YolcuEkle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
    }
}
