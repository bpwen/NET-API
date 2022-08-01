using System;
using System.Configuration;

namespace HRMS.DBUtility
{
    
    public class PubConstant
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public static string DBConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            }
        }
    }
}
