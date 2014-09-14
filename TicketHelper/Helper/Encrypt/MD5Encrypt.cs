using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TicketHelper.Helper.Encrypt
{
    /// <summary>
    /// MD5安全类
    /// </summary>
    public class MD5Encrypt
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns>keyMd5加密字符串</returns>
        public static string GetMD5(string hashText)
        {
            MD5 mp = MD5.Create();
            byte[] _byte = mp.ComputeHash(Encoding.UTF8.GetBytes(hashText));
            string keyMd5 = string.Empty;
            for (int i = 0; i < _byte.Length; i++)
            {
                keyMd5 += _byte[i].ToString("x");
            }
            return keyMd5;
        }

        /// <summary>
        /// 用MD5算法对字符串加密
        /// </summary>
        /// <param name="strOriginal"></param>
        /// <returns></returns>
        public static string Md5EncryptString(string strOriginal)
        {
            var encoder = new UTF8Encoding();
            var md5Hasher = new MD5CryptoServiceProvider();
            byte[] bytePassword = md5Hasher.ComputeHash(encoder.GetBytes(strOriginal));
            string str = System.Text.Encoding.Default.GetString(bytePassword);
            return str;
        }

        /// <summary>
        /// 用MD5算法对字符串加密
        /// </summary>
        /// <param name="strOriginal"></param>
        /// <returns></returns>
        public static byte[] Md5Encrypt(string strOriginal)
        {
            var encoder = new UTF8Encoding();
            var md5Hasher = new MD5CryptoServiceProvider();
            byte[] bytePassword = md5Hasher.ComputeHash(encoder.GetBytes(strOriginal));
            return bytePassword;
        }
    }
}
