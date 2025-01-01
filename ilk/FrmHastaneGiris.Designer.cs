namespace ilk
{
    partial class FrmHastaneGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaneGiris));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doktor Ekle - Güncelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Randevu Ekle - Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Ekle - Güncelle";
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnRandevuEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRandevuEkle.BackgroundImage")));
            this.btnRandevuEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuEkle.Location = new System.Drawing.Point(720, 189);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(249, 207);
            this.btnRandevuEkle.TabIndex = 2;
            this.btnRandevuEkle.UseVisualStyleBackColor = false;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnHastaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaEkle.Image")));
            this.btnHastaEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaEkle.Location = new System.Drawing.Point(84, 189);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(249, 207);
            this.btnHastaEkle.TabIndex = 1;
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnDoktorEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorEkle.Image")));
            this.btnDoktorEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoktorEkle.Location = new System.Drawing.Point(400, 189);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(249, 207);
            this.btnDoktorEkle.TabIndex = 0;
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // FrmHastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1088, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRandevuEkle);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoktorEkle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmHastaneGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaneGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}