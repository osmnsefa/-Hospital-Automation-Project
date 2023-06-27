using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    public partial class Doktor_Giriş : Form
    {
        public Doktor_Giriş()
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
            // Giriş yap butonu oluşturuldu.
            SqlCommand komut = new SqlCommand("Select * From Tbl_doktor Where DoktorTc=@p1 and DoktorSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox_doktor_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_doktor_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            // TC ve şifre kontrolü yapıldı.
            if (dr.Read())
            {
                Doktor_Detay detay = new Doktor_Detay();
                detay.tc = maskedTextBox_doktor_tc.Text;
                detay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ve Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglan.baglanti().Close();
        }

        private void Doktor_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
