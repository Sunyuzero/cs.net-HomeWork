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

        public double num1, num2, result;
        public String operation;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            try{
                num1 = double.Parse(textBox1.Text);
            }
            catch(FormatException ex)
            {
                label4.Text = "必须输入数字";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            try
            {
                num2 = double.Parse(textBox2.Text);
            }
            catch (FormatException ex)
            {
                label4.Text = "必须输入数字";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            switch(operation)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": if (num2 == 0.0) { label4.Text = "除数不能为0"; return; }
                          else { result = num1 / num2; break; }
                default : break;
            }
            label4.Text = num1 + operation + num2 + "=" + result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = comboBox1.SelectedItem.ToString();
        }
    }
}
