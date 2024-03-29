﻿namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    partial class KC_Kullanci
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
            this.btnKullanciSil = new System.Windows.Forms.Button();
            this.btnKullanciEkle = new System.Windows.Forms.Button();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKullanciSayisi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.upperPanel.Controls.Add(this.btnKullanciSil);
            this.upperPanel.Controls.Add(this.btnKullanciEkle);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1408, 69);
            this.upperPanel.TabIndex = 1;
            // 
            // btnKullanciSil
            // 
            this.btnKullanciSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnKullanciSil.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanciSil.Location = new System.Drawing.Point(196, 3);
            this.btnKullanciSil.Name = "btnKullanciSil";
            this.btnKullanciSil.Size = new System.Drawing.Size(196, 66);
            this.btnKullanciSil.TabIndex = 1;
            this.btnKullanciSil.Text = "Kullancı Sil";
            this.btnKullanciSil.UseVisualStyleBackColor = false;
            this.btnKullanciSil.Visible = false;
            this.btnKullanciSil.Click += new System.EventHandler(this.btnKullanciSil_Click);
            // 
            // btnKullanciEkle
            // 
            this.btnKullanciEkle.BackColor = System.Drawing.Color.SlateGray;
            this.btnKullanciEkle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanciEkle.Location = new System.Drawing.Point(3, 3);
            this.btnKullanciEkle.Name = "btnKullanciEkle";
            this.btnKullanciEkle.Size = new System.Drawing.Size(196, 66);
            this.btnKullanciEkle.TabIndex = 1;
            this.btnKullanciEkle.Text = "Kullancı Ekle";
            this.btnKullanciEkle.UseVisualStyleBackColor = false;
            this.btnKullanciEkle.Click += new System.EventHandler(this.btnKullanciEkle_Click);
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lowerPanel.Controls.Add(this.label1);
            this.lowerPanel.Controls.Add(this.labelKullanciSayisi);
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
            // labelKullanciSayisi
            // 
            this.labelKullanciSayisi.AutoSize = true;
            this.labelKullanciSayisi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanciSayisi.ForeColor = System.Drawing.Color.White;
            this.labelKullanciSayisi.Location = new System.Drawing.Point(1246, 21);
            this.labelKullanciSayisi.Name = "labelKullanciSayisi";
            this.labelKullanciSayisi.Size = new System.Drawing.Size(37, 29);
            this.labelKullanciSayisi.TabIndex = 2;
            this.labelKullanciSayisi.Text = "00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KC_Kullanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Name = "KC_Kullanci";
            this.Size = new System.Drawing.Size(1408, 669);
            this.Load += new System.EventHandler(this.KC_Kullanci_Load);
            this.upperPanel.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button btnKullanciSil;
        private System.Windows.Forms.Button btnKullanciEkle;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKullanciSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
