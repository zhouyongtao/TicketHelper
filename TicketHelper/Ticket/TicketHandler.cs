using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TicketHelper.Helper;
using TicketHelper.Model;

namespace TicketHelper.Ticket
{
    internal class TicketHandler
    {
        private readonly static CookieContainer cookieContainers = new CookieContainer();

        #region 初始化并获得验证码
        public static async Task<Image> LoginInitAndGetloginVcode(bool IsFirst = false)
        {
            try
            {
                var handler = new HttpClientHandler() { CookieContainer = cookieContainers, AllowAutoRedirect = true, AutomaticDecompression = DecompressionMethods.GZip };
                using (var httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("Host", "kyfw.12306.cn");
                    httpClient.DefaultRequestHeaders.Add("Origin", ConstantKey.loginorigin);
                    httpClient.DefaultRequestHeaders.Add("Referer", ConstantKey.loginRefer);
                    httpClient.DefaultRequestHeaders.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131");
                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
                    if (IsFirst)
                    {
                        //loginInit
                        string loginInit = await httpClient.GetStringAsync(ConstantKey.loginInit);
                        if (string.IsNullOrEmpty(loginInit) || !loginInit.Contains("登录")) return null;
                        //loginJs
                        var resp = await httpClient.GetAsync(ConstantKey.loginJs);
                        if (!resp.IsSuccessStatusCode) return null;
                    }
                    //VerifyCode
                    var verifyStream = await httpClient.GetStreamAsync(ConstantKey.loginVcode);
                    if (verifyStream == null) return null;
                    return Image.FromStream(verifyStream);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region 检查验证码
        public static async Task<bool> ChkVerifyCodeAnsyn(string verifyNo)
        {
            try
            {
                var handler = new HttpClientHandler() { CookieContainer = cookieContainers, AllowAutoRedirect = true, AutomaticDecompression = DecompressionMethods.GZip };
                using (var httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("Host", "kyfw.12306.cn");
                    httpClient.DefaultRequestHeaders.Add("Origin", ConstantKey.loginorigin);
                    httpClient.DefaultRequestHeaders.Add("Referer", ConstantKey.loginRefer);
                    httpClient.DefaultRequestHeaders.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131");
                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
                    // 构造POST参数
                    var data = new FormUrlEncodedContent(new Dictionary<string, string>()
                    {
                       {"randCode", verifyNo},
                       {"rand", "sjrand"}
                    });
                    var response = await httpClient.PostAsync(ConstantKey.loginChkVcode, data);
                    response.EnsureSuccessStatusCode();
                    string content = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(content) || !content.Contains("Y") || !content.Contains("true")) return false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 登陆
        public static async Task<bool> loginVerifyLogin(string userName, string pwd, string verifyNo)
        {
            try
            {
                var handler = new HttpClientHandler() { CookieContainer = cookieContainers, AllowAutoRedirect = true, AutomaticDecompression = DecompressionMethods.GZip };
                using (var httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("Host", "kyfw.12306.cn");
                    httpClient.DefaultRequestHeaders.Add("Origin", ConstantKey.loginorigin);
                    httpClient.DefaultRequestHeaders.Add("Referer", ConstantKey.loginRefer);
                    httpClient.DefaultRequestHeaders.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131");
                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
                    // 构造POST参数
                    var data = new FormUrlEncodedContent(new Dictionary<string, string>()
                    {
                       {"loginUserDTO.user_name", userName},
                       {"userDTO.password", pwd},
                       {"randCode", verifyNo}
                    });
                    var response = await httpClient.PostAsync(ConstantKey.loginVerifyLogin, data);
                    response.EnsureSuccessStatusCode();
                    string content = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(content) || !content.Contains("Y") || !content.Contains("loginCheck")) return false;
                    //{"validateMessagesShowId":"_validatorMessage","status":true,"httpstatus":200,"data":{"loginCheck":"Y"},"messages":[],"validateMessages":{}}
                    //{"validateMessagesShowId":"_validatorMessage","status":true,"httpstatus":200,"data":{},"messages":["验证码不正确！"],"validateMessages":{}}
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion


        public static async Task<LeftTicket> queryleftTicket(string beginDate, string start_station, string end_station, string id_type = "ADULT")
        {
            try
            {
                var handler = new HttpClientHandler() { CookieContainer = cookieContainers, AllowAutoRedirect = true, AutomaticDecompression = DecompressionMethods.GZip };
                using (var httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("Host", "kyfw.12306.cn");
                    httpClient.DefaultRequestHeaders.Add("Origin", ConstantKey.loginorigin);
                    httpClient.DefaultRequestHeaders.Add("Referer", ConstantKey.loginRefer);
                    httpClient.DefaultRequestHeaders.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.131");
                    var dict = new Dictionary<string, string>
                    {
                        {"beginDate", beginDate},
                        {"start_station", start_station},
                        {"end_station", end_station},
                        {"id_type", id_type}
                    };
                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
                    string url = HttpUtil.ReplaceURL(ConstantKey.queryTicket, dict);
                    var content = await httpClient.GetStringAsync(url);
                    if (string.IsNullOrEmpty(content) || !content.Contains("预订")) return null;
                    return JsonConvert.DeserializeObject<LeftTicket>(content);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
