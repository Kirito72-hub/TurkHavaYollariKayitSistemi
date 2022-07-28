namespace TurkHavaYollarıKayıtSistemi.Forms
{
    partial class YolculukEkle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.cbNerden = new System.Windows.Forms.ComboBox();
            this.cbNereye = new System.Windows.Forms.ComboBox();
            this.dtpKalkisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbUcakID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVarisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpKalkisSaati = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpVarisSaati);
            this.panel1.Controls.Add(this.dtpVarisTarihi);
            this.panel1.Controls.Add(this.dtpKalkisSaati);
            this.panel1.Controls.Add(this.dtpKalkisTarihi);
            this.panel1.Controls.Add(this.cbUcakID);
            this.panel1.Controls.Add(this.cbNereye);
            this.panel1.Controls.Add(this.cbNerden);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 642);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalkış Tarihi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 3;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Location = new System.Drawing.Point(202, 540);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 53);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 3;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(392, 540);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(184, 53);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // cbNerden
            // 
            this.cbNerden.BackColor = System.Drawing.Color.White;
            this.cbNerden.DropDownHeight = 200;
            this.cbNerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNerden.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNerden.FormattingEnabled = true;
            this.cbNerden.IntegralHeight = false;
            this.cbNerden.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbNerden.Location = new System.Drawing.Point(21, 129);
            this.cbNerden.Name = "cbNerden";
            this.cbNerden.Size = new System.Drawing.Size(353, 41);
            this.cbNerden.TabIndex = 2;
            // 
            // cbNereye
            // 
            this.cbNereye.DropDownHeight = 200;
            this.cbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNereye.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.IntegralHeight = false;
            this.cbNereye.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbNereye.Location = new System.Drawing.Point(411, 129);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(353, 41);
            this.cbNereye.TabIndex = 3;
            // 
            // dtpKalkisTarihi
            // 
            this.dtpKalkisTarihi.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarihi.Location = new System.Drawing.Point(21, 251);
            this.dtpKalkisTarihi.Name = "dtpKalkisTarihi";
            this.dtpKalkisTarihi.Size = new System.Drawing.Size(265, 43);
            this.dtpKalkisTarihi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(404, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varış Tarihi";
            // 
            // dtpVarisTarihi
            // 
            this.dtpVarisTarihi.CustomFormat = "";
            this.dtpVarisTarihi.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarisTarihi.Location = new System.Drawing.Point(411, 251);
            this.dtpVarisTarihi.Name = "dtpVarisTarihi";
            this.dtpVarisTarihi.Size = new System.Drawing.Size(265, 43);
            this.dtpVarisTarihi.TabIndex = 4;
            this.dtpVarisTarihi.Value = new System.DateTime(2022, 7, 28, 16, 35, 0, 0);
            // 
            // cbUcakID
            // 
            this.cbUcakID.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUcakID.FormattingEnabled = true;
            this.cbUcakID.Location = new System.Drawing.Point(21, 413);
            this.cbUcakID.Name = "cbUcakID";
            this.cbUcakID.Size = new System.Drawing.Size(265, 41);
            this.cbUcakID.TabIndex = 3;
            this.cbUcakID.Text = "Uçak Numerası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(272, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Yolculuk Ekle";
            // 
            // dtpVarisSaati
            // 
            this.dtpVarisSaati.CustomFormat = "HH:mm";
            this.dtpVarisSaati.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVarisSaati.Location = new System.Drawing.Point(411, 315);
            this.dtpVarisSaati.Name = "dtpVarisSaati";
            this.dtpVarisSaati.ShowUpDown = true;
            this.dtpVarisSaati.Size = new System.Drawing.Size(265, 43);
            this.dtpVarisSaati.TabIndex = 4;
            this.dtpVarisSaati.Value = new System.DateTime(2022, 7, 28, 16, 35, 0, 0);
            // 
            // dtpKalkisSaati
            // 
            this.dtpKalkisSaati.CustomFormat = "HH:mm";
            this.dtpKalkisSaati.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKalkisSaati.Location = new System.Drawing.Point(21, 315);
            this.dtpKalkisSaati.Name = "dtpKalkisSaati";
            this.dtpKalkisSaati.ShowUpDown = true;
            this.dtpKalkisSaati.Size = new System.Drawing.Size(265, 43);
            this.dtpKalkisSaati.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nerden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(404, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nereye";
            // 
            // YolculukEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(796, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YolculukEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YolculukEkle";
            this.Load += new System.EventHandler(this.YolculukEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNereye;
        private System.Windows.Forms.ComboBox cbNerden;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpVarisTarihi;
        private System.Windows.Forms.DateTimePicker dtpKalkisTarihi;
        private System.Windows.Forms.ComboBox cbUcakID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKalkisSaati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVarisSaati;
    }
}