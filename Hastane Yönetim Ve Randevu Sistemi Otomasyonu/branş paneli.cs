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
    public partial class branş_paneli : Form
    {
        public branş_paneli()
        {
            InitializeComponent();
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void branş_paneli_Load(object sender, EventArgs e)
        {
            // Datagridview'e elimizdeki branşları aktardık.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_brans", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //İnsert komutu ile branş ekleme yaptık.
            SqlCommand komut = new SqlCommand("insert into Tbl_brans (Bransad) values(@b1)", baglan.baglanti());
            komut.Parameters.AddWithValue("@b1", txt_brans_ad.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview üzerinde seçilen branş bilgilerini gösterdik.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_brans_ıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_brans_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // Delete komutu ile branş silme işlemini gerçekleştirdik.
            SqlCommand komut=new SqlCommand("Delete From Tbl_brans where bransid=@b1 ",baglan.baglanti());
            komut.Parameters.AddWithValue("@b1", txt_brans_ıd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            // Update komutu ile branş güncelleme işlemini gerçekleştirdik.
            SqlCommand komut = new SqlCommand("Update Tbl_brans set bransad=@b1 where bransid=@b2", baglan.baglanti());
            komut.Parameters.AddWithValue("@b1", txt_brans_ad.Text);
            komut.Parameters.AddWithValue("@b2", txt_brans_ıd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
