namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Sekreter_Giriş
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
            this.maskedTextBox_sekreter_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_sekreter_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 60);
            this.label3.TabIndex = 19;
            this.label3.Text = "SEKRETER GİRİŞ PANELİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Location = new System.Drawing.Point(232, 264);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(175, 39);
            this.btn_giris_yap.TabIndex = 2;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = true;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // maskedTextBox_sekreter_tc
            // 
            this.maskedTextBox_sekreter_tc.Location = new System.Drawing.Point(232, 145);
            this.maskedTextBox_sekreter_tc.Mask = "00000000000";
            this.maskedTextBox_sekreter_tc.Name = "maskedTextBox_sekreter_tc";
            this.maskedTextBox_sekreter_tc.Size = new System.Drawing.Size(175, 34);
            this.maskedTextBox_sekreter_tc.TabIndex = 0;
            this.maskedTextBox_sekreter_tc.ValidatingType = typeof(int);
            // 
            // txt_sekreter_sifre
            // 
            this.txt_sekreter_sifre.Location = new System.Drawing.Point(232, 198);
            this.txt_sekreter_sifre.Name = "txt_sekreter_sifre";
            this.txt_sekreter_sifre.Size = new System.Drawing.Size(175, 34);
            this.txt_sekreter_sifre.TabIndex = 1;
            this.txt_sekreter_sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC Kimlik No:";
            // 
            // Sekreter_Giriş
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(533, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.maskedTextBox_sekreter_tc);
            this.Controls.Add(this.txt_sekreter_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sekreter_Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter_Giriş";
            this.Load += new System.EventHandler(this.Sekreter_Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_sekreter_tc;
        private System.Windows.Forms.TextBox txt_sekreter_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}