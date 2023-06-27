using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    public partial class Hasta_giriş : Form
    {
        public Hasta_giriş()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_üye_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayıt sayfasına geçiş yapıldı.
            Form_hasta_kayıt kayıt = new Form_hasta_kayıt();
            kayıt.Show();
            
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            // Hasta için giriş butonu eklendi.
            SqlCommand komut = new SqlCommand("Select * From Tbl_hastalar Where HastaTc=@p1 and HastaSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox_hasta_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_hasta_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            // TC ve şifre kontrolü yapıldı.
            if (dr.Read())
            {
                Form_hasta_bilgi blg = new Form_hasta_bilgi();
                blg.tc = maskedTextBox_hasta_tc.Text;
                blg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ve Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglan.baglanti().Close();
        }

        private void Hasta_giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
