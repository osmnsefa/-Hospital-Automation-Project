namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Form_Bilgileri_Düzenle
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
            this.btn_güncelle_hasta = new System.Windows.Forms.Button();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.msk_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_hasta_ad = new System.Windows.Forms.TextBox();
            this.txt_hasta_soyad = new System.Windows.Forms.TextBox();
            this.txt_hasta_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_güncelle_hasta
            // 
            this.btn_güncelle_hasta.Location = new System.Drawing.Point(197, 318);
            this.btn_güncelle_hasta.Name = "btn_güncelle_hasta";
            this.btn_güncelle_hasta.Size = new System.Drawing.Size(175, 43);
            this.btn_güncelle_hasta.TabIndex = 6;
            this.btn_güncelle_hasta.Text = "Güncelle";
            this.btn_güncelle_hasta.UseVisualStyleBackColor = true;
            this.btn_güncelle_hasta.Click += new System.EventHandler(this.btn_güncelle_hasta_Click);
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Location = new System.Drawing.Point(197, 271);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(175, 34);
            this.cmb_cinsiyet.TabIndex = 5;
            // 
            // msk_tel
            // 
            this.msk_tel.Location = new System.Drawing.Point(197, 182);
            this.msk_tel.Mask = "00000000000";
            this.msk_tel.Name = "msk_tel";
            this.msk_tel.Size = new System.Drawing.Size(175, 34);
            this.msk_tel.TabIndex = 3;
            this.msk_tel.ValidatingType = typeof(int);
            // 
            // msk_hasta_tc
            // 
            this.msk_hasta_tc.Location = new System.Drawing.Point(197, 140);
            this.msk_hasta_tc.Mask = "00000000000";
            this.msk_hasta_tc.Name = "msk_hasta_tc";
            this.msk_hasta_tc.Size = new System.Drawing.Size(175, 34);
            this.msk_hasta_tc.TabIndex = 2;
            this.msk_hasta_tc.ValidatingType = typeof(int);
            // 
            // txt_hasta_ad
            // 
            this.txt_hasta_ad.Location = new System.Drawing.Point(197, 52);
            this.txt_hasta_ad.Name = "txt_hasta_ad";
            this.txt_hasta_ad.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_ad.TabIndex = 0;
            // 
            // txt_hasta_soyad
            // 
            this.txt_hasta_soyad.Location = new System.Drawing.Point(197, 97);
            this.txt_hasta_soyad.Name = "txt_hasta_soyad";
            this.txt_hasta_soyad.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_soyad.TabIndex = 1;
            // 
            // txt_hasta_sifre
            // 
            this.txt_hasta_sifre.Location = new System.Drawing.Point(197, 228);
            this.txt_hasta_sifre.Name = "txt_hasta_sifre";
            this.txt_hasta_sifre.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_sifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Telefon:";
            // 
            // Form_Bilgileri_Düzenle
            // 
            this.AcceptButton = this.btn_güncelle_hasta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(490, 418);
            this.Controls.Add(this.btn_güncelle_hasta);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.msk_tel);
            this.Controls.Add(this.msk_hasta_tc);
            this.Controls.Add(this.txt_hasta_ad);
            this.Controls.Add(this.txt_hasta_soyad);
            this.Controls.Add(this.txt_hasta_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Bilgileri_Düzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Bilgileri_Düzenle";
            this.Load += new System.EventHandler(this.Form_Bilgileri_Düzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_güncelle_hasta;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.MaskedTextBox msk_tel;
        private System.Windows.Forms.MaskedTextBox msk_hasta_tc;
        private System.Windows.Forms.TextBox txt_hasta_ad;
        private System.Windows.Forms.TextBox txt_hasta_soyad;
        private System.Windows.Forms.TextBox txt_hasta_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}