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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulProje
{
    public partial class DersList : Form
    {
        public DersList()
        {
            InitializeComponent();
        }
        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.ders
                                        select new
                                        {
                                            x.dersId,
                                            x.dersAd,
                                            x.dersKredi,
                                            x.okulYonetimT.yonetimAdSoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.ders.ToList();


        }
        private void DersList_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.okulYonetimT
                               where x.yonetimTip == "12"
                               select new
                               {
                                   x.yonetimId,
                                   x.yonetimAdSoyad
                               }).ToList();

            comboBox1.ValueMember = "yonetimId";
            comboBox1.DisplayMember = "yonetimAdSoyad";
            comboBox1.DataSource = ogretmenler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtkredi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int DersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var dersbul = db.ders.Find(DersID);
                db.ders.Remove(dersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int DersID = Convert.ToInt32(txtid.Text);

            var guncelle = db.ders.Find(DersID);
            guncelle.dersAd = txtdersad.Text;
            guncelle.dersKredi = txtkredi.Text;
            guncelle.dersOkulYonetimID = Convert.ToInt16(comboBox1.SelectedValue);
            db.SaveChanges();
            MessageBox.Show("Ders Kayıdı Güncellendi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
