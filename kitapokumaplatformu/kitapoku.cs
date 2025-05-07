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
    public partial class kitapoku : Form
    {
        public kitapoku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void kitapoku_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = veri.kitapIsimleri;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenKitap = comboBox1.SelectedItem.ToString();

            // Seçilen kitabın içeriğini textBox1'e yazdıralım
            if (veri.kitapIcerikleri.ContainsKey(secilenKitap))
            {
                // TextBox'a içeriği yazalım
                textBox1.Text = veri.kitapIcerikleri[secilenKitap];

                // TextBox'ın özelliklerini ayarlayalım
                textBox1.Multiline = true;       // Birden fazla satırda gösterim sağlanacak
                textBox1.ScrollBars = ScrollBars.Vertical; // Dikey kaydırma çubuğu ekleyelim
                textBox1.ReadOnly = true;
            }
        }
    }
}
