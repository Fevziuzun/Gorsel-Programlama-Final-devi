using GorselProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class OgrenciPanelListele : Form
    {
        public OgrenciPanelListele()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {

            dataGridView1.DataSource = db.ogrenci.ToList();

            dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtogrencino.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtbolum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void OgrenciPanelListele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ad Soyad")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciAdSoyad.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Öğrenci No")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciNo.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Bolum")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciBolum.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int OgrenciId = Convert.ToInt32(txtid.Text);

            var guncelle = db.ogrenci.Find(OgrenciId);
            guncelle.ogrenciAdSoyad = txtadsoyad.Text;
            guncelle.ogrenciNo = txtogrencino.Text;
            guncelle.ogrenciDogumTarih = dateTimePicker1.Value;
            guncelle.ogrenciBolum = txtbolum.Text;
            guncelle.ogrenciKayitTarih = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kayıdı Güncellendi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int OgrenciId = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencibul = db.ogrenci.Find(OgrenciId);
                db.ogrenci.Remove(ogrencibul);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
    }
}
