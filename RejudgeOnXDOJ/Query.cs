﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejudgeOnXDOJ
{
    class Query
    {
        /// <summary>
        /// 向网页发送http请求
        /// </summary>
        /// <param name="strRequestUri"></param>
        /// <param name="strReferer"></param>
        /// <param name="Method"></param>
        /// <param name="cookie"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string HttpGetRequest(string strRequestUri, string strReferer,string Method,string cookie, Dictionary<string, string> parameters)
        {
            GC.Collect();
            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(strRequestUri);
            Uri uri = new Uri(strRequestUri);
            CookieContainer cookies = new CookieContainer();
            cookies.Add(uri,new Cookie("lastlang", "1"));
            if (cookie == null) cookie = "h286makj44kn59hick7o0ahhn6";
            cookies.Add(uri, new Cookie("dicthuaci", "off"));
            cookies.Add(uri,new Cookie("PHPSESSID", cookie));
            httpRequest.CookieContainer = cookies;
            httpRequest.Method = Method;
            httpRequest.Referer = strReferer;
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36";
            httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.Timeout = 100000;
            httpRequest.KeepAlive = false;
            httpRequest.Proxy = null;
            if (Method == "POST")
            {
                httpRequest.ServicePoint.Expect100Continue = false;
                //构造post数据
                if (!(parameters == null || parameters.Count == 0))
                {
                    StringBuilder buffer = new StringBuilder();
                    int i = 0;
                    foreach (string key in parameters.Keys)
                    {
                        if (i > 0)
                        {
                            buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                        }
                        else
                        {
                            buffer.AppendFormat("{0}={1}", key, parameters[key]);
                            i++;
                        }
                    }
                    byte[] data = Encoding.ASCII.GetBytes(buffer.ToString());
                    using (Stream stream = httpRequest.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Close();
                    }
                }
            }
            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                Stream responseStream = httpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                string strResponse = reader.ReadToEnd();
                reader.Close();
                responseStream.Close();
                httpRequest.Abort();
                httpRequest = null;
                return strResponse;
            }
            catch(Exception)
            {
                //老规矩超时不处理
                return null;
            }
            
        }
    }
}
