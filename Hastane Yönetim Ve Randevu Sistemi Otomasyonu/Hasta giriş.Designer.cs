namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Hasta_giriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_üye_ol = new System.Windows.Forms.LinkLabel();
            this.txt_hasta_sifre = new System.Windows.Forms.TextBox();
            this.maskedTextBox_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // linkLabel_üye_ol
            // 
            this.linkLabel_üye_ol.AutoSize = true;
            this.linkLabel_üye_ol.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.linkLabel_üye_ol.Location = new System.Drawing.Point(407, 189);
            this.linkLabel_üye_ol.Name = "linkLabel_üye_ol";
            this.linkLabel_üye_ol.Size = new System.Drawing.Size(77, 21);
            this.linkLabel_üye_ol.TabIndex = 3;
            this.linkLabel_üye_ol.TabStop = true;
            this.linkLabel_üye_ol.Text = "ÜYE OL";
            this.linkLabel_üye_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_üye_ol_LinkClicked);
            // 
            // txt_hasta_sifre
            // 
            this.txt_hasta_sifre.Location = new System.Drawing.Point(212, 176);
            this.txt_hasta_sifre.Name = "txt_hasta_sifre";
            this.txt_hasta_sifre.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_sifre.TabIndex = 1;
            this.txt_hasta_sifre.UseSystemPasswordChar = true;
            this.txt_hasta_sifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox_hasta_tc
            // 
            this.maskedTextBox_hasta_tc.Location = new System.Drawing.Point(212, 123);
            this.maskedTextBox_hasta_tc.Mask = "00000000000";
            this.maskedTextBox_hasta_tc.Name = "maskedTextBox_hasta_tc";
            this.maskedTextBox_hasta_tc.Size = new System.Drawing.Size(175, 34);
            this.maskedTextBox_hasta_tc.TabIndex = 0;
            this.maskedTextBox_hasta_tc.ValidatingType = typeof(int);
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Location = new System.Drawing.Point(212, 242);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(175, 39);
            this.btn_giris_yap.TabIndex = 2;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = true;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(81, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            // 
            // Hasta_giriş
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.maskedTextBox_hasta_tc);
            this.Controls.Add(this.txt_hasta_sifre);
            this.Controls.Add(this.linkLabel_üye_ol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Hasta_giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta_giriş";
            this.Load += new System.EventHandler(this.Hasta_giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_üye_ol;
        private System.Windows.Forms.TextBox txt_hasta_sifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_hasta_tc;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.Label label3;
    }
}