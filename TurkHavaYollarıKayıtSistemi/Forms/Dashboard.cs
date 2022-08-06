using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkHavaYollarıKayıtSistemi.KullanciKontrolUi;

namespace TurkHavaYollarıKayıtSistemi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        //Kullanci adini Merhaba! den sonra yzilmasi
        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelKullanciAdi.Text = "Merhaba! " + ConstValue.KullanciAdi;
        }
        //getirlecek control ui'n boyutlari duzenletecek fonksiyon
        private void addControls(UserControl uc)
        {
            panelControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //AnaSayfa butunununa basildiginda control ui getirmek (AnaSayfa.cs)
        private void button1_Click(object sender, EventArgs e)
        {
            KC_BiletAl AnaSayfa = new KC_BiletAl();
            addControls(AnaSayfa);
            
        }
       //timer saat,dakika gostermesi icin ayarlama
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.labelTime.Text = dt.ToString("HH:mm");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
        //Yolculuk butunununa basildiginda control ui getirmek (Yolculuk.cs)
        private void btnYolculuk_Click(object sender, EventArgs e)
        {
            KC_Yolculuk Yolculuk = new KC_Yolculuk();
            addControls(Yolculuk);
        }
        //Yolcu butunununa basildiginda control ui getirmek (Yolcu.cs)
        private void btnYolcu_Click(object sender, EventArgs e)
        {
            KC_Yolcu Yolcu = new KC_Yolcu();
            addControls(Yolcu);
        }
        //Ucak butunununa basildiginda control ui getirmek (Ucak.cs)
        private void btnUcak_Click(object sender, EventArgs e)
        {
            KC_Ucak Ucak = new KC_Ucak();
            addControls(Ucak);
        }
        //Kullanci butunununa basildiginda control ui getirmek (Kullanci.cs)
        private void btnKullanci_Click(object sender, EventArgs e)
        {
            KC_Kullanci Kullanci = new KC_Kullanci();
            addControls(Kullanci);
        }

        private void labelKullanciAdi_Click(object sender, EventArgs e)
        {

        }
        //minimize butunu
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}