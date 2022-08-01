using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Web.Script.Serialization;

namespace HRMS.BPW
{
    public class json
    {
        #region 【json转换为字符串】
        /// <summary>
        /// json转换为字符串
        /// </summary>
        /// <param name="rs"></param>
        /// <returns></returns>
        public static string parse(Hashtable rs)
        {
            return new JavaScriptSerializer().Serialize(rs);
        }
        #endregion

        #region 【字符串转换为json】
        /// <summary>
        /// 字符串转换为json
        /// </summary>
        /// <param name="rs"></param>
        /// <returns></returns>
        public static JObject parse(string rs)
        {
            try
            {
                return (JObject)JsonConvert.DeserializeObject(rs);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion


        #region 【json端口】
        /// <summary>
        /// json端口
        /// </summary>
        public class port
        {
            public object data { get; set; }
            /// <summary>
            /// 获取用户列表参数,接口名称封装
            /// </summary>
            public paging.parameter paging { get; set; }
            /// <summary>
            /// 相关提示
            /// </summary>
            public string info { get; set; }
            /// <summary>
            /// 错误提示
            /// </summary>
            public string error { get; set; }
            /// <summary>
            /// 添加内容返回的ID
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 数量
            /// </summary>
            public object count { get; set; }
        }
        #endregion
    }
}