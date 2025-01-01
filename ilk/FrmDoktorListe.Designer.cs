namespace ilk
{
    partial class FrmDoktorListe
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorListe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuaneSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new ilk.HastaneProjeDataSetTableAdapters.TableAdapterManager();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoktorlarBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 647);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktoridDataGridViewTextBoxColumn,
            this.DoktorAdSoyad,
            this.bransAdDataGridViewTextBoxColumn,
            this.MuaneSayisi,
            this.doktorTcDataGridViewTextBoxColumn,
            this.doktorSifreDataGridViewTextBoxColumn,
            this.DoktorDurum});
            this.dataGridView1.DataSource = this.vDoktorlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1619, 647);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            this.doktoridDataGridViewTextBoxColumn.Width = 125;
            // 
            // DoktorAdSoyad
            // 
            this.DoktorAdSoyad.DataPropertyName = "DoktorAdSoyad";
            this.DoktorAdSoyad.HeaderText = "DoktorAdSoyad";
            this.DoktorAdSoyad.MinimumWidth = 6;
            this.DoktorAdSoyad.Name = "DoktorAdSoyad";
            this.DoktorAdSoyad.Width = 190;
            // 
            // bransAdDataGridViewTextBoxColumn
            // 
            this.bransAdDataGridViewTextBoxColumn.DataPropertyName = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.HeaderText = "BransAd";
            this.bransAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransAdDataGridViewTextBoxColumn.Name = "bransAdDataGridViewTextBoxColumn";
            this.bransAdDataGridViewTextBoxColumn.Width = 119;
            // 
            // MuaneSayisi
            // 
            this.MuaneSayisi.DataPropertyName = "MuaneSayisi";
            this.MuaneSayisi.HeaderText = "MuaneSayisi";
            this.MuaneSayisi.MinimumWidth = 6;
            this.MuaneSayisi.Name = "MuaneSayisi";
            this.MuaneSayisi.Width = 162;
            // 
            // doktorTcDataGridViewTextBoxColumn
            // 
            this.doktorTcDataGridViewTextBoxColumn.DataPropertyName = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.HeaderText = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTcDataGridViewTextBoxColumn.Name = "doktorTcDataGridViewTextBoxColumn";
            this.doktorTcDataGridViewTextBoxColumn.Width = 126;
            // 
            // doktorSifreDataGridViewTextBoxColumn
            // 
            this.doktorSifreDataGridViewTextBoxColumn.DataPropertyName = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.HeaderText = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorSifreDataGridViewTextBoxColumn.Name = "doktorSifreDataGridViewTextBoxColumn";
            this.doktorSifreDataGridViewTextBoxColumn.Width = 151;
            // 
            // DoktorDurum
            // 
            this.DoktorDurum.DataPropertyName = "DoktorDurum";
            this.DoktorDurum.HeaderText = "DoktorDurum";
            this.DoktorDurum.MinimumWidth = 6;
            this.DoktorDurum.Name = "DoktorDurum";
            this.DoktorDurum.Width = 173;
            // 
            // vDoktorlarBindingSource
            // 
            this.vDoktorlarBindingSource.DataSource = typeof(ilk.vDoktorlar);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1619, 136);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Düzenlemek istediğiniz Kaydın üzerine çift tıklayınız!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(42, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(701, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Tbl_BranslarTableAdapter = null;
            this.tableAdapterManager1.Tbl_DoktorlarTableAdapter = null;
            this.tableAdapterManager1.Tbl_HastalarTableAdapter = null;
            this.tableAdapterManager1.Tbl_RandevularTableAdapter = null;
            this.tableAdapterManager1.Tbl_SekreterTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ilk.HastaneProjeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataSource = typeof(ilk.Tbl_Doktorlar);
            // 
            // FrmDoktorListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1619, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoktorlarBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private System.Windows.Forms.BindingSource vDoktorlarBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private HastaneProjeDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuaneSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorDurum;
    }
}

