using OkulProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciPanel ogrpanel = new OgrenciPanel();
            ogrpanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkulYonetim oklyonetim = new OkulYonetim();
            oklyonetim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DersPaneli derspanel = new DersPaneli();
            derspanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciDersPanel derspanel = new OgrenciDersPanel();
            derspanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciPanel ogrpanel = new OgrenciPanel();
            ogrpanel.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciPanelListele OgrenciPanelListele = new OgrenciPanelListele();
            OgrenciPanelListele.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OkulYonetimList okulYonetimList = new OkulYonetimList();
            okulYonetimList.Show();
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciDersList ogrenciDersList = new OgrenciDersList();
            ogrenciDersList.Show();
        }

        private void listeleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DersList dersList = new DersList();
            dersList.Show();
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OkulYonetim okulYonetim = new OkulYonetim();
            okulYonetim.Show();
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciDersPanel ogrenciDersPanel = new OgrenciDersPanel();
            ogrenciDersPanel.Show();
        }

        private void girişToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DersPaneli dersPaneli = new DersPaneli();
            dersPaneli.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
