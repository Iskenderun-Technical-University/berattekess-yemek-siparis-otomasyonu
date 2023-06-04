//using WinFormsApp1.Model;

using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class frmUrunAdd : Form
    {
        SqlSiparisDbContext Mycontext = new SqlSiparisDbContext();
        private string dosyayolu = "";
        public frmUrunAdd()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            var Uruntypes = Mycontext.UrunTypes.Select(x => x.UrunTipi).ToList();
            comboBox1.Items.Add("Seçiniz");
            comboBox1.SelectedIndex = 0;
            foreach (var u in Uruntypes)
            {
                comboBox1.Items.Add(u);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedIndex > 0)
            {

                urun.UrunAdý = textBox1.Text;
                urun.UrunFiyati = Convert.ToDecimal(textBox2.Text);
                urun.Type = comboBox1.SelectedIndex;
                urun.Pic = dosyayolu;
                Mycontext.Urunlers.Add(urun);
                Mycontext.SaveChanges();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Alanlarý doldurun");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyalarý (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dosyayolu = openFileDialog.FileName;
                    // Seçilen resmin yolunu görüntü kutusuna yükle
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Dosya yolunu veritabanýna kaydetmek için aþaðýdaki adýmlarý takip edin.
                    // ...
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}