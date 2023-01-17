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
    public partial class OgrenciDersList : Form
    {
        public OgrenciDersList()
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
        private void OgrenciDersList_Load(object sender, EventArgs e)
        {
            listele();
            var ogrenciler = (from x in db.ogrenci
                              select new
                              {
                                  x.ogrenciID,
                                  x.ogrenciAdSoyad

                              }).ToList();
            var dersler = (from x in db.ders
                           select new
                           {
                               x.dersId,
                               x.dersAd

                           }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ogrenci")
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
