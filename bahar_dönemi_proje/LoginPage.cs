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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                kullanici_sifre.UseSystemPasswordChar = true;
                checkBox1.Text = " Parolayı Gizle";
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                kullanici_sifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Parolayı Göster";
            }
        }

        private void kullanici_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitEkranı kayit = new KayitEkranı();
            kayit.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            String kullaniciAd = "admin";
            String KullaniciSifre = "123";

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
