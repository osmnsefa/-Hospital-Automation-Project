namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Doktor_Detay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label_ad_soyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rich_txt_randevu_detay = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cıkış_yap = new System.Windows.Forms.Button();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_bilgi_düzenle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGrid_randevu_listesi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_randevu_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label_ad_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOKTOR BİLGİ";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(209, 44);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(133, 26);
            this.lbl_tc.TabIndex = 6;
            this.lbl_tc.Text = "00000000000";
            // 
            // label_ad_soyad
            // 
            this.label_ad_soyad.AutoSize = true;
            this.label_ad_soyad.Location = new System.Drawing.Point(209, 96);
            this.label_ad_soyad.Name = "label_ad_soyad";
            this.label_ad_soyad.Size = new System.Drawing.Size(98, 26);
            this.label_ad_soyad.TabIndex = 4;
            this.label_ad_soyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rich_txt_randevu_detay);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 258);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU DETAY";
            // 
            // rich_txt_randevu_detay
            // 
            this.rich_txt_randevu_detay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_txt_randevu_detay.Location = new System.Drawing.Point(3, 30);
            this.rich_txt_randevu_detay.Name = "rich_txt_randevu_detay";
            this.rich_txt_randevu_detay.Size = new System.Drawing.Size(389, 225);
            this.rich_txt_randevu_detay.TabIndex = 0;
            this.rich_txt_randevu_detay.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cıkış_yap);
            this.groupBox3.Controls.Add(this.btn_duyurular);
            this.groupBox3.Controls.Add(this.btn_bilgi_düzenle);
            this.groupBox3.Location = new System.Drawing.Point(12, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 154);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HIZLI ERİŞİM";
            // 
            // btn_cıkış_yap
            // 
            this.btn_cıkış_yap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkış_yap.Location = new System.Drawing.Point(20, 98);
            this.btn_cıkış_yap.Name = "btn_cıkış_yap";
            this.btn_cıkış_yap.Size = new System.Drawing.Size(348, 41);
            this.btn_cıkış_yap.TabIndex = 0;
            this.btn_cıkış_yap.Text = "Çıkış Yap";
            this.btn_cıkış_yap.UseVisualStyleBackColor = true;
            this.btn_cıkış_yap.Click += new System.EventHandler(this.btn_cıkış_yap_Click);
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duyurular.Location = new System.Drawing.Point(205, 33);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(163, 41);
            this.btn_duyurular.TabIndex = 0;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_bilgi_düzenle
            // 
            this.btn_bilgi_düzenle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgi_düzenle.Location = new System.Drawing.Point(20, 36);
            this.btn_bilgi_düzenle.Name = "btn_bilgi_düzenle";
            this.btn_bilgi_düzenle.Size = new System.Drawing.Size(163, 41);
            this.btn_bilgi_düzenle.TabIndex = 0;
            this.btn_bilgi_düzenle.Text = "Bilgileri Düzenle ";
            this.btn_bilgi_düzenle.UseVisualStyleBackColor = true;
            this.btn_bilgi_düzenle.Click += new System.EventHandler(this.btn_bilgi_düzenle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGrid_randevu_listesi);
            this.groupBox4.Location = new System.Drawing.Point(427, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 591);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RANDEVU LİSTESİ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGrid_randevu_listesi
            // 
            this.dataGrid_randevu_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_randevu_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_randevu_listesi.Location = new System.Drawing.Point(3, 30);
            this.dataGrid_randevu_listesi.Name = "dataGrid_randevu_listesi";
            this.dataGrid_randevu_listesi.RowHeadersWidth = 51;
            this.dataGrid_randevu_listesi.RowTemplate.Height = 24;
            this.dataGrid_randevu_listesi.Size = new System.Drawing.Size(693, 558);
            this.dataGrid_randevu_listesi.TabIndex = 1;
            // 
            // Doktor_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1138, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Doktor_Detay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor_Detay";
            this.Load += new System.EventHandler(this.Doktor_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_randevu_listesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_ad_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rich_txt_randevu_detay;
        private System.Windows.Forms.Button btn_cıkış_yap;
        private System.Windows.Forms.Button btn_duyurular;
        private System.Windows.Forms.Button btn_bilgi_düzenle;
        private System.Windows.Forms.DataGridView dataGrid_randevu_listesi;
        private System.Windows.Forms.Label lbl_tc;
    }
}