using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

/*
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description 扩展string
 * @date 2010年9月10日17:16:38
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer 
 */
namespace TicketHelper.Helper.Extension
{
    public static class StringExtension
    {
        /// <summary>
        /// 是否是莫泰酒店(酒店品牌)
        /// </summary>
        /// <param name="hotelCd"></param>
        /// <returns></returns>
        public static bool IsMotel(this string hotelCd)
        {
            if (hotelCd.IsNullOrEmpty())
                throw new ArgumentNullException("hotelCd");
            return hotelCd.Contains("M", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 获得酒店品牌
        /// </summary>
        /// <param name="sBrand"></param>
        /// <returns></returns>
        public static string GetHotelBrand(this string sBrand)
        {
            if (sBrand.IsNullOrEmpty())
                throw new ArgumentNullException("sBrand");
            if (sBrand == "二") return "H";
            else if (sBrand == "四") return "Y";
            else if (sBrand == "三") return "M";
            return "二";
        }


        public static string GetArrdTime(this string memType)
        {
            if (memType.Equals("gd"))
                return "1420";
            else
                if (memType.Equals("gb"))
                    return "1419";
                else
                    return "1418";
        }


        /// <summary>
        /// 反转字符串
        /// </summary>
        /// <param name="textField"></param>
        /// <returns></returns>
        public static string Reverse(this string source)
        {
            if (source.IsNullOrEmpty())
                throw new ArgumentNullException("source");
            char[] chars = source.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// 字符串转BASE64
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToBase64(this string source)
        {
            if (source.IsNullOrEmpty())
                throw new ArgumentNullException("source");
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(source));
        }


        public static byte[] ToByte(this string source)
        {
            if (source.IsNullOrEmpty())
                throw new ArgumentNullException("source");
            return Encoding.UTF8.GetBytes(source);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string MD5Hash(this string source)
        {
            string hash = string.Empty;
            if (source.IsNullOrEmpty())
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] data = Encoding.ASCII.GetBytes(source);
                data = md5.ComputeHash(data);
                for (int i = 0; i < data.Length; i++)
                    hash += data[i].ToString("x2");
            }
            return hash;
        }

        /// <summary>
        /// 字符串转换JSON
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T DeserializeJSON<T>(this string source)
        {
            if (source.IsNullOrEmpty())
                throw new ArgumentNullException("source");
            return JsonConvert.DeserializeObject<T>(source);
            //注册其他转换器
            //return fastJSON.JSON.Instance.ToObject<T>(source);
            //return Homeinns.Common.Data.Serializer.JsonSerializer.Deserialize<T>(source);
            //return Homeinns.Common.Data.Serializer.JsonSerializer.JsonToObject<T>(source);
            //return new JavaScriptSerializer().Deserialize<T>(source);
        }


        /// <summary>
        /// 流转对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T DeserializeXML<T>(this string content)
        {
            T obj = default(T);
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                obj = (T)new XmlSerializer(typeof(T)).Deserialize(new StreamReader(ms, Encoding.UTF8));
            }
            return obj;
        }



        /// <summary>
        /// Sql和Script注入式攻击检查
        /// </summary>
        /// <param name="insertStr">需检查的语句</param>
        /// <returns>返回安全语句</returns>
        public static string CheckSQLAttack(this string insertSQL)
        {
            if (insertSQL.IsNullOrEmpty())
                throw new ArgumentNullException("insertSQL");
            return insertSQL.Split(new[] { "'", ";", " ", "<", "--" }, 1, StringSplitOptions.RemoveEmptyEntries)[0];
        }

        /// <summary>
        /// Sql和Script注入式攻击检查
        /// </summary>
        /// <param name="insertStr">需检查的语句</param>
        /// <returns>返回安全语句</returns>
        public static string CheckAllSQLAttack(this string insertSQL)
        {
            if (insertSQL.IsNullOrEmpty())
                throw new ArgumentNullException("insertSQL");
            return insertSQL.Split(new[] { "'", ";", "<", "--", "and", "exec", "delete", "update", "count", "*", "chr", "mid", "master", "truncate", "set", "varchar", "cast", "admin" }, 1, StringSplitOptions.RemoveEmptyEntries)[0];
        }

        /// Method to make sure that user's inputs are not malicious
        /// Petshop WebUtility.cs
        /// User's Input
        /// Maximum length of input
        /// The cleaned up version of the input
        public static string InputText(this string text, int maxLength)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            if (text.Length > maxLength)
                text = text.Substring(0, maxLength);
            text = Regex.Replace(text, "[\\s]{2,}", " ");    //two or more spaces
            text = Regex.Replace(text, "(<[b|B][r|R]/*>)+|(<[p|P](.|\\n)*?>)", "\n");    //

