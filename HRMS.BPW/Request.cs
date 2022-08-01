using System;
using System.Web;

namespace HRMS.BPW
{
    /// <summary>
    /// 获取
    /// </summary>
    public class Request
    {
        #region 【Form】
        /// <summary>
        /// 文本框取值
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string form(string text)
        {
            return HttpContext.Current.Request.Form[text];
        }

        /// <summary>
        /// 文本框取值
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Form(string text)
        {
             return form(text);
        }

        /// <summary>
        /// 文本框取值,是否数字如不是则返回-1不保留小数点。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="i">默认为0数字类型</param>
        /// <returns></returns>
        public static int Form(string text, int i)
        {
            string objs = Form(text);
            if (objs != null)
            {
                if (regex.IsDigital(objs))
                {
                    return Convert.ToInt32(objs);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 文本框取值,是否数字如不是则返回-1保留小数点。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static decimal Intf(string text)
        {
            string objs = form(text);
            if (objs != null)
            {
                try
                {
                    decimal str = Convert.ToDecimal(objs);
                    if (regex.IsDigital(str.ToString()))
                    {
                        return str;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 文本框取值,是否数字如不是则返回-1获取整数需要小数点则用Intf。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int Int(string text)
        {
            string objs = form(text);
            if (objs != null)
            {
                if (regex.IsDigital(objs))
                {
                    return Convert.ToInt32(objs);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region 【QueryString】
        /// <summary>
        /// 获取URL上相关参数
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string QueryString(string text)
        {
            string objs = HttpContext.Current.Request.QueryString[text];
            if (string.IsNullOrEmpty(objs))
            {
                return null;
            }
            else
            {
                return objs;
            }
        }

        /// <summary>
        /// 文本框取值，没删除相关空格字符等。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="i">默认为0</param>
        /// <returns></returns>
        public static string QueryString(string text, string i)
        {
            string objs = HttpContext.Current.Request.QueryString[text];
            if (string.IsNullOrEmpty(objs))
            {
                return null;
            }
            else
            {
                return objs;
            }
        }

        /// <summary>
        /// 获取URL上相关参数,是否数字如不是则返回-1。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int QueryStringInt(string text)
        {
            string objs = QueryString(text);
            if(objs != null)
            {
                if (regex.IsDigital(objs))
                {
                    return Convert.ToInt32(objs);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        #endregion

        public static string HtmlEncode(string val, int i)
        {
            //表示删除空格和对HTML字符编码的就是把>变成& gt;对特殊符号进行编码
            string Text = System.Web.HttpContext.Current.Server.HtmlEncode(val.Trim());

            switch (i)
            {
                case 1:
                    Text = Text.Replace(" ", "");
                    break;
                case 2:
                    Text = Text.Replace(" ", "");
                    break;
            }
            return Text;
        }

        #region 【IP】
        /// <summary>
        /// 获取客户端IP地址
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string IP()
        {
            string clientIP = "0.0.0.0";
            if (System.Web.HttpContext.Current != null)
            {
                HttpRequest request = HttpContext.Current.Request;
                clientIP = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (string.IsNullOrEmpty(clientIP) || (clientIP.ToLower() == "unknown"))
                {
                    clientIP = request.ServerVariables["HTTP_X_REAL_IP"];
                    if (string.IsNullOrEmpty(clientIP))
                    {
                        clientIP = request.ServerVariables["REMOTE_ADDR"];
                    }
                }
                else
                {
                    clientIP = clientIP.Split(',')[0];
                }
            }
            return clientIP;
        }
        #endregion

        #region 【域名网址】
        /// <summary>
        /// 域名地址
        /// </summary>
        /// <returns></returns>
        public static string Url()
        {
            if(HttpContext.Current.Request.Url.Port == 80)
            {
                return Convert.ToString("http://" + HttpContext.Current.Request.Url.Host);
            }
            else
            {
                return Convert.ToString("http://" + HttpContext.Current.Request.Url.Host + ":" + HttpContext.Current.Request.Url.Port);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">
        /// 0:用户上一页地址
        /// </param>
        /// <returns></returns>
        public static string Url(int i)
        {
            string url = null;
            // 用户上一页地址
            if(i == 0){
                try
                {
                    url = HttpContext.Current.Request.UrlReferrer.ToString();
                    if (IF.Null(url))
                    {
                        url = HttpContext.Current.Request.ServerVariables["HTTP_REFERER"];
                    }
                }
                catch (Exception)
                {

                }
            }
            else if (i == 1)
            {
                // 当前页地址
                try
                {
                    url = HttpContext.Current.Request.Url.ToString();
                }
                catch (Exception)
                {

                }
            }
            return url;
        }
        #endregion
    }
}