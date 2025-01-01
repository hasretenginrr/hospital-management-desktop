namespace ilk
{
    partial class FrmHastaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaEkle));
            this.txtadHasta = new System.Windows.Forms.TextBox();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.radiokadin = new System.Windows.Forms.RadioButton();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txttchasta = new System.Windows.Forms.MaskedTextBox();
            this.txtsifrehasta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtadHasta
            // 
            this.txtadHasta.Location = new System.Drawing.Point(201, 129);
            this.txtadHasta.Name = "txtadHasta";
            this.txtadHasta.Size = new System.Drawing.Size(174, 36);
            this.txtadHasta.TabIndex = 6;
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.Location = new System.Drawing.Point(200, 432);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(148, 56);
            this.btnEkleGuncelle.TabIndex = 13;
            this.btnEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = " Ad Soyad: ";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(200, 180);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(175, 36);
            this.msktel.TabIndex = 8;
            // 
            // radiokadin
            // 
            this.radiokadin.AutoSize = true;
            this.radiokadin.Location = new System.Drawing.Point(204, 364);
            this.radiokadin.Name = "radiokadin";
            this.radiokadin.Size = new System.Drawing.Size(87, 32);
            this.radiokadin.TabIndex = 11;
            this.radiokadin.TabStop = true;
            this.radiokadin.Text = "Kadın";
            this.radiokadin.UseVisualStyleBackColor = true;
            // 
            // radioerkek
            // 
            this.radioerkek.AutoSize = true;
            this.radioerkek.Location = new System.Drawing.Point(293, 364);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(85, 32);
            this.radioerkek.TabIndex = 12;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "Erkek";
            this.radioerkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cinsiyet:";
            // 
            // txttchasta
            // 
            this.txttchasta.Location = new System.Drawing.Point(200, 241);
            this.txttchasta.Mask = "00000000000";
            this.txttchasta.Name = "txttchasta";
            this.txttchasta.Size = new System.Drawing.Size(174, 36);
            this.txttchasta.TabIndex = 9;
            this.txttchasta.ValidatingType = typeof(int);
            // 
            // txtsifrehasta
            // 
            this.txtsifrehasta.Location = new System.Drawing.Point(204, 302);
            this.txtsifrehasta.Mask = "00000";
            this.txtsifrehasta.Name = "txtsifrehasta";
            this.txtsifrehasta.Size = new System.Drawing.Size(170, 36);
            this.txtsifrehasta.TabIndex = 21;
            this.txtsifrehasta.ValidatingType = typeof(int);
            // 
            // FrmHastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(532, 570);
            this.Controls.Add(this.txtsifrehasta);
            this.Controls.Add(this.txttchasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioerkek);
            this.Controls.Add(this.radiokadin);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadHasta);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadHasta;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.RadioButton radiokadin;
        private System.Windows.Forms.RadioButton radioerkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txttchasta;
        private System.Windows.Forms.MaskedTextBox txtsifrehasta;
    }
}