using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/**
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description 常用正则扩展
 * @date 2013年9月20日20:19:40
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer 
 */
namespace TicketHelper.Helper.Extension
{
    public static class RegularExtension
    {
        public static bool IsEmail(this string source)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(source);
        }
    }
}
