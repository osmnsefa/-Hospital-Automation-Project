namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Girişler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girişler));
            this.button_doktor = new System.Windows.Forms.Button();
            this.button_hasta = new System.Windows.Forms.Button();
            this.button_sekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_doktor
            // 
            this.button_doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_doktor.BackgroundImage")));
            this.button_doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_doktor.Location = new System.Drawing.Point(67, 182);
            this.button_doktor.Name = "button_doktor";
            this.button_doktor.Size = new System.Drawing.Size(172, 134);
            this.button_doktor.TabIndex = 0;
            this.button_doktor.UseVisualStyleBackColor = true;
            this.button_doktor.Click += new System.EventHandler(this.button_doktor_Click);
            // 
            // button_hasta
            // 
            this.button_hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hasta.BackgroundImage")));
            this.button_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hasta.Location = new System.Drawing.Point(289, 182);
            this.button_hasta.Name = "button_hasta";
            this.button_hasta.Size = new System.Drawing.Size(172, 134);
            this.button_hasta.TabIndex = 1;
            this.button_hasta.UseVisualStyleBackColor = true;
            this.button_hasta.Click += new System.EventHandler(this.button_hasta_Click);
            // 
            // button_sekreter
            // 
            this.button_sekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sekreter.BackgroundImage")));
            this.button_sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sekreter.Location = new System.Drawing.Point(498, 182);
            this.button_sekreter.Name = "button_sekreter";
            this.button_sekreter.Size = new System.Drawing.Size(172, 134);
            this.button_sekreter.TabIndex = 2;
            this.button_sekreter.UseVisualStyleBackColor = true;
            this.button_sekreter.Click += new System.EventHandler(this.button_sekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOKTOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(336, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTA";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(526, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "SEKRETER";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(73, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "COŞAR HOSPITAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Girişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(730, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sekreter);
            this.Controls.Add(this.button_hasta);
            this.Controls.Add(this.button_doktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Girişler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coşar Hospital Giriş Ekranı";
            this.Load += new System.EventHandler(this.Girişler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_doktor;
        private System.Windows.Forms.Button button_hasta;
        private System.Windows.Forms.Button button_sekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

