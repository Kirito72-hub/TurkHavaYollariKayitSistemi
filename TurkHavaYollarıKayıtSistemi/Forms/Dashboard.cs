using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkHavaYollarıKayıtSistemi;

namespace TurkHavaYollarıKayıtSistemi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelKullanciAdi.Text = ConstValue.KullanciAdi;
        }

       /* private void addControls(UserControl uc)
        {
            panelControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
            uc.BringToFront();
        }*/

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.labelTime.Text = dt.ToString("HH:mm");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}