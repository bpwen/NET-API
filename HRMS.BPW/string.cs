using System;

namespace HRMS.BPW
{
    /// <summary>
    /// 字符串处理
    /// </summary>
    public class @string
    {
        #region 【随机】
        /// <summary>
        /// 随机
        /// </summary>
        /// <param name="str">数字一个范围如999以内数字</param>
        /// <returns></returns>
        /// 可用于订单号如：bpw.data.Admin.Admin.get_bill(0) + bpw.Time.val("yyyyMMddHHmmss") + bpw.@string.Ran(999);
        public static string Ran(int str)
        {
            Random ran = new Random();
            return ran.Next(str).ToString();
        }
        #endregion

        #region 【全局唯一标识符】
        /// <summary>
        /// 全局唯一标识符
        /// </summary>
        /// <returns></returns>
        public static string Guid()
        {
            return System.Guid.NewGuid().ToString("N");
        }
        /// <summary>
        /// 全局唯一标识符
        /// </summary>
        /// <param name="str">
        /// GUID 的格式为“xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx”，其中每个 x 是 0-9 或 a-f 范围内的一个32位十六进制数。例如：6F9619FF-8B86-D011-B42D-00C04FC964FF 即为有效的 GUID 值。
        ///System.Guid.NewGuid().ToString("N");        32位字符串
        ///xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        ///
        ///System.Guid.NewGuid().ToString("D");        连字符分隔的32位字符串
        ///xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
        ///
        ///System.Guid.NewGuid().ToString("B");        在大括号中、由连字符分隔的32位字符串
        ///{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}
        ///
        ///System.Guid.NewGuid().ToString("P");        在圆括号中、由连字符分隔的32位字符串
        ///(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
        /// </param>
        /// <returns></returns>
        public static string Guid(string str)
        {
            return System.Guid.NewGuid().ToString(str);
        }
        #endregion

        #region 【删除字符串】
        /// <summary>
        /// 删除字符串
        /// </summary>
        /// <param name="Text">文本</param>
        /// <param name="Start">从第几个开始：如删除最后一个字符则传【Text.Length-1】文本的长度-1，End传1，如Delete("www.bxsc.net",0,3)返回则bxsc.net</param>
        /// <param name="End">最后一个</param>
        /// <returns></returns>
        public static string Delete(string Text, int Start, int End)
        {
            return Text.Remove(Start, End);
        }
        #endregion

        #region 【字符转换大小写和相关判断】
        /// <summary>
        /// 字符转换和判断
        /// </summary>
        /// <param name="str">字符</param>
        /// <param name="type">输出那一个</param>
        /// <returns></returns>
        public static string zh(char str, int type)
        {
            string Result = null;
            switch (type)
            {
                case 1:
                    Result = Char.IsLetter(str).ToString();//判断是否为字母    返回 true false
                    break;
                case 2:
                    Result = Char.IsDigit(str).ToString();//判断是否为数字    返回 true false
                    break;
                case 3:
                    Result = Char.IsLetterOrDigit(str).ToString();//判断是否为字母和数字数字    返回 true false
                    break;
                case 4:
                    Result = Char.IsLower(str).ToString();//判断是否为小写字母    返回 true false
                    break;
                case 5:
                    Result = Char.IsUpper(str).ToString();//判断是否为大写字母    返回 true false
                    break;
                case 6:
                    Result = Char.IsPunctuation(str).ToString();//判断是否为标点符号    返回 true false
                    break;
                case 7:
                    Result = Char.IsSeparator(str).ToString();//判断是否为分割符    返回 true false
                    break;
                case 8:
                    Result = Char.IsWhiteSpace(str).ToString();//判断是否为空白    返回 true false
                    break;
                case 9:
                    Result = Char.ToUpper(str).ToString();//将字符转换为大写字母
                    break;
                case 10:
                    Result = Char.ToLower(str).ToString();//将字符转换为小写字母
                    break;
                default:
                    break;
            }
            return Result;
        }
        #endregion

        #region 【比较字符串相同相等不】
        /// <summary>
        /// 比较字符串相同相等不 相同为 true 否则为 false
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stra"></param>
        /// <returns></returns>
        public static bool IsContrast(string str, string stra)
        {
            return str.Equals(stra);
        }

