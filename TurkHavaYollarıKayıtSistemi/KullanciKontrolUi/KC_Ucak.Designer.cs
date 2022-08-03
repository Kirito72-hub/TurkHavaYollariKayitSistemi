namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    partial class KC_Ucak
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
            this.btnUcakSil = new System.Windows.Forms.Button();
            this.btnUcakEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltxt = new System.Windows.Forms.Label();
            this.labelUcakSayisi = new System.Windows.Forms.Label();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.upperPanel.Controls.Add(this.btnUcakSil);
            this.upperPanel.Controls.Add(this.btnUcakEkle);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1408, 69);
            this.upperPanel.TabIndex = 1;
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
            this.btnUcakSil.Click += new System.EventHandler(this.btnUcakSil_Click);
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
            this.btnUcakEkle.Click += new System.EventHandler(this.btnUcakEkle_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1408, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lowerPanel.Controls.Add(this.label1);
            this.lowerPanel.Controls.Add(this.labeltxt);
            this.lowerPanel.Controls.Add(this.labelUcakSayisi);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 600);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(1408, 69);
            this.lowerPanel.TabIndex = 3;
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
            this.labeltxt.Location = new System.Drawing.Point(1168, 20);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(127, 29);
            this.labeltxt.TabIndex = 1;
            this.labeltxt.Text = "Uçak Sayısı:";
            // 
            // labelUcakSayisi
            // 
            this.labelUcakSayisi.AutoSize = true;
            this.labelUcakSayisi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUcakSayisi.ForeColor = System.Drawing.Color.White;
            this.labelUcakSayisi.Location = new System.Drawing.Point(1301, 20);
            this.labelUcakSayisi.Name = "labelUcakSayisi";
            this.labelUcakSayisi.Size = new System.Drawing.Size(37, 29);
            this.labelUcakSayisi.TabIndex = 2;
            this.labelUcakSayisi.Text = "00";
            // 
            // KC_Ucak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.upperPanel);
            this.Name = "KC_Ucak";
            this.Size = new System.Drawing.Size(1408, 669);
            this.Load += new System.EventHandler(this.KC_Ucak_Load);
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button btnUcakSil;
        private System.Windows.Forms.Button btnUcakEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.Label labelUcakSayisi;
    }
}
