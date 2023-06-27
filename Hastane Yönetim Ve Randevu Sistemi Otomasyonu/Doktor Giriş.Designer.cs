namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Doktor_Giriş
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.maskedTextBox_doktor_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_doktor_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(64, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "DOKTOR GİRİŞ PANELİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Location = new System.Drawing.Point(226, 258);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(175, 39);
            this.btn_giris_yap.TabIndex = 2;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = true;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // maskedTextBox_doktor_tc
            // 
            this.maskedTextBox_doktor_tc.Location = new System.Drawing.Point(226, 139);
            this.maskedTextBox_doktor_tc.Mask = "00000000000";
            this.maskedTextBox_doktor_tc.Name = "maskedTextBox_doktor_tc";
            this.maskedTextBox_doktor_tc.Size = new System.Drawing.Size(175, 34);
            this.maskedTextBox_doktor_tc.TabIndex = 0;
            this.maskedTextBox_doktor_tc.ValidatingType = typeof(int);
            // 
            // txt_doktor_sifre
            // 
            this.txt_doktor_sifre.Location = new System.Drawing.Point(226, 192);
            this.txt_doktor_sifre.Name = "txt_doktor_sifre";
            this.txt_doktor_sifre.Size = new System.Drawing.Size(175, 34);
            this.txt_doktor_sifre.TabIndex = 1;
            this.txt_doktor_sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Kimlik No:";
            // 
            // Doktor_Giriş
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.maskedTextBox_doktor_tc);
            this.Controls.Add(this.txt_doktor_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Doktor_Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor_Giriş";
            this.Load += new System.EventHandler(this.Doktor_Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_doktor_tc;
        private System.Windows.Forms.TextBox txt_doktor_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}