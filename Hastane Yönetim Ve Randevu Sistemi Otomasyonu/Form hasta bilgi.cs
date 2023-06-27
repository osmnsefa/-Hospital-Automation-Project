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
    public partial class Form_hasta_bilgi : Form
    {
        public Form_hasta_bilgi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İnsert komutu ile randevu oluşturma işlemi yapıldı.
            SqlCommand komut = new SqlCommand("insert into Tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@r1", dateTimePicker_tarih.Text);
            komut.Parameters.AddWithValue("@r2", msk_saat.Text);
            komut.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komut.Parameters.AddWithValue("@r5", label_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        public string tc;
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void Form_hasta_bilgi_Load(object sender, EventArgs e)
        {
            label_tc.Text = tc;
            // ad soyad çekme
            SqlCommand komut = new SqlCommand("Select Hastaad,Hastasoyad From tbl_hastalar Where HastaTc=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_ad_soyad.Text = dr[0] + " " + dr[1];
            }
            baglan.baglanti().Close();
            // randevu çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_randevu Where HastaTc=" + tc, baglan.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            // branşları çekme
            SqlCommand komut2 = new SqlCommand("Select bransad From Tbl_brans ", baglan.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            baglan.baglanti().Close();
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen branşa göre doktor listeleme yapıldı.
            cmb_doktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select Doktorad,Doktorsoyad From Tbl_doktor Where Doktorbrans=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_doktor.Items.Add(dr[0]+" " + dr[1]);
            }
            baglan.baglanti().Close();
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hastanın kendisine ait randevular veri tabanından Datagridview'e aktarıldı.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_randevu Where HastaTc='" + label_tc.Text + "'", baglan.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnk_bilgilerini_düzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hasta için bilgi düzenleme sayfasına geçiş yapıldı.
            Form_Bilgileri_Düzenle fr = new Form_Bilgileri_Düzenle();
            fr.Tcno = label_tc.Text;
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview üzerinden seçilen randevu bilgileri gösterildi.
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_ıd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            dateTimePicker_tarih.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            msk_saat.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            cmb_doktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // Update komutu ile randevu güncelleme yapıldı.
            SqlCommand komut = new SqlCommand("Update Tbl_randevu set RandevuTarih=@r1,RandevuSaat=@r2,RandevuBrans=@r3,RandevuDoktor=@r4 where Randevuid=@r5 and HastaTC=@r6", baglan.baglanti());
            komut.Parameters.AddWithValue("@r1", dateTimePicker_tarih.Text);
            komut.Parameters.AddWithValue("@r2", msk_saat.Text);
            komut.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komut.Parameters.AddWithValue("@r5", txt_ıd.Text);
            komut.Parameters.AddWithValue("@r6", label_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            // Delete komutu ile randevu iptali yapıldı.
            SqlCommand komut = new SqlCommand("Delete  From Tbl_randevu Where Randevuid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ıd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
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
    }
}
