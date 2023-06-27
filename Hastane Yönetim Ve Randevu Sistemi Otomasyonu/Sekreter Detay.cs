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
    public partial class Sekreter_Detay : Form
    {
        public Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void Sekreter_Detay_Load(object sender, EventArgs e)
        {
            // ad soyad çekme
            lbl_tc.Text=tcnumara;
            SqlCommand komut=new SqlCommand("Select Sekreteradsoyad From Tbl_sekreter Where SekreterTc="+tcnumara,baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad_soyad.Text = dr[0].ToString();
            }
            baglan.baglanti().Close();
            // branşları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_brans", baglan.baglanti());
            da.Fill(dt);
            dataGrid_branslar.DataSource = dt;
            // doktorları datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Doktorad + ' ' + Doktorsoyad) as ' Doktorlar',Doktorbrans From Tbl_doktor", baglan.baglanti());
            da2.Fill(dt2);
            dataGrid_doktorlar.DataSource = dt2;
           
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            // İnsert komutu ile duyuru oluşturuldu.
            SqlCommand komut =new SqlCommand("insert into Tbl_duyuru (Duyuru) values (@d1)",baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", richtxt_duyuru.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Duyur Oluşturuldu","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_doktor_panel_Click(object sender, EventArgs e)
        {
            // Doktor paneline geçiş yapıldı.
            Frm_doktor_paneli dr = new Frm_doktor_paneli();
            dr.Show();
            
        }

        private void btn_brans_panel_Click(object sender, EventArgs e)
        {
            // Branş paneline geçiş yapıldı.
            branş_paneli brn = new branş_paneli();
            brn.Show();

        }

        private void btn_randevu_liste_Click(object sender, EventArgs e)
        {
            // Randevu listesi sayfasına geçiş yapıldı.
            Frm_Randevu_Liste rnd = new Frm_Randevu_Liste();
            rnd.Show();
        }

        private void button_duyuru_Click(object sender, EventArgs e)
        {
            // Duyurular sayfasına geçiş yapıldı.
            Doktor_Duyurular duyuru=new Doktor_Duyurular();
            duyuru.Show();
        }

        private void button_cıkıs_Click(object sender, EventArgs e)
        {
            // Çıkış butonu oluşturuldu.
            
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

        private void btn_giris_Click(object sender, EventArgs e)
        {

        }
    }
}
