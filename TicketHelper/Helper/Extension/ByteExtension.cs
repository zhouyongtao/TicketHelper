using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description 扩展Byte
 * @date 2010年9月12日11:26:24
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer 
 */
namespace TicketHelper.Helper.Extension
{
    public static class ByteExtension
    {
        /// <summary>
        /// byte[]转内存流
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static MemoryStream ToMemoryStream(this byte[] data)
        {
            return new MemoryStream(data);
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public static void Save(this byte[] data, string path)
        {
            File.WriteAllBytes(path, data);
        }
    }
}
