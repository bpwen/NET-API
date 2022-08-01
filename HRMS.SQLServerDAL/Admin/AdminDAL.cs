using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.Admin;
using HRMS.DBUtility;//Please add references

namespace HRMS.SQLServerDAL.Admin
{
	/// <summary>
	/// 数据访问类:AdminDAL
	/// </summary>
	public partial class AdminDAL:IAdminDAL
	{
		public AdminDAL()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Admin_ID", "Admin");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Admin_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append(" where Admin_ID=@Admin_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Admin_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(HRMS.Model.Admin.AdminModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Admin(");
            strSql.Append("Admin_username,Admin_password,Admin_User_group,Admin_State,Admin_Logon_times,Admin_AddID,Admin_Online,Admin_IP,Admin_Date,Admin_zjdate,Admin_zjip)");
            strSql.Append(" values (");
            strSql.Append("@Admin_username,@Admin_password,@Admin_User_group,@Admin_State,@Admin_Logon_times,@Admin_AddID,@Admin_Online,@Admin_IP,@Admin_Date,@Admin_zjdate,@Admin_zjip)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_username", SqlDbType.NVarChar,50),
                    new SqlParameter("@Admin_password", SqlDbType.NVarChar,500),
                    new SqlParameter("@Admin_User_group", SqlDbType.Int,4),
                    new SqlParameter("@Admin_State", SqlDbType.Int,4),
                    new SqlParameter("@Admin_Logon_times", SqlDbType.Int,4),
                    new SqlParameter("@Admin_AddID", SqlDbType.Int,4),
                    new SqlParameter("@Admin_Online", SqlDbType.NVarChar,100),
                    new SqlParameter("@Admin_IP", SqlDbType.NVarChar,20),
                    new SqlParameter("@Admin_Date", SqlDbType.DateTime),
                    new SqlParameter("@Admin_zjdate", SqlDbType.DateTime),
                    new SqlParameter("@Admin_zjip", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.Admin_username;
            parameters[1].Value = model.Admin_password;
            parameters[2].Value = model.Admin_User_group;
            parameters[3].Value = model.Admin_State;
            parameters[4].Value = model.Admin_Logon_times;
            parameters[5].Value = model.Admin_AddID;
            parameters[6].Value = model.Admin_Online;
            parameters[7].Value = model.Admin_IP;
            parameters[8].Value = model.Admin_Date;
            parameters[9].Value = model.Admin_zjdate;
            parameters[10].Value = model.Admin_zjip;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HRMS.Model.Admin.AdminModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Admin set ");
            strSql.Append("Admin_username=@Admin_username,");
            strSql.Append("Admin_password=@Admin_password,");
            strSql.Append("Admin_User_group=@Admin_User_group,");
            strSql.Append("Admin_State=@Admin_State,");
            strSql.Append("Admin_Logon_times=@Admin_Logon_times,");
            strSql.Append("Admin_AddID=@Admin_AddID,");
            strSql.Append("Admin_Online=@Admin_Online,");
            strSql.Append("Admin_IP=@Admin_IP,");
            strSql.Append("Admin_Date=@Admin_Date,");
            strSql.Append("Admin_zjdate=@Admin_zjdate,");
            strSql.Append("Admin_zjip=@Admin_zjip");
            strSql.Append(" where Admin_ID=@Admin_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_username", SqlDbType.NVarChar,50),
                    new SqlParameter("@Admin_password", SqlDbType.NVarChar,500),
                    new SqlParameter("@Admin_User_group", SqlDbType.Int,4),
                    new SqlParameter("@Admin_State", SqlDbType.Int,4),
                    new SqlParameter("@Admin_Logon_times", SqlDbType.Int,4),
                    new SqlParameter("@Admin_AddID", SqlDbType.Int,4),
                    new SqlParameter("@Admin_Online", SqlDbType.NVarChar,100),
                    new SqlParameter("@Admin_IP", SqlDbType.NVarChar,20),
                    new SqlParameter("@Admin_Date", SqlDbType.DateTime),
                    new SqlParameter("@Admin_zjdate", SqlDbType.DateTime),
                    new SqlParameter("@Admin_zjip", SqlDbType.NVarChar,20),
                    new SqlParameter("@Admin_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Admin_username;
            parameters[1].Value = model.Admin_password;
            parameters[2].Value = model.Admin_User_group;
            parameters[3].Value = model.Admin_State;
            parameters[4].Value = model.Admin_Logon_times;
            parameters[5].Value = model.Admin_AddID;
            parameters[6].Value = model.Admin_Online;
            parameters[7].Value = model.Admin_IP;
            parameters[8].Value = model.Admin_Date;
            parameters[9].Value = model.Admin_zjdate;
            parameters[10].Value = model.Admin_zjip;
            parameters[11].Value = model.Admin_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Admin_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Admin ");
            strSql.Append(" where Admin_ID=@Admin_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Admin_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Admin_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Admin ");
            strSql.Append(" where Admin_ID in (" + Admin_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.Admin.AdminModel GetModel(int Admin_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Admin_ID,Admin_username,Admin_password,Admin_User_group,Admin_State,Admin_Logon_times,Admin_AddID,Admin_Online,Admin_IP,Admin_Date,Admin_zjdate,Admin_zjip from Admin ");
            strSql.Append(" where Admin_ID=@Admin_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Admin_ID;

            HRMS.Model.Admin.AdminModel model = new HRMS.Model.Admin.AdminModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.Admin.AdminModel DataRowToModel(DataRow row)
        {
            HRMS.Model.Admin.AdminModel model = new HRMS.Model.Admin.AdminModel();
            if (row != null)
            {
                if (row["Admin_ID"] != null && row["Admin_ID"].ToString() != "")
                {
                    model.Admin_ID = int.Parse(row["Admin_ID"].ToString());
                }
                if (row["Admin_username"] != null)
                {
                    model.Admin_username = row["Admin_username"].ToString();
                }
                if (row["Admin_password"] != null)
                {
                    model.Admin_password = row["Admin_password"].ToString();
                }
                if (row["Admin_User_group"] != null && row["Admin_User_group"].ToString() != "")
                {
                    model.Admin_User_group = int.Parse(row["Admin_User_group"].ToString());
                }
                if (row["Admin_State"] != null && row["Admin_State"].ToString() != "")
                {
                    model.Admin_State = int.Parse(row["Admin_State"].ToString());
                }
                if (row["Admin_Logon_times"] != null && row["Admin_Logon_times"].ToString() != "")
                {
                    model.Admin_Logon_times = int.Parse(row["Admin_Logon_times"].ToString());
                }
                if (row["Admin_AddID"] != null && row["Admin_AddID"].ToString() != "")
                {
                    model.Admin_AddID = int.Parse(row["Admin_AddID"].ToString());
                }
                if (row["Admin_Online"] != null)
                {
                    model.Admin_Online = row["Admin_Online"].ToString();
                }
                if (row["Admin_IP"] != null)
                {
                    model.Admin_IP = row["Admin_IP"].ToString();
                }
                if (row["Admin_Date"] != null && row["Admin_Date"].ToString() != "")
                {
                    model.Admin_Date = DateTime.Parse(row["Admin_Date"].ToString());
                }
                if (row["Admin_zjdate"] != null && row["Admin_zjdate"].ToString() != "")
                {
                    model.Admin_zjdate = DateTime.Parse(row["Admin_zjdate"].ToString());
                }
                if (row["Admin_zjip"] != null)
                {
                    model.Admin_zjip = row["Admin_zjip"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Admin_ID,Admin_username,Admin_password,Admin_User_group,Admin_State,Admin_Logon_times,Admin_AddID,Admin_Online,Admin_IP,Admin_Date,Admin_zjdate,Admin_zjip ");
            strSql.Append(" FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Admin_ID,Admin_username,Admin_password,Admin_User_group,Admin_State,Admin_Logon_times,Admin_AddID,Admin_Online,Admin_IP,Admin_Date,Admin_zjdate,Admin_zjip ");
            strSql.Append(" FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Admin_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Admin T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Admin";
			parameters[1].Value = "Admin_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod

        #region  【编辑】ExtensionMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsUsername(string Admin_username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append(" where Admin_username=@Admin_username");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_username", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = Admin_username;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 检查用户是否在线用，会话查询查询到该用户其他信息
        /// </summary>
        /// <param name="SessionID">固定值必须：Session.SessionID</param>
        /// <returns></returns>
        public bool Exists_Online(string Admin_Online)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append(" where Admin_Online=@Admin_Online");
            SqlParameter[] parameters = {
                    new SqlParameter("@Admin_Online", SqlDbType.NVarChar,100)
            };
            parameters[0].Value = Admin_Online;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 用会话查询得到一个对象实体
        /// </summary>
        public HRMS.Model.Admin.AdminModel GetModel_Online(string Admin_Online)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Admin where Admin_Online=@Admin_Online");
            SqlParameter[] parameters = {
                new SqlParameter("@Admin_Online", SqlDbType.NVarChar,100)
            };
            parameters[0].Value = Admin_Online;

            HRMS.Model.Admin.AdminModel model = new HRMS.Model.Admin.AdminModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">帐号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public HRMS.Model.Admin.AdminModel Login(string userName, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Admin where Admin_username=@userName and Admin_password=@password");
            SqlParameter[] parameters = {
				new SqlParameter("@UserName", SqlDbType.NVarChar,50),
				new SqlParameter("@Password", SqlDbType.NVarChar,500),
            };
            parameters[0].Value = userName;
            parameters[1].Value = password;

            HRMS.Model.Admin.AdminModel model = new HRMS.Model.Admin.AdminModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

