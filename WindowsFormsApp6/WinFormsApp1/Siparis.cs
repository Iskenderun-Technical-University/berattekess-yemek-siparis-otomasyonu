using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Siparis : Form
    {
        SqlSiparisDbContext Mycontext = new SqlSiparisDbContext();
        private decimal Urunfiyat = 0;
        private decimal DrinFiyat = 0;
        private decimal tutar = 0;
        public Siparis()
        {
            InitializeComponent();
            textBox3.Text = tutar.ToString();
            var Orders = Mycontext.Urunlers.ToList();
            var drinks = Mycontext.Drinks.ToList();
            comboBox1.Items.Add("Ürün Seçiniz");
            comboBox2.Items.Add("İçeçek Seçiniz");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            foreach (var drink in drinks)
            {
                comboBox2.Items.Add(drink.Name);

            }
            foreach (var Order in Orders)
            {
                comboBox1.Items.Add(Order.UrunAdı);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pic1 = Mycontext.Urunlers.Where(x => x.UrunAdı == comboBox1.SelectedItem).FirstOrDefault();

            if (pic1 != null)
            {

                Urunfiyat= Convert.ToDecimal(pic1.UrunFiyati);
                pictureBox1.Image = Image.FromFile(pic1.Pic);
                tutar = Urunfiyat + DrinFiyat;
                textBox3.Text=tutar.ToString();
               
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Urunfiyat = 0;
                }
                tutar = Urunfiyat + DrinFiyat;
                textBox3.Text = tutar.ToString();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pic1 = Mycontext.Drinks.Where(x => x.Name == comboBox2.SelectedItem).FirstOrDefault();
            if (pic1 != null)
            {
                DrinFiyat = Convert.ToDecimal(pic1.Fiyati);                
                pictureBox2.Image = Image.FromFile(pic1.Resim);
         
                tutar = Urunfiyat + DrinFiyat;
                textBox3.Text = tutar.ToString();
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    DrinFiyat = 0;
                }
                tutar = Urunfiyat + DrinFiyat;
                textBox3.Text = tutar.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();
            siparisler.MusteriAd = textBox1.Text;
            siparisler.MusteriTelno = int.Parse(textBox2.Text);
            siparisler.Adres = textBox4.Text;
            siparisler.Eposta = textBox5.Text;
            siparisler.UrunId = comboBox1.SelectedIndex;
            siparisler.DrinkId = comboBox2.SelectedIndex;
            siparisler.Tutar = int.Parse(textBox3.Text);
            Mycontext.Siparislers.Add(siparisler);
            Mycontext.SaveChanges();
            MessageBox.Show("Sipariş Kaydedildi");

        }
    }
}
