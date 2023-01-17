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

namespace GorselProje
{
    public partial class OgrenciDersPanel : Form
    {
        public OgrenciDersPanel()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.ogrenciDers
                                        select new
                                        {
                                            x.ogrenciDersID,
                                            x.ders.dersAd,
                                            x.ogrenci.ogrenciAdSoyad
                                           
                                           

                                        }).ToList();
           
          


    

            var derslist = db.ders.ToList();


        }

        private void OgrenciDersPanel_Load(object sender, EventArgs e)
        {
            listele();
            var ogrenciler = (from x in db.ogrenci
                               select new
                               {
                                   x.ogrenciID,
                                   x.ogrenciAdSoyad

                               }).ToList();

            cmbogrenci.ValueMember = "ogrenciID";
            cmbogrenci.DisplayMember = "ogrenciAdSoyad";
            cmbogrenci.DataSource = ogrenciler; listele();


            var dersler = (from x in db.ders
                              select new
                              {
                                  x.dersId,
                                  x.dersAd

                              }).ToList();

            cmbders.ValueMember = "dersId";
            cmbders.DisplayMember = "dersAd";
            cmbders.DataSource = dersler; listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbders.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbogrenci.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
          
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int ogrenciDersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencidersbul = db.ogrenciDers.Find(ogrenciDersID);
                db.ogrenciDers.Remove(ogrencidersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Ve Öğrenci İlişkisi Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciDers ekle = new ogrenciDers();
            ekle.ogrenciDers2ID = Convert.ToInt16(cmbders.SelectedValue);
            ekle.ogrenciDersOgrenciID = Convert.ToInt16(cmbogrenci.SelectedValue);
            db.ogrenciDers.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Ataması Yapıldı.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="Ogrenci")
            {
                {
                    var arama = textBox1.Text;
                    var sonuc = (from x in db.ogrenciDers
                                 where x.ogrenci.ogrenciAdSoyad.Contains(arama)
                                 select new
                                 {
                                     x.ogrenciDersID,
                                     x.ders.dersAd,
                                     x.ogrenci.ogrenciAdSoyad

                                 }).ToList();
                    dataGridView1.DataSource = sonuc.ToList();


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                listele();
            
        }
    }
}
