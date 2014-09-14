using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketHelper.Ticket
{
    public class ConstantKey
    {
        /*
            https://kyfw.12306.cn/otn/resources/js/framework/station_name.js
            https://kyfw.12306.cn/otn/userCommon/allCitys
            https://kyfw.12306.cn/otn/userCommon/schoolNames
         */

        /// <summary>
        /// 设置请求的头
        /// </summary>
        public static string loginRefer = @"https://kyfw.12306.cn/otn/login/init";
        public static string loginorigin = @" https://kyfw.12306.cn";

        /// <summary>
        /// loginInit初始化
        /// </summary>
        public static string loginInit = @"https://kyfw.12306.cn/otn/login/init";
        public static string loginJs = @"https://kyfw.12306.cn/otn/dynamicJs/loginJs";
        /// <summary>
        /// 登陆验证码
        /// </summary>
        public static string loginVcode = @"https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=login&rand=sjrand&" + DateTime.Now.TimeOfDay.TotalDays;
        /// <summary>
        /// 验证验证码
        /// </summary>
        public static string loginChkVcode = @"https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
        /// <summary>
        /// 用户登陆
        /// </summary>
        public static string loginVerifyLogin = @"https://kyfw.12306.cn/otn/login/loginAysnSuggest";

        /// <summary>
        /// 联系人
        /// </summary>
        public static string getPassengerDTOs = @"https://kyfw.12306.cn/otn/confirmPassenger/getPassengerDTOs";

        /// <summary>
        /// 查询余票
        /// </summary>
        public static string queryTicket = @"https://kyfw.12306.cn/otn/leftTicket/queryT?leftTicketDTO.train_date=${beginDate}&leftTicketDTO.from_station=${start_station}&leftTicketDTO.to_station=${end_station}&purpose_codes=${id_type}";


        //https://kyfw.12306.cn/otn/leftTicket/queryT?leftTicketDTO.train_date=2014-09-30&leftTicketDTO.from_station=AOH&leftTicketDTO.to_station=MGH&purpose_codes=ADULT


        public static string Say
        {
            get
            {
                return "我只想做一个安静的美男子";
            }
        }

    }
}
