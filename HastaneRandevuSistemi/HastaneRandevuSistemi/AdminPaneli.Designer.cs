namespace HastaneRandevuSistemi
{
    partial class AdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            this.KlinikListBox = new System.Windows.Forms.ListBox();
            this.DoktorlarListBox = new System.Windows.Forms.ListBox();
            this.KlinikEkleButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KlinikSilButon = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KlinikTxtBox = new System.Windows.Forms.TextBox();
            this.DoktorTxtBox = new System.Windows.Forms.TextBox();
            this.DoktorSilButon = new System.Windows.Forms.Button();
            this.DoktorEkleButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RandevuSilButon = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // KlinikListBox
            // 
            this.KlinikListBox.FormattingEnabled = true;
            this.KlinikListBox.Items.AddRange(new object[] {
            "Çocuk Hastalıkları",
            "Cildiye",
            "İç Hastalıklar (Dahiliye)",
            "Kalp Ve Damar Cerrahisi"});
            this.KlinikListBox.Location = new System.Drawing.Point(201, 55);
            this.KlinikListBox.Name = "KlinikListBox";
            this.KlinikListBox.Size = new System.Drawing.Size(236, 147);
            this.KlinikListBox.TabIndex = 0;
            // 
            // DoktorlarListBox
            // 
            this.DoktorlarListBox.FormattingEnabled = true;
            this.DoktorlarListBox.Items.AddRange(new object[] {
            "Doktor Ahmet",
            "Doktor Mehmet"});
            this.DoktorlarListBox.Location = new System.Drawing.Point(810, 55);
            this.DoktorlarListBox.Name = "DoktorlarListBox";
            this.DoktorlarListBox.Size = new System.Drawing.Size(228, 147);
            this.DoktorlarListBox.TabIndex = 1;
            // 
            // KlinikEkleButon
            // 
            this.KlinikEkleButon.BackColor = System.Drawing.Color.LightGray;
            this.KlinikEkleButon.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KlinikEkleButon.Location = new System.Drawing.Point(201, 226);
            this.KlinikEkleButon.Name = "KlinikEkleButon";
            this.KlinikEkleButon.Size = new System.Drawing.Size(102, 33);
            this.KlinikEkleButon.TabIndex = 2;
            this.KlinikEkleButon.Text = "KLİNİK EKLE";
            this.KlinikEkleButon.UseVisualStyleBackColor = false;
            this.KlinikEkleButon.Click += new System.EventHandler(this.KlinikEkleButon_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(150, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "KULLANICI EKLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KlinikSilButon
            // 
            this.KlinikSilButon.BackColor = System.Drawing.Color.LightGray;
            this.KlinikSilButon.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KlinikSilButon.Location = new System.Drawing.Point(201, 277);
            this.KlinikSilButon.Name = "KlinikSilButon";
            this.KlinikSilButon.Size = new System.Drawing.Size(236, 25);
            this.KlinikSilButon.TabIndex = 4;
            this.KlinikSilButon.Text = "SEÇİLEN KLİNİĞİ SİL";
            this.KlinikSilButon.UseVisualStyleBackColor = false;
            this.KlinikSilButon.Click += new System.EventHandler(this.KlinikSilButon_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(367, 584);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "SEÇİLİ KULLANICIYI SİL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "KLİNİKLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(871, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOKTORLAR";
            // 
            // KlinikTxtBox
            // 
            this.KlinikTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KlinikTxtBox.Location = new System.Drawing.Point(319, 232);
            this.KlinikTxtBox.Name = "KlinikTxtBox";
            this.KlinikTxtBox.Size = new System.Drawing.Size(118, 20);
            this.KlinikTxtBox.TabIndex = 12;
            // 
            // DoktorTxtBox
            // 
            this.DoktorTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoktorTxtBox.Location = new System.Drawing.Point(928, 232);
            this.DoktorTxtBox.Name = "DoktorTxtBox";
            this.DoktorTxtBox.Size = new System.Drawing.Size(110, 20);
            this.DoktorTxtBox.TabIndex = 16;
            // 
            // DoktorSilButon
            // 
            this.DoktorSilButon.BackColor = System.Drawing.Color.LightGray;
            this.DoktorSilButon.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorSilButon.Location = new System.Drawing.Point(810, 277);
            this.DoktorSilButon.Name = "DoktorSilButon";
            this.DoktorSilButon.Size = new System.Drawing.Size(228, 25);
            this.DoktorSilButon.TabIndex = 15;
            this.DoktorSilButon.Text = "SEÇİLEN DOKTORU SİL";
            this.DoktorSilButon.UseVisualStyleBackColor = false;
            this.DoktorSilButon.Click += new System.EventHandler(this.DoktorSilButon_Click);
            // 
            // DoktorEkleButon
            // 
            this.DoktorEkleButon.BackColor = System.Drawing.Color.LightGray;
            this.DoktorEkleButon.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorEkleButon.Location = new System.Drawing.Point(810, 226);
            this.DoktorEkleButon.Name = "DoktorEkleButon";
            this.DoktorEkleButon.Size = new System.Drawing.Size(112, 33);
            this.DoktorEkleButon.TabIndex = 14;
            this.DoktorEkleButon.Text = "DOKTOR EKLE";
            this.DoktorEkleButon.UseVisualStyleBackColor = false;
            this.DoktorEkleButon.Click += new System.EventHandler(this.DoktorEkleButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 187);
            this.dataGridView1.TabIndex = 18;
            // 
            // RandevuSilButon
            // 
            this.RandevuSilButon.BackColor = System.Drawing.Color.LightGray;
            this.RandevuSilButon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RandevuSilButon.Location = new System.Drawing.Point(836, 583);
            this.RandevuSilButon.Name = "RandevuSilButon";
            this.RandevuSilButon.Size = new System.Drawing.Size(202, 48);
            this.RandevuSilButon.TabIndex = 19;
            this.RandevuSilButon.Text = "SEÇİLEN RANDEVUYU SİL";
            this.RandevuSilButon.UseVisualStyleBackColor = false;
            this.RandevuSilButon.Click += new System.EventHandler(this.RandevuSilButon_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(662, 379);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(510, 187);
            this.dataGridView2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(197, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "SİSTEME KAYITLI KULLANICILAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(840, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "KAYITLI RANDEVULAR";
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1227, 656);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RandevuSilButon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoktorTxtBox);
            this.Controls.Add(this.DoktorSilButon);
            this.Controls.Add(this.DoktorEkleButon);
            this.Controls.Add(this.KlinikTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KlinikSilButon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KlinikEkleButon);
            this.Controls.Add(this.DoktorlarListBox);
            this.Controls.Add(this.KlinikListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaneli";
            this.Load += new System.EventHandler(this.AdminPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox KlinikListBox;
        private System.Windows.Forms.ListBox DoktorlarListBox;
        private System.Windows.Forms.Button KlinikEkleButon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KlinikSilButon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KlinikTxtBox;
        private System.Windows.Forms.TextBox DoktorTxtBox;
        private System.Windows.Forms.Button DoktorSilButon;
        private System.Windows.Forms.Button DoktorEkleButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RandevuSilButon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}