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
    public partial class Doktor_Duyurular : Form
    {
        public Doktor_Duyurular()
        {
            InitializeComponent();
        }
        // baglan adında bir nesne oluşturup sql server'a bağlandık.
        Sql_Bağlantısı baglan =new Sql_Bağlantısı();
        private void Doktor_Duyurular_Load(object sender, EventArgs e)
        {
            // Oluşturulan duyurular veri tabanından Datagridview'e aktarıldı.
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_duyuru",baglan.baglanti());
            da.Fill(dt);
            dataGrid_duyurular.DataSource = dt;
        }
    }
}
