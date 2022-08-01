using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HRMS.BPW
{
    /// <summary>
    /// 正则表达式
    /// </summary>
    public class regex
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regular"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Dictionary<string, string> IsRegular(string regular, string value)
        {
            MatchCollection str = Regex.Matches(value, regular, RegexOptions.IgnoreCase);
            Dictionary<string, string> array = new Dictionary<string, string>();
            if (str.Count != 0)
            {
                foreach (Match rs in str)
                {
                    for (int i=0;i< rs.Groups.Count; i++)
                    {
                        array["value_" + i] = rs.Groups[i].Value;
                    }
                }
            }
            return array;
        }


        #region 【正则表达式】判断True还是False
        private static bool IsMatch(string str, string value)
        {
            Regex regex = new System.Text.RegularExpressions.Regex(value);
            return Regex.IsMatch(value, str);
        }
        #endregion

        #region 验证是否数字
        /// <summary>
        ///验证是否数字
        /// </summary>
        public static bool IsDigital(string itemValue)
        {
            //return (IsMatch(@"^[0-9]*$", itemValue));
            return (IsMatch(@"^\d+(\.\d+)?$", itemValue));
        }
        #endregion

        #region 验证数字
        /// <summary>
        ///验证是否数字:1,2,3,4,5,6
        /// </summary>
        public static bool IsArrint(string itemValue)
        {
            return (IsMatch(@"^\d(,\d)*$", itemValue));
        }
        #endregion

        #region 验证IP地址
        /// <summary>
        /// 验证IP地址
        /// </summary>
        public static bool IsIP(string itemValue)
        {
            return (IsMatch(@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$", itemValue));
        }
        #endregion
    }
}