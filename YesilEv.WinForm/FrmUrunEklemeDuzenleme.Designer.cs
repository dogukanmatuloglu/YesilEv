namespace YesilEv.WinForm
{
    partial class FrmUrunEklemeDuzenleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBarkodNo = new System.Windows.Forms.TextBox();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.cbxUretici = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxUrunIcerigi = new System.Windows.Forms.TextBox();
            this.pictureOn = new System.Windows.Forms.PictureBox();
            this.PictureArka = new System.Windows.Forms.PictureBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üretici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün İçeriği";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxBarkodNo
            // 
            this.tbxBarkodNo.Location = new System.Drawing.Point(188, 42);
            this.tbxBarkodNo.Name = "tbxBarkodNo";
            this.tbxBarkodNo.Size = new System.Drawing.Size(203, 22);
            this.tbxBarkodNo.TabIndex = 5;
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(188, 124);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(203, 22);
            this.tbxUrunAdi.TabIndex = 6;
            // 
            // cbxUretici
            // 
            this.cbxUretici.FormattingEnabled = true;
            this.cbxUretici.Location = new System.Drawing.Point(188, 82);
            this.cbxUretici.Name = "cbxUretici";
            this.cbxUretici.Size = new System.Drawing.Size(203, 24);
            this.cbxUretici.TabIndex = 7;
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(188, 164);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(203, 24);
            this.cbxKategori.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ön Yüz Fotoğrafı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Arka Yüz Fotoğrafı";
            // 
            // tbxUrunIcerigi
            // 
            this.tbxUrunIcerigi.Location = new System.Drawing.Point(188, 201);
            this.tbxUrunIcerigi.Multiline = true;
            this.tbxUrunIcerigi.Name = "tbxUrunIcerigi";
            this.tbxUrunIcerigi.Size = new System.Drawing.Size(203, 92);
            this.tbxUrunIcerigi.TabIndex = 11;
            // 
            // pictureOn
            // 
            this.pictureOn.Location = new System.Drawing.Point(71, 343);
            this.pictureOn.Name = "pictureOn";
            this.pictureOn.Size = new System.Drawing.Size(121, 64);
            this.pictureOn.TabIndex = 12;
            this.pictureOn.TabStop = false;
            // 
            // PictureArka
            // 
            this.PictureArka.Location = new System.Drawing.Point(270, 343);
            this.PictureArka.Name = "PictureArka";
            this.PictureArka.Size = new System.Drawing.Size(121, 64);
            this.PictureArka.TabIndex = 13;
            this.PictureArka.TabStop = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(71, 439);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(320, 23);
            this.btnUrunEkle.TabIndex = 14;
            this.btnUrunEkle.Text = "Gönder";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // FrmUrunEklemeDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 586);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.PictureArka);
            this.Controls.Add(this.pictureOn);
            this.Controls.Add(this.tbxUrunIcerigi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.cbxUretici);
            this.Controls.Add(this.tbxUrunAdi);
            this.Controls.Add(this.tbxBarkodNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUrunEklemeDuzenleme";
            this.Text = "FrmUrunEklemeDuzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBarkodNo;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.ComboBox cbxUretici;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxUrunIcerigi;
        private System.Windows.Forms.PictureBox pictureOn;
        private System.Windows.Forms.PictureBox PictureArka;
        private System.Windows.Forms.Button btnUrunEkle;
    }
}