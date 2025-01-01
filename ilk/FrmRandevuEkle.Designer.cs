namespace ilk
{
    partial class FrmRandevuEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.tblHastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkaktif = new System.Windows.Forms.CheckBox();
            this.chkpasif = new System.Windows.Forms.CheckBox();
            this.btn_randevuekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRandevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoktorlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hasta:";
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.Location = new System.Drawing.Point(163, 393);
            this.btnEkleGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(225, 65);
            this.btnEkleGuncelle.TabIndex = 30;
            this.btnEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DataSource = this.tblHastalarBindingSource;
            this.cmbHasta.DisplayMember = "HastaAdSoyad";
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(192, 68);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(196, 36);
            this.cmbHasta.TabIndex = 31;
            this.cmbHasta.ValueMember = "Hastaid";
            // 
            // tblHastalarBindingSource
            // 
            this.tblHastalarBindingSource.DataSource = typeof(ilk.Tbl_Hastalar);
            // 
            // vRandevuBindingSource
            // 
            this.vRandevuBindingSource.DataSource = typeof(ilk.vRandevu);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Doktor:";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DataSource = this.tblDoktorlarBindingSource;
            this.cmbDoktor.DisplayMember = "DoktorAdSoyad";
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(192, 127);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(196, 36);
            this.cmbDoktor.TabIndex = 33;
            this.cmbDoktor.ValueMember = "Doktorid";
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataSource = typeof(ilk.Tbl_Doktorlar);
            // 
            // vDoktorlarBindingSource
            // 
            this.vDoktorlarBindingSource.DataSource = typeof(ilk.vDoktorlar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tarih:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(192, 194);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(196, 36);
            this.mskTarih.TabIndex = 35;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Saat:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(192, 256);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(196, 36);
            this.mskSaat.TabIndex = 37;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Durum:";
            // 
            // chkaktif
            // 
            this.chkaktif.AutoSize = true;
            this.chkaktif.Location = new System.Drawing.Point(192, 330);
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Size = new System.Drawing.Size(79, 32);
            this.chkaktif.TabIndex = 40;
            this.chkaktif.Text = "Aktif";
            this.chkaktif.UseVisualStyleBackColor = true;
            // 
            // chkpasif
            // 
            this.chkpasif.AutoSize = true;
            this.chkpasif.Location = new System.Drawing.Point(271, 330);
            this.chkpasif.Name = "chkpasif";
            this.chkpasif.Size = new System.Drawing.Size(79, 32);
            this.chkpasif.TabIndex = 41;
            this.chkpasif.Text = "Pasif";
            this.chkpasif.UseVisualStyleBackColor = true;
            // 
            // btn_randevuekle
            // 
            this.btn_randevuekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_randevuekle.Location = new System.Drawing.Point(163, 477);
            this.btn_randevuekle.Name = "btn_randevuekle";
            this.btn_randevuekle.Size = new System.Drawing.Size(225, 61);
            this.btn_randevuekle.TabIndex = 42;
            this.btn_randevuekle.Text = "Teşhis Ekle - Güncelle";
            this.btn_randevuekle.UseVisualStyleBackColor = false;
            this.btn_randevuekle.Click += new System.EventHandler(this.btn_randevuekle_Click);
            // 
            // FrmRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(494, 600);
            this.Controls.Add(this.btn_randevuekle);
            this.Controls.Add(this.chkpasif);
            this.Controls.Add(this.chkaktif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRandevuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.tblHastalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRandevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoktorlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource vRandevuBindingSource;
        private System.Windows.Forms.CheckBox chkaktif;
        private System.Windows.Forms.CheckBox chkpasif;
        private System.Windows.Forms.BindingSource tblHastalarBindingSource;
        private System.Windows.Forms.BindingSource vDoktorlarBindingSource;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private System.Windows.Forms.Button btn_randevuekle;
    }
}