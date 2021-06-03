namespace HastaneRandevuSistemi
{
    partial class DoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGiris));
            this.DoktorAdTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoktorSifreTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoktorGirisbuton = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // DoktorAdTxtbox
            // 
            this.DoktorAdTxtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoktorAdTxtbox.Location = new System.Drawing.Point(217, 58);
            this.DoktorAdTxtbox.Name = "DoktorAdTxtbox";
            this.DoktorAdTxtbox.Size = new System.Drawing.Size(146, 20);
            this.DoktorAdTxtbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOKTOR İSİM SOYİSİM :";
            // 
            // DoktorSifreTxtbox
            // 
            this.DoktorSifreTxtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DoktorSifreTxtbox.Location = new System.Drawing.Point(217, 113);
            this.DoktorSifreTxtbox.Name = "DoktorSifreTxtbox";
            this.DoktorSifreTxtbox.Size = new System.Drawing.Size(146, 20);
            this.DoktorSifreTxtbox.TabIndex = 16;
            this.DoktorSifreTxtbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "ŞİFRE :";
            // 
            // DoktorGirisbuton
            // 
            this.DoktorGirisbuton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorGirisbuton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoktorGirisbuton.ImageIndex = 0;
            this.DoktorGirisbuton.ImageList = this.ımageList1;
            this.DoktorGirisbuton.Location = new System.Drawing.Point(217, 152);
            this.DoktorGirisbuton.Name = "DoktorGirisbuton";
            this.DoktorGirisbuton.Size = new System.Drawing.Size(146, 48);
            this.DoktorGirisbuton.TabIndex = 17;
            this.DoktorGirisbuton.Text = "     GİRİŞ";
            this.DoktorGirisbuton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoktorGirisbuton.UseVisualStyleBackColor = true;
            this.DoktorGirisbuton.Click += new System.EventHandler(this.DoktorGirisbuton_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "enter.png");
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 259);
            this.Controls.Add(this.DoktorGirisbuton);
            this.Controls.Add(this.DoktorSifreTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoktorAdTxtbox);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DoktorAdTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DoktorSifreTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoktorGirisbuton;
        private System.Windows.Forms.ImageList ımageList1;
    }
}