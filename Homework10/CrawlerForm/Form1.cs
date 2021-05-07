using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerForm {
  public partial class Form1 : Form {
    BindingSource resultBindingSource = new BindingSource();
    Crawler crawler = new Crawler();

    public Form1() {
      InitializeComponent();
      dgvResult.DataSource = resultBindingSource;
      crawler.PageDownloaded += Crawler_PageDownloaded;
      crawler.CrawlerStopped += Crawler_CrawlerStopped;
    }

    private void Crawler_CrawlerStopped(Crawler obj) {
      Action action = () => lblInfo.Text = "爬虫已停止";
      if (this.InvokeRequired) {
        this.Invoke(action);
      }else {
        action();
      }
    }

    private void Crawler_PageDownloaded(Crawler crawler, string url, string info) {
      
      Action <string,string> action = this.AddUrl;
      if (this.InvokeRequired) {
        this.Invoke(action,new object[] { url,info});
      }else {
        AddUrl(url,info);
      }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        Start();    
    }
    private void Clear()
    {
        resultBindingSource.Clear();
    }

    private void AddUrl(string url,string info)
    {
        var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
        resultBindingSource.Add(pageInfo);
    }
    private async void Start()
    {     
        Clear();
        crawler.StartURL = txtUrl.Text;
        Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
        if (match.Length == 0) return;
        string host = match.Groups["host"].Value;
        crawler.HostFilter = "^" + host + "$";
        crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";

        Task task = Task.Run(() => crawler.Start());
        await task;
        StartStatus();
     }

    private void StartStatus()
    {
        lblInfo.Text = "爬虫已启动....";
    }
    private void txtUrl_TextChanged(object sender, EventArgs e) {   }

    private void Form1_Load(object sender, EventArgs e) {  }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){ }
  }
}
