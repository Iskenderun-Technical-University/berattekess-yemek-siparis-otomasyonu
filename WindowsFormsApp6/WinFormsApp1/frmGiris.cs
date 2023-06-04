using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = " Parolayı Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Parolayı Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                MessageBox.Show("Giriş Başarılı");
                Anasayfa frm = new Anasayfa();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
