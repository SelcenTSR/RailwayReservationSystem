namespace Proje
{
    partial class BiletAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletAlma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbvagon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbkoltuk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbtarih = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsaat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.cmbnereden = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbvagon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbkoltuk);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbtarih);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbsaat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbnereye);
            this.groupBox2.Controls.Add(this.cmbnereden);
            this.groupBox2.Location = new System.Drawing.Point(8, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(839, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vagon :";
            // 
            // cmbvagon
            // 
            this.cmbvagon.FormattingEnabled = true;
            this.cmbvagon.Location = new System.Drawing.Point(677, 66);
            this.cmbvagon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbvagon.Name = "cmbvagon";
            this.cmbvagon.Size = new System.Drawing.Size(132, 24);
            this.cmbvagon.TabIndex = 8;
            this.cmbvagon.SelectedIndexChanged += new System.EventHandler(this.cmbvagon_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Koltuk :";
            // 
            // cmbkoltuk
            // 
            this.cmbkoltuk.FormattingEnabled = true;
            this.cmbkoltuk.Location = new System.Drawing.Point(677, 102);
            this.cmbkoltuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbkoltuk.Name = "cmbkoltuk";
            this.cmbkoltuk.Size = new System.Drawing.Size(132, 24);
            this.cmbkoltuk.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tarih :";
            // 
            // cmbtarih
            // 
            this.cmbtarih.FormattingEnabled = true;
            this.cmbtarih.Location = new System.Drawing.Point(382, 62);
            this.cmbtarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtarih.Name = "cmbtarih";
            this.cmbtarih.Size = new System.Drawing.Size(132, 24);
            this.cmbtarih.TabIndex = 6;
            this.cmbtarih.SelectedIndexChanged += new System.EventHandler(this.cmbtarih_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saat :";
            // 
            // cmbsaat
            // 
            this.cmbsaat.FormattingEnabled = true;
            this.cmbsaat.Location = new System.Drawing.Point(382, 106);
            this.cmbsaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbsaat.Name = "cmbsaat";
            this.cmbsaat.Size = new System.Drawing.Size(132, 24);
            this.cmbsaat.TabIndex = 4;
            this.cmbsaat.SelectedIndexChanged += new System.EventHandler(this.cmbsaat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nereye :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nereden :";
            // 
            // cmbnereye
            // 
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Location = new System.Drawing.Point(111, 100);
            this.cmbnereye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(132, 24);
            this.cmbnereye.TabIndex = 1;
            this.cmbnereye.SelectedIndexChanged += new System.EventHandler(this.cmbnereye_SelectedIndexChanged);
            // 
            // cmbnereden
            // 
            this.cmbnereden.FormattingEnabled = true;
            this.cmbnereden.Location = new System.Drawing.Point(111, 60);
            this.cmbnereden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbnereden.Name = "cmbnereden";
            this.cmbnereden.Size = new System.Drawing.Size(132, 24);
            this.cmbnereden.TabIndex = 0;
            this.cmbnereden.SelectedIndexChanged += new System.EventHandler(this.cmbnereden_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(839, 249);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vagon";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Bilet Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BiletAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BiletAlma";
            this.Text = "Bilet Alma";
            this.Load += new System.EventHandler(this.BiletAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbnereye;
        private System.Windows.Forms.ComboBox cmbnereden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbtarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbkoltuk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbvagon;
        private System.Windows.Forms.Button button2;
    }
}