using System;
using System.Linq;
using System.Windows.Forms;

namespace ilk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        bool doktor_mu;
        bool hasta_giris;
        int doktorid;
        int hastaid;

        void form_cagir(bool doktor_mu, int doktorid, bool hasta_giris, int hastaid)
        {
            this.Hide();
            FrmHastaneGiris frmHastaneGiris = new FrmHastaneGiris(doktor_mu, doktorid, hastaid,hasta_giris);
            frmHastaneGiris.ShowDialog();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            HastaneProjeEntities dbContext = new HastaneProjeEntities();

            var gelenDoktor = dbContext.Tbl_Doktorlar.FirstOrDefault(s => s.DoktorTc == txtTc.Text && s.DoktorSifre == txtSifre.Text);

            if (gelenDoktor == null)
            {
                var gelenSekreter = dbContext.Tbl_Sekreter.FirstOrDefault(s => s.SekreterTc == txtTc.Text && s.SekreterSifre == txtSifre.Text);

                if (gelenSekreter == null)
                {
                    var gelenHasta = dbContext.Tbl_Hastalar.FirstOrDefault(s => s.HastaTc == txtTc.Text && s.HastaSifre == txtSifre.Text);
                    if (gelenHasta == null)
                    {
                       
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                            hasta_giris = false;
                    }
                    else
                    {
                        hasta_giris = true;
                        hastaid = gelenHasta.Hastaid;
                        form_cagir(doktor_mu,doktorid,hasta_giris,hastaid);

                    }
                }
                else
                {
                    doktor_mu = false;
                    form_cagir(doktor_mu, doktorid,hasta_giris,hastaid);
                }
            }
            else
            {
                doktor_mu = true;
                doktorid = gelenDoktor.Doktorid;
                form_cagir(doktor_mu, doktorid, hasta_giris, hastaid);
            }
        }
        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris_Click(sender, e);
            }
        }
    }
}
