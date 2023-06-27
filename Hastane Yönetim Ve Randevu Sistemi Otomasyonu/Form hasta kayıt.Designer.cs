namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Form_hasta_kayıt
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
            this.msk_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_hasta_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hasta_ad = new System.Windows.Forms.TextBox();
            this.txt_hasta_soyad = new System.Windows.Forms.TextBox();
            this.msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox_hasta_kayıt = new System.Windows.Forms.GroupBox();
            this.groupBox_hasta_kayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // msk_hasta_tc
            // 
            this.msk_hasta_tc.Location = new System.Drawing.Point(183, 133);
            this.msk_hasta_tc.Mask = "00000000000";
            this.msk_hasta_tc.Name = "msk_hasta_tc";
            this.msk_hasta_tc.Size = new System.Drawing.Size(175, 34);
            this.msk_hasta_tc.TabIndex = 2;
            this.msk_hasta_tc.ValidatingType = typeof(int);
            // 
            // txt_hasta_sifre
            // 
            this.txt_hasta_sifre.Location = new System.Drawing.Point(183, 221);
            this.txt_hasta_sifre.Name = "txt_hasta_sifre";
            this.txt_hasta_sifre.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_sifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            // 
            // txt_hasta_ad
            // 
            this.txt_hasta_ad.Location = new System.Drawing.Point(183, 45);
            this.txt_hasta_ad.Name = "txt_hasta_ad";
            this.txt_hasta_ad.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_ad.TabIndex = 0;
            // 
            // txt_hasta_soyad
            // 
            this.txt_hasta_soyad.Location = new System.Drawing.Point(183, 90);
            this.txt_hasta_soyad.Name = "txt_hasta_soyad";
            this.txt_hasta_soyad.Size = new System.Drawing.Size(175, 34);
            this.txt_hasta_soyad.TabIndex = 1;
            // 
            // msk_tel
            // 
            this.msk_tel.Location = new System.Drawing.Point(183, 175);
            this.msk_tel.Mask = "00000000000";
            this.msk_tel.Name = "msk_tel";
            this.msk_tel.Size = new System.Drawing.Size(175, 34);
            this.msk_tel.TabIndex = 3;
            this.msk_tel.ValidatingType = typeof(int);
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(183, 264);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(175, 34);
            this.cmb_cinsiyet.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(183, 360);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(175, 39);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // groupBox_hasta_kayıt
            // 
            this.groupBox_hasta_kayıt.Controls.Add(this.txt_hasta_ad);
            this.groupBox_hasta_kayıt.Controls.Add(this.btn_temizle);
            this.groupBox_hasta_kayıt.Controls.Add(this.label1);
            this.groupBox_hasta_kayıt.Controls.Add(this.button1);
            this.groupBox_hasta_kayıt.Controls.Add(this.label6);
            this.groupBox_hasta_kayıt.Controls.Add(this.cmb_cinsiyet);
            this.groupBox_hasta_kayıt.Controls.Add(this.label3);
            this.groupBox_hasta_kayıt.Controls.Add(this.msk_tel);
            this.groupBox_hasta_kayıt.Controls.Add(this.label4);
            this.groupBox_hasta_kayıt.Controls.Add(this.msk_hasta_tc);
            this.groupBox_hasta_kayıt.Controls.Add(this.label5);
            this.groupBox_hasta_kayıt.Controls.Add(this.label2);
            this.groupBox_hasta_kayıt.Controls.Add(this.txt_hasta_soyad);
            this.groupBox_hasta_kayıt.Controls.Add(this.txt_hasta_sifre);
            this.groupBox_hasta_kayıt.Location = new System.Drawing.Point(29, 12);
            this.groupBox_hasta_kayıt.Name = "groupBox_hasta_kayıt";
            this.groupBox_hasta_kayıt.Size = new System.Drawing.Size(422, 443);
            this.groupBox_hasta_kayıt.TabIndex = 8;
            this.groupBox_hasta_kayıt.TabStop = false;
            this.groupBox_hasta_kayıt.Text = "HASTA KAYIT";
            // 
            // Form_hasta_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(506, 481);
            this.Controls.Add(this.groupBox_hasta_kayıt);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_hasta_kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_hasta_kayıt";
            this.Load += new System.EventHandler(this.Form_hasta_kayıt_Load);
            this.groupBox_hasta_kayıt.ResumeLayout(false);
            this.groupBox_hasta_kayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_hasta_tc;
        private System.Windows.Forms.TextBox txt_hasta_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hasta_ad;
        private System.Windows.Forms.TextBox txt_hasta_soyad;
        private System.Windows.Forms.MaskedTextBox msk_tel;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.GroupBox groupBox_hasta_kayıt;
    }
}