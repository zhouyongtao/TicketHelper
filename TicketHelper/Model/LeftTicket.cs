﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TicketHelper.Model
{

    public class QueryLeftNewDTO
    {

        [JsonProperty("train_no")]
        public string TrainNo;

        [JsonProperty("station_train_code")]
        public string StationTrainCode;

        [JsonProperty("start_station_telecode")]
        public string StartStationTelecode;

        [JsonProperty("start_station_name")]
        public string StartStationName;

        [JsonProperty("end_station_telecode")]
        public string EndStationTelecode;

        [JsonProperty("end_station_name")]
        public string EndStationName;

        [JsonProperty("from_station_telecode")]
        public string FromStationTelecode;

        [JsonProperty("from_station_name")]
        public string FromStationName;

        [JsonProperty("to_station_telecode")]
        public string ToStationTelecode;

        [JsonProperty("to_station_name")]
        public string ToStationName;

        [JsonProperty("start_time")]
        public string StartTime;

        [JsonProperty("arrive_time")]
        public string ArriveTime;

        [JsonProperty("day_difference")]
        public string DayDifference;

        [JsonProperty("train_class_name")]
        public string TrainClassName;

        [JsonProperty("lishi")]
        public string Lishi;

        [JsonProperty("canWebBuy")]
        public string CanWebBuy;

        [JsonProperty("lishiValue")]
        public string LishiValue;

        [JsonProperty("yp_info")]
        public string YpInfo;

        [JsonProperty("control_train_day")]
        public string ControlTrainDay;

        [JsonProperty("start_train_date")]
        public string StartTrainDate;

        [JsonProperty("seat_feature")]
        public string SeatFeature;

        [JsonProperty("yp_ex")]
        public string YpEx;

        [JsonProperty("train_seat_feature")]
        public string TrainSeatFeature;

        [JsonProperty("seat_types")]
        public string SeatTypes;

        [JsonProperty("location_code")]
        public string LocationCode;

        [JsonProperty("from_station_no")]
        public string FromStationNo;

        [JsonProperty("to_station_no")]
        public string ToStationNo;

        [JsonProperty("control_day")]
        public int ControlDay;

        [JsonProperty("sale_time")]
        public string SaleTime;

        [JsonProperty("is_support_card")]
        public string IsSupportCard;

        [JsonProperty("gg_num")]
        public string GgNum;

        [JsonProperty("gr_num")]
        public string GrNum;

        [JsonProperty("qt_num")]
        public string QtNum;

        [JsonProperty("rw_num")]
        public string RwNum;

        [JsonProperty("rz_num")]
        public string RzNum;

        [JsonProperty("tz_num")]
        public string TzNum;

        [JsonProperty("wz_num")]
        public string WzNum;

        [JsonProperty("yb_num")]
        public string YbNum;

        [JsonProperty("yw_num")]
        public string YwNum;

        [JsonProperty("yz_num")]
        public string YzNum;

        [JsonProperty("ze_num")]
        public string ZeNum;

        [JsonProperty("zy_num")]
        public string ZyNum;

        [JsonProperty("swz_num")]
        public string SwzNum;
    }

    public class Datum
    {

        [JsonProperty("queryLeftNewDTO")]
        public QueryLeftNewDTO QueryLeftNewDTO;

        [JsonProperty("secretStr")]
        public string SecretStr;

        [JsonProperty("buttonTextInfo")]
        public string ButtonTextInfo;
    }

    public class ValidateMessages
    {
    }

    public class LeftTicket
    {

        [JsonProperty("validateMessagesShowId")]
        public string ValidateMessagesShowId;

        [JsonProperty("status")]
        public bool Status;

        [JsonProperty("httpstatus")]
        public int Httpstatus;

        [JsonProperty("data")]
        public Datum[] Data;

        [JsonProperty("messages")]
        public object[] Messages;

        [JsonProperty("validateMessages")]
        public ValidateMessages ValidateMessages;
    }

}