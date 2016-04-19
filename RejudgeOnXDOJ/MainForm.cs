using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace RejudgeOnXDOJ
{
    public partial class MainFom : Form
    {
        public MainFom()
        {
            InitializeComponent();
        }
        public static int[] data = new int[10000];
        public static int cnt = 0;
        /// <summary>
        /// 根据页面来重判，仅仅可以用于比赛中的状态页面
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        public void GetId(string url, ref int[] data)
        {
            //获取需要重判的页面
            string html = Query.HttpGetRequest(url, url,"GET",cookie.Text.ToString(),null);
            int start = html.IndexOf("<tbody>");
            int len = html.IndexOf("</tbody>") - start;
            if (len < 0) return;
            html = html.Substring(start, len);
            cnt = 0;
            //获取所有重判的编号
            while (html.IndexOf("<tr><td>") != -1)
            {
                int numstart = html.IndexOf("<tr><td>") + 9;
                html = html.Substring(numstart);
                int numend = html.IndexOf("</td><td>") - 1;
                int numlen = numend + 1;
                if (numlen <= 0) return;
                string num = html.Substring(0, numlen);
                int.TryParse(num, out data[++cnt]);
                //MessageBox.Show(data[cnt].ToString());
            }
            Rejudge();
        }
        /// <summary>
        /// 将data数组里的所有编号重新评测
        /// </summary>
        public void Rejudge()
        {
            string rejudgeUrl = this.rejudgeUrl.Text.ToString();
            for (int i = 1; i <= cnt; i++)
            {
                int ii = i;
                new Thread(() =>
                {
                    string html = Query.HttpGetRequest(rejudgeUrl, rejudgeUrl, "GET", cookie.Text.ToString(), null);
                    //获得postkey
                    html = html.Substring(html.IndexOf("Solution"));
                    html = html.Substring(html.IndexOf("postkey"));
                    html = html.Substring(html.IndexOf("value"));
                    string postkey = html.Substring(html.IndexOf("\"") + 1, 10);
                    //发送重判请求
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("rjsid", data[ii].ToString());
                    dict.Add("do", "do");
                    dict.Add("postkey", postkey);
                    lock(output)
                    {
                        string tmp = Query.HttpGetRequest(rejudgeUrl, rejudgeUrl, "POST", cookie.Text.ToString(), dict);
                        if (tmp != null) output.Text += data[ii].ToString() + " Rejudged" + Environment.NewLine;
                    }
                }).Start();
                Thread.Sleep(500);
            }
        }
        /// <summary>
        /// 直接指定运行编号序列来重判
        /// </summary>
        public void Getdata()
        {
            string tmp = num.Text.ToString();
            string[] strdata = new string[1000];
            strdata= tmp.Split(' ');
            cnt = 0;
            foreach(string str in strdata)
            {
                data[++cnt] = int.Parse(str);
            }
            Rejudge();
        }
        private void startByPage_Click(object sender, EventArgs e)
        {
            output.Text = "";
            string url = page.Text.ToString();
            Task.Factory.StartNew(() => GetId(url, ref data));
        }

        private void startByNum_Click(object sender, EventArgs e)
        {
            output.Text = "";
            Task.Factory.StartNew(() => Getdata());
        }
        /// <summary>
        /// 设置总在最前和透明度设置方便在浏览器之上操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 200;
            Opacity = 0.75;
            opacity.Text = "0.75";
            rejudgeUrl.Text = "http://acm.xidian.edu.cn/admin/rejudge.php";

        }
        private void opacity_TextChanged(object sender, EventArgs e)
        {
            if (opacity.Text.ToString() == string.Empty)
            {
                
                Opacity = 0.75;
            }
            else
            {
                double opacityValue = 0;
                double.TryParse(opacity.Text.ToString(), out opacityValue);
                if (opacityValue > 0 && opacityValue <= 1)
                {
                    Opacity = opacityValue;
                }
            }
        }
    }
}