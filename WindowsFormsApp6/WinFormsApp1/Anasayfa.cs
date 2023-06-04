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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDrink frm = new frmDrink();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUrunAdd frm = new frmUrunAdd();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Siparis frm = new Siparis();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