            text = Regex.Replace(text, "(\\s*&[n|N][b|B][s|S][p|P];\\s*)+", " ");    // 
            text = Regex.Replace(text, "<(.|\\n)*?>", string.Empty);    //any other tags
            text = text.Replace("'", "''");
            return text;
        }


        /// <summary>
        /// 注入式攻击检查
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsCheckSQLAttack(this string text)
        {
            if (text.IsNullOrEmpty())
                throw new ArgumentNullException("text");
            const string sqlInject = @" and |exec |insert |select |delete |update | count | * | chr | mid |master |truncate | set |declare | varchar |cast(|cast |admin";
            try
            {
                string[] anySqlStr = sqlInject.Split('|');
                foreach (string jk in anySqlStr)
                {
                    if (text.Contains(jk))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// 验证字符串是否是正整数。
        /// </summary>
        /// <param name="checkedStr">需验证的字符串。</param>
        /// <param name="includeZero">是否包括零</param>
        /// <returns></returns>
        public static bool IsPositiveInt(this string source, bool includeZero = false)
        {
            if (includeZero)
                return Regex.IsMatch(source, @"^([1-9]\d*|0)$");
            else
                return Regex.IsMatch(source, @"^[1-9]\d*$");
        }

        public static bool IsMatch(this string source, string pattern)
        {
            if (source == null) return false;
            else return Regex.IsMatch(source, pattern);
        }

        public static string Match(this string source, string pattern)
        {
            if (source == null) return "";
            return Regex.Match(source, pattern).Value;
        }

        public static string ToCamel(this string source)
        {
            if (source.IsNullOrEmpty()) return source;
            return source[0].ToString().ToLower() + source.Substring(1);
        }

        public static string ToPascal(this string source)
        {
            if (source.IsNullOrEmpty()) return source;
            return source[0].ToString().ToUpper() + source.Substring(1);
        }
        public static bool IsInt(this string source)
        {
            int i;
            return int.TryParse(source, out i);
        }

        public static int ToInt(this string source)
        {
            return int.Parse(source);
        }

        //为空时转为0
        public static int ToNetInt(this string str, int defaultVal = 0)
        {
            int i;
            try
            {
                int.TryParse(str, out i);
            }
            catch { i = defaultVal; }
            return i;
        }

        public static DateTime? ToDateTime(this string str, DateTime? defaultVal = null)
        {
            DateTime? dt = null;
            try
            {
                dt = DateTime.Parse(str);
                //DateTime.TryParse(str, out dt);
            }
            catch
            {
                if (defaultVal.HasValue)
                {
                    dt = defaultVal.Value;
                }
            }
            return dt;
        }

        public static string DBValueToNetValue(this object objS)
        {
            //object i;
            try
            {
                if (DBNull.Value == objS)
                {
                    objS = "";
                }

            }
            catch { objS = ""; }

            return objS.ToString();
        }

        /// <summary>
        /// 简单字符串加密
        /// </summary>
        /// <param name="stringToEncrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(this string stringToEncrypt, string key)
        {
            if (string.IsNullOrEmpty(stringToEncrypt))
                throw new ArgumentException("An empty string value cannot be encrypted.");
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
            CspParameters cspp = new CspParameters() { KeyContainerName = key };
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            byte[] bytes = rsa.Encrypt(System.Text.UTF8Encoding.UTF8.GetBytes(stringToEncrypt), true);
            return BitConverter.ToString(bytes);
        }

        /// <summary>
        /// 简单字符串解密
        /// </summary>
        /// <param name="stringToDecrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(this string stringToDecrypt, string key)
        {
            if (string.IsNullOrEmpty(stringToDecrypt))
                throw new ArgumentException("An empty string value cannot be encrypted.");
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
            CspParameters cspp = new CspParameters() { KeyContainerName = key };
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
            string[] decryptArray = stringToDecrypt.Split(new string[] { "-" }, StringSplitOptions.None);
            byte[] decryptByteArray = Array.ConvertAll<string, byte>(decryptArray, (s => Convert.ToByte(byte.Parse(s, System.Globalization.NumberStyles.HexNumber))));
            byte[] bytes = rsa.Decrypt(decryptByteArray, true);
            return System.Text.UTF8Encoding.UTF8.GetString(bytes);
        }
        /// <summary>
        /// 转换MMT日期格式为系统日期格式
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime ConvertMmtDate(this string source)
        {
            return DateTime.ParseExact(source, "yyyyMMdd", null); ;
        }
        /// <summary>
        /// 转换MMT日期格式为系统日期格式
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime ConvertMmtDateWithTime(this string source)
        {
            return DateTime.ParseExact(source, "yyyyMMddHHmmss", null); ;
        }
        /// <summary>
        ///  转换MMT价格格式
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static float ConvertMmtPrice(this string source)
        {
            return float.Parse(source) / 100;
        }
    }
}