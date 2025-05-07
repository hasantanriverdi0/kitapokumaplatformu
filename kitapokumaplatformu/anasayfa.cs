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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            kitapekle.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
            kitapoku kitapoku = new kitapoku();
            kitapoku.Show();
            this.Hide();
        }
    }
}
