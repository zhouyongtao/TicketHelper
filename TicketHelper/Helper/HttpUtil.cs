using System;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Web;
using System.Threading;

/**
* 版权所有 All Rights Reserved
*
* @author Irving_Zhou
* @description  HTTP辅助类
* @date 2013年9月20日15:04:52
* @version 1.0.0
* @email zhouyongtao@outlook.com
* @blog http://www.cnblogs.com/Irving/
*/
namespace TicketHelper.Helper
{
    /// <summary>
    /// Cookie写入硬盘
    /// </summary>
    public class Win32API
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string A_0, string A_1, string A_2);
    }

    /// <summary>
    /// IP与端口号
    /// </summary>
    public class RemoteArddess
    {
        public string IP { get; set; }
        public string Port { get; set; }
    }


    public class HttpUtil
    {
        /// <summary>
        /// 设置默认UserAgent
        /// </summary>
        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
        /// <summary>
        /// 设置会话Cookie
        /// </summary>
        private readonly static CookieContainer cookieContainer = new CookieContainer();
        /// <summary>
        /// 初始信号状态
        /// </summary>
        private static ManualResetEvent allDone = new ManualResetEvent(false);

        #region 辅助相关方法
        /// <summary>
        /// URL替换
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="dict">替换的数据</param>
        /// <returns></returns>
        public static string ReplaceURL(string url, IDictionary dict)
        {
            foreach (DictionaryEntry item in dict)
            {
                string key = item.Key.ToString();
                string value = item.Value.ToString();
                url = url.Replace(String.Format(@"${{{0}}}", key), value);
            }
            return url;
        }

        /// <summary>
        /// 构造参数
        /// </summary>
        /// <param name="param">参数</param>
        /// <param name="encode">编码方式</param>
        /// <returns></returns>
        public static string BuildRequestParam(SortedDictionary<string, string> param, Encoding encode)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in param)
            {
                prestr.Append(String.Format("{0}={1}&", temp.Key, HttpUtility.UrlEncode(temp.Value, encode)));
            }
            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);
            return prestr.ToString();
        }

        ///<summary>
        ///创建服务请求内容
        ///</summary>
        ///<param name="callMsg">参数:表示方法调用消息接口</param>
        ///<returns>返回请求消息数据流</returns>
        public static string BuildRequestStream(object objModelName, params string[] args)
        {
            StringBuilder xml_builder = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xml_builder.Append("<");
            xml_builder.Append(objModelName);
            xml_builder.Append(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"");
            xml_builder.Append(">");
            for (int index = 0; index < args.Length; index++)
            {
                xml_builder.Append("<");
                xml_builder.Append(args[index].Split(new char[] { '_' })[0]);
                xml_builder.Append(">");
                xml_builder.Append(args[index].Split(new char[] { '_' })[1]);
                xml_builder.Append("</");
                xml_builder.Append(args[index].Split(new char[] { '_' })[0]);
                xml_builder.Append(">");
            }
            xml_builder.Append("</");
            xml_builder.Append(objModelName);
            xml_builder.Append(">");
            return xml_builder.ToString();
        }

        public static string getSessionID()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            r.Next();
            int rint = r.Next(90000) + 10000;
            return ((DateTime.Now - new DateTime(1970, 1, 1)).Ticks / 10000).ToString() + rint;
        }

        public static string getTimeZone()
        {
            return TimeZone.CurrentTimeZone.GetUtcOffset(System.DateTime.Now).Hours.ToString();
        }

        public static string getRandomNum()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int rint = r.Next(90000) + 10000;
            return ((DateTime.Now - new DateTime(1970, 1, 1)).Ticks / 10000).ToString() + rint;
        }

        //get hash code
        public static string getHashCode(String str, bool caseSensitive)
        {
            int hash = 1315423911;
            int ch = 0;
            if (!caseSensitive)
            {
                str = str.ToLower();
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                ch = (int)(str[i]);
                hash ^= ((hash << 5) + ch + (hash >> 2));
            }
            return (hash & 0x7FFFFFFF).ToString();
        }

        #endregion

     


        /// <summary>
        /// 简单的POST数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string UploadData(string url, string data)
        {
            // "arg1=a&arg2=b";
            byte[] postData = Encoding.UTF8.GetBytes(data);
            WebClient webClient = new WebClient();
            //webClient.DownloadStringAsync();
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            byte[] responseData = webClient.UploadData(url, "POST", postData);
            return Encoding.UTF8.GetString(responseData);
        }

        #region 同步HTTP请求
        /// <summary>
        /// 创建HTTP请求
        /// </summary>
        /// <param name="url">请求URL</param>
        /// <param name="method">请求方式</param>
        /// <param name="data">请求参数</param>
        /// <param name="soapAction">调用WebService设置soapAction头</param>
        /// <param name="timeout">请求超时时间</param>
        /// <param name="contentType">设置HTTP contentType类型</param>
        /// <returns></returns>
        public static string HttpProxy(string url, string method = "GET", string data = null, string contentType = "application/x-www-form-urlencoded", string soapAction = null, int timeout = 8000)
        {
            try
            {
                if (url.IsEmpty())
                    throw new ArgumentNullException("url");
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.KeepAlive = true;
                req.Method = method.ToUpper();
                req.AllowAutoRedirect = true;
                req.CookieContainer = cookieContainer;
                req.ContentType = contentType;
                req.UserAgent = DefaultUserAgent;
                req.Timeout = timeout;
                //调用WebService
                if (!soapAction.IsEmpty())
                {
                    req.Headers.Add("SOAPAction", soapAction);
                }
                // req.Referer = ConstantsTicketKeys.loginInit;
                // req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                if (method.ToUpper() == "POST" && !data.IsEmpty())
                {
                    byte[] postBytes = UTF8Encoding.UTF8.GetBytes(data);
                    //new ASCIIEncoding().GetBytes(data);
                    req.ContentLength = postBytes.Length;
                    using (Stream stream = req.GetRequestStream())
                    {
                        stream.Write(postBytes, 0, postBytes.Length);
                    }
                }
                //忽略HTTPS证书
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslError) =>
                {
                    return true;
                };
                HttpWebResponse resonse = (HttpWebResponse)req.GetResponse();
                using (StreamReader reader = new StreamReader(resonse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        /// <summary>  
        /// 创建GET方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="timeout">请求的超时时间</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static HttpWebResponse CreateGetHttpResponse(string url, int? timeout, string userAgent, CookieCollection cookies)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            if (!string.IsNullOrEmpty(userAgent))
                request.UserAgent = userAgent;
            else
                request.UserAgent = DefaultUserAgent;
            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            return request.GetResponse() as HttpWebResponse;
        }
        /// <summary>  
        /// 创建POST方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="parameters">随同请求POST的参数名称及参数值字典</param>  
        /// <param name="timeout">请求的超时时间</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="requestEncoding">发送HTTP请求时所用的编码</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters, int? timeout, string userAgent, Encoding requestEncoding, CookieCollection cookies)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (requestEncoding == null)
            {
                throw new ArgumentNullException("requestEncoding");
            }
            HttpWebRequest request = null;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            else
            {
                request.UserAgent = DefaultUserAgent;
            }

            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            //如果需要POST数据  
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
                    }
                    i++;
                }
                byte[] data = requestEncoding.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// HTTPS证书配置(总是接受)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
        #endregion

        #region 异步HTTP请求
        public static void SendAsyncRequest(String url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 10000;
                request.BeginGetResponse(delegate(IAsyncResult ar)
                {
                    try
                    {
                        request.EndGetResponse(ar);
                    }
                    catch (Exception ex)
                    {

                    }
                }, null);
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 创建异步HTTP请求
        /// </summary>
        /// <param name="url">http://stackoverflow.com/questions/10565090/getting-the-response-of-a-asynchronous-httpwebrequest?rq=1</param>
        /// <param name="method"></param>
        /// <param name="data"></param>
        /// <param name="contentType"></param>
        /// <param name="timeout"></param>
        public static void HttpProxyAsync(string url, string method = "GET", string data = null, string contentType = "application/x-www-form-urlencoded", int timeout = 1000)
        {
            try
            {
                if (url.IsEmpty())
                    throw new ArgumentNullException("url");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = contentType;
                request.Method = method.ToUpper();
                request.Timeout = timeout;
                if (method.ToUpper() == "POST" && data.IsNotEmpty())
                {
                    request.BeginGetRequestStream(AsyncRequestCallback =>
                    {
                        request = (HttpWebRequest)AsyncRequestCallback.AsyncState;
                        Stream stream = request.EndGetRequestStream(AsyncRequestCallback);
                        byte[] byteArray = Encoding.UTF8.GetBytes(data);
                        stream.Write(byteArray, 0, data.Length);
                        stream.Flush();
                        stream.Close();
                    }, request);
                }
                request.BeginGetResponse(AsyncResponseCallback =>
                {
                    request = (HttpWebRequest)AsyncResponseCallback.AsyncState;
                    HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(AsyncResponseCallback);
                    Stream streamResponse = response.GetResponseStream();
                    StreamReader streamRead = new StreamReader(streamResponse);
                    string result = streamRead.ReadToEnd();
                    if (result.IsEmpty())
                    {
                        //调用失败
                    }
                    else
                    {
                        //System.Threading.Thread.Sleep(10000);
                        //异步调用成功
                    }
                    streamResponse.Close();
                    streamRead.Close();
                    response.Close();
                    allDone.Set();
                }, request);
                allDone.WaitOne();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}