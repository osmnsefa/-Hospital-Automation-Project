using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    internal class Sql_Bağlantısı
    {
        // Sql bağlantısı sağlandı.
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-DA9DR921;Initial Catalog=\"Hastane Proje\";Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
