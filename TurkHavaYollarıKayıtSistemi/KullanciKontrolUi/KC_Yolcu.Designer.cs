namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    partial class KC_Yolcu
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
            this.btnYolcuSil = new System.Windows.Forms.Button();
            this.btnYolcuEkle = new System.Windows.Forms.Button();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltxt = new System.Windows.Forms.Label();
            this.labelYolcuSayisi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.upperPanel.Controls.Add(this.btnYolcuSil);
            this.upperPanel.Controls.Add(this.btnYolcuEkle);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1408, 69);
            this.upperPanel.TabIndex = 1;
            // 
            // btnYolcuSil
            // 
            this.btnYolcuSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolcuSil.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolcuSil.Location = new System.Drawing.Point(196, 3);
            this.btnYolcuSil.Name = "btnYolcuSil";
            this.btnYolcuSil.Size = new System.Drawing.Size(196, 66);
            this.btnYolcuSil.TabIndex = 1;
            this.btnYolcuSil.Text = "Yolcu Sil";
            this.btnYolcuSil.UseVisualStyleBackColor = false;
            this.btnYolcuSil.Visible = false;
            this.btnYolcuSil.Click += new System.EventHandler(this.btnYolcuSil_Click);
            // 
            // btnYolcuEkle
            // 
            this.btnYolcuEkle.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolcuEkle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolcuEkle.Location = new System.Drawing.Point(3, 3);
            this.btnYolcuEkle.Name = "btnYolcuEkle";
            this.btnYolcuEkle.Size = new System.Drawing.Size(196, 66);
            this.btnYolcuEkle.TabIndex = 1;
            this.btnYolcuEkle.Text = "Yolcu Ekle";
            this.btnYolcuEkle.UseVisualStyleBackColor = false;
            this.btnYolcuEkle.Click += new System.EventHandler(this.btnYolcuEkle_Click);
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lowerPanel.Controls.Add(this.label1);
            this.lowerPanel.Controls.Add(this.labeltxt);
            this.lowerPanel.Controls.Add(this.labelYolcuSayisi);
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
            this.labeltxt.Size = new System.Drawing.Size(131, 29);
            this.labeltxt.TabIndex = 1;
            this.labeltxt.Text = "Yolcu Sayısı:";
            // 
            // labelYolcuSayisi
            // 
            this.labelYolcuSayisi.AutoSize = true;
            this.labelYolcuSayisi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYolcuSayisi.ForeColor = System.Drawing.Color.White;
            this.labelYolcuSayisi.Location = new System.Drawing.Point(1305, 20);
            this.labelYolcuSayisi.Name = "labelYolcuSayisi";
            this.labelYolcuSayisi.Size = new System.Drawing.Size(37, 29);
            this.labelYolcuSayisi.TabIndex = 2;
            this.labelYolcuSayisi.Text = "00";
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
            this.dataGridView1.TabIndex = 3;
            // 
            // KC_Yolcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Name = "KC_Yolcu";
            this.Size = new System.Drawing.Size(1408, 669);
            this.Load += new System.EventHandler(this.KC_Yolcu_Load);
            this.upperPanel.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button btnYolcuSil;
        private System.Windows.Forms.Button btnYolcuEkle;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.Label labelYolcuSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
