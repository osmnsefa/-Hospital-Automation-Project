using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yönetim_Ve_Randevu_Sistemi_Otomasyonu
{
    public partial class Girişler : Form
    {
        public Girişler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Girişler_Load(object sender, EventArgs e)
        {

        }

        private void button_doktor_Click(object sender, EventArgs e)
        {
            // Doktor giriş sayfasına geçiş
            Doktor_Giriş dr = new Doktor_Giriş();
            dr.Show();
            this.Hide();
        }

        private void button_hasta_Click(object sender, EventArgs e)
        {
            // Hasta giriş sayfasına geçiş
            Hasta_giriş hst = new Hasta_giriş();
            hst.Show();
            this.Hide();
        }

        private void button_sekreter_Click(object sender, EventArgs e)
        {
            // Sekreter giriş sayfasına geçiş
            Sekreter_Giriş skr = new Sekreter_Giriş();
            skr.Show();
            this.Hide();
        }
    }
}
