using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapokumaplatformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text.Trim();
            string telefon = textBox2.Text.Trim();

            // Ad Soyad ve Telefon Kontrolü
            if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefon.Length != 10 || !long.TryParse(telefon, out _))
            {
                MessageBox.Show("Telefon numarası 10 haneli ve sadece rakamlardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Anasayfa'ya geçiş
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide(); // Form1'i gizle
        }
    }
}
