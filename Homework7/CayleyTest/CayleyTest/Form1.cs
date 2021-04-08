using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTest
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        private Pen pen = Pens.Blue;
        private int n = 10;
        private int leng = 100;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (graphics == null) graphics = panel2.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        private void drawCayleyTree(int n,double x0,double y0,double length,double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);

        }

        private void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("红色");
            comboBox1.Items.Add("蓝色");
            comboBox1.Items.Add("黄色");
            comboBox1.Items.Add("绿色");

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 15;

            hScrollBar1.Maximum = 150;

            hScrollBar2.Maximum = 109;
            hScrollBar2.Minimum = 0;

            hScrollBar3.Maximum = 109;
            hScrollBar3.Minimum = 0;

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "红色":  pen = Pens.Red;    break;
                case "蓝色":  pen = Pens.Blue;   break;
                case "黄色":  pen = Pens.Yellow; break;
                case "绿色":  pen = Pens.Green;  break;
                default: break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            leng = hScrollBar1.Value;
            label4.Text = hScrollBar1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            th1 = Int32.Parse(textBox1.Text) * Math.PI / 180;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            th2 = Int32.Parse(textBox2.Text) * Math.PI / 180;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            per1 = (double)hScrollBar2.Value / 100;
            label11.Text = per1.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            per2 = (double)hScrollBar3.Value / 100;
            label12.Text = per2.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
