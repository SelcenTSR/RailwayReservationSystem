namespace Proje
{
    partial class YolcuSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YolcuSistemi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblid = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbltrenbilgiid = new System.Windows.Forms.Label();
            this.vagon = new System.Windows.Forms.Label();
            this.koltuk = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(303, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(438, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbladsoyad);
            this.groupBox2.Controls.Add(this.lbltc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(101, 147);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(100, 17);
            this.lbltel.TabIndex = 15;
            this.lbltel.Text = "000 000 00 00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon :";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(101, 99);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(60, 17);
            this.lbladsoyad.TabIndex = 13;
            this.lbladsoyad.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(101, 46);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(96, 17);
            this.lbltc.TabIndex = 12;
            this.lbltc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bilet Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bilet Al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(134, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgileri Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblid.Location = new System.Drawing.Point(753, 55);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(33, 17);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "lblid";
            this.lblid.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(753, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 17);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "lbltc";
            this.lbl.Visible = false;
            // 
            // lbltrenbilgiid
            // 
            this.lbltrenbilgiid.AutoSize = true;
            this.lbltrenbilgiid.Location = new System.Drawing.Point(753, 118);
            this.lbltrenbilgiid.Name = "lbltrenbilgiid";
            this.lbltrenbilgiid.Size = new System.Drawing.Size(83, 17);
            this.lbltrenbilgiid.TabIndex = 9;
            this.lbltrenbilgiid.Text = "lbltrenbilgiid";
            this.lbltrenbilgiid.Visible = false;
            // 
            // vagon
            // 
            this.vagon.AutoSize = true;
            this.vagon.Location = new System.Drawing.Point(753, 150);
            this.vagon.Name = "vagon";
            this.vagon.Size = new System.Drawing.Size(47, 17);
            this.vagon.TabIndex = 10;
            this.vagon.Text = "vagon";
            this.vagon.Visible = false;
            // 
            // koltuk
            // 
            this.koltuk.AutoSize = true;
            this.koltuk.Location = new System.Drawing.Point(753, 185);
            this.koltuk.Name = "koltuk";
            this.koltuk.Size = new System.Drawing.Size(45, 17);
            this.koltuk.TabIndex = 11;
            this.koltuk.Text = "koltuk";
            this.koltuk.Visible = false;
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(748, 381);
            this.btncikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(98, 30);
            this.btncikis.TabIndex = 36;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // YolcuSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 422);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.koltuk);
            this.Controls.Add(this.vagon);
            this.Controls.Add(this.lbltrenbilgiid);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YolcuSistemi";
            this.Text = "Yolcu Sistemi";
            this.Load += new System.EventHandler(this.YolcuSistemi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbltrenbilgiid;
        private System.Windows.Forms.Label vagon;
        private System.Windows.Forms.Label koltuk;
        private System.Windows.Forms.Button btncikis;
    }
}