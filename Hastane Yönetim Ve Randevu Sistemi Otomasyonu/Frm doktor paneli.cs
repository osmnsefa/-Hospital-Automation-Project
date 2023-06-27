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
    public partial class Frm_doktor_paneli : Form
    {
        public Frm_doktor_paneli()
        {
            InitializeComponent();
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void Frm_doktor_paneli_Load(object sender, EventArgs e)
        {
            // Doktor bilgilerini veri tabanından Datagridview'e ekledik.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_doktor ", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.baglanti().Close();
            // Branşları combo boxa aktarma
            SqlCommand komut2 = new SqlCommand("Select bransad From Tbl_brans", baglan.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0].ToString());
            }
            baglan.baglanti().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            // İnsert komutu ile doktor ekleme yapıldı.
            SqlCommand komut = new SqlCommand("insert into Tbl_doktor(Doktorad,Doktorsoyad,DoktorTc,Doktorbrans,Doktorsifre)values(@d1,@d2,@d3,@d4,@d5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", msk_tc.Text);
            komut.Parameters.AddWithValue("@d4", cmb_brans.Text);
            komut.Parameters.AddWithValue("@d5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview üzerinden seçilen doktor bilgileri gösterildi.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // Delete komutu ile silme işlemi yapıldı.
            SqlCommand komut = new SqlCommand("Delete  From Tbl_doktor Where DoktorTc=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            // Update komutu ile doktor bilgileri güncelleme işlemi yapıldı.
            SqlCommand komut = new SqlCommand("update Tbl_doktor set Doktorad=@d1,Doktorsoyad=@d2,Doktorbrans=@d4,Doktorsifre=@d5 Where DoktorTc=@d3", baglan.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", msk_tc.Text);
            komut.Parameters.AddWithValue("@d4", cmb_brans.Text);
            komut.Parameters.AddWithValue("@d5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
