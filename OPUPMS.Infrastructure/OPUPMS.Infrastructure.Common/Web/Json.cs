/********************************************************************************
 * Copyright © 2017 OPUPMS.Framework 版权所有
 * Author: OPUPMS - Justin
 * Description: OPUPMS快速开发平台
 * Website：http://www.opu.com.cn
*********************************************************************************/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace OPUPMS.Infrastructure.Common.Web
{
    /// <summary>
    /// Json 扩展类
    /// </summary>
    public static class Json
    {
        public static object ToJson(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject(Json);
        }

        /// <summary>
        /// 将对象序列化为Json 字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            return JsonConvert.SerializeObject(obj, timeConverter);
        }

        public static string ToJson(this object obj, string datetimeformats)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = datetimeformats };
            return JsonConvert.SerializeObject(obj, timeConverter);
        }

        /// <summary>
        /// 将Json 反序列化为指定对象类型的 Object
        /// </summary>
        /// <typeparam name="T">指定需反序列化的对象类型</typeparam>
        /// <param name="Json">Json 字符串</param>
        /// <returns></returns>
        public static T ToObject<T>(this string Json)
        {
            return Json == null ? default(T) : JsonConvert.DeserializeObject<T>(Json);
        }

        public static List<T> ToList<T>(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject<List<T>>(Json);
        }

        public static DataTable ToTable(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject<DataTable>(Json);
        }

        public static JObject ToJObject(this string Json)
        {
            return Json == null ? JObject.Parse("{}") : JObject.Parse(Json.Replace("&nbsp;", ""));
        }

        public static string ObjToGetStr(this object T)
        {
            StringBuilder res = new StringBuilder();
            Type type = T.GetType();
            System.Reflection.PropertyInfo[] ps = type.GetProperties();
            foreach (PropertyInfo i in ps)
            {
                object obj = i.GetValue(T, null);
                if (res.IsEmpty())
                {
                    res.Append($"{i.Name}={obj}");
                }
                else
                {
                    res.Append($"&{i.Name}={obj}");
                }
            }
            return res.ToString();
        }
    }
}
