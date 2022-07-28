namespace TurkHavaYollarıKayıtSistemi.KullanciKontrolUi
{
    partial class KC_Yolculuk
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
            this.upperPanel = new System.Windows.Forms.Panel();
            this.midPanel = new System.Windows.Forms.Panel();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.btnYolculukEkle = new System.Windows.Forms.Button();
            this.btnYolculukSil = new System.Windows.Forms.Button();
            this.labeltxt = new System.Windows.Forms.Label();
            this.labelYolculukSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.upperPanel.Controls.Add(this.btnYolculukSil);
            this.upperPanel.Controls.Add(this.btnYolculukEkle);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1408, 69);
            this.upperPanel.TabIndex = 0;
            // 
            // midPanel
            // 
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 69);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1408, 600);
            this.midPanel.TabIndex = 0;
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.lowerPanel.Controls.Add(this.label1);
            this.lowerPanel.Controls.Add(this.labeltxt);
            this.lowerPanel.Controls.Add(this.labelYolculukSayisi);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 600);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(1408, 69);
            this.lowerPanel.TabIndex = 0;
            // 
            // btnYolculukEkle
            // 
            this.btnYolculukEkle.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolculukEkle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolculukEkle.Location = new System.Drawing.Point(3, 0);
            this.btnYolculukEkle.Name = "btnYolculukEkle";
            this.btnYolculukEkle.Size = new System.Drawing.Size(196, 69);
            this.btnYolculukEkle.TabIndex = 1;
            this.btnYolculukEkle.Text = "Yolculuk Ekle";
            this.btnYolculukEkle.UseVisualStyleBackColor = false;
            // 
            // btnYolculukSil
            // 
            this.btnYolculukSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnYolculukSil.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolculukSil.Location = new System.Drawing.Point(196, 0);
            this.btnYolculukSil.Name = "btnYolculukSil";
            this.btnYolculukSil.Size = new System.Drawing.Size(196, 69);
            this.btnYolculukSil.TabIndex = 1;
            this.btnYolculukSil.Text = "Yolculuk Sil";
            this.btnYolculukSil.UseVisualStyleBackColor = false;
            // 
            // labeltxt
            // 
            this.labeltxt.AutoSize = true;
            this.labeltxt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltxt.ForeColor = System.Drawing.Color.White;
            this.labeltxt.Location = new System.Drawing.Point(1168, 20);
            this.labeltxt.Name = "labeltxt";
            this.labeltxt.Size = new System.Drawing.Size(161, 29);
            this.labeltxt.TabIndex = 1;
            this.labeltxt.Text = "Yolculuk Sayısı:";
            // 
            // labelYolculukSayisi
            // 
            this.labelYolculukSayisi.AutoSize = true;
            this.labelYolculukSayisi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYolculukSayisi.ForeColor = System.Drawing.Color.White;
            this.labelYolculukSayisi.Location = new System.Drawing.Point(1326, 20);
            this.labelYolculukSayisi.Name = "labelYolculukSayisi";
            this.labelYolculukSayisi.Size = new System.Drawing.Size(37, 29);
            this.labelYolculukSayisi.TabIndex = 2;
            this.labelYolculukSayisi.Text = "00";
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
            // KC_Yolculuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.upperPanel);
            this.Name = "KC_Yolculuk";
            this.Size = new System.Drawing.Size(1408, 669);
            this.upperPanel.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Button btnYolculukSil;
        private System.Windows.Forms.Button btnYolculukEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltxt;
        private System.Windows.Forms.Label labelYolculukSayisi;
    }
}
