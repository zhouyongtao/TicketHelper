using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketHelper
{
    /// <summary>
    /// 查询车次参数
    /// </summary>
    public class QueryTicket
    {
        public string Tran_date { get; set; }
        public string From_station_telecode { get; set; }
        public string To_station_telecode { get; set; }
        public string Train_no { get; set; }
        public string TrainPassType { get; set; }
        public string TrainClass { get; set; }
        public string IncludeStudent { get; set; }
        public string SeatTypeAndNum { get; set; }
        public string Start_time_str { get; set; }
    }
}
