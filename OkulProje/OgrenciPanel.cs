using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProje
{
    public partial class OgrenciPanel : Form
    {
        public OgrenciPanel()
        {
            InitializeComponent();
        }
        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {
           
        }
        private void OgrenciPanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ogrenci ekle = new ogrenci();
            ekle.ogrenciAdSoyad = txtadsoyad.Text;
            ekle.ogrenciNo = txtogrencino.Text;
            ekle.ogrenciDogumTarih = dateTimePicker1.Value;
            ekle.ogrenciBolum = txtbolum.Text;
            ekle.ogrenciKayitTarih = DateTime.Now;
            db.ogrenci.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kaydı Oluşturuldu.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            
        }

       

        

        private void btnsil_Click(object sender, EventArgs e)
        {
            int OgrenciId = Convert.ToInt32(txtid.Text);

            var ogrencibul = db.ogrenci.Find(OgrenciId);
            db.ogrenci.Remove(ogrencibul);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
