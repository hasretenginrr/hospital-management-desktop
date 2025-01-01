namespace ilk
{
    partial class FrmTeşhisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeşhisler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxsikayet = new System.Windows.Forms.RichTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnilacekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblilaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblKayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet2 = new ilk.HastaneProjeDataSet2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxsteshis = new System.Windows.Forms.RichTextBox();
            this.tblilaclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vIlaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilacAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilaclarBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilaclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIlaclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbxsikayet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 381);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(77, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastanın Şikayetini Yazınız.";
            // 
            // txtbxsikayet
            // 
            this.txtbxsikayet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtbxsikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxsikayet.Location = new System.Drawing.Point(0, 0);
            this.txtbxsikayet.Name = "txtbxsikayet";
            this.txtbxsikayet.Size = new System.Drawing.Size(462, 381);
            this.txtbxsikayet.TabIndex = 1;
            this.txtbxsikayet.Text = "";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kaydet.Location = new System.Drawing.Point(12, 399);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(196, 72);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.btn_kaydet);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 743);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "İsim Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "null";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.btnilacekle);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(989, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 743);
            this.panel3.TabIndex = 2;
            // 
            // btnilacekle
            // 
            this.btnilacekle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnilacekle.Location = new System.Drawing.Point(303, 202);
            this.btnilacekle.Name = "btnilacekle";
            this.btnilacekle.Size = new System.Drawing.Size(134, 36);
            this.btnilacekle.TabIndex = 2;
            this.btnilacekle.Text = "Ekle";
            this.btnilacekle.UseVisualStyleBackColor = false;
            this.btnilacekle.Click += new System.EventHandler(this.btnilacekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "İlaç:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblilaclarBindingSource;
            this.comboBox1.DisplayMember = "ilacAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 36);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ilacid";
            // 
            // tblilaclarBindingSource
            // 
            this.tblilaclarBindingSource.DataSource = typeof(ilk.Tbl_ilaclar);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(486, 471);
            this.panel6.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitid,
            this.ilacAd});
            this.dataGridView1.DataSource = this.vIlaclarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblKayitlarBindingSource
            // 
            this.tblKayitlarBindingSource.DataSource = typeof(ilk.Tbl_Kayitlar);
            // 
            // hastaneProjeDataSet2
            // 
            this.hastaneProjeDataSet2.DataSetName = "HastaneProjeDataSet2";
            this.hastaneProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(462, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 743);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtbxsteshis);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 381);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(108, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = " Hastanın Teşhisini Yazınız.";
            // 
            // txtbxsteshis
            // 
            this.txtbxsteshis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtbxsteshis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxsteshis.Location = new System.Drawing.Point(0, 0);
            this.txtbxsteshis.Name = "txtbxsteshis";
            this.txtbxsteshis.Size = new System.Drawing.Size(525, 379);
            this.txtbxsteshis.TabIndex = 1;
            this.txtbxsteshis.Text = "";
            // 
            // tblilaclarBindingSource1
            // 
            this.tblilaclarBindingSource1.DataSource = typeof(ilk.Tbl_ilaclar);
            // 
            // vIlaclarBindingSource
            // 
            this.vIlaclarBindingSource.DataSource = typeof(ilk.vIlaclar);
            // 
            // kayitid
            // 
            this.kayitid.DataPropertyName = "kayitid";
            this.kayitid.HeaderText = "kayitid";
            this.kayitid.MinimumWidth = 6;
            this.kayitid.Name = "kayitid";
            this.kayitid.Width = 125;
            // 
            // ilacAd
            // 
            this.ilacAd.DataPropertyName = "ilacAd";
            this.ilacAd.HeaderText = "ilacAd";
            this.ilacAd.MinimumWidth = 6;
            this.ilacAd.Name = "ilacAd";
            this.ilacAd.Width = 125;
            // 
            // FrmTeşhisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1475, 743);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTeşhisler";
            this.Text = "FrmTeşhisler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTeşhisler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilaclarBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilaclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIlaclarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtbxsikayet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txtbxsteshis;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private HastaneProjeDataSet2 hastaneProjeDataSet2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource tblilaclarBindingSource;
        private System.Windows.Forms.Button btnilacekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblKayitlarBindingSource;
        private System.Windows.Forms.BindingSource tblilaclarBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacAd;
        private System.Windows.Forms.BindingSource vIlaclarBindingSource;
    }
}