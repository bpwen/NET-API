using System.Web;
using System.Web.Script.Serialization;

namespace HRMS.BPW
{
    /// <summary>
    /// 响应
    /// </summary>
    public class Response
    {
        #region 【接口返回接口应用】
        public static string GetModel(object text)
        {
            json.port json = new json.port();
            json.data = text;
            return new JavaScriptSerializer().Serialize(json);
        }

        public static string GetModel(object text, int i)
        {
            json.port json = new json.port();
            json.data = text;
            json.count = i;
            return new JavaScriptSerializer().Serialize(json);
        }

        public static string GetModel(object textA, paging.parameter textB)
        {
            json.port json = new json.port();
            json.data = textA;
            json.paging = textB;
            return new JavaScriptSerializer().Serialize(json);
        }

        #region 【GetCount】
        /// <summary>
        /// 数量
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string GetCount(string i)
        {
            json.port json = new json.port();
            json.count = i;
            return new JavaScriptSerializer().Serialize(json);
        }
        #endregion

        #region 【error】
        /// <summary>
        /// 错误提示返回已json形式返回
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <returns></returns>
        public static string error(string text)
        {
            json.port json = new json.port();
            json.error = text;
            return new JavaScriptSerializer().Serialize(json);
        }
        #endregion

        #region 【alert】
        /// <summary>
        /// 相关提示返回已json形式返回
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <returns></returns>
        public static string alert(string text)
        {
            json.port json = new json.port();
            json.info = text;
            return new JavaScriptSerializer().Serialize(json);
        }
        /// <summary>
        /// 相关提示返回已json形式返回
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="id">错误自定义ID</param>
        /// <returns></returns>
        public static string alert(string text, int id)
        {
            json.port json = new json.port();
            json.info = text;
            json.id = id;
            return new JavaScriptSerializer().Serialize(json);
        }
        public static string alert(bool _bool)
        {
            json.port json = new json.port();
            json.info = _bool.ToString();
            return new JavaScriptSerializer().Serialize(json);
        }
        #endregion
        #endregion

        #region 【Response应用】

        #region 【输出一个文本】
        /// <summary>
        /// 输出一个文本
        /// </summary>
        /// <param name="objs"></param>
        public static void Write(string objs)
        {
            HttpContext.Current.Response.Write(objs);
        }
        #endregion

        #region 【将请求重定向到新 URL 并指定该新 URL】
        /// <summary>
        /// 将请求重定向到新 URL 并指定该新 URL
        /// </summary>
        /// <param name="url"></param>
        public static void Redirect(string url)
        {
            HttpContext.Current.Response.Redirect(url);
        }
        #endregion

        #endregion
    }
}