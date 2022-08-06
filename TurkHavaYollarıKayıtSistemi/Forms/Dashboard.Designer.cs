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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SideBanner = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKullanci = new System.Windows.Forms.Button();
            this.btnUcak = new System.Windows.Forms.Button();
            this.btnYolcu = new System.Windows.Forms.Button();
            this.btnYolculuk = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.labelKullanciAdi = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpperBanner = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager1 = new TurkHavaYollarıKayıtSistemi.THYDataSetTableAdapters.TableAdapterManager();
            this.SideBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UpperBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBanner
            // 
            this.SideBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.SideBanner.Controls.Add(this.labelKullanciAdi);
            this.SideBanner.Controls.Add(this.pictureBox2);
            this.SideBanner.Controls.Add(this.btnKullanci);
            this.SideBanner.Controls.Add(this.btnUcak);
            this.SideBanner.Controls.Add(this.btnYolcu);
            this.SideBanner.Controls.Add(this.btnYolculuk);
            this.SideBanner.Controls.Add(this.btnAnaSayfa);
            this.SideBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBanner.ForeColor = System.Drawing.Color.White;
            this.SideBanner.Location = new System.Drawing.Point(0, 0);
            this.SideBanner.Margin = new System.Windows.Forms.Padding(0);
            this.SideBanner.Name = "SideBanner";
            this.SideBanner.Size = new System.Drawing.Size(283, 900);
            this.SideBanner.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnKullanci
            // 
            this.btnKullanci.BackColor = System.Drawing.Color.SlateGray;
            this.btnKullanci.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKullanci.FlatAppearance.BorderSize = 3;
            this.btnKullanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanci.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanci.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanci.Image")));
            this.btnKullanci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanci.Location = new System.Drawing.Point(0, 812);
            this.btnKullanci.Margin = new System.Windows.Forms.Padding(0);
            this.btnKullanci.Name = "btnKullanci";
            this.btnKullanci.Size = new System.Drawing.Size(283, 86);
            this.btnKullanci.TabIndex = 4;
            this.btnKullanci.Text = "Kullancı";
            this.btnKullanci.UseVisualStyleBackColor = false;
            this.btnKullanci.Click += new System.EventHandler(this.btnKullanci_Click);
            // 
            // btnUcak
            // 
            this.btnUcak.BackColor = System.Drawing.Color.SlateGray;
            this.btnUcak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUcak.FlatAppearance.BorderSize = 3;
            this.btnUcak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcak.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcak.Image = ((System.Drawing.Image)(resources.GetObject("btnUcak.Image")));
            this.btnUcak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcak.Location = new System.Drawing.Point(0, 726);
            this.btnUcak.Margin = new System.Windows.Forms.Padding(0);
            this.btnUcak.Name = "btnUcak";
            this.btnUcak.Size = new System.Drawing.Size(283, 86);
            this.btnUcak.TabIndex = 3;
            this.btnUcak.Text = "Uçak";
            this.btnUcak.UseVisualStyleBackColor = false;
            this.btnUcak.Click += new System.EventHandler(this.btnUcak_Click);
            // 
            // btnYolcu
            // 
            this.btnYolcu.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolcu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYolcu.FlatAppearance.BorderSize = 3;
            this.btnYolcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYolcu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolcu.Image = ((System.Drawing.Image)(resources.GetObject("btnYolcu.Image")));
            this.btnYolcu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYolcu.Location = new System.Drawing.Point(0, 640);
            this.btnYolcu.Margin = new System.Windows.Forms.Padding(0);
            this.btnYolcu.Name = "btnYolcu";
            this.btnYolcu.Size = new System.Drawing.Size(283, 86);
            this.btnYolcu.TabIndex = 2;
            this.btnYolcu.Text = "Yolcu";
            this.btnYolcu.UseVisualStyleBackColor = false;
            this.btnYolcu.Click += new System.EventHandler(this.btnYolcu_Click);
            // 
            // btnYolculuk
            // 
            this.btnYolculuk.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolculuk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYolculuk.FlatAppearance.BorderSize = 3;
            this.btnYolculuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYolculuk.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolculuk.Image = ((System.Drawing.Image)(resources.GetObject("btnYolculuk.Image")));
            this.btnYolculuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYolculuk.Location = new System.Drawing.Point(0, 554);
            this.btnYolculuk.Margin = new System.Windows.Forms.Padding(0);
            this.btnYolculuk.Name = "btnYolculuk";
            this.btnYolculuk.Size = new System.Drawing.Size(283, 86);
            this.btnYolculuk.TabIndex = 1;
            this.btnYolculuk.Text = "Yolculuk";
            this.btnYolculuk.UseVisualStyleBackColor = false;
            this.btnYolculuk.Click += new System.EventHandler(this.btnYolculuk_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnaSayfa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 3;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.Image")));
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 468);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(283, 86);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "Bilet al";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelKullanciAdi
            // 
            this.labelKullanciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKullanciAdi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanciAdi.Location = new System.Drawing.Point(1, 155);
            this.labelKullanciAdi.Margin = new System.Windows.Forms.Padding(0);
            this.labelKullanciAdi.Name = "labelKullanciAdi";
            this.labelKullanciAdi.Size = new System.Drawing.Size(281, 29);
            this.labelKullanciAdi.TabIndex = 0;
            this.labelKullanciAdi.Text = "KullancıAdı";
            this.labelKullanciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKullanciAdi.Click += new System.EventHandler(this.labelKullanciAdi_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(283, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1517, 110);
            this.TopPanel.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Location = new System.Drawing.Point(1435, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 39);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(1479, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(949, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UpperBanner
            // 
            this.UpperBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.UpperBanner.Controls.Add(this.labelTime);
            this.UpperBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBanner.Location = new System.Drawing.Point(283, 110);
            this.UpperBanner.Name = "UpperBanner";
            this.UpperBanner.Size = new System.Drawing.Size(1517, 118);
            this.UpperBanner.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTime.Location = new System.Drawing.Point(1415, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(99, 42);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(283, 228);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1517, 672);
            this.panelControl.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Tbl_KullanciTableAdapter = null;
            this.tableAdapterManager1.Tbl_UcakTableAdapter = null;
            this.tableAdapterManager1.Tbl_YolculukTableAdapter = null;
            this.tableAdapterManager1.Tbl_YolcuTableAdapter = null;
            this.tableAdapterManager1.Tbl_YolcuYolculukTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TurkHavaYollarıKayıtSistemi.THYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 900);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.UpperBanner);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SideBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SideBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UpperBanner.ResumeLayout(false);
            this.UpperBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBanner;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel UpperBanner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKullanci;
        private System.Windows.Forms.Button btnUcak;
        private System.Windows.Forms.Button btnYolcu;
        private System.Windows.Forms.Button btnYolculuk;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label labelKullanciAdi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private THYDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnMinimize;
    }
}