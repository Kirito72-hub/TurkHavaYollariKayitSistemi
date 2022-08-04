namespace TurkHavaYollarıKayıtSistemi.Forms
{
    partial class KullanciEkle
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
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxEskiSifre = new System.Windows.Forms.TextBox();
            this.txtBoxKullanci = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKullanciAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtBoxSifre);
            this.panel1.Controls.Add(this.txtBoxEskiSifre);
            this.panel1.Controls.Add(this.txtBoxKullanci);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelKullanciAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 495);
            this.panel1.TabIndex = 2;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.txtBoxSifre.Location = new System.Drawing.Point(39, 213);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(265, 43);
            this.txtBoxSifre.TabIndex = 1;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // txtBoxEskiSifre
            // 
            this.txtBoxEskiSifre.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.txtBoxEskiSifre.Location = new System.Drawing.Point(39, 347);
            this.txtBoxEskiSifre.Name = "txtBoxEskiSifre";
            this.txtBoxEskiSifre.Size = new System.Drawing.Size(265, 43);
            this.txtBoxEskiSifre.TabIndex = 2;
            this.txtBoxEskiSifre.UseSystemPasswordChar = true;
            // 
            // txtBoxKullanci
            // 
            this.txtBoxKullanci.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.txtBoxKullanci.Location = new System.Drawing.Point(39, 125);
            this.txtBoxKullanci.Name = "txtBoxKullanci";
            this.txtBoxKullanci.Size = new System.Drawing.Size(265, 43);
            this.txtBoxKullanci.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 3;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(215, 430);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(184, 53);
            this.btnIptal.TabIndex = 4;
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
            this.btnKaydet.Location = new System.Drawing.Point(16, 430);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 53);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(92, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Kullancı Ekle";
            // 
            // labelKullanciAdi
            // 
            this.labelKullanciAdi.AutoSize = true;
            this.labelKullanciAdi.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanciAdi.Location = new System.Drawing.Point(32, 305);
            this.labelKullanciAdi.Name = "labelKullanciAdi";
            this.labelKullanciAdi.Size = new System.Drawing.Size(159, 39);
            this.labelKullanciAdi.TabIndex = 0;
            this.labelKullanciAdi.Text = "XXX Şifresi";
            this.labelKullanciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullancı Adı";
            // 
            // KullanciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(450, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullanciEkle";
            this.Text = "KullanciEkle";
            this.Load += new System.EventHandler(this.KullanciEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxEskiSifre;
        private System.Windows.Forms.TextBox txtBoxKullanci;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKullanciAdi;
        private System.Windows.Forms.Label label1;
    }
}