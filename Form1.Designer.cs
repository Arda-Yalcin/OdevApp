namespace OdevApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnKaydet = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lbOgrenciler = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNumara = new TextBox();
            label5 = new Label();
            txtAd = new TextBox();
            label6 = new Label();
            txtSoyad = new TextBox();
            label7 = new Label();
            cbSinif = new ComboBox();
            label8 = new Label();
            txtDers = new TextBox();
            label9 = new Label();
            txtOdev = new TextBox();
            label10 = new Label();
            rdOdevEvet = new RadioButton();
            rdOdevHayir = new RadioButton();
            label11 = new Label();
            nudPuan = new NumericUpDown();
            btnSil = new Button();
            btnYeni = new Button();
            btnEkleGuncelle = new Button();
            lblKayitBilgi = new Label();
            pbKayitBilgi = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKayitBilgi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 65);
            panel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Goldenrod;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(458, 11);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(118, 45);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(62, 7);
            label1.Name = "label1";
            label1.Size = new Size(244, 54);
            label1.TabIndex = 1;
            label1.Text = "Ödev Takibi";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.test;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbOgrenciler);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 413);
            panel2.TabIndex = 1;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.Dock = DockStyle.Fill;
            lbOgrenciler.Font = new Font("Segoe UI", 11F);
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 20;
            lbOgrenciler.Location = new Point(0, 23);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(194, 390);
            lbOgrenciler.TabIndex = 1;
            lbOgrenciler.SelectedIndexChanged += lbOgrenciler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.SeaGreen;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 0;
            label2.Text = "ÖĞRENCİ LİSTESİ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.SeaGreen;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(194, 65);
            label3.Name = "label3";
            label3.Size = new Size(402, 23);
            label3.TabIndex = 2;
            label3.Text = "ÖĞRENCİ DETAYI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(217, 119);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 3;
            label4.Text = "Numara";
            // 
            // txtNumara
            // 
            txtNumara.BackColor = Color.DarkSeaGreen;
            txtNumara.Location = new Point(322, 117);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(245, 23);
            txtNumara.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(217, 148);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 3;
            label5.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.DarkSeaGreen;
            txtAd.Location = new Point(322, 146);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(245, 23);
            txtAd.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(217, 177);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 3;
            label6.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.DarkSeaGreen;
            txtSoyad.Location = new Point(322, 175);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(245, 23);
            txtSoyad.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(217, 207);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 3;
            label7.Text = "Sınıfı";
            // 
            // cbSinif
            // 
            cbSinif.BackColor = Color.DarkSeaGreen;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(325, 205);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(121, 23);
            cbSinif.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(220, 236);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 3;
            label8.Text = "Ders";
            // 
            // txtDers
            // 
            txtDers.BackColor = Color.DarkSeaGreen;
            txtDers.Location = new Point(325, 234);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(245, 23);
            txtDers.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(220, 265);
            label9.Name = "label9";
            label9.Size = new Size(103, 21);
            label9.TabIndex = 3;
            label9.Text = "Ödev Konusu";
            // 
            // txtOdev
            // 
            txtOdev.BackColor = Color.DarkSeaGreen;
            txtOdev.Location = new Point(325, 263);
            txtOdev.Multiline = true;
            txtOdev.Name = "txtOdev";
            txtOdev.Size = new Size(245, 72);
            txtOdev.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(217, 340);
            label10.Name = "label10";
            label10.Size = new Size(134, 21);
            label10.TabIndex = 3;
            label10.Text = "Ödevi Yapmış Mı?";
            // 
            // rdOdevEvet
            // 
            rdOdevEvet.AutoSize = true;
            rdOdevEvet.Font = new Font("Segoe UI", 11F);
            rdOdevEvet.Location = new Point(359, 339);
            rdOdevEvet.Name = "rdOdevEvet";
            rdOdevEvet.Size = new Size(55, 24);
            rdOdevEvet.TabIndex = 6;
            rdOdevEvet.TabStop = true;
            rdOdevEvet.Text = "Evet";
            rdOdevEvet.UseVisualStyleBackColor = true;
            // 
            // rdOdevHayir
            // 
            rdOdevHayir.AutoSize = true;
            rdOdevHayir.Font = new Font("Segoe UI", 11F);
            rdOdevHayir.Location = new Point(438, 339);
            rdOdevHayir.Name = "rdOdevHayir";
            rdOdevHayir.Size = new Size(62, 24);
            rdOdevHayir.TabIndex = 6;
            rdOdevHayir.TabStop = true;
            rdOdevHayir.Text = "Hayır";
            rdOdevHayir.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(217, 377);
            label11.Name = "label11";
            label11.Size = new Size(45, 21);
            label11.TabIndex = 3;
            label11.Text = "Puan";
            // 
            // nudPuan
            // 
            nudPuan.BackColor = Color.DarkSeaGreen;
            nudPuan.Font = new Font("Segoe UI", 11F);
            nudPuan.Location = new Point(325, 375);
            nudPuan.Name = "nudPuan";
            nudPuan.Size = new Size(120, 27);
            nudPuan.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(271, 421);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(77, 45);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.ForestGreen;
            btnYeni.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(368, 421);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(77, 45);
            btnYeni.TabIndex = 8;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.BackColor = Color.LightSeaGreen;
            btnEkleGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEkleGuncelle.ForeColor = Color.White;
            btnEkleGuncelle.Location = new Point(449, 421);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(135, 45);
            btnEkleGuncelle.TabIndex = 8;
            btnEkleGuncelle.Text = "Ekle/Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = false;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // lblKayitBilgi
            // 
            lblKayitBilgi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKayitBilgi.ImageAlign = ContentAlignment.MiddleLeft;
            lblKayitBilgi.Location = new Point(469, 92);
            lblKayitBilgi.Name = "lblKayitBilgi";
            lblKayitBilgi.Size = new Size(93, 23);
            lblKayitBilgi.TabIndex = 9;
            lblKayitBilgi.Text = "Kayıt Bilgisi";
            lblKayitBilgi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbKayitBilgi
            // 
            pbKayitBilgi.Image = Properties.Resources.yeni;
            pbKayitBilgi.Location = new Point(436, 88);
            pbKayitBilgi.Name = "pbKayitBilgi";
            pbKayitBilgi.Size = new Size(30, 33);
            pbKayitBilgi.SizeMode = PictureBoxSizeMode.CenterImage;
            pbKayitBilgi.TabIndex = 10;
            pbKayitBilgi.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 478);
            Controls.Add(pbKayitBilgi);
            Controls.Add(lblKayitBilgi);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(nudPuan);
            Controls.Add(rdOdevHayir);
            Controls.Add(rdOdevEvet);
            Controls.Add(cbSinif);
            Controls.Add(label7);
            Controls.Add(txtOdev);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtDers);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(txtSoyad);
            Controls.Add(label6);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(txtNumara);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKayitBilgi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ListBox lbOgrenciler;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumara;
        private Label label5;
        private TextBox txtAd;
        private Label label6;
        private TextBox txtSoyad;
        private Label label7;
        private ComboBox cbSinif;
        private Label label8;
        private TextBox txtDers;
        private Label label9;
        private TextBox txtOdev;
        private Label label10;
        private RadioButton rdOdevEvet;
        private RadioButton rdOdevHayir;
        private Label label11;
        private NumericUpDown nudPuan;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnYeni;
        private Button btnEkleGuncelle;
        private Label lblKayitBilgi;
        private PictureBox pbKayitBilgi;
    }
}
