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

//23.08.2024----------------
//24.08.2024----------- TRİGGER YAZILDI VERİTABANINDA RANDEVU EKLENDİĞİNDE MUANESAYİSİNİ BİR ARTTIRACAK ŞEKİLDE!

namespace ilk
{
    public partial class FrmRandevuEkle : Form
    {

        int gelendeger;
        

        HastaneProjeEntities dbEkle = new HastaneProjeEntities();
        HastaneProjeEntities doktor = new HastaneProjeEntities();
        HastaneProjeEntities hasta = new HastaneProjeEntities();

        public FrmRandevuEkle(int id)
        {
            InitializeComponent();

            gelendeger = id;
 
            tblDoktorlarBindingSource.DataSource = doktor.Tbl_Doktorlar.ToList();
            tblHastalarBindingSource.DataSource = hasta.Tbl_Hastalar.ToList();

            //vRandevuBindingSource.DataSource = dbEkle.vRandevu.ToList();

            if (id != 0) {
                btnEkleGuncelle.Text = "Randevu Bilgilerini Güncelle";
                var gelen = dbEkle.Tbl_Randevular.Where(s => s.Randevuid == id).FirstOrDefault();
                int randevudrm = Convert.ToInt32(gelen.RandevuDurum);
                cmbDoktor.SelectedValue = gelen.Doktorid;
                cmbHasta.SelectedValue = gelen.Hastaid;
                mskTarih.Text= gelen.RandevuTarih;
                mskSaat.Text = gelen.RandevuSaat;
                
               
                if (randevudrm == 1)
                {
                    chkaktif.Checked = true;
                }
                else
                {
                    chkpasif.Checked = true;
                };
            }

            else
            {
                btnEkleGuncelle.Text = "Ekle";
            }

            

        }
         private void btnEkleGuncelle_Click(object sender, EventArgs e)
         {
            bool Randevudurum;
            

            if (chkaktif.Checked)
            {
                Randevudurum= true;
            }
            else
            {
                Randevudurum= false;
            }

            if (gelendeger != 0) //güncelleme ()
            {
                var gelen = dbEkle.Tbl_Randevular.Where(s => s.Randevuid == gelendeger).FirstOrDefault();
                //tblHastalarBindingSource.DataSource = hasta.Tbl_Hastalar.ToList();
                gelen.RandevuTarih = mskTarih.Text;
                gelen.RandevuSaat = mskSaat.Text;
                gelen.Doktorid = Convert.ToInt32(cmbDoktor.SelectedValue);
                gelen.Hastaid = Convert.ToInt32(cmbHasta.SelectedValue);
                gelen.RandevuDurum = Randevudurum;
            }
            else
            {
                Tbl_Randevular randevuEkle = new Tbl_Randevular()
                {

                    Hastaid= Convert.ToInt32(cmbHasta.SelectedValue),
                    Doktorid=Convert.ToInt32(cmbDoktor.SelectedValue),
                    RandevuSaat= mskSaat.Text,
                    RandevuTarih= mskTarih.Text,
                    RandevuDurum=Randevudurum,

                };
                dbEkle.Tbl_Randevular.Add(randevuEkle);     
                
            }
            dbEkle.SaveChanges();
            this.Close();
        }

        private void btn_randevuekle_Click(object sender, EventArgs e)
        {
            FrmTeşhisler teshisler = new FrmTeşhisler(gelendeger);
            teshisler.ShowDialog();
            this.Close();
        }
    }
}
