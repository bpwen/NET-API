using System;

namespace HRMS.Model.Admin
{
	/// <summary>
	/// 用户系统
	/// </summary>
	[Serializable]
	public partial class AdminModel
	{
		public AdminModel()
		{}
        #region Model
        private int _admin_id;
        private string _admin_username;
        private string _admin_password;
        private int? _admin_user_group = 0;
        private int? _admin_state = 0;
        private int? _admin_logon_times = 0;
        private int? _admin_addid = 0;
        private string _admin_online = "0";
        private string _admin_ip;
        private DateTime? _admin_date = DateTime.Now;
        private DateTime? _admin_zjdate = DateTime.Now;
        private string _admin_zjip;
        /// <summary>
        /// 帐号ID
        /// </summary>
        public int Admin_ID
        {
            set { _admin_id = value; }
            get { return _admin_id; }
        }
        /// <summary>
        /// 登录帐号
        /// </summary>
        public string Admin_username
        {
            set { _admin_username = value; }
            get { return _admin_username; }
        }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Admin_password
        {
            set { _admin_password = value; }
            get { return _admin_password; }
        }
        /// <summary>
        /// 用户组:如(普通用户0，会员1，企业会员2，年度会员3，超级会员4，前台管理员5，系统管理员组6)数字对应用户组自定义编号
        /// </summary>
        public int? Admin_User_group
        {
            set { _admin_user_group = value; }
            get { return _admin_user_group; }
        }
        /// <summary>
        /// 帐号状态：默认为0表示正常，锁定为1，表示不准登录，异常状态
        /// </summary>
        public int? Admin_State
        {
            set { _admin_state = value; }
            get { return _admin_state; }
        }
        /// <summary>
        /// 帐号登录次数
        /// </summary>
        public int? Admin_Logon_times
        {
            set { _admin_logon_times = value; }
            get { return _admin_logon_times; }
        }
        /// <summary>
        /// 添加人：默认为0表示用户注册或SQL数据库里面添加，如是管理员添加则记录管理员帐号ID
        /// </summary>
        public int? Admin_AddID
        {
            set { _admin_addid = value; }
            get { return _admin_addid; }
        }
        /// <summary>
        /// 用户是否在线,0表示不在线，不等于0则表示在线，不等于0则是用户当前会话的唯一标识符。
        /// </summary>
        public string Admin_Online
        {
            set { _admin_online = value; }
            get { return _admin_online; }
        }
        /// <summary>
        /// 记录添加或帐号注册地的IP地址
        /// </summary>
        public string Admin_IP
        {
            set { _admin_ip = value; }
            get { return _admin_ip; }
        }
        /// <summary>
        /// 帐号添加日期或帐号注册日期
        /// </summary>
        public DateTime? Admin_Date
        {
            set { _admin_date = value; }
            get { return _admin_date; }
        }
        /// <summary>
        /// 记录最近登录日期
        /// </summary>
        public DateTime? Admin_zjdate
        {
            set { _admin_zjdate = value; }
            get { return _admin_zjdate; }
        }
        /// <summary>
        /// 记录最近登录IP
        /// </summary>
        public string Admin_zjip
        {
            set { _admin_zjip = value; }
            get { return _admin_zjip; }
        }
        #endregion Model

    }
}