        /// <summary>
        /// 比较字符串相同相等不
        /// </summary>
        /// <param name="str">字符串1</param>
        /// <param name="stra">字符串2</param>
        /// <param name="type">1Compare比较 2CompareTo比较 3略其大小写比较</param>
        /// <returns></returns>
        public static int IsContrast(string str, string stra, int type)
        {
            int Result = 0;
            switch (type)
            {
                case 1:
                    Result = String.Compare(str, stra);//比较两个字符相同不，相同则返回0 返回1或-1都是不相同
                    break;
                case 2:
                    Result = str.CompareTo(stra);//比较两个字符相同不，相同则返回0 返回1或-1都是不相同
                    break;
                case 3:
                    Result = String.Compare(str, stra, true);//较两个字符相同不忽略其大小写
                    break;
                default:
                    break;
            }
            return Result;


        }
        #endregion

        #region 【截取符号】
        /// <summary>
        /// 截取符号
        /// </summary>
        /// <param name="str">字符</param>
        /// <param name="Symbol">Symbol 截取符号 如 // | ,</param>
        /// <param name="Ending">结位置</param>
        /// <returns></returns>
        /// str = D:\\BPWEN\\bxsc.com
        /// Symbol = \\
        /// Ending = 1
        /// return bxsc.com
        public static string Substring(string str, string Symbol, int Ending)
        {
            string Result = null;
            Result = str.Substring(str.LastIndexOf(Symbol) + Ending);
            return Result;
        }

        /// <summary>
        /// 截取符号
        /// </summary>
        /// <param name="str">字符</param>
        /// <param name="Start">开始位置</param>
        /// <param name="Symbol">Symbol 截取符号 如 // | ,</param>
        /// <param name="Ending">结位置</param>
        /// <returns></returns>
        /// str = D:\\BPWEN\\bxsc.com
        /// Start = 0
        /// Symbol = \\
        /// Ending = 1
        /// return D:\BPWEN\
        public static string Substring(string str, int Start, string Symbol, int Ending)
        {
            string Result = null;
            Result = str.Substring(Start, str.LastIndexOf(Symbol) + Ending);
            return Result;
        }

        /// <summary>
        /// 截取字符串长度从左到右第0个开始
        /// </summary>
        /// <param name="str">要截取的字符串</param>
        /// <param name="len">要截取的长度</param>
        /// <returns>返回字符串</returns>
        public static string SubStr(string str, int len)
        {
            if (str.Length > len)
            {
                return str.Substring(0, len);
            }
            else
            {
                return str;
            }
        }
        public static string SubStr(string str, int Start, int len)
        {
            if (str.Length > len)
            {
                return str.Substring(Start, len);
            }
            else
            {
                return str;
            }
        }
        #endregion

        #region 【分割字符读取】
        /// <summary>
        /// 分割字符读取
        /// </summary>
        /// <param name="str">a,b,c,d,e,f,g</param>
        /// <param name="i">2</param>
        /// <returns>b</returns>
        public static string Split(string str, int i)
        {
            string[] staNews = str.Split(',');
            return staNews[i];
        }
        public static string Split(string str, string Symbol, int i)
        {
            string[] staNews = str.Split(char.Parse(Symbol));
            return staNews[i];
        }

        #endregion

        #region 【插入填充字符串】
        /// <summary>
        /// 按位置插入填充
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Seat">Seat插入位子</param>
        /// <param name="Fill">插入字符</param>
        /// str = bxsc
        /// Seat = 0
        /// Fill = www.
        /// str1 = www.bxsc
        /// 
        /// str = www.bxsc
        /// Seat = 8
        /// Fill = .com
        /// str1 = www.bxsc.com
        public void Insert(string str, int Seat, string Fill)
        {
            string str1 = str.Insert(Seat, Fill);
        }

        /// <summary>
        /// 左右填充字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="leftFill">左字符</param>
        /// <param name="rightFill">右字符</param>
        /// <returns></returns>
        /// str = 百姓市场
        /// str3 = 《百姓市场》
        public string Insert(string str)
        {
            string str1 = str;
            string str2 = str1.PadLeft(str1.Length + 1, '《');
            string str3 = str2.PadRight(str2.Length + 1, '》');
            return str3;
        }

        #endregion

        #region 过滤某个字符
        /// <summary>
        /// 过滤某个字符
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="Object">指定删除的</param>
        /// <param name="str">替换的值</param>
        /// <returns>如文本：Replace("administrator","istrator","")返回：return admin</returns>
        public string Replace(string text, string Object, string str)
        {
            return text.Replace(Object, str);
        }
        #endregion 

        #region 【移出最后一个字符】
        /// <summary>
        /// 移出最后一个字符
        /// </summary>
        /// <param name="str">字符</param>
        /// <returns></returns>
        public static string Remove(string str)
        {
            return str.Remove(str.Length - 1, 1);
        }
        #endregion
    }
}