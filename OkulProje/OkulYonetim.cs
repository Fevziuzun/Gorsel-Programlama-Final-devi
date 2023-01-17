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
    public partial class OkulYonetim : Form
    {
        public OkulYonetim()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();
        public string deger;

        void listele()
        {
            var yonetimlist = db.okulYonetimT.ToList();


        }
        private void OkulYonetim_Load(object sender, EventArgs e)
        {
            listele();
            cmbpozisyon.Items.Add("İdare");
            cmbpozisyon.Items.Add("Öğretmen");
            cmbpozisyon.Items.Add("Öğrenci İşleri");
         
           

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int sum1 = Convert.ToInt32(e.Value);
                if (sum1 == 11)
                {
                    e.Value = "İdare";
                }
                else if (sum1 == 12)
                {
                    e.Value = "Öğretmen";
                }
                else if (sum1 == 13)
                {
                    e.Value = "Öğrenci İşleri";
                }
            }
        }

        

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            okulYonetimT ekle = new okulYonetimT();
            ekle.yonetimAdSoyad = txtadsoyad.Text;
            ekle.yonetimGorevi = txtgorev.Text;

           
            if (cmbpozisyon.Text == "İdare")
            {
                ekle.yonetimTip = "11";
            }
            else if (cmbpozisyon.Text == "Öğretmen")
            {
                ekle.yonetimTip = "12";
            }
            else if (cmbpozisyon.Text == "Öğrenci İşleri")
            {
                ekle.yonetimTip = "13";
            }
            
    
            db.okulYonetimT.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yönetim Kaydı Oluşturuldu.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        

        private void cmbpozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
            
        }
    }
