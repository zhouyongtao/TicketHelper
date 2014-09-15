using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description 扩展TimeSpan
 * @date 2010年9月10日19:08:46
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer 
 */
namespace TicketHelper.Helper.Extension
{
    public static class TimeSpanExtension
    {
        public static TimeSpan Days(this int days)
        {
            return TimeSpan.FromDays((double)days);
        }

        public static TimeSpan Hours(this int hours)
        {
            return TimeSpan.FromHours((double)hours);
        }

        public static TimeSpan Milliseconds(this int milliseconds)
        {
            return TimeSpan.FromMilliseconds((double)milliseconds);
        }

        public static TimeSpan Minutes(this int minutes)
        {
            return TimeSpan.FromMinutes((double)minutes);
        }

        public static TimeSpan Seconds(this int seconds)
        {
            return TimeSpan.FromSeconds((double)seconds);
        }

        public static TimeSpan Ticks(this int ticks)
        {
            return TimeSpan.FromTicks((long)ticks);
        }
    }
}
