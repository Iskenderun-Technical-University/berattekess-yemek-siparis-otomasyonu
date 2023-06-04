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
    public partial class frmDrink : Form
    {
        SqlSiparisDbContext Mycontex = new SqlSiparisDbContext();
        private string dosyayolu = "";
        public frmDrink()
        {

            InitializeComponent();

            button1.Click += button1_Click;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Drink icecek = new Drink();
                icecek.Fiyati = Convert.ToInt32(textBox2.Text);
                icecek.Name = textBox1.Text;
                icecek.Resim = dosyayolu;
                Mycontex.Drinks.Add(icecek);
                Mycontex.SaveChanges();
                MessageBox.Show("Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dosyayolu = openFileDialog.FileName;
                    // Seçilen resmin yolunu görüntü kutusuna yükle
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Dosya yolunu veritabanına kaydetmek için aşağıdaki adımları takip edin.
                    // ...
                }
            }

        }

        private void frmDrink_Load(object sender, EventArgs e)
        {

        }
    }
}
