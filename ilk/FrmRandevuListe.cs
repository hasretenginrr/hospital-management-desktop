using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//23.08.2024-------------------------------------
/*Randevular tablosunda Hasta AD,Soyad Doktor Ad,Soyad ve branş bilgisi de göstermek istediğim için
 * yeni bir view yarattık. Bu viewda foregn key yardımı ile randevular tablosuna kolayca hasta ve doktor bilgilerini çektik. 
 Bu viewu frameworke çektik ve modelimize ekledik. Kaydedip güncelledikten sonra randevu listeleme ekranında tbl_randevular değil de viewu(Vrandevular) listeledik. 
!!! Önemli bir Düzeltme yapıldı ve Randevu eklerken kayıtları comboboxtan düzgün getirmek için veritabanı güncellendi. Tüm kayıtlar ad soyad olarak kaydedildi.
İsim ve Soyisim bir columnda tutuldu. Bu sebeple tüm formlar ve kodlar güncellendi. viewlar yeniden yazıldı ve şema edildi. 
 
 */
namespace ilk
{

    public partial class FrmRandevuListe : Form
    {
        bool doktor_mu_;
        int doktor_id;
        bool hasta_giris_;
        int hasta_id_;
        int silinenid;


        public FrmRandevuListe(bool _doktor_mu,int doktorid_ ,bool hastagiris_,int hastaid_)
        {
            doktor_mu_= _doktor_mu;
            doktor_id= doktorid_;
            hasta_giris_ = hastagiris_;
            hasta_id_= hastaid_;
            InitializeComponent();
        }

        HastaneProjeEntities dbsil = new HastaneProjeEntities();



        void kayitBul()
        {
            HastaneProjeEntities dbListele = new HastaneProjeEntities();
            if (doktor_mu_ == true)
            {
                dataGridView1.DataSource = dbListele.vRandevu.Where(s => s.Doktorid == doktor_id && s.DoktorDurum==true).OrderBy(s => s.Randevuid).ToList();
                btnKayitEkle.Enabled = false;
                btnkayitsil.Enabled = false;
            }
            else if (hasta_giris_ == true)
            {
                btnKayitEkle.Enabled = false; //kayıt yapamasın 
                dataGridView1.DataSource = dbListele.vRandevu.Where(s => s.Hastaid == hasta_id_ && s.DoktorDurum == true).OrderBy(s => s.Randevuid).ToList();
                dataGridView1.MouseDoubleClick -= dataGridView1_MouseDoubleClick; // güncelleme yapamaasın 

            }
            else
            {
                dataGridView1.DataSource = dbListele.vRandevu.Where(s=> s.DoktorDurum == true).OrderBy(s => s.Randevuid ).ToList();

             //   await dataGridView1.DataSource = dbListele.vRandevu.OrderBy(s => s.Randevuid).ToListAsync(); //aynı zamanda çalışan uyg. da grid dolarken arka planda çalışmanı sağlar. 

            }
            dataGridView1.Refresh();

        }
        public void FrmRandevuListe_Load(object sender, EventArgs e)
        {
            kayitBul();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {          
               FrmRandevuEkle rndekle = new FrmRandevuEkle(hasta_id_);
               rndekle.ShowDialog();
               kayitBul();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
               FrmRandevuEkle frmekle = new FrmRandevuEkle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
               frmekle.ShowDialog();
               kayitBul();            
        }

        //2.09.24 
        private void btnkayitsil_Click(object sender, EventArgs e)
        {
            int silinen_id= Convert.ToInt32(silinenid);
            var silinen = dbsil.Tbl_Randevular.Find(silinen_id);
            if (silinen != null)
            {               
                dbsil.Tbl_Randevular.Remove(silinen);
                dbsil.SaveChanges();
            }
            kayitBul() ;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            silinenid=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
