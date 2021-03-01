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
            label1.Text = "";
            try
            {
                num1 = double.Parse(textBox1.Text);
            }
            catch(FormatException ex)
            {
                label1.Text = "必须填入数字";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                num2 = double.Parse(textBox2.Text);
            }
            catch (FormatException ex)
            {
                label1.Text = "必须填入数字";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            result = num1 + num2;
            operation = '+';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            result = num1 - num2;
            operation = '-';
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            result = num1 * num2;
            operation = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (num2 == 0) { label1.Text = "除数不能为0";  return; }
            result = num1 / num2;
            operation = '/';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = num1.ToString() + operation.ToString() + num2.ToString() + "=" + result.ToString();
        }
    }
}
