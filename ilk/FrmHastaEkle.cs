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
    public partial class FrmHastaEkle : Form
    {
        int gelendeger;

        HastaneProjeEntities dbHasta1 = new HastaneProjeEntities();
        HastaneProjeEntities dbHasta2 = new HastaneProjeEntities();
        HastaneProjeEntities dbHasta3 = new HastaneProjeEntities();




        public FrmHastaEkle(int id)
        {
            int cinsiyet;

            InitializeComponent();
            gelendeger = id;
            if (gelendeger != 0)
            {
                btnEkleGuncelle.Text = "Güncelle";
                var gelen = dbHasta3.Tbl_Hastalar.Where(s => s.Hastaid == id).FirstOrDefault();
                cinsiyet = Convert.ToInt32(gelen.HastaCinsiyet);

                if (cinsiyet == 1)
                {
                    radiokadin.Checked = true;

                }
                else
                {
                    radioerkek.Checked = true;
                }

                txtadHasta.Text = gelen.HastaAdSoyad;
                msktel.Text = gelen.HastaTelefon;
                txttchasta.Text = gelen.HastaTc;
                txtsifrehasta.Text = gelen.HastaSifre;


            }
            else
            {
                btnEkleGuncelle.Text = "Ekle";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte cinsiyet;
            if (radiokadin.Checked == true)
            {
                cinsiyet = 1;
            }
            else { cinsiyet = 0; }
            if (gelendeger == 0)
            {
                Tbl_Hastalar Kisi_Ekle = new Tbl_Hastalar()
                {
                    HastaAdSoyad = txtadHasta.Text,
                    HastaSifre = txtsifrehasta.Text,
                    HastaTc = txttchasta.Text,
                    HastaTelefon = msktel.Text,
                    HastaCinsiyet = cinsiyet,
                };
                dbHasta2.Tbl_Hastalar.Add(Kisi_Ekle);
                dbHasta2.SaveChanges();
            }
            else
            {
                var gelen = dbHasta3.Tbl_Hastalar.Where(s => s.Hastaid == gelendeger).FirstOrDefault();
                gelen.HastaAdSoyad = txtadHasta.Text;
                gelen.HastaTc = txttchasta.Text;
                gelen.HastaTelefon = msktel.Text;
                gelen.HastaSifre = txtsifrehasta.Text;

                if (radiokadin.Checked == true)
                { gelen.HastaCinsiyet = 1; }
                else { gelen.HastaCinsiyet = 0; }
                dbHasta3.SaveChanges();
            }
            this.Close();
        }




    }
}

