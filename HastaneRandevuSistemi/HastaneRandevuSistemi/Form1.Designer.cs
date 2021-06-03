namespace HastaneRandevuSistemi
{
    partial class AnaGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGirisSayfasi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTxtbox = new System.Windows.Forms.TextBox();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.GirisButon = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UyeKayitButon = new System.Windows.Forms.Button();
            this.AdminGirisButon = new System.Windows.Forms.Button();
            this.DoktorGirisAnaButon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tarihlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "                      HASTANE  RANDEVU  SİSTEMİ                       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C KİMLİK NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(141, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE :";
            // 
            // tcTxtbox
            // 
            this.tcTxtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tcTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTxtbox.Location = new System.Drawing.Point(243, 318);
            this.tcTxtbox.MaxLength = 11;
            this.tcTxtbox.Name = "tcTxtbox";
            this.tcTxtbox.Size = new System.Drawing.Size(192, 26);
            this.tcTxtbox.TabIndex = 4;
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sifreTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxtbox.Location = new System.Drawing.Point(243, 373);
            this.sifreTxtbox.MaxLength = 11;
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(192, 26);
            this.sifreTxtbox.TabIndex = 5;
            this.sifreTxtbox.UseSystemPasswordChar = true;
            // 
            // GirisButon
            // 
            this.GirisButon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GirisButon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButon.ForeColor = System.Drawing.Color.Black;
            this.GirisButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GirisButon.ImageIndex = 0;
            this.GirisButon.ImageList = this.ımageList1;
            this.GirisButon.Location = new System.Drawing.Point(479, 251);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(192, 49);
            this.GirisButon.TabIndex = 7;
            this.GirisButon.Text = "SİSTEME GİRİŞ";
            this.GirisButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GirisButon.UseVisualStyleBackColor = false;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "enter.png");
            this.ımageList1.Images.SetKeyName(1, "clipboard.png");
            this.ımageList1.Images.SetKeyName(2, "settings.png");
            this.ımageList1.Images.SetKeyName(3, "stethoscope.png");
            // 
            // UyeKayitButon
            // 
            this.UyeKayitButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UyeKayitButon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UyeKayitButon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeKayitButon.ForeColor = System.Drawing.Color.Black;
            this.UyeKayitButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UyeKayitButon.ImageIndex = 1;
            this.UyeKayitButon.ImageList = this.ımageList1;
            this.UyeKayitButon.Location = new System.Drawing.Point(479, 306);
            this.UyeKayitButon.Name = "UyeKayitButon";
            this.UyeKayitButon.Size = new System.Drawing.Size(192, 49);
            this.UyeKayitButon.TabIndex = 8;
            this.UyeKayitButon.Text = "SİSTEME ÜYE OL";
            this.UyeKayitButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UyeKayitButon.UseVisualStyleBackColor = false;
            this.UyeKayitButon.Click += new System.EventHandler(this.UyeKayitButon_Click);
            // 
            // AdminGirisButon
            // 
            this.AdminGirisButon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AdminGirisButon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminGirisButon.ForeColor = System.Drawing.Color.Black;
            this.AdminGirisButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminGirisButon.ImageIndex = 2;
            this.AdminGirisButon.ImageList = this.ımageList1;
            this.AdminGirisButon.Location = new System.Drawing.Point(479, 361);
            this.AdminGirisButon.Name = "AdminGirisButon";
            this.AdminGirisButon.Size = new System.Drawing.Size(192, 49);
            this.AdminGirisButon.TabIndex = 9;
            this.AdminGirisButon.Text = "ADMİN GİRİŞ";
            this.AdminGirisButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminGirisButon.UseVisualStyleBackColor = false;
            this.AdminGirisButon.Click += new System.EventHandler(this.AdminGirisButon_Click);
            // 
            // DoktorGirisAnaButon
            // 
            this.DoktorGirisAnaButon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoktorGirisAnaButon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorGirisAnaButon.ForeColor = System.Drawing.Color.Black;
            this.DoktorGirisAnaButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoktorGirisAnaButon.ImageIndex = 3;
            this.DoktorGirisAnaButon.ImageList = this.ımageList1;
            this.DoktorGirisAnaButon.Location = new System.Drawing.Point(479, 416);
            this.DoktorGirisAnaButon.Name = "DoktorGirisAnaButon";
            this.DoktorGirisAnaButon.Size = new System.Drawing.Size(192, 49);
            this.DoktorGirisAnaButon.TabIndex = 10;
            this.DoktorGirisAnaButon.Text = "DOKTOR GİRİŞ";
            this.DoktorGirisAnaButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoktorGirisAnaButon.UseVisualStyleBackColor = false;
            this.DoktorGirisAnaButon.Click += new System.EventHandler(this.DoktorGirisAnaButon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihlabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tarihlabel
            // 
            this.tarihlabel.Name = "tarihlabel";
            this.tarihlabel.Size = new System.Drawing.Size(16, 17);
            this.tarihlabel.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(462, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(202, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Copyright © 2021 Fatih Mehmet Sağır Tüm hakları saklıdır.";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AnaGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DoktorGirisAnaButon);
            this.Controls.Add(this.AdminGirisButon);
            this.Controls.Add(this.UyeKayitButon);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.tcTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AnaGirisSayfasi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTANE RANDEVU SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcTxtbox;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.Button UyeKayitButon;
        private System.Windows.Forms.Button AdminGirisButon;
        private System.Windows.Forms.Button DoktorGirisAnaButon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tarihlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}

