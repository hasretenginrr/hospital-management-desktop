namespace ilk
{
    partial class FrmDoktorEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.tblBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txttc = new System.Windows.Forms.MaskedTextBox();
            this.txtsfre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbxcalisiyor = new System.Windows.Forms.RadioButton();
            this.chkbxcalismiyor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = " Ad Soyad: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // cmbbrans
            // 
            this.cmbbrans.DataSource = this.tblBranslarBindingSource;
            this.cmbbrans.DisplayMember = "BransAd";
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(187, 97);
            this.cmbbrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(163, 36);
            this.cmbbrans.TabIndex = 2;
            this.cmbbrans.ValueMember = "Bransid";
            // 
            // tblBranslarBindingSource
            // 
            this.tblBranslarBindingSource.DataSource = typeof(ilk.Tbl_Branslar);
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(187, 45);
            this.txtDoktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(163, 36);
            this.txtDoktor.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(187, 154);
            this.txttc.Mask = "00000000000";
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(163, 36);
            this.txttc.TabIndex = 8;
            this.txttc.ValidatingType = typeof(int);
            // 
            // txtsfre
            // 
            this.txtsfre.Location = new System.Drawing.Point(187, 212);
            this.txtsfre.Mask = "00000";
            this.txtsfre.Name = "txtsfre";
            this.txtsfre.Size = new System.Drawing.Size(163, 36);
            this.txtsfre.TabIndex = 9;
            this.txtsfre.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Durum:";
            // 
            // chkbxcalisiyor
            // 
            this.chkbxcalisiyor.AutoSize = true;
            this.chkbxcalisiyor.Location = new System.Drawing.Point(177, 268);
            this.chkbxcalisiyor.Name = "chkbxcalisiyor";
            this.chkbxcalisiyor.Size = new System.Drawing.Size(114, 32);
            this.chkbxcalisiyor.TabIndex = 13;
            this.chkbxcalisiyor.TabStop = true;
            this.chkbxcalisiyor.Text = "Çalışıyor";
            this.chkbxcalisiyor.UseVisualStyleBackColor = true;
            // 
            // chkbxcalismiyor
            // 
            this.chkbxcalismiyor.AutoSize = true;
            this.chkbxcalismiyor.Location = new System.Drawing.Point(297, 268);
            this.chkbxcalismiyor.Name = "chkbxcalismiyor";
            this.chkbxcalismiyor.Size = new System.Drawing.Size(133, 32);
            this.chkbxcalismiyor.TabIndex = 14;
            this.chkbxcalismiyor.TabStop = true;
            this.chkbxcalismiyor.Text = "Çalışmıyor";
            this.chkbxcalismiyor.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 485);
            this.Controls.Add(this.chkbxcalismiyor);
            this.Controls.Add(this.chkbxcalisiyor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsfre);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtDoktor);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBranslarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.BindingSource tblBranslarBindingSource;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.MaskedTextBox txttc;
        private System.Windows.Forms.MaskedTextBox txtsfre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chkbxcalisiyor;
        private System.Windows.Forms.RadioButton chkbxcalismiyor;
    }
}