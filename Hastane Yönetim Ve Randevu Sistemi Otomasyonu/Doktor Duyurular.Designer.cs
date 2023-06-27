namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    partial class Doktor_Duyurular
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
            this.dataGrid_duyurular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_duyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_duyurular
            // 
            this.dataGrid_duyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_duyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_duyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_duyurular.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_duyurular.Name = "dataGrid_duyurular";
            this.dataGrid_duyurular.RowHeadersWidth = 51;
            this.dataGrid_duyurular.RowTemplate.Height = 24;
            this.dataGrid_duyurular.Size = new System.Drawing.Size(800, 450);
            this.dataGrid_duyurular.TabIndex = 0;
            // 
            // Doktor_Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_duyurular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Doktor_Duyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor_Duyurular";
            this.Load += new System.EventHandler(this.Doktor_Duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_duyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_duyurular;
    }
}