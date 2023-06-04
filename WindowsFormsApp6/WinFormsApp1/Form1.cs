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

    public partial class Form1 : Form
    {
        SqlSiparisDbContext Context = new SqlSiparisDbContext();
        public Form1()
        {
            InitializeComponent();

            var siparis = from s in Context.Siparislers
                          join u in Context.Urunlers on s.UrunId equals u.Id
                          join ic in Context.Drinks on s.DrinkId equals ic.Id
                          select new
                          {
                              MüşteriAd = s.MusteriAd,
                              MüşteriNo = s.MusteriTelno,
                              Eposta = s.Eposta,
                              Adres = s.Adres,
                              ÜrünAdı = u.UrunAdı,
                              İçeçek = ic.Name,
                              SiparişTutarı = s.Tutar,
                          };
            dataGridView1.DataSource = siparis.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var siparis = from s in Context.Siparislers
                          join u in Context.Urunlers on s.UrunId equals u.Id
                          join ic in Context.Drinks on s.DrinkId equals ic.Id
                          select new
                          {
                              MüşteriAd = s.MusteriAd,
                              MüşteriNo = s.MusteriTelno,
                              Eposta = s.Eposta,
                              Adres = s.Adres,
                              ÜrünAdı = u.UrunAdı,
                              İçeçek = ic.Name,
                              SiparişTutarı = s.Tutar,
                          };

            if (textBox1.Text != "")
            {
                siparis = siparis.Where(x => x.MüşteriAd.Contains(textBox1.Text));
            }
            if (textBox2.Text != "")
            {
                siparis = siparis.Where(x => x.ÜrünAdı.Contains(textBox2.Text));
            }
            dataGridView1.DataSource = siparis.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
