using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crawlerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();     
        }

        static SimpleCrawler crawler = new SimpleCrawler();
        Thread thread = new Thread(crawler.Crawl);

        private void Form1_Load(object sender, EventArgs e)
        {
            label_info.DataBindings.Add("Text", crawler, "message");
        }

        private void btn_crawer_Click(object sender, EventArgs e)
        {
            bindingSource_Urls.DataSource = crawler.urlInfo;
            crawler.startUrl = tb_URL.Text;
            crawler.urls.Add(crawler.startUrl, false);//加入初始页面
            thread.Start();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }
    }
}
