namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Form_hasta_bilgi
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
            this.groupBox_hasta_bilgi = new System.Windows.Forms.GroupBox();
            this.label_ad_soyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_randevu = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lnk_bilgilerini_düzenle = new System.Windows.Forms.LinkLabel();
            this.btn_randevu_al = new System.Windows.Forms.Button();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.groupBox_hasta_bilgi.SuspendLayout();
            this.groupBox_randevu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_hasta_bilgi
            // 
            this.groupBox_hasta_bilgi.Controls.Add(this.label_ad_soyad);
            this.groupBox_hasta_bilgi.Controls.Add(this.label2);
            this.groupBox_hasta_bilgi.Controls.Add(this.label_tc);
            this.groupBox_hasta_bilgi.Controls.Add(this.label1);
            this.groupBox_hasta_bilgi.Location = new System.Drawing.Point(0, 0);
            this.groupBox_hasta_bilgi.Name = "groupBox_hasta_bilgi";
            this.groupBox_hasta_bilgi.Size = new System.Drawing.Size(393, 195);
            this.groupBox_hasta_bilgi.TabIndex = 0;
            this.groupBox_hasta_bilgi.TabStop = false;
            this.groupBox_hasta_bilgi.Text = "Hasta Bilgi";
            // 
            // label_ad_soyad
            // 
            this.label_ad_soyad.AutoSize = true;
            this.label_ad_soyad.Location = new System.Drawing.Point(169, 104);
            this.label_ad_soyad.Name = "label_ad_soyad";
            this.label_ad_soyad.Size = new System.Drawing.Size(98, 26);
            this.label_ad_soyad.TabIndex = 1;
            this.label_ad_soyad.Text = "Null Null";
            this.label_ad_soyad.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Location = new System.Drawing.Point(186, 52);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(133, 26);
            this.label_tc.TabIndex = 0;
            this.label_tc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox_randevu
            // 
            this.groupBox_randevu.Controls.Add(this.btn_cıkıs);
            this.groupBox_randevu.Controls.Add(this.label3);
            this.groupBox_randevu.Controls.Add(this.txt_ıd);
            this.groupBox_randevu.Controls.Add(this.btn_iptal);
            this.groupBox_randevu.Controls.Add(this.btn_guncelle);
            this.groupBox_randevu.Controls.Add(this.dateTimePicker_tarih);
            this.groupBox_randevu.Controls.Add(this.msk_saat);
            this.groupBox_randevu.Controls.Add(this.lbl_saat);
            this.groupBox_randevu.Controls.Add(this.lbl_tarih);
            this.groupBox_randevu.Controls.Add(this.lnk_bilgilerini_düzenle);
            this.groupBox_randevu.Controls.Add(this.btn_randevu_al);
            this.groupBox_randevu.Controls.Add(this.cmb_doktor);
            this.groupBox_randevu.Controls.Add(this.cmb_brans);
            this.groupBox_randevu.Controls.Add(this.label5);
            this.groupBox_randevu.Controls.Add(this.label4);
            this.groupBox_randevu.Location = new System.Drawing.Point(0, 184);
            this.groupBox_randevu.Name = "groupBox_randevu";
            this.groupBox_randevu.Size = new System.Drawing.Size(393, 445);
            this.groupBox_randevu.TabIndex = 0;
            this.groupBox_randevu.TabStop = false;
            this.groupBox_randevu.Text = "Randevu Detay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID:";
            // 
            // txt_ıd
            // 
            this.txt_ıd.Location = new System.Drawing.Point(163, 33);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(173, 34);
            this.txt_ıd.TabIndex = 13;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(163, 332);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(173, 39);
            this.btn_iptal.TabIndex = 12;
            this.btn_iptal.Text = "İPTAL ET";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(163, 285);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(173, 39);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(163, 154);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(173, 34);
            this.dateTimePicker_tarih.TabIndex = 11;
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(163, 194);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(173, 34);
            this.msk_saat.TabIndex = 10;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(86, 202);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(57, 26);
            this.lbl_saat.TabIndex = 8;
            this.lbl_saat.Text = "Saat:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(77, 160);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(66, 26);
            this.lbl_tarih.TabIndex = 9;
            this.lbl_tarih.Text = "Tarih:";
            // 
            // lnk_bilgilerini_düzenle
            // 
            this.lnk_bilgilerini_düzenle.AutoSize = true;
            this.lnk_bilgilerini_düzenle.Location = new System.Drawing.Point(6, 413);
            this.lnk_bilgilerini_düzenle.Name = "lnk_bilgilerini_düzenle";
            this.lnk_bilgilerini_düzenle.Size = new System.Drawing.Size(184, 26);
            this.lnk_bilgilerini_düzenle.TabIndex = 4;
            this.lnk_bilgilerini_düzenle.TabStop = true;
            this.lnk_bilgilerini_düzenle.Text = "Bilgilerini Düzenle";
            this.lnk_bilgilerini_düzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_bilgilerini_düzenle_LinkClicked);
            // 
            // btn_randevu_al
            // 
            this.btn_randevu_al.Location = new System.Drawing.Point(163, 236);
            this.btn_randevu_al.Name = "btn_randevu_al";
            this.btn_randevu_al.Size = new System.Drawing.Size(173, 41);
            this.btn_randevu_al.TabIndex = 3;
            this.btn_randevu_al.Text = "RANDEVU AL";
            this.btn_randevu_al.UseVisualStyleBackColor = true;
            this.btn_randevu_al.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(163, 113);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(173, 34);
            this.cmb_doktor.TabIndex = 1;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(163, 73);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(173, 34);
            this.cmb_brans.TabIndex = 1;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doktor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Branş:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(399, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 614);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(762, 581);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(163, 377);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(174, 33);
            this.btn_cıkıs.TabIndex = 1;
            this.btn_cıkıs.Text = "ÇIKIŞ YAP";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // Form_hasta_bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1179, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_randevu);
            this.Controls.Add(this.groupBox_hasta_bilgi);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_hasta_bilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_hasta_bilgi";
            this.Load += new System.EventHandler(this.Form_hasta_bilgi_Load);
            this.groupBox_hasta_bilgi.ResumeLayout(false);
            this.groupBox_hasta_bilgi.PerformLayout();
            this.groupBox_randevu.ResumeLayout(false);
            this.groupBox_randevu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_hasta_bilgi;
        private System.Windows.Forms.Label label_ad_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_randevu;
        private System.Windows.Forms.Button btn_randevu_al;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnk_bilgilerini_düzenle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ıd;
        private System.Windows.Forms.Button btn_cıkıs;
    }
}