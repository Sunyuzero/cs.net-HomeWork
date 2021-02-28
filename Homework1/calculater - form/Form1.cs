using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, result;
        char operation;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = num1 + num2;
            operation = '+';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = num1 - num2;
            operation = '-';
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
            operation = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = num1 / num2;
            operation = '/';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = num1.ToString() + operation.ToString() + num2.ToString() + "=" + result.ToString();
        }
    }
}
