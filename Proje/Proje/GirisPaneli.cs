using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            YolcuGiris fr = new YolcuGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYoneticiGirisi_Click(object sender, EventArgs e)
        {
            YoneticiGiris fr = new YoneticiGiris();
            fr.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalısanGiris fr = new CalısanGiris();
            fr.Show();
            this.Hide();
        }
    }
}
