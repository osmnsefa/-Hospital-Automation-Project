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
    public partial class Form_Bilgileri_Düzenle : Form
    {
        public Form_Bilgileri_Düzenle()
        {
            InitializeComponent();
        }
        public string Tcno ;
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan =new Sql_Bağlantısı();
        private void Form_Bilgileri_Düzenle_Load(object sender, EventArgs e)
        {
            // Hastaya ait bilgileri veri tabanından aldık.
            msk_hasta_tc.Text = Tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_hastalar Where HastaTc=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_hasta_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_hasta_ad.Text = dr[1].ToString();
                txt_hasta_soyad.Text = dr[2].ToString();
                msk_tel.Text = dr[4].ToString();
                txt_hasta_sifre.Text = dr[5].ToString();
                cmb_cinsiyet.Text=dr[6].ToString();
            }
        }

        private void btn_güncelle_hasta_Click(object sender, EventArgs e)
        {
            // Update komutu ile hasta bilgilerini güncelledik.
            SqlCommand komut = new SqlCommand("Update Tbl_hastalar set Hastaad=@p1,Hastasoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,Hastacinsiyet=@p5 Where HastaTc=@p6",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_hasta_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_hasta_soyad.Text);
            komut.Parameters.AddWithValue("@p3", msk_tel.Text);
            komut.Parameters.AddWithValue("@p4", txt_hasta_sifre.Text);
            komut.Parameters.AddWithValue("@p5", cmb_cinsiyet.Text);
            komut.Parameters.AddWithValue("@p6",msk_hasta_tc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
