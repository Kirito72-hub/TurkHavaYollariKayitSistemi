namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    partial class KC_BiletAl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cbNerden = new System.Windows.Forms.ComboBox();
            this.cbNereye = new System.Windows.Forms.ComboBox();
            this.btnUcakSil = new System.Windows.Forms.Button();
            this.btnUcakEkle = new System.Windows.Forms.Button();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltxt = new System.Windows.Forms.Label();
            this.labelYolculukSayisi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.upperPanel.Controls.Add(this.btnSifirla);
            this.upperPanel.Controls.Add(this.dtpTarih);
            this.upperPanel.Controls.Add(this.cbNerden);
            this.upperPanel.Controls.Add(this.cbNereye);
            this.upperPanel.Controls.Add(this.btnUcakSil);
            this.upperPanel.Controls.Add(this.btnUcakEkle);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1408, 69);
            this.upperPanel.TabIndex = 2;
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.White;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSifirla.Location = new System.Drawing.Point(1265, 20);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(115, 31);
            this.btnSifirla.TabIndex = 9;
            this.btnSifirla.Text = "TÜMÜNÜ KALDIR";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "";
            this.dtpTarih.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(1043, 21);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(173, 31);
            this.dtpTarih.TabIndex = 8;
            this.dtpTarih.Value = new System.DateTime(2022, 8, 7, 14, 1, 57, 0);
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // cbNerden
            // 
            this.cbNerden.DropDownHeight = 300;
            this.cbNerden.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNerden.FormattingEnabled = true;
            this.cbNerden.IntegralHeight = false;
            this.cbNerden.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Alanya",
            "Antalya",
            "Balıkesir",
            "Bursa",
            "Çanakkale",
            "Denizli",
            "Diyarbakır",
            "Elazığ",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Hatay",
            "Isparta",
            "İstanbul",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kayseri",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Muğla",
            "Muğla",
            "Nevşehir",
            "Ordu",
            "Samsun",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Tekirdağ",
            "Trabzon",
            "Uşak",
            "Van",
            "Zonguldak"});
            this.cbNerden.Location = new System.Drawing.Point(482, 20);
            this.cbNerden.Name = "cbNerden";
            this.cbNerden.Size = new System.Drawing.Size(270, 31);
            this.cbNerden.TabIndex = 6;
            this.cbNerden.SelectedIndexChanged += new System.EventHandler(this.cbNerden_SelectedIndexChanged);
            // 
            // cbNereye
            // 
            this.cbNereye.DropDownHeight = 300;
            this.cbNereye.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.IntegralHeight = false;
            this.cbNereye.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Alanya",
            "Antalya",
            "Balıkesir",
            "Bursa",
            "Çanakkale",
            "Denizli",
            "Diyarbakır",
            "Elazığ",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Hatay",
            "Isparta",
            "İstanbul",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kayseri",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Muğla",
            "Muğla",
            "Nevşehir",
            "Ordu",
            "Samsun",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Tekirdağ",
            "Trabzon",
            "Uşak",
            "Van",
            "Zonguldak"});
            this.cbNereye.Location = new System.Drawing.Point(758, 20);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(279, 31);
            this.cbNereye.TabIndex = 7;
            this.cbNereye.SelectedIndexChanged += new System.EventHandler(this.cbNereye_SelectedIndexChanged);
            // 
            // btnUcakSil
            // 
            this.btnUcakSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnUcakSil.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcakSil.Location = new System.Drawing.Point(196, 3);
            this.btnUcakSil.Name = "btnUcakSil";
            this.btnUcakSil.Size = new System.Drawing.Size(196, 66);
            this.btnUcakSil.TabIndex = 1;
            this.btnUcakSil.Text = "Uçak Sil";
            this.btnUcakSil.UseVisualStyleBackColor = false;
            this.btnUcakSil.Visible = false;
            // 
            // btnUcakEkle
            // 
            this.btnUcakEkle.BackColor = System.Drawing.Color.SlateGray;
            this.btnUcakEkle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcakEkle.Location = new System.Drawing.Point(3, 3);
            this.btnUcakEkle.Name = "btnUcakEkle";
            this.btnUcakEkle.Size = new System.Drawing.Size(196, 66);
            this.btnUcakEkle.TabIndex = 1;
            this.btnUcakEkle.Text = "Uçak Ekle";
            this.btnUcakEkle.UseVisualStyleBackColor = false;
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lowerPanel.Controls.Add(this.labelYolculukSayisi);
            this.lowerPanel.Controls.Add(this.label1);
            this.lowerPanel.Controls.Add(this.labeltxt);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 600);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(1408, 69);
            this.lowerPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Türk Hava Yolları A.O. Her hakkı saklıdır. © 1996 - 2022";
            // 
            // labeltxt
            // 
            this.labeltxt.AutoSize = true;
            this.labeltxt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltxt.ForeColor = System.Drawing.Color.White;
            this.labeltxt.Location = new System.Drawing.Point(1151, 20);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(159, 29);
            this.labeltxt.TabIndex = 1;
            this.labeltxt.Text = "Yolculuk sayısı:";
            // 
            // labelYolculukSayisi
            // 
            this.labelYolculukSayisi.AutoSize = true;
            this.labelYolculukSayisi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYolculukSayisi.ForeColor = System.Drawing.Color.White;
            this.labelYolculukSayisi.Location = new System.Drawing.Point(1301, 21);
            this.labelYolculukSayisi.Name = "labelYolculukSayisi";
            this.labelYolculukSayisi.Size = new System.Drawing.Size(37, 29);
            this.labelYolculukSayisi.TabIndex = 2;
            this.labelYolculukSayisi.Text = "00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1408, 531);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // KC_BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Name = "KC_BiletAl";
            this.Size = new System.Drawing.Size(1408, 669);
            this.Load += new System.EventHandler(this.KC_BiletAl_Load);
            this.upperPanel.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button btnUcakSil;
        private System.Windows.Forms.Button btnUcakEkle;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.Label labelYolculukSayisi;
        private System.Windows.Forms.ComboBox cbNerden;
        private System.Windows.Forms.ComboBox cbNereye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnSifirla;
    }
}
