using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Web;

namespace Homeinns.Common.Ext.Extension
{ /**
    * 版权所有 All Rights Reserved
    *
    * @author Irving
    * @description 扩展IDictionary字典
    * @date 2014年8月27日 16:02:02
    * @version 1.0.0
    * @email zhouyongtao@outlook.com
    * @blog http://www.cnblogs.com/Irving/
    */
    public static class DictionaryExtension
    {
        /// <summary>
        /// 构建请求参数
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static string BuildParam<TKey, TValue>(this IDictionary<TKey, TValue> collection)
        {
            return string.Join("&", collection.Select(keyValuePair => string.Format("{0}={1}", keyValuePair.Key, keyValuePair.Value)).ToArray());
        }

        /// <summary>
        /// 构建请求参数(带编码)
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="collection"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string BuildParamWithEncoding<TKey, TValue>(this IDictionary<TKey, TValue> collection, Encoding encode)
        {
            var prestr = new StringBuilder();
            foreach (KeyValuePair<TKey, TValue> temp in collection)
            {
                prestr.Append(String.Format("{0}={1}&", temp.Key, HttpUtility.UrlEncode(temp.Value.ToString(), encode)));
            }
            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);
            return prestr.ToString();
        }

        /// <summary>
        /// 尝试将键和值添加到字典中：如果不存在，才添加；存在，不添加也不抛导常
        /// </summary>
        public static Dictionary<TKey, TValue> TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key) == false) dict.Add(key, value);
            return dict;
        }

        /// <summary>
        /// 将键和值添加或替换到字典中(如果不存则添加；存在则替换)
        /// </summary>
        public static Dictionary<TKey, TValue> AddOrReplace<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            dict[key] = value;
            return dict;
        }

        /// <summary>
        /// 获取键值
        /// </summary>
        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue))
        {
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }
    }
}
