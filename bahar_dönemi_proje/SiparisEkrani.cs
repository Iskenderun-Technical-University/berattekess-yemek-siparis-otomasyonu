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
    public partial class SiparisEkrani : Form
    {
        public SiparisEkrani()
        {
            InitializeComponent();
        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* seçimleri temizle*/

            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int tutar = 0;
        
            if(radioButton9.Checked == true)
            {
                tutar = tutar + 60;
            }
            else if (radioButton10.Checked == true)
            {
                tutar = tutar + 90;
            }
            else if (radioButton11.Checked == true)
            {
                tutar = tutar + 120;
            }

            if(radioButton12.Checked == true)
            {
                tutar = tutar + 0;
            }
            else if(radioButton13.Checked == true)
            {
                tutar = tutar + 5;
            }
            else if (radioButton14.Checked == true)
            {
                tutar = tutar + 10;
            }
            label1.Text = tutar.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
