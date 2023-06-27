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
    public partial class Doktor_Bilgileri_Düzenle : Form
    {
        public Doktor_Bilgileri_Düzenle()
        {
            InitializeComponent();
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string Tcno;
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void Doktor_Bilgileri_Düzenle_Load(object sender, EventArgs e)
        {
            // Doktor bilgilerini veri tabanından çektik.
            msk_tc.Text = Tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_doktor Where DoktorTc=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                cmb_brans.Text = dr[3].ToString();
                txt_sifre.Text = dr[5].ToString();
                
            }
            // Branşları combobox'a aktardık.
            SqlCommand komut2 = new SqlCommand("Select bransad From Tbl_brans", baglan.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0].ToString());
            }
            baglan.baglanti().Close();
        }

        private void btn_doktor_güncelle_Click(object sender, EventArgs e)
        {
            // Update komutu ile bilgileri güncelledik.
            SqlCommand komut = new SqlCommand("Update Tbl_doktor set Doktorad=@p1,Doktorsoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 Where DoktorTc=@p5", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p5", msk_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
