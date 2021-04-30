using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace crawlerWinForm
{
    public class SimpleCrawler
    {
        public List<Urls> urlInfo { get; set; }

        public Hashtable urls = new Hashtable();
        private int count = 0;
        public string startUrl { get; set; }
        public string message { get; set; }

        public SimpleCrawler()
        {
            urlInfo = new List<Urls>();
            message = "请输入爬取的网站";
        }

        public bool isThisWeb(string url)
        {
            string pattern = "^" + startUrl;
            return Regex.IsMatch(url, pattern);
        }

        public bool isTargetUrl(string url)
        {
            string pattern = @".(html|jsp|aspx)$";
            return Regex.IsMatch(url, pattern);
        }

        public string TransIntoAbsolutePath(string path)
        {
            if (!Regex.IsMatch(path, @"^(https|http)://"))
            {
                return startUrl + @"/" + path;
            }
            else return path;
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            message = "开始爬行了...";
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10 || !isThisWeb(current)) break;
                Console.WriteLine("爬行" + current + "页面!");
                message = "爬行" + current + "页面!";

                current = TransIntoAbsolutePath(current);

                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;

                if(isTargetUrl(current)) Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
                message = "爬行结束";
            }
        }

        public void showMessage()
        {
            urlInfo.ForEach(url => Console.WriteLine(url.url + " : " + url.info));
        }

        public string DownLoad(string url)
        {
            showMessage();
            Urls Url = new Urls();
            Url.url = url;
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                Url.info = "爬行成功";
                return html;
            }
            catch (Exception ex)
            {
                Url.info = ex.Message;
                return "";
            }
            finally
            {
                urlInfo.Add(Url);
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
