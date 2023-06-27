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
    public partial class Doktor_Detay : Form
    {
        public Doktor_Detay()
        {
            InitializeComponent();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            // Duyurular sayfasına geçiş yaptık.
            Doktor_Duyurular duyuru = new Doktor_Duyurular();
            duyuru.Show();
            
        }

        private void btn_cıkış_yap_Click(object sender, EventArgs e)
        {   
            // Çıkış yap butonu oluşturuldu.
            DialogResult sonuc = MessageBox.Show("ÇIKIŞ YAPILSIN MI?", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == sonuc)
            {
                MessageBox.Show("ÇIKIŞ YAPILDI ,İYİ GÜNLER...");
                Girişler giris = new Girişler();
                giris.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ÇIKIŞ YAPILMADI");
            }
        }

        private void btn_bilgi_düzenle_Click(object sender, EventArgs e)
        {
            // Doktor için bilgi düzenleme sayfasına geçiş yapıldı.
            Doktor_Bilgileri_Düzenle blg=new Doktor_Bilgileri_Düzenle();
            blg.Tcno = lbl_tc.Text;
            blg.Show();
            
        }
        public string tc;
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void Doktor_Detay_Load(object sender, EventArgs e)
        {

            lbl_tc.Text = tc;
            // ad soyad çekme
            SqlCommand komut = new SqlCommand("Select Doktorad,Doktorsoyad From tbl_doktor Where DoktorTc=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_ad_soyad.Text = dr[0] + " " + dr[1];
            }
            baglan.baglanti().Close();
            // Doktora ait randevular veri tabanından Datagridview'e aktarıldı.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_randevu Where RandevuDoktor='" + label_ad_soyad.Text + "'", baglan.baglanti());
            da.Fill(dt);
            dataGrid_randevu_listesi.DataSource = dt;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
