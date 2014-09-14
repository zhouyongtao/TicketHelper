using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TicketHelper.Helper.Encrypt
{
    /// <summary>
    /// SHA 加密类
    /// </summary>
    public class SHAEncrypt
    {

        /// <summary>
        /// 使用SHA1Managed对字符串进行加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1ManagedEncrypt(string str)
        {
            string result = string.Empty;
            //先将要加密的字符串转换成byte数组
            byte[] inputData = System.Text.Encoding.Default.GetBytes("Task" + str);
            //在通过SHA1Managed类加密，并得到加密后的byte[]类型
            byte[] data = System.Security.Cryptography.SHA1Managed.Create().ComputeHash(inputData);

            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                //将每个byte数据转换成16进制。"X":表示大写16进制；"X2"：表示大写16进制保留2位；"x"：表示小写16进制
                strBuild.Append(data[i].ToString("X2"));
            }
            return strBuild.ToString();
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="insertStr"></param>
        /// <returns></returns>
        public static string SHA1Encrypt(string insertStr)
        {
            byte[] tmpByte;
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            tmpByte = sha1.ComputeHash(GetKeyByteArray(insertStr));
            sha1.Clear();
            return GetStringValue(tmpByte);
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string SHA1(string pwd)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "SHA1");
        }

        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="insertStr"></param>
        /// <returns></returns>
        public static string SHA256Encrypt(string insertStr)
        {
            byte[] tmpByte;
            SHA256 sha256 = new SHA256Managed();
            tmpByte = sha256.ComputeHash(GetKeyByteArray(insertStr));
            sha256.Clear();
            return GetStringValue(tmpByte);
        }
        /// <summary>
        /// SHA512加密
        /// </summary>
        /// <param name="insertStr"></param>
        /// <returns></returns>
        public static string SHA512Encrypt(string insertStr)
        {
            byte[] tmpByte;
            SHA512 sha512 = new SHA512Managed();
            tmpByte = sha512.ComputeHash(GetKeyByteArray(insertStr));
            sha512.Clear();
            return GetStringValue(tmpByte);
        }

        private static byte[] GetKeyByteArray(string strKey)
        {
            ASCIIEncoding Asc = new ASCIIEncoding();
            int tmpStrLen = strKey.Length;
            byte[] tmpByte = new byte[tmpStrLen - 1];
            tmpByte = Asc.GetBytes(strKey);
            return tmpByte;
        }

        private static string GetStringValue(byte[] bytes)
        {
            string tmpString = "";
            ASCIIEncoding Asc = new ASCIIEncoding();
            tmpString = Asc.GetString(bytes);
            return tmpString;
        }

        private static string GetNumString(byte[] bytes)
        {
            string tmpString = "";
            for (int iCounter = 0; iCounter < bytes.Length; ++iCounter)
            {
                tmpString = tmpString + bytes[iCounter];
            }
            return tmpString;
        }
    }
}
