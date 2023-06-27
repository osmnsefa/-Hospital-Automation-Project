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
    public partial class Form_hasta_kayıt : Form
    {
        public Form_hasta_kayıt()
        {
            InitializeComponent();
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan = new Sql_Bağlantısı();
        private void button1_Click(object sender, EventArgs e)
        {
            // İnsert komutu ile hasta kayıt işlemi yapıldı.
            SqlCommand komut=new SqlCommand("insert into Tbl_hastalar(Hastaad,Hastasoyad,HastaTc,HastaTelefon,HastaSifre,Hastacinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_hasta_ad.Text);
            komut.Parameters.AddWithValue("@p2",txt_hasta_soyad.Text);
            komut.Parameters.AddWithValue("@p3",msk_hasta_tc.Text);
            komut.Parameters.AddWithValue("@p4",msk_tel.Text);
            komut.Parameters.AddWithValue("@p5", txt_hasta_sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kaydınız Başarı İle Gerçekleştirildi şifreniz: " + txt_hasta_sifre.Text, "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            // Ekranda yer alan bilgiler temizlendi.
            for (int i = 0; i < groupBox_hasta_kayıt.Controls.Count; i++)
            {
                if (groupBox_hasta_kayıt.Controls[i] is TextBox || groupBox_hasta_kayıt.Controls[i] is MaskedTextBox|| groupBox_hasta_kayıt.Controls[i] is ComboBox)
                {
                    groupBox_hasta_kayıt.Controls[i].Text = string.Empty;
                }
            }
        }

        private void Form_hasta_kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
