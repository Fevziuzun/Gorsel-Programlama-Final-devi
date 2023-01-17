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
    public partial class DersPaneli : Form
    {
        public DersPaneli()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {
            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.ders.ToList();


        }
        private void DersPaneli_Load(object sender, EventArgs e)
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            ders ekle = new ders();
            ekle.dersAd = txtdersad.Text;
            ekle.dersKredi = txtkredi.Text;
            ekle.dersOkulYonetimID = Convert.ToInt16(comboBox1.SelectedValue);
            db.ders.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ders Kaydedildi.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var ogretmenler = (from x in db.okulYonetimT
                                   where x.yonetimTip == "12"
                                   select new
                                   {
                                       x.yonetimId,
                                       x.yonetimAdSoyad

                                   }).ToList();
                foreach (var item in ogretmenler)
                {
                    e.Value = item.yonetimAdSoyad;
                }

               
             
            
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
