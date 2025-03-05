namespace OdevApp
{
    partial class FrmGiris
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtKullanici = new TextBox();
            label2 = new Label();
            txtParola = new TextBox();
            btnOturumAc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user__1_;
            pictureBox1.Location = new Point(81, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 149);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = Color.LightSteelBlue;
            txtKullanici.Font = new Font("Segoe UI", 12F);
            txtKullanici.Location = new Point(39, 173);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(210, 29);
            txtKullanici.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 208);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.BackColor = Color.LightSteelBlue;
            txtParola.Font = new Font("Segoe UI", 12F);
            txtParola.Location = new Point(39, 232);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '●';
            txtParola.Size = new Size(210, 29);
            txtParola.TabIndex = 2;
            // 
            // btnOturumAc
            // 
            btnOturumAc.BackColor = Color.MediumSeaGreen;
            btnOturumAc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOturumAc.ForeColor = Color.White;
            btnOturumAc.Location = new Point(42, 273);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(207, 37);
            btnOturumAc.TabIndex = 3;
            btnOturumAc.Text = "Oturum Aç";
            btnOturumAc.UseVisualStyleBackColor = false;
            btnOturumAc.Click += btnOturumAc_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 378);
            Controls.Add(btnOturumAc);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(txtKullanici);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtKullanici;
        private Label label2;
        private TextBox txtParola;
        private Button btnOturumAc;
    }
}