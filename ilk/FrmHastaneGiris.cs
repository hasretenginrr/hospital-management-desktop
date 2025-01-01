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

namespace ilk
{
    public partial class FrmHastaneGiris : Form
    {

        bool _doktor_mu;
        int doktorid_;
        bool hastagiris_;
        int hastaid_;

        public FrmHastaneGiris(bool doktor_mu, int doktorid, int hastaid, bool hasta_giris)
        {
            _doktor_mu = doktor_mu;
            doktorid_=doktorid;
            hastagiris_ = hasta_giris;
            hastaid_=hastaid;

            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
          if (_doktor_mu==true) {
               btnRandevuEkle.Enabled=true;
               btnHastaEkle.Enabled=false;
               btnDoktorEkle.Enabled = true;
               label3.Text = "Randevu Görüntüle";
               label4.Text = "Bilgileri Görüntüle";
            }

            else
            {
                btnRandevuEkle.Enabled = true;
                btnHastaEkle.Enabled = true;
                btnDoktorEkle.Enabled = true;
            }
            if (hastagiris_ == true){
                btnDoktorEkle.Enabled = false;
                btnHastaEkle.Enabled = false;
                btnRandevuEkle.Enabled = true;
                label3.Text = "Randevu görüntüle";
            }
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            FrmDoktorListe dkekle =new FrmDoktorListe(doktorid_,_doktor_mu);
            dkekle.ShowDialog();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            FrmHastaListele hastals=new FrmHastaListele();
            hastals.ShowDialog();
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            FrmRandevuListe rndliste =new FrmRandevuListe(_doktor_mu,doktorid_,hastagiris_,hastaid_);
            rndliste.ShowDialog();
        }
    }
}
