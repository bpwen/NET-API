using System;
using System.Configuration;

namespace HRMS.DBUtility
{
    
    public class PubConstant
    {
        /// <summary>
        /// ���ݿ�����
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
