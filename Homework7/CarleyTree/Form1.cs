using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;

        private Pen pen = Pens.White;
        private int n = 10;
        private int leng = 100;
        private Color color;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("红色");
            comboBox1.Items.Add("蓝色");
            comboBox1.Items.Add("黄色");
            comboBox1.Items.Add("绿色");
            comboBox1.Items.Add("其他");

            comboBox2.Items.Add("Dash");
            comboBox2.Items.Add("Dot");
            comboBox2.Items.Add("Solid");
            comboBox2.Items.Add("Custom");
            comboBox2.Items.Add("DashDotDot");

            trackBar1.Maximum = 500;
            trackBar1.Minimum = 0;

            trackBar2.Maximum = 15;
            trackBar2.Minimum = 0;
        }

        private void drawCayleyTree(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);

        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        //判断文本框输入内容
        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)                         
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true;  
            }
        }

        //绘图
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        //画笔颜色
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "红色": 
                    pen = Pens.Red;
                    label2.BackColor = pen.Color;
                    color = pen.Color;
                    break;
                case "蓝色":
                    pen = Pens.Blue;
                    label2.BackColor = pen.Color;
                    color = pen.Color;
                    break;
                case "黄色":
                    pen = Pens.Yellow;
                    label2.BackColor = pen.Color;
                    color = pen.Color;
                    break;
                case "绿色": 
                    pen = Pens.Green;
                    label2.BackColor = pen.Color;
                    color = pen.Color;
                    break;
                case "其他":
                    ColorDialog colorDialog = new ColorDialog();
                    colorDialog.ShowDialog();
                    pen = new Pen(colorDialog.Color);
                    label2.BackColor = pen.Color;
                    color = pen.Color;
                    break;
                default: break;
            }
        }

        //画笔样式
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Dash":
                    pen = new Pen(color);
                    pen.DashStyle = DashStyle.Dash;
                    break;
                case "Dot":
                    pen = new Pen(color);
                    pen.DashStyle = DashStyle.Dot;
                    break;
                case "Solid":
                    pen = new Pen(color);
                    pen.DashStyle = DashStyle.Solid;
                    break;
                case "DashDotDot":
                    pen = new Pen(color);
                    pen.DashStyle = DashStyle.DashDotDot;
                    break;
                default:
                    break;
            }
        }

        //主干长度
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            leng = trackBar1.Value;
            label5.Text = "主干长度  " + trackBar1.Value;
        }     

        //递归深度
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            n = trackBar2.Value;
            label4.Text = "递归深度  " + trackBar2.Value;
        }

        //左分支角度
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0 && e.KeyChar.ToString() == "0")
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) < 0) textBox1.Text = "0";
            if (Int32.Parse(textBox1.Text) > 100) textBox1.Text = "100";
            th1 = Int32.Parse(textBox1.Text) * Math.PI / 180;
            label6.Text = "左分支角度 " + Math.Round(th1, 3);
        }

        //右分支角度
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0 && e.KeyChar.ToString() == "0")
            {
                e.Handled = true;
            }
            if (e.KeyChar != 8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) < 0) textBox1.Text = "0";
            if (Int32.Parse(textBox1.Text) > 100) textBox1.Text = "100";
            th2 = Int32.Parse(textBox1.Text) * Math.PI / 180;
            label7.Text = "右分支角度 " + Math.Round(th2, 3);
        }

        //左分支长度比
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(textBox3.Text) < 0) textBox3.Text = "0";
            if (double.Parse(textBox3.Text) > 1) textBox3.Text = "1";
            per1 = double.Parse(textBox3.Text);
            label8.Text = "左分支长度比 " + per1;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }

        //右分支长度比
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(textBox4.Text);
            label9.Text = "右分支长度比 " + per2;
            if (double.Parse(textBox4.Text) < 0) textBox4.Text = "0";
            if (double.Parse(textBox4.Text) > 1) textBox4.Text = "1";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumber(sender, e);
        }
    }
}
