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
            comboBox1.Items.Add("Se�iniz");
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

                urun.UrunAd� = textBox1.Text;
                urun.UrunFiyati = Convert.ToDecimal(textBox2.Text);
                urun.Type = comboBox1.SelectedIndex;
                urun.Pic = dosyayolu;
                Mycontext.Urunlers.Add(urun);
                Mycontext.SaveChanges();
                MessageBox.Show("�r�n Eklendi");
            }
            else
            {
                MessageBox.Show("Alanlar� doldurun");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyalar� (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dosyayolu = openFileDialog.FileName;
                    // Se�ilen resmin yolunu g�r�nt� kutusuna y�kle
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Dosya yolunu veritaban�na kaydetmek i�in a�a��daki ad�mlar� takip edin.
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