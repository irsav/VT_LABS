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

       

        private void OnPlusClick(object sender, EventArgs e)
        {
            int sum;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                label2.Text = sum.ToString();
            }
        }

        private void OnMinusClick(object sender, EventArgs e)
        {
            int sum;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sum = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                label2.Text = sum.ToString();
            }
        }

        private void OnMultiplyClick(object sender, EventArgs e)
        {
            int sum;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sum = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                label2.Text = sum.ToString();
            }
        }

        private void OnDevideClick(object sender, EventArgs e)
        {
            int sum;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text != "0")
            {
                sum = int.Parse(textBox1.Text) / int.Parse(textBox2.Text );
                label2.Text = sum.ToString();
            }
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
        }
    }
}
