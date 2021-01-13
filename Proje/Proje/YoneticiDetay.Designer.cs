namespace Proje
{
    partial class YoneticiDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiDetay));
            this.Trenler = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnereden = new System.Windows.Forms.TextBox();
            this.txtnereye = new System.Windows.Forms.TextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.ComboBox();
            this.Trenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Trenler
            // 
            this.Trenler.Controls.Add(this.dataGridView2);
            this.Trenler.Location = new System.Drawing.Point(349, 42);
            this.Trenler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Trenler.Name = "Trenler";
            this.Trenler.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Trenler.Size = new System.Drawing.Size(359, 326);
            this.Trenler.TabIndex = 0;
            this.Trenler.TabStop = false;
            this.Trenler.Text = "Tren Bilgileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 17);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(355, 307);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(239, 402);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(81, 30);
            this.btngüncelle.TabIndex = 2;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(650, 454);
            this.btncikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(98, 30);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbladsoyad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbltc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(275, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetici Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(115, 63);
            this.lbladsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(60, 17);
            this.lbladsoyad.TabIndex = 8;
            this.lbladsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "AD SOYAD :";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(115, 26);
            this.lbltc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(96, 17);
            this.lbltc.TabIndex = 6;
            this.lbltc.Text = "00000000000";
            this.lbltc.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tren No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nereden :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nereye :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tarih :";
            // 
            // txtnereden
            // 
            this.txtnereden.Location = new System.Drawing.Point(130, 214);
            this.txtnereden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnereden.Name = "txtnereden";
            this.txtnereden.Size = new System.Drawing.Size(90, 22);
            this.txtnereden.TabIndex = 12;
            // 
            // txtnereye
            // 
            this.txtnereye.Location = new System.Drawing.Point(130, 246);
            this.txtnereye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnereye.Name = "txtnereye";
            this.txtnereye.Size = new System.Drawing.Size(90, 22);
            this.txtnereye.TabIndex = 13;
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(130, 274);
            this.msktarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(90, 22);
            this.msktarih.TabIndex = 15;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(130, 310);
            this.msksaat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msksaat.Mask = "90:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(90, 22);
            this.msksaat.TabIndex = 17;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saat :";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsil.Location = new System.Drawing.Point(147, 402);
            this.btnsil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(78, 30);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tren Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 344);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 22);
            this.txtid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tren ID :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtno
            // 
            this.txtno.FormattingEnabled = true;
            this.txtno.Location = new System.Drawing.Point(130, 182);
            this.txtno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(90, 24);
            this.txtno.TabIndex = 23;
            this.txtno.DropDown += new System.EventHandler(this.txtno_DropDown);
            this.txtno.SelectedIndexChanged += new System.EventHandler(this.txtno_SelectedIndexChanged);
            // 
            // YoneticiDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 494);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.msksaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msktarih);
            this.Controls.Add(this.txtnereye);
            this.Controls.Add(this.txtnereden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.Trenler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YoneticiDetay";
            this.Text = " Yönetici Detay";
            this.Load += new System.EventHandler(this.YoneticiDetay_Load);
            this.Shown += new System.EventHandler(this.YoneticiDetay_Shown);
            this.Enter += new System.EventHandler(this.YoneticiDetay_Enter);
            this.Trenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Trenler;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnereden;
        private System.Windows.Forms.TextBox txtnereye;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtno;
    }
}