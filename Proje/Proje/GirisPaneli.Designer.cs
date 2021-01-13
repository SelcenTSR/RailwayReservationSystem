namespace Proje
{
    partial class GirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnYolcuGirisi = new System.Windows.Forms.Button();
            this.BtnYoneticiGirisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCalisanGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnYolcuGirisi
            // 
            this.BtnYolcuGirisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnYolcuGirisi.Location = new System.Drawing.Point(41, 292);
            this.BtnYolcuGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnYolcuGirisi.Name = "BtnYolcuGirisi";
            this.BtnYolcuGirisi.Size = new System.Drawing.Size(112, 34);
            this.BtnYolcuGirisi.TabIndex = 1;
            this.BtnYolcuGirisi.Text = "Yolcu Girişi";
            this.BtnYolcuGirisi.UseVisualStyleBackColor = false;
            this.BtnYolcuGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // BtnYoneticiGirisi
            // 
            this.BtnYoneticiGirisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnYoneticiGirisi.Location = new System.Drawing.Point(408, 292);
            this.BtnYoneticiGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnYoneticiGirisi.Name = "BtnYoneticiGirisi";
            this.BtnYoneticiGirisi.Size = new System.Drawing.Size(112, 34);
            this.BtnYoneticiGirisi.TabIndex = 2;
            this.BtnYoneticiGirisi.Text = "Yönetici Girişi";
            this.BtnYoneticiGirisi.UseVisualStyleBackColor = false;
            this.BtnYoneticiGirisi.Click += new System.EventHandler(this.BtnYoneticiGirisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnCalisanGirisi
            // 
            this.BtnCalisanGirisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCalisanGirisi.Location = new System.Drawing.Point(226, 292);
            this.BtnCalisanGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCalisanGirisi.Name = "BtnCalisanGirisi";
            this.BtnCalisanGirisi.Size = new System.Drawing.Size(112, 34);
            this.BtnCalisanGirisi.TabIndex = 4;
            this.BtnCalisanGirisi.Text = "Çalışan Girişi";
            this.BtnCalisanGirisi.UseVisualStyleBackColor = false;
            this.BtnCalisanGirisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 355);
            this.Controls.Add(this.BtnCalisanGirisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnYoneticiGirisi);
            this.Controls.Add(this.BtnYolcuGirisi);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GirisPaneli";
            this.Text = "Tren Otomasyon Sistemi ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnYolcuGirisi;
        private System.Windows.Forms.Button BtnYoneticiGirisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCalisanGirisi;
    }
}

