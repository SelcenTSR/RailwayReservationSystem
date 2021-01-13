namespace Proje
{
    partial class YolcuGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YolcuGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YolcuSifre = new System.Windows.Forms.TextBox();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.linkUye = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // YolcuSifre
            // 
            this.YolcuSifre.Location = new System.Drawing.Point(157, 154);
            this.YolcuSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YolcuSifre.Name = "YolcuSifre";
            this.YolcuSifre.Size = new System.Drawing.Size(109, 22);
            this.YolcuSifre.TabIndex = 2;
            this.YolcuSifre.UseSystemPasswordChar = true;
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(157, 114);
            this.mskdTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdTc.Mask = "00000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(109, 22);
            this.mskdTc.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(199, 194);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(67, 26);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // linkUye
            // 
            this.linkUye.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkUye.AutoSize = true;
            this.linkUye.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkUye.Location = new System.Drawing.Point(216, 233);
            this.linkUye.Name = "linkUye";
            this.linkUye.Size = new System.Drawing.Size(51, 17);
            this.linkUye.TabIndex = 1;
            this.linkUye.TabStop = true;
            this.linkUye.Text = "Üye Ol";
            this.linkUye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUye_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yolcu Giriş Paneli";
            // 
            // YolcuGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkUye);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.YolcuSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "YolcuGiris";
            this.Text = "Yolcu Girişi";
            this.Load += new System.EventHandler(this.YolcuGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YolcuSifre;
        private System.Windows.Forms.MaskedTextBox mskdTc;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel linkUye;
        private System.Windows.Forms.Label label3;
    }
}