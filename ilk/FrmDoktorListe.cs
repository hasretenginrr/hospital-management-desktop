using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;



//20.08.2024------------------------
//++ database tabloları, onların anahtarları, şemalamaları...
//Yeni model ekleyerek Entitiy framework sqle bağlandı. 


namespace ilk
{
    public partial class FrmDoktorListe : Form
    {

        HastaneProjeEntities dbContext = new HastaneProjeEntities();
        HastaneProjeEntities dbListele = new HastaneProjeEntities();

        int gelendoktor;
        bool gelendoktormu;
        public FrmDoktorListe(int doktorid_,bool _doktor_mu)
        {
            gelendoktor = doktorid_;
            gelendoktormu = _doktor_mu;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (gelendoktormu == true)
            {
                dataGridView1.DataSource = dbListele.vDoktorlar.Where(s => s.Doktorid == gelendoktor && s.DoktorDurum == true).ToList();
                button1.Enabled = false;
                dataGridView1.MouseDoubleClick -= dataGridView1_MouseDoubleClick;

            }
            else
            {


                HastaneProjeEntities dbListele = new HastaneProjeEntities();
                dataGridView1.DataSource = dbListele.vDoktorlar.OrderBy(s => s.Doktorid).ToList();

            }

        }
        private void label1_Click_1(object sender, EventArgs e) { }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorEkle fr = new FrmDoktorEkle(0);
            fr.ShowDialog();
            dataGridView1.DataSource = dbContext.vDoktorlar.OrderBy(s => s.Doktorid).ToList();


        }


        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            


            //  label1.Text = dataGridView1.SelectedCells[0].Value.ToString();  //direk seçili hücrenin içindeki veriyi al     
            //label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() ; // seçili satırın 0. hücresi!!!
            FrmDoktorEkle fr = new FrmDoktorEkle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            fr.ShowDialog();
            dataGridView1.DataSource = dbListele.vDoktorlar.OrderBy(s => s.Doktorid).ToList();
            // dataGridView1.Refresh(); veri tabanını güncellemek için denendi fakat çalışmadı o yüzden ToList() methoduna yönelindi. 
        }

       

       

        // 21.08.2024--------------------


        /*  private void button2_Click(object sender, EventArgs e)
          {
              dataGridView1.DataSource = dbListele.vDoktorlar.OrderBy(s => s.Doktorid).ToList();

              //BURAYA BAK REFRESH YAPMIYOR VE YENİDEN LİSTELEME YAPMIYOR! KONTROL ETMELİSİN! 
              //Düzeltildi, yeni bir dbcontext yarattık (dbListele)!

               //ShowDiolog() methodu kullandığımız için form2 kapanınca otomatikmen showdialog() tetiklenip kod oradan devam ediyor. Bu durumda yeniden listele butonuna gerek duymadığımız için kaldırdık ve form2 kapanınca datagrid yenilendi. Listeleme mrthodunu showdialogun altına ekledik!

             
              /*Veri tabanında Branslar tablosu düzenlend. Doktorlar tablosunda yaratılan bransad, bransid olarak değiştirildi. Bu sayede
              foreginkey bağlantısı ile iki tablo birbirine bağlandı. Daha sonra datagrid'de bransid göstermek yerine bransad göstermek için bir view yarattık ve o view'ı frameworke bağladık. Vdoktorlar adında yeni bir bindingSource oluştu ve bunu DataGride girip düzenledik. 
              Model1.edmx yapısını update edip derledik(Eğer yapmazsak veritabanında yaptığımız güncellemeleri framework ile beraber kullanamayız!



          }
         */



        //22.08.2024---------------




    }
}
