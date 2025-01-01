namespace ilk
{
    partial class FrmRandevuListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet1 = new ilk.HastaneProjeDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkayitsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.tbl_RandevularTableAdapter = new ilk.HastaneProjeDataSet1TableAdapters.Tbl_RandevularTableAdapter();
            this.hastaneProjeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BransAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HastaSikayet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTeshis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRandevuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 726);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.HastaAdSoyad,
            this.DoktorAdSoyad,
            this.BransAd,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.randevuDurumDataGridViewCheckBoxColumn,
            this.HastaSikayet,
            this.HastaTeshis});
            this.dataGridView1.DataSource = this.vRandevuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1583, 726);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // tblRandevularBindingSource
            // 
            this.tblRandevularBindingSource.DataMember = "Tbl_Randevular";
            this.tblRandevularBindingSource.DataSource = this.hastaneProjeDataSet1;
            // 
            // hastaneProjeDataSet1
            // 
            this.hastaneProjeDataSet1.DataSetName = "HastaneProjeDataSet1";
            this.hastaneProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnkayitsil);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnKayitEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1583, 166);
            this.panel2.TabIndex = 1;
            // 
            // btnkayitsil
            // 
            this.btnkayitsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkayitsil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnkayitsil.Location = new System.Drawing.Point(290, 73);
            this.btnkayitsil.Name = "btnkayitsil";
            this.btnkayitsil.Size = new System.Drawing.Size(175, 60);
            this.btnkayitsil.TabIndex = 3;
            this.btnkayitsil.Text = "Kayit Sil";
            this.btnkayitsil.UseVisualStyleBackColor = false;
            this.btnkayitsil.Click += new System.EventHandler(this.btnkayitsil_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Düzenlemek istediğiniz Kaydın üzerine çift tıklayınız!";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKayitEkle.Location = new System.Drawing.Point(72, 73);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(161, 60);
            this.btnKayitEkle.TabIndex = 0;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = false;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // tbl_RandevularTableAdapter
            // 
            this.tbl_RandevularTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneProjeDataSet1BindingSource
            // 
            this.hastaneProjeDataSet1BindingSource.DataSource = this.hastaneProjeDataSet1;
            this.hastaneProjeDataSet1BindingSource.Position = 0;
            // 
            // vRandevuBindingSource
            // 
            this.vRandevuBindingSource.DataSource = typeof(ilk.vRandevu);
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuidDataGridViewTextBoxColumn.Width = 142;
            // 
            // HastaAdSoyad
            // 
            this.HastaAdSoyad.DataPropertyName = "HastaAdSoyad";
            this.HastaAdSoyad.HeaderText = "HastaAdSoyad";
            this.HastaAdSoyad.MinimumWidth = 6;
            this.HastaAdSoyad.Name = "HastaAdSoyad";
            this.HastaAdSoyad.Width = 178;
            // 
            // DoktorAdSoyad
            // 
            this.DoktorAdSoyad.DataPropertyName = "DoktorAdSoyad";
            this.DoktorAdSoyad.HeaderText = "DoktorAdSoyad";
            this.DoktorAdSoyad.MinimumWidth = 6;
            this.DoktorAdSoyad.Name = "DoktorAdSoyad";
            this.DoktorAdSoyad.Width = 190;
            // 
            // BransAd
            // 
            this.BransAd.DataPropertyName = "BransAd";
            this.BransAd.HeaderText = "BransAd";
            this.BransAd.MinimumWidth = 6;
            this.BransAd.Name = "BransAd";
            this.BransAd.Width = 119;
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            this.randevuTarihDataGridViewTextBoxColumn.Width = 170;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.Width = 165;
            // 
            // randevuDurumDataGridViewCheckBoxColumn
            // 
            this.randevuDurumDataGridViewCheckBoxColumn.DataPropertyName = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.HeaderText = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.randevuDurumDataGridViewCheckBoxColumn.Name = "randevuDurumDataGridViewCheckBoxColumn";
            this.randevuDurumDataGridViewCheckBoxColumn.Width = 167;
            // 
            // HastaSikayet
            // 
            this.HastaSikayet.DataPropertyName = "HastaSikayet";
            this.HastaSikayet.HeaderText = "HastaSikayet";
            this.HastaSikayet.MinimumWidth = 6;
            this.HastaSikayet.Name = "HastaSikayet";
            this.HastaSikayet.Width = 165;
            // 
            // HastaTeshis
            // 
            this.HastaTeshis.DataPropertyName = "HastaTeshis";
            this.HastaTeshis.HeaderText = "HastaTeshis";
            this.HastaTeshis.MinimumWidth = 6;
            this.HastaTeshis.Name = "HastaTeshis";
            this.HastaTeshis.Width = 152;
            // 
            // FrmRandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1583, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRandevuListe";
            this.Text = "FrmRandevuListe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRandevuListe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRandevuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Label label1;
        private HastaneProjeDataSet1 hastaneProjeDataSet1;
        private System.Windows.Forms.BindingSource tblRandevularBindingSource;
        private HastaneProjeDataSet1TableAdapters.Tbl_RandevularTableAdapter tbl_RandevularTableAdapter;
        private System.Windows.Forms.BindingSource hastaneProjeDataSet1BindingSource;
        private System.Windows.Forms.BindingSource vRandevuBindingSource;
        private System.Windows.Forms.Button btnkayitsil;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BransAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevuDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSikayet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTeshis;
    }
}