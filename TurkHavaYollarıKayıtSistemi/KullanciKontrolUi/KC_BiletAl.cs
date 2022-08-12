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
            SqlDataAdapter sorgu1 = new SqlDataAdapter("Select * from [YolculukBiletAl]", db);
            DataTable dt1 = new DataTable();
            sorgu1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns[0].Visible = false;
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
            labelYolculukSayisi.Text = "Yolculuk Sayısı: "+counter.ToString();
        }
        //Bilet sayisi toplayip label icinde yazmak
        private void CounterBilet()
        {
            int CounterBilet = dataGridView2.DisplayedRowCount(true);
            labelYolculukSayisi.Text = "Bilet Sayısı: " + CounterBilet.ToString();
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
        //cift tikla olayi
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ConstValue.YolculukID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Yolcu kaydı var mı ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //YolcuBul formu cagirmak
                using (YolculukBul YolculukBul = new YolculukBul())
                {
                    YolculukBul.ShowDialog();
                    this.OnLoad(e);
                }
            }
            else
            {
                //YolcuEkle formu acar kullanci no basinca
                MessageBox.Show("Lütfen yolcu kaydı olusturunuz!");
                using (YolcuEkle YolcuEkle = new YolcuEkle())
                {
                    YolcuEkle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
        //tab degisince bilet sil butonu cikacak ve bilet sayisi yenilecek geri tab gidince kalmayacaklar
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) { btnBiletSil.Visible = true; CounterBilet();}
                
            else if(tabControl1.SelectedIndex == 0) { btnBiletSil.Visible = false; counters(); }
        }
        //tablodan bir cell uzerinde basarsak silmek butonu cikar silme basarsak kayit siliniyor
        //Secilen cell'in hangi satirda oldugunu ogrencmek icin 
        int Scell;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            object value = dataGridView2.Rows[index].Cells[0].Value;
            Scell = (int)value;
        }
        //Delete butonda SP kullanildi cell numerasi Scell degiskeninde atilir ve SP'ye gonderilir
        private void btnBiletSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("Exec DeleteYolcuYolculuk '" + Scell + "'", db);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Bilet Kaydı Silindi");
                this.OnLoad(e);
            }
        }
        
    }
}