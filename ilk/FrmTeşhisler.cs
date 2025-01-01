using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk
{
   
    public partial class FrmTeşhisler : Form
    {
        int gelenid;
        HastaneProjeEntities dbContext = new HastaneProjeEntities();

        public FrmTeşhisler(int gelendeger)
        {
            InitializeComponent();
            gelenid = gelendeger;
            var gelenbilgi= dbContext.Tbl_Randevular.Where(s => s.Randevuid == gelenid).FirstOrDefault();
            label4.Text = gelenbilgi.Tbl_Hastalar.HastaAdSoyad;
            label6.Text = gelenbilgi.Tbl_Hastalar.HastaTc;

            tblilaclarBindingSource.DataSource = dbContext.Tbl_ilaclar.ToList();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var gelendb = dbContext.Tbl_Randevular.Where(s => s.Randevuid == gelenid).FirstOrDefault();

            gelendb.HastaSikayet=txtbxsikayet.Text;
            gelendb.HastaTeshis=txtbxsteshis.Text;
            dbContext.SaveChanges();

            this.Close();
        }

        private void FrmTeşhisler_Load(object sender, EventArgs e)
        {
            var gelendb = dbContext.Tbl_Randevular.Where(s => s.Randevuid == gelenid).FirstOrDefault();
            dataGridView1.DataSource = dbContext.vIlaclar.Where(s => s.Randevuid == gelenid).ToList();

            txtbxsikayet.Text = gelendb.HastaSikayet;
            txtbxsteshis.Text = gelendb.HastaTeshis;

            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "seçiniz";    
            
        }



        private void btnilacekle_Click(object sender, EventArgs e)
        {
            Tbl_Kayitlar kayitlar = new Tbl_Kayitlar()
            {
                ilacid = Convert.ToInt32(comboBox1.SelectedValue),
                Randevuid = gelenid
                
            };
            dbContext.Tbl_Kayitlar.Add(kayitlar);
            dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.vIlaclar.Where(s => s.Randevuid == gelenid).ToList();
        }
    }
}
