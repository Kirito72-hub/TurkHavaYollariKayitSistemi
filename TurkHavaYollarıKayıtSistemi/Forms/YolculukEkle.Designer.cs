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
            this.dtpVarisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpKalkisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpKalkisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbUcakID = new System.Windows.Forms.ComboBox();
            this.cbNereye = new System.Windows.Forms.ComboBox();
            this.cbNerden = new System.Windows.Forms.ComboBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(918, 642);
            this.panel1.TabIndex = 0;
            // 
            // dtpVarisSaati
            // 
            this.dtpVarisSaati.CustomFormat = "HH:mm";
            this.dtpVarisSaati.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVarisSaati.Location = new System.Drawing.Point(482, 305);
            this.dtpVarisSaati.Name = "dtpVarisSaati";
            this.dtpVarisSaati.ShowUpDown = true;
            this.dtpVarisSaati.Size = new System.Drawing.Size(412, 43);
            this.dtpVarisSaati.TabIndex = 4;
            this.dtpVarisSaati.Value = new System.DateTime(2022, 7, 28, 16, 35, 0, 0);
            // 
            // dtpVarisTarihi
            // 
            this.dtpVarisTarihi.CustomFormat = "";
            this.dtpVarisTarihi.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarisTarihi.Location = new System.Drawing.Point(482, 241);
            this.dtpVarisTarihi.Name = "dtpVarisTarihi";
            this.dtpVarisTarihi.Size = new System.Drawing.Size(412, 43);
            this.dtpVarisTarihi.TabIndex = 4;
            this.dtpVarisTarihi.Value = new System.DateTime(2022, 7, 28, 16, 35, 0, 0);
            // 
            // dtpKalkisSaati
            // 
            this.dtpKalkisSaati.CustomFormat = "HH:mm";
            this.dtpKalkisSaati.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKalkisSaati.Location = new System.Drawing.Point(32, 305);
            this.dtpKalkisSaati.Name = "dtpKalkisSaati";
            this.dtpKalkisSaati.ShowUpDown = true;
            this.dtpKalkisSaati.Size = new System.Drawing.Size(417, 43);
            this.dtpKalkisSaati.TabIndex = 4;
            // 
            // dtpKalkisTarihi
            // 
            this.dtpKalkisTarihi.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKalkisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarihi.Location = new System.Drawing.Point(32, 241);
            this.dtpKalkisTarihi.Name = "dtpKalkisTarihi";
            this.dtpKalkisTarihi.Size = new System.Drawing.Size(417, 43);
            this.dtpKalkisTarihi.TabIndex = 4;
            // 
            // cbUcakID
            // 
            this.cbUcakID.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUcakID.FormattingEnabled = true;
            this.cbUcakID.Location = new System.Drawing.Point(32, 403);
            this.cbUcakID.Name = "cbUcakID";
            this.cbUcakID.Size = new System.Drawing.Size(417, 41);
            this.cbUcakID.TabIndex = 3;
            this.cbUcakID.Text = "Uçak Numerası";
            // 
            // cbNereye
            // 
            this.cbNereye.DropDownHeight = 200;
            this.cbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNereye.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.IntegralHeight = false;
            this.cbNereye.Items.AddRange(new object[] {
            "Adana Şakirpaşa Havalimanı",
            "Ankara Esenboğa Havalimanı",
            "Alanya Gazipaşa Havalimanı",
            "Antalya Havalimanı",
            "Balıkesir Kocaseyit Havalimanı",
            "Bursa Yenişehir Havalimanı",
            "Çanakkale Havalimanı",
            "Denizli Çardak Havalimanı",
            "Diyarbakır Havalimanı",
            "Elazığ Havalimanı",
            "Erzurum Havalimanı",
            "Eskişehir Hasan Polatkan Havalimanı",
            "Gaziantep Havalimanı",
            "Hatay Havalimanı",
            "Isparta Süleyman Demirel Havalimanı",
            "İstanbul Havalimanı",
            "İstanbul Sabiha Gökçen Havalimanı",
            "İzmir Adnan Menderes Havalimanı",
            "Kars Harakani Havalimanı",
            "Kayseri Havalimanı",
            "Kocaeli Cengiz Topel Havalimanı",
            "Konya Havalimanı",
            "Kütahya Zafer Havalimanı",
            "Malatya Havalimanı",
            "Muğla Dalaman Havalimanı",
            "Muğla Milas-Bodrum Havalimanı",
            "Nevşehir Kapadokya Havalimanı",
            "Ordu Giresun Havalimanı",
            "Samsun Çarşamba Havalimanı",
            "Sinop Havalimanı",
            "Sivas Nuri Demirağ Havalimanı",
            "Şanlıurfa GAP Havalimanı",
            "Tekirdağ Çorlu Havalimanı",
            "Trabzon Havalimanı",
            "Uşak Havalimanı",
            "Van Ferit Melen Havalimanı",
            "Zonguldak Çaycuma Havalimanı"});
            this.cbNereye.Location = new System.Drawing.Point(477, 129);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(417, 41);
            this.cbNereye.TabIndex = 3;
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
            "Adana Şakirpaşa Havalimanı",
            "Ankara Esenboğa Havalimanı",
            "Alanya Gazipaşa Havalimanı",
            "Antalya Havalimanı",
            "Balıkesir Kocaseyit Havalimanı",
            "Bursa Yenişehir Havalimanı",
            "Çanakkale Havalimanı",
            "Denizli Çardak Havalimanı",
            "Diyarbakır Havalimanı",
            "Elazığ Havalimanı",
            "Erzurum Havalimanı",
            "Eskişehir Hasan Polatkan Havalimanı",
            "Gaziantep Havalimanı",
            "Hatay Havalimanı",
            "Isparta Süleyman Demirel Havalimanı",
            "İstanbul Havalimanı",
            "İstanbul Sabiha Gökçen Havalimanı",
            "İzmir Adnan Menderes Havalimanı",
            "Kars Harakani Havalimanı",
            "Kayseri Havalimanı",
            "Kocaeli Cengiz Topel Havalimanı",
            "Konya Havalimanı",
            "Kütahya Zafer Havalimanı",
            "Malatya Havalimanı",
            "Muğla Dalaman Havalimanı",
            "Muğla Milas-Bodrum Havalimanı",
            "Nevşehir Kapadokya Havalimanı",
            "Ordu Giresun Havalimanı",
            "Samsun Çarşamba Havalimanı",
            "Sinop Havalimanı",
            "Sivas Nuri Demirağ Havalimanı",
            "Şanlıurfa GAP Havalimanı",
            "Tekirdağ Çorlu Havalimanı",
            "Trabzon Havalimanı",
            "Uşak Havalimanı",
            "Van Ferit Melen Havalimanı",
            "Zonguldak Çaycuma Havalimanı"});
            this.cbNerden.Location = new System.Drawing.Point(32, 129);
            this.cbNerden.Name = "cbNerden";
            this.cbNerden.Size = new System.Drawing.Size(417, 41);
            this.cbNerden.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 3;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(462, 540);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(184, 53);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 3;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Location = new System.Drawing.Point(272, 540);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 53);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(334, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Yolculuk Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(475, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nereye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(475, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nerden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalkış Tarihi";
            // 
            // YolculukEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(936, 660);
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