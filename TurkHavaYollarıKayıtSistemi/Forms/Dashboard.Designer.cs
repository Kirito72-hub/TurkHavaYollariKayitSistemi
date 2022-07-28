namespace TurkHavaYollarıKayıtSistemi
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKullanciAdi = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnYolculuk = new System.Windows.Forms.Button();
            this.btnYolcu = new System.Windows.Forms.Button();
            this.btnUcak = new System.Windows.Forms.Button();
            this.btnKullanci = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnKullanci);
            this.panel1.Controls.Add(this.btnUcak);
            this.panel1.Controls.Add(this.btnYolcu);
            this.panel1.Controls.Add(this.btnYolculuk);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelKullanciAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 861);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1501, 110);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(283, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1501, 118);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(853, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelKullanciAdi
            // 
            this.labelKullanciAdi.AutoSize = true;
            this.labelKullanciAdi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanciAdi.Location = new System.Drawing.Point(112, 38);
            this.labelKullanciAdi.Name = "labelKullanciAdi";
            this.labelKullanciAdi.Size = new System.Drawing.Size(124, 29);
            this.labelKullanciAdi.TabIndex = 0;
            this.labelKullanciAdi.Text = "KullanciAdi";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 449);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(283, 86);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYolculuk
            // 
            this.btnYolculuk.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolculuk.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolculuk.Location = new System.Drawing.Point(0, 532);
            this.btnYolculuk.Name = "btnYolculuk";
            this.btnYolculuk.Size = new System.Drawing.Size(283, 86);
            this.btnYolculuk.TabIndex = 1;
            this.btnYolculuk.Text = "Yolculuk";
            this.btnYolculuk.UseVisualStyleBackColor = false;
            // 
            // btnYolcu
            // 
            this.btnYolcu.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolcu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolcu.Location = new System.Drawing.Point(0, 610);
            this.btnYolcu.Name = "btnYolcu";
            this.btnYolcu.Size = new System.Drawing.Size(283, 86);
            this.btnYolcu.TabIndex = 2;
            this.btnYolcu.Text = "Yolcu";
            this.btnYolcu.UseVisualStyleBackColor = false;
            // 
            // btnUcak
            // 
            this.btnUcak.BackColor = System.Drawing.Color.SlateGray;
            this.btnUcak.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcak.Location = new System.Drawing.Point(0, 691);
            this.btnUcak.Name = "btnUcak";
            this.btnUcak.Size = new System.Drawing.Size(283, 86);
            this.btnUcak.TabIndex = 3;
            this.btnUcak.Text = "Uçak";
            this.btnUcak.UseVisualStyleBackColor = false;
            // 
            // btnKullanci
            // 
            this.btnKullanci.BackColor = System.Drawing.Color.SlateGray;
            this.btnKullanci.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanci.Location = new System.Drawing.Point(0, 774);
            this.btnKullanci.Name = "btnKullanci";
            this.btnKullanci.Size = new System.Drawing.Size(283, 86);
            this.btnKullanci.TabIndex = 4;
            this.btnKullanci.Text = "Kullancı";
            this.btnKullanci.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(1465, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 34);
            this.button6.TabIndex = 8;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhaba!";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKullanci;
        private System.Windows.Forms.Button btnUcak;
        private System.Windows.Forms.Button btnYolcu;
        private System.Windows.Forms.Button btnYolculuk;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label labelKullanciAdi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}