using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void dort_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "4";
        }

        private void UserInputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void bir_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "3";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "0";
        }

        private void sil_Click(object sender, EventArgs e)
        {
            String TEST_STRING = UserInputText.Text.ToString();

            if (TEST_STRING == null || TEST_STRING.Length == 0) {
                UserInputText.Text= "";
            }
            else{
                UserInputText.Text= TEST_STRING.Substring(0, TEST_STRING.Length - 1);
            }
            
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "/";
        }

        private void carp_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "*";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "+";
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "-";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            string math = UserInputText.Text;
            string value = new DataTable().Compute(math, null).ToString();
            //String math = UserInputText.Text.Trim();

            UserInputText.Text = value;
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            UserInputText.Text = "";
        }
    }
}
