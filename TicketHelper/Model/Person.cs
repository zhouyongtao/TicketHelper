using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketHelper
{
    /// <summary>
    /// 乘客信息类
    /// </summary>
    public class Person
    {
        public string First_letter { get; set; }
        public string IsUserSelf { get; set; }
        public string Mobile_no { get; set; }
        public string Old_Passenger_id_no { get; set; }
        public string Old_passenger_id_type_code { get; set; }
        public string Old_passenger_name { get; set; }
        public string Passenger_flag { get; set; }
        public string Passenger_id_no { get; set; }
        public string Passenger_id_type_code { get; set; }
        public string Passenger_id_type_name { get; set; }
        public string Passenger_name { get; set; }
        public string Passenger_type { get; set; }
        public string Passenger_type_name { get; set; }
        public string RecordCount { get; set; }
    }
}
