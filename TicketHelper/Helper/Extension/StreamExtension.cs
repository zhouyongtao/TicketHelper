using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

/*
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description 扩展Stream
 * @date 2013年10月2日19:44:28
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer 
 */
namespace TicketHelper.Helper.Extension
{
    public static class StreamExtension
    {
        private const int BufferSize = 1024;

        /// <summary>
        /// 流转字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="isBase64">是否为Base64编码(UTF-8编码)</param>
        /// <returns></returns>
        public static string AsStringText(this Stream stream, bool isBase64 = false)
        {
            try
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string result = reader.ReadToEnd();
                    if (!isBase64)
                    {
                        return result;
                    }
                    else
                    {
                        return Encoding.UTF8.GetString(Convert.FromBase64String(result));
                    }
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 流转对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this Stream stream, bool isBase64 = false)
        {
            T obj = default(T);
            string content = string.Empty;
            try
            {
                content = stream.AsStringText(isBase64);
                using (Stream ms = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    obj = (T)new XmlSerializer(typeof(T)).Deserialize(new StreamReader(ms, Encoding.UTF8));
                }
            }
            catch (Exception ex)
            {
               // NRLog.ExceptionLog("XML反序列化对象失败" + content, ex);
            }
            return obj;
        }


        /// <summary>
        /// 流拷贝到其他流中（如写入文件）
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }


        /// <summary>
        /// 内存流转byte[]数组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ReadFully(this Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                CopyTo(input, ms);
                if (ms.Length == ms.GetBuffer().Length)
                {
                    return ms.GetBuffer();
                }
                return ms.ToArray();
            }
        }
    }
}
