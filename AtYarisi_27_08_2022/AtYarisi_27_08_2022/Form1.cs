using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi_27_08_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciAtSol, ikinciAtSol, ucuncuAtSol;
        Random rnd = new Random();

        private void timer_Tick(object sender, EventArgs e)
        {
            int birinciAt = pictureBox1.Width;
            int ikinciAt = pictureBox2.Width;
            int ucuncuAt = pictureBox3.Width;

            pictureBox1.Left += rnd.Next(6,16);
            pictureBox2.Left += rnd.Next(6,16);
            pictureBox3.Left += rnd.Next(6,16);

            int bitisUzakligi = textBox4.Left;
            if (birinciAt + pictureBox1.Left >= bitisUzakligi) 
            {
                timer.Enabled = false;
                MessageBox.Show("Birinci At Yarışı Kazandı");
                btnYeniden.Enabled = true;
            }

            if (ikinciAt + pictureBox2.Left >= bitisUzakligi)
            {
                timer.Enabled = false;
                MessageBox.Show("İkinci At Yarışı kazandı");
                btnYeniden.Enabled = true;
            }

            if (ucuncuAt + pictureBox3.Left >= bitisUzakligi)
            {
                timer.Enabled = false;
                MessageBox.Show("Üçüncü At Yarışı kazandı");
                btnYeniden.Enabled = true;
            }
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btnBasla.Enabled = false;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciAtSol = pictureBox1.Left;
            ikinciAtSol = pictureBox2.Left;
            ucuncuAtSol = pictureBox3.Left;
            btnYeniden.Enabled = false;
        }
    }
}
