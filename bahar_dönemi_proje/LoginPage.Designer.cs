
namespace bahar_dönemi_proje
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_ad = new System.Windows.Forms.TextBox();
            this.kullanici_sifre = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(133, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kullanici_ad
            // 
            this.kullanici_ad.Location = new System.Drawing.Point(271, 166);
            this.kullanici_ad.Multiline = true;
            this.kullanici_ad.Name = "kullanici_ad";
            this.kullanici_ad.Size = new System.Drawing.Size(154, 20);
            this.kullanici_ad.TabIndex = 2;
            this.kullanici_ad.TextChanged += new System.EventHandler(this.kullanici_ad_TextChanged);
            // 
            // kullanici_sifre
            // 
            this.kullanici_sifre.Location = new System.Drawing.Point(271, 229);
            this.kullanici_sifre.Multiline = true;
            this.kullanici_sifre.Name = "kullanici_sifre";
            this.kullanici_sifre.PasswordChar = '*';
            this.kullanici_sifre.Size = new System.Drawing.Size(154, 20);
            this.kullanici_sifre.TabIndex = 3;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(376, 315);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(88, 45);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(489, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Parolayı Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(282, 315);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(88, 45);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.kullanici_sifre);
            this.Controls.Add(this.kullanici_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanı Giriş Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanici_ad;
        private System.Windows.Forms.TextBox kullanici_sifre;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGiris;
    }
}

