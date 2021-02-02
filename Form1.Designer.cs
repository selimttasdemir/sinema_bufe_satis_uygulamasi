namespace sinema_büfe_satiş_uygulamasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbilet = new System.Windows.Forms.TextBox();
            this.lbbilet = new System.Windows.Forms.Label();
            this.txtcay = new System.Windows.Forms.TextBox();
            this.lbcay = new System.Windows.Forms.Label();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.lbsu = new System.Windows.Forms.Label();
            this.txtmisir = new System.Windows.Forms.TextBox();
            this.lbmisir = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbkasa = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.lbtoplam = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.txtbilet);
            this.groupBox1.Controls.Add(this.lbbilet);
            this.groupBox1.Controls.Add(this.txtcay);
            this.groupBox1.Controls.Add(this.lbcay);
            this.groupBox1.Controls.Add(this.txtsu);
            this.groupBox1.Controls.Add(this.lbsu);
            this.groupBox1.Controls.Add(this.txtmisir);
            this.groupBox1.Controls.Add(this.lbmisir);
            this.groupBox1.Location = new System.Drawing.Point(30, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktarı:";
            // 
            // txtbilet
            // 
            this.txtbilet.Location = new System.Drawing.Point(86, 149);
            this.txtbilet.Name = "txtbilet";
            this.txtbilet.Size = new System.Drawing.Size(93, 30);
            this.txtbilet.TabIndex = 7;
            // 
            // lbbilet
            // 
            this.lbbilet.AutoSize = true;
            this.lbbilet.Location = new System.Drawing.Point(15, 152);
            this.lbbilet.Name = "lbbilet";
            this.lbbilet.Size = new System.Drawing.Size(56, 22);
            this.lbbilet.TabIndex = 6;
            this.lbbilet.Text = "Bilet:";
            // 
            // txtcay
            // 
            this.txtcay.Location = new System.Drawing.Point(86, 113);
            this.txtcay.Name = "txtcay";
            this.txtcay.Size = new System.Drawing.Size(93, 30);
            this.txtcay.TabIndex = 5;
            // 
            // lbcay
            // 
            this.lbcay.AutoSize = true;
            this.lbcay.Location = new System.Drawing.Point(20, 116);
            this.lbcay.Name = "lbcay";
            this.lbcay.Size = new System.Drawing.Size(51, 22);
            this.lbcay.TabIndex = 4;
            this.lbcay.Text = "Çay:";
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(86, 77);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(93, 30);
            this.txtsu.TabIndex = 3;
            // 
            // lbsu
            // 
            this.lbsu.AutoSize = true;
            this.lbsu.Location = new System.Drawing.Point(32, 80);
            this.lbsu.Name = "lbsu";
            this.lbsu.Size = new System.Drawing.Size(39, 22);
            this.lbsu.TabIndex = 2;
            this.lbsu.Text = "Su:";
            // 
            // txtmisir
            // 
            this.txtmisir.Location = new System.Drawing.Point(86, 41);
            this.txtmisir.Name = "txtmisir";
            this.txtmisir.Size = new System.Drawing.Size(93, 30);
            this.txtmisir.TabIndex = 1;
            // 
            // lbmisir
            // 
            this.lbmisir.AutoSize = true;
            this.lbmisir.Location = new System.Drawing.Point(11, 44);
            this.lbmisir.Name = "lbmisir";
            this.lbmisir.Size = new System.Drawing.Size(60, 22);
            this.lbmisir.TabIndex = 0;
            this.lbmisir.Text = "Mısır:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(234, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 196);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Fiyatları:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bilet: 20TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Çay: 3TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Su: 2TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mısır: 4TL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbkasa);
            this.groupBox3.Controls.Add(this.lb2);
            this.groupBox3.Controls.Add(this.btnhesap);
            this.groupBox3.Controls.Add(this.lbtoplam);
            this.groupBox3.Controls.Add(this.lb1);
            this.groupBox3.Location = new System.Drawing.Point(401, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 195);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(10, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "SIFIRLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbkasa
            // 
            this.lbkasa.AutoSize = true;
            this.lbkasa.Location = new System.Drawing.Point(83, 149);
            this.lbkasa.Name = "lbkasa";
            this.lbkasa.Size = new System.Drawing.Size(58, 22);
            this.lbkasa.TabIndex = 11;
            this.lbkasa.Text = "00 TL";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(13, 149);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(64, 22);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "KASA:";
            // 
            // btnhesap
            // 
            this.btnhesap.BackColor = System.Drawing.Color.Red;
            this.btnhesap.Location = new System.Drawing.Point(10, 66);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(126, 36);
            this.btnhesap.TabIndex = 9;
            this.btnhesap.Text = "HESAP";
            this.btnhesap.UseVisualStyleBackColor = false;
            this.btnhesap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtoplam
            // 
            this.lbtoplam.AutoSize = true;
            this.lbtoplam.Location = new System.Drawing.Point(106, 41);
            this.lbtoplam.Name = "lbtoplam";
            this.lbtoplam.Size = new System.Drawing.Size(58, 22);
            this.lbtoplam.TabIndex = 8;
            this.lbtoplam.Text = "00 TL";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 41);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(94, 22);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "TOPLAM:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pristina", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 49);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sinema & Büfe Satış Paneli";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(30, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 70);
            this.listBox1.TabIndex = 13;
            this.listBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(634, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Swis721 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Satış Menüsü";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbilet;
        private System.Windows.Forms.Label lbbilet;
        private System.Windows.Forms.TextBox txtcay;
        private System.Windows.Forms.Label lbcay;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.Label lbsu;
        private System.Windows.Forms.TextBox txtmisir;
        private System.Windows.Forms.Label lbmisir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label lbtoplam;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbkasa;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

