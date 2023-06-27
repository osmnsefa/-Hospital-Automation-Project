namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Frm_Randevu_Liste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_doktor = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(363, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 546);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sil);
            this.groupBox3.Controls.Add(this.dateTimePicker_tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.btn_güncelle);
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.msk_tc);
            this.groupBox3.Controls.Add(this.msk_saat);
            this.groupBox3.Controls.Add(this.cmb_doktor);
            this.groupBox3.Controls.Add(this.cmb_brans);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_doktor);
            this.groupBox3.Controls.Add(this.lbl_brans);
            this.groupBox3.Controls.Add(this.lbl_saat);
            this.groupBox3.Controls.Add(this.lbl_tarih);
            this.groupBox3.Controls.Add(this.lbl_id);
            this.groupBox3.Location = new System.Drawing.Point(2, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 543);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU PANELİ";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(124, 93);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(141, 34);
            this.dateTimePicker_tarih.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(124, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(141, 34);
            this.txt_id.TabIndex = 0;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(124, 396);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(141, 37);
            this.btn_güncelle.TabIndex = 7;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(124, 353);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(141, 37);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(124, 247);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(141, 34);
            this.msk_tc.TabIndex = 5;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(124, 128);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(141, 34);
            this.msk_saat.TabIndex = 2;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(124, 209);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(141, 34);
            this.cmb_doktor.TabIndex = 4;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(124, 170);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(141, 34);
            this.cmb_brans.TabIndex = 3;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "TC:";
            // 
            // lbl_doktor
            // 
            this.lbl_doktor.AutoSize = true;
            this.lbl_doktor.Location = new System.Drawing.Point(34, 212);
            this.lbl_doktor.Name = "lbl_doktor";
            this.lbl_doktor.Size = new System.Drawing.Size(84, 26);
            this.lbl_doktor.TabIndex = 1;
            this.lbl_doktor.Text = "Doktor:";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Location = new System.Drawing.Point(47, 173);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(71, 26);
            this.lbl_brans.TabIndex = 1;
            this.lbl_brans.Text = "Branş:";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(61, 136);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(57, 26);
            this.lbl_saat.TabIndex = 1;
            this.lbl_saat.Text = "Saat:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(52, 101);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(66, 26);
            this.lbl_tarih.TabIndex = 1;
            this.lbl_tarih.Text = "Tarih:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(71, 64);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(42, 26);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(124, 439);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(141, 36);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Frm_Randevu_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Randevu_Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Randevu_Liste";
            this.Load += new System.EventHandler(this.Frm_Randevu_Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_doktor;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_sil;
    }
}