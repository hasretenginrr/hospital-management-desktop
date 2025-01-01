using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



//20.08.2024----------

namespace ilk
{
    public partial class FrmDoktorEkle : Form
    {


        HastaneProjeEntities dbContextGetir = new HastaneProjeEntities();
        HastaneProjeEntities db_branslar = new HastaneProjeEntities();


        HastaneProjeEntities dbContext = new HastaneProjeEntities();
        int gelenDeger;
        

        public FrmDoktorEkle(int id)
        {

            InitializeComponent();
            gelenDeger = id;
            label6.Text = id.ToString(); //id doğru alınıyor mu diye bir label aracılığı ile kontrol ettik. 
            

            tblBranslarBindingSource.DataSource = db_branslar.Tbl_Branslar.ToList();

            
            if (id != 0) {
                    var gelen = dbContextGetir.Tbl_Doktorlar.Where(s => s.Doktorid == id).FirstOrDefault();
                    button1.Text = "Güncelle";
                    int doktordrm = Convert.ToInt32(gelen.DoktorDurum);
                    txtDoktor.Text = gelen.DoktorAdSoyad;
                    txtsfre.Text = gelen.DoktorSifre;
                    cmbbrans.SelectedValue = gelen.Bransid.Value;
                    txttc.Text = gelen.DoktorTc;

                    if (doktordrm == 1)
                    {
                        chkbxcalisiyor.Checked = true;
                    }
                    else
                    {
                        chkbxcalismiyor.Checked = true;
                    };
            }
        
            else
            {
                button1.Text = "Ekle";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool Doktor_durum;
            if (chkbxcalisiyor.Checked)
            {
                Doktor_durum = true;
            }
            else
            {
                Doktor_durum = false;
            }

            if (gelenDeger == 0)
            {
                Tbl_Doktorlar Kisi_Ekle = new Tbl_Doktorlar
                {
                    DoktorAdSoyad = txtDoktor.Text,
                    Bransid = Convert.ToInt32(cmbbrans.SelectedValue. ToString()), // Convert.ToInt32(cmbbrans.Text),
                    DoktorSifre = txtsfre.Text,
                    DoktorTc = txttc.Text,
                    DoktorDurum = Doktor_durum,

                };

                dbContext.Tbl_Doktorlar.Add(Kisi_Ekle);
                dbContext.SaveChanges();
            }
            else
            {
                var gelen = dbContextGetir.Tbl_Doktorlar.Where(s => s.Doktorid == gelenDeger).FirstOrDefault(); 
                //gelen değeri yani id nosunu db. den framework yardımı ile çektik ve eşit mi diye kontrol ettik. o id deki değerleri textlere yazıldı ve biz değiştirdiğimizde db. kaydederek devam etmesini bekliyoruz. 
                 gelen.DoktorAdSoyad= txtDoktor.Text;
                 gelen.Bransid= Convert.ToInt32(cmbbrans.SelectedValue.ToString());
                 gelen.DoktorTc= txttc.Text;
                 gelen.DoktorSifre= txtsfre.Text;
                gelen.DoktorDurum = Doktor_durum;
                    
                dbContextGetir.SaveChanges();
            }
            this.Close();  
        }



        //21.08.2024------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (gelenDeger == 0)
            {

                cmbbrans.SelectedItem = null;
                cmbbrans.SelectedText = "seçiniz";
            }

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //sql manage st. gidip bir branslar tablosu olustur. Brans isimleri ile değil id noları ile çek ve comboboxa ekle!

        //22.08.2024------------------


        





    }
}
