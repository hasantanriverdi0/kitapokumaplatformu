using KitapOkumaSistemi;
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
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string kitapIsmi = textBox1.Text.Trim();
            string kitapIcerigi = textBox2.Text.Trim();

            // Kitap ismi ve içerik boş değilse ana veri yapısına ekliyoruz
            if (!string.IsNullOrEmpty(kitapIsmi) && !string.IsNullOrEmpty(kitapIcerigi))
            {
                // Ana veri yapısına yeni kitap ekleyelim
                if (!veri.kitapIcerikleri.ContainsKey(kitapIsmi))
                {
                    veri.kitapIsimleri.Add(kitapIsmi);
                    veri.kitapIcerikleri.Add(kitapIsmi, kitapIcerigi);

                    MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizleyelim
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu kitap zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kitap ismi ve içeriği boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
