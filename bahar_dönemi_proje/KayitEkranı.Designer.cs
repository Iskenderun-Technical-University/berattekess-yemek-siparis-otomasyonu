
namespace bahar_dönemi_proje
{
    partial class KayitEkranı
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kayit_adSoyad = new System.Windows.Forms.TextBox();
            this.kayit_kullaniciAd = new System.Windows.Forms.TextBox();
            this.kayit_parola = new System.Windows.Forms.TextBox();
            this.kayit_telefon = new System.Windows.Forms.MaskedTextBox();
            this.kayit_eposta = new System.Windows.Forms.TextBox();
            this.kayit_adres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kayit_parola2 = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.kayit_dogum_tarihi = new System.Windows.Forms.DateTimePicker();
            this.kayit_eposta2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(166, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(167, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(167, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(167, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(166, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // kayit_adSoyad
            // 
            this.kayit_adSoyad.Location = new System.Drawing.Point(279, 12);
            this.kayit_adSoyad.Multiline = true;
            this.kayit_adSoyad.Name = "kayit_adSoyad";
            this.kayit_adSoyad.Size = new System.Drawing.Size(137, 20);
            this.kayit_adSoyad.TabIndex = 1;
            this.kayit_adSoyad.TextChanged += new System.EventHandler(this.kayit_ad_soyad_TextChanged);
            // 
            // kayit_kullaniciAd
            // 
            this.kayit_kullaniciAd.Location = new System.Drawing.Point(279, 50);
            this.kayit_kullaniciAd.Multiline = true;
            this.kayit_kullaniciAd.Name = "kayit_kullaniciAd";
            this.kayit_kullaniciAd.Size = new System.Drawing.Size(137, 20);
            this.kayit_kullaniciAd.TabIndex = 3;
            // 
            // kayit_parola
            // 
            this.kayit_parola.Location = new System.Drawing.Point(279, 85);
            this.kayit_parola.Multiline = true;
            this.kayit_parola.Name = "kayit_parola";
            this.kayit_parola.PasswordChar = '*';
            this.kayit_parola.Size = new System.Drawing.Size(137, 20);
            this.kayit_parola.TabIndex = 4;
            this.kayit_parola.TextChanged += new System.EventHandler(this.kayit_parola_TextChanged);
            // 
            // kayit_telefon
            // 
            this.kayit_telefon.Location = new System.Drawing.Point(279, 241);
            this.kayit_telefon.Mask = "(999) 000-0000";
            this.kayit_telefon.Name = "kayit_telefon";
            this.kayit_telefon.Size = new System.Drawing.Size(100, 20);
            this.kayit_telefon.TabIndex = 10;
            // 
            // kayit_eposta
            // 
            this.kayit_eposta.Location = new System.Drawing.Point(279, 160);
            this.kayit_eposta.Multiline = true;
            this.kayit_eposta.Name = "kayit_eposta";
            this.kayit_eposta.Size = new System.Drawing.Size(88, 20);
            this.kayit_eposta.TabIndex = 7;
            // 
            // kayit_adres
            // 
            this.kayit_adres.Location = new System.Drawing.Point(279, 274);
            this.kayit_adres.Name = "kayit_adres";
            this.kayit_adres.Size = new System.Drawing.Size(339, 61);
            this.kayit_adres.TabIndex = 11;
            this.kayit_adres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(167, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parola Doğrula:";
            // 
            // kayit_parola2
            // 
            this.kayit_parola2.Location = new System.Drawing.Point(279, 127);
            this.kayit_parola2.Multiline = true;
            this.kayit_parola2.Name = "kayit_parola2";
            this.kayit_parola2.PasswordChar = '*';
            this.kayit_parola2.Size = new System.Drawing.Size(137, 20);
            this.kayit_parola2.TabIndex = 5;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(302, 341);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(103, 33);
            this.btn_kayit.TabIndex = 12;
            this.btn_kayit.Text = "Kayıt Oluştur";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // kayit_dogum_tarihi
            // 
            this.kayit_dogum_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kayit_dogum_tarihi.Location = new System.Drawing.Point(279, 201);
            this.kayit_dogum_tarihi.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.kayit_dogum_tarihi.MinDate = new System.DateTime(1913, 1, 1, 0, 0, 0, 0);
            this.kayit_dogum_tarihi.Name = "kayit_dogum_tarihi";
            this.kayit_dogum_tarihi.ShowUpDown = true;
            this.kayit_dogum_tarihi.Size = new System.Drawing.Size(112, 20);
            this.kayit_dogum_tarihi.TabIndex = 9;
            this.kayit_dogum_tarihi.ValueChanged += new System.EventHandler(this.kayit_dogum_tarihi_ValueChanged);
            // 
            // kayit_eposta2
            // 
            this.kayit_eposta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kayit_eposta2.FormattingEnabled = true;
            this.kayit_eposta2.Items.AddRange(new object[] {
            "@hotmail.com",
            "@gmail.com",
            "@outlook.com",
            "@icloud.com"});
            this.kayit_eposta2.Location = new System.Drawing.Point(373, 159);
            this.kayit_eposta2.Name = "kayit_eposta2";
            this.kayit_eposta2.Size = new System.Drawing.Size(85, 21);
            this.kayit_eposta2.TabIndex = 8;
            this.kayit_eposta2.SelectedIndexChanged += new System.EventHandler(this.kayit_eposta2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(447, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "parolayı göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // KayitEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.kayit_eposta2);
            this.Controls.Add(this.kayit_dogum_tarihi);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.kayit_parola2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kayit_adres);
            this.Controls.Add(this.kayit_eposta);
            this.Controls.Add(this.kayit_telefon);
            this.Controls.Add(this.kayit_parola);
            this.Controls.Add(this.kayit_kullaniciAd);
            this.Controls.Add(this.kayit_adSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KayitEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.KayitEkranı_Load);
            this.Shown += new System.EventHandler(this.KayitEkranı_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kayit_adSoyad;
        private System.Windows.Forms.TextBox kayit_kullaniciAd;
        private System.Windows.Forms.TextBox kayit_parola;
        private System.Windows.Forms.MaskedTextBox kayit_telefon;
        private System.Windows.Forms.TextBox kayit_eposta;
        private System.Windows.Forms.RichTextBox kayit_adres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kayit_parola2;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.DateTimePicker kayit_dogum_tarihi;
        private System.Windows.Forms.ComboBox kayit_eposta2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}