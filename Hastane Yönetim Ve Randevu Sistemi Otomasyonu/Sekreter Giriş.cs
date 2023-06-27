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
    public partial class Sekreter_Giriş : Form
    {
        public Sekreter_Giriş()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            // Giriş yap butonu eklendi.
            SqlCommand komut = new SqlCommand("Select * From Tbl_sekreter Where SekreterTc=@p1 and Sekretersifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox_sekreter_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sekreter_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            // TC ve şifre kontrolü yapıldı.
            if (dr.Read())
            {
                Sekreter_Detay detay = new Sekreter_Detay();
                detay.tcnumara = maskedTextBox_sekreter_tc.Text;
                detay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc ve Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglan.baglanti().Close();
        }

        private void Sekreter_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
