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
    public partial class Frm_Randevu_Liste : Form
    {
        public Frm_Randevu_Liste()
        {
            InitializeComponent();
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan =new Sql_Bağlantısı();
        private void Frm_Randevu_Liste_Load(object sender, EventArgs e)
        {
            // Randevular veri tabanından Datagridview'e aktarıldı.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevu", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //branşı combo boxa aktarma
            SqlCommand komut2 = new SqlCommand("Select bransad From Tbl_brans", baglan.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0].ToString());
            }
            baglan.baglanti().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // İnsert komutu ile randevu ekleme işlemi gerçekleştirildi
            SqlCommand komut = new SqlCommand("insert into Tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@r1", dateTimePicker_tarih.Text);
            komut.Parameters.AddWithValue("@r2", msk_saat.Text);
            komut.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komut.Parameters.AddWithValue("@r5", msk_tc.Text);
                       
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview üzerinden seçilen randevunun bilgileri gösterildi.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            dateTimePicker_tarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            msk_saat.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmb_doktor.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msk_tc.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            // Update komutu ile güncelleme yapıldı.
            SqlCommand komut = new SqlCommand("Update Tbl_randevu set RandevuTarih=@r1,RandevuSaat=@r2,RandevuBrans=@r3,RandevuDoktor=@r4,HastaTc=@r6 where Randevuid=@r7", baglan.baglanti());
            komut.Parameters.AddWithValue("@r1", dateTimePicker_tarih.Text);
            komut.Parameters.AddWithValue("@r2", msk_saat.Text);
            komut.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komut.Parameters.AddWithValue("@r6",msk_tc.Text);
            komut.Parameters.AddWithValue("@r7", txt_id.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select Doktorad,Doktorsoyad From Tbl_doktor Where Doktorbrans=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            baglan.baglanti().Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // Delete komutu ile silme işlemi gerçekleştirildi.
            SqlCommand komut = new SqlCommand("Delete  From Tbl_randevu Where HastaTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
