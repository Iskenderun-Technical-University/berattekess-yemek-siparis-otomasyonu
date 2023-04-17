using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bahar_dönemi_proje
{
    public partial class KayitEkranı : Form
    {
        public KayitEkranı()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydınız başarıyla oluşturuldu...");
        }

        private void KayitEkranı_Load(object sender, EventArgs e)
        {

        }

        private void kayit_parola_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_kayit_Click(object sender, EventArgs e) { 

            /*yaş hesaplama için yapılan işlemler*/   
            
            DateTime dogumTarihi;
            TimeSpan yıl;
            int yas;
            dogumTarihi = kayit_dogum_tarihi.Value;
            yıl = DateTime.Today - dogumTarihi;
            yas = yıl.Days / 365;

            /* metin kutularını değişkene atama işlemleri*/

            string isim = kayit_ad.Text;
            string soyad = kayit_soyad.Text;
            string kullanici_Ad = kayit_kullaniciAd.Text;
            string parola = kayit_parola.Text;
            string dogrulamaParola = kayit_parola2.Text;
            string ePosta = kayit_eposta.Text;
            string ePosta2 = kayit_eposta2.Text;
            string telefon = kayit_telefon.Text;
            string adres = kayit_adres.Text;

            /* kayıt ekranı kontrolleri*/

            if (isim.Length < 2 || isim.Length > 30)
            {
                MessageBox.Show("Ad alanı için karakter uzunluğu 2 ile 30 karakter arasında olmalıdır...");
            }
            else if (soyad.Length < 2 || soyad.Length > 30)
            {
                MessageBox.Show("Soyad alanı için karakter uzunluğu 2 ile 30 karakter arasında olmalıdır...");
            }
            else if (kullanici_Ad.Length < 2 || kullanici_Ad.Length > 15)
            {
                MessageBox.Show("Kullanıcı ad alanı için karakter uzunluğu 2 ile 15 karakter arasında olmalıdır...");
            }
            else if (parola.Length < 8)
            {
                MessageBox.Show("Parola en az 8 karakterden oluşmalı...");
            }
            else if (parola.Length != 0 && dogrulamaParola.Length == 0)
            {
                MessageBox.Show("Parola doğrulama en az 8 karakterden oluşmalı...");
            }
            else if (parola != dogrulamaParola)
            {
                MessageBox.Show("Parolalar eşleşmedi lütfen tekrar deneyiniz...");
            }
            else if ( ePosta.Length < 5 || ePosta2.Length == 0)
            {
                MessageBox.Show("Lütfen E-posta alanını doldurunuz...");
            }
            else if(yas < 12 )
            {
                MessageBox.Show("12 yaşından küçük olduğunu belirttiğin için bu uygulamayı kullanamazsın");
                Application.Exit();
            }
            else if(telefon.Length == 0 || telefon.Length < 14)
            {
                MessageBox.Show("Nuamra hatalı lütfen tekrar deneyin...");
            }
            else if(adres.Length == 0 && adres.Length < 100)
            {
                MessageBox.Show("Lütfen adres alanını doldurunuz");
            }
            else
            {
                MessageBox.Show("kaydınız başarıyla oluşturuldu...");
            }
        }

        private void kayit_dogum_tarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  
    
            /* kayıt ekranında parola kutularının gizliliğini belirleme */

            if(checkBox1.CheckState == CheckState.Checked)
            {
                kayit_parola.UseSystemPasswordChar = true;
                kayit_parola2.UseSystemPasswordChar = true;
                checkBox1.Text = "parolayı gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                kayit_parola.UseSystemPasswordChar = false;
                kayit_parola2.UseSystemPasswordChar = false;
                checkBox1.Text = "parolayı göster";
            }
        }

        private void kayit_ad_soyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
