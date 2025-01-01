using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//22.08.2024----------------------
//++ veri tabanında bazı düzeltmeler yapıldı. Tc no type'ı varchar(15 olarak değiştirildi.) model güncellendi, kaydedildi, derlendi. 


namespace ilk
{
    public partial class FrmHastaListele : Form

    {
        int silinenid;

        public FrmHastaListele()
        {
            InitializeComponent();
        }


        HastaneProjeEntities dbsil = new HastaneProjeEntities();

        void kayitBul()
        {
            HastaneProjeEntities dbListele2 = new HastaneProjeEntities();
            dataGridView1.DataSource = dbListele2.Tbl_Hastalar.OrderBy(s => s.Hastaid).ToList();
            dataGridView1.Refresh();
        }

        //HastaneProjeEntities dbListele = new HastaneProjeEntities();
        //Kayitbul içindeki db açma kapama işini her seferinde ayrı ayrı yapmak yerine kayitbul() adında yeni bir fonk. üretip onun içinde bir kere çağırdık. Bu durumda yeni db bağlanıp listeleme yapacağımız her yerde kayitbul() çağırdık. 


        private void FrmHastaListele_Load(object sender, EventArgs e)
        {
            //ilk form yüklendiğinde db deki veileri listele
            // dataGridView1.DataSource = dbListele.Tbl_Hastalar.OrderBy(s=>s.Hastaid).ToList();
            kayitBul();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kayıt ekleme formuna geçiş yap
            FrmHastaEkle frmekle = new FrmHastaEkle(0);
            frmekle.ShowDialog();
            //Ekleme sayfası kapandıktan sonra ShowDialogdan devam eder.Eklenen verileri listelemek için kayitbul() çağırdık. 
            kayitBul();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HastaneProjeEntities dbListele2 = new HastaneProjeEntities();
            FrmHastaEkle fr = new FrmHastaEkle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            fr.ShowDialog();
            //güncellenen verileri listelemek için kayitbul() çağırdık. 
            kayitBul();
        }

        private void btnkayitsil_Click(object sender, EventArgs e)
        {
            int silinen_id = Convert.ToInt32(silinenid);
            var silinen = dbsil.Tbl_Hastalar.Find(silinen_id);
            if (silinen != null)
            {
                /*   var randevular = dbsil.Tbl_Randevular.Where(r => r.Hastaid == silinen_id).ToList();
                   foreach (var randevu in randevular)
                   {
                   dbsil.Tbl_Randevular.Remove(randevu);
                    }    
                bu kod, hasta sildiğimde randevusunu da silmeye yarar. Fakat bunu kodla yapmak yerine veritabanındaki bir özellik ile yaptık. 
                database diagrama gelip hastalar ile randevular tablosunun foreign key bağlantısının özelliklerini açtık.
                INSERT AND UPDATE Specificaiton özelliğinin altındaki Delete Rule özelliğini cascade yaptığımda aynı sonucu verdi.
                 */ 
                dbsil.Tbl_Hastalar.Remove(silinen);
                dbsil.SaveChanges();
            }
            kayitBul();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            silinenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
