using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.applets;
using HRMS.DBUtility;
using System.Text.RegularExpressions;

namespace HRMS.SQLServerDAL.applets
{
	/// <summary>
	/// applets_industry
	/// </summary>
	public partial class industryDAL : IindustryDAL
	{
		public industryDAL()
		{}
        #region 【基本方法】BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "applets_industry");
        }
        #endregion

        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from applets_industry");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
    			new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool Exists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from applets_industry");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Exists(strSql.ToString());
        }
        #endregion

        #region 【增加一条数据】
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(HRMS.Model.applets.industryModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into applets_industry(");
            strSql.Append("title,cover,microcode,date,uid)");
            strSql.Append(" values (");
            strSql.Append("@title,@cover,@microcode,@date,@uid)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
		    		new SqlParameter("@title", SqlDbType.NVarChar,50),
                    new SqlParameter("@cover", SqlDbType.NVarChar,100),
                    new SqlParameter("@microcode", SqlDbType.NVarChar,100),
                    new SqlParameter("@date", SqlDbType.DateTime),
                    new SqlParameter("@uid", SqlDbType.Int,4)
            };
			parameters[0].Value = model.title;
            parameters[1].Value = model.cover;
            parameters[2].Value = model.microcode;
            parameters[3].Value = model.date;
            parameters[4].Value = model.uid;

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
        #endregion
        
        #region 【更新一条数据】
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HRMS.Model.applets.industryModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update applets_industry set ");
            strSql.Append("title=@title,");
    		strSql.Append("cover=@cover,");
    		strSql.Append("microcode=@microcode,");
    		strSql.Append("date=@date,");
    		strSql.Append("uid=@uid");
    		strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
		    		new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@title", SqlDbType.NVarChar,50),
                    new SqlParameter("@cover", SqlDbType.NVarChar,100),
                    new SqlParameter("@microcode", SqlDbType.NVarChar,100),
                    new SqlParameter("@date", SqlDbType.DateTime),
                    new SqlParameter("@uid", SqlDbType.Int,4)
		    };
			parameters[0].Value = model.id;
            parameters[1].Value = model.title;
            parameters[2].Value = model.cover;
            parameters[3].Value = model.microcode;
            parameters[4].Value = model.date;
            parameters[5].Value = model.uid;

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
        #endregion

        #region 【删除一条数据】
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from applets_industry ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
    			new SqlParameter("@id", SqlDbType.Int,4)
 
            };
            parameters[0].Value = id;

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
        
        public bool Delete(string strWhere, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from applets_industry ");
            strSql.Append(" where " + strWhere + "=@id");
            SqlParameter[] parameters = {
    			new SqlParameter("@id", SqlDbType.Int,4)
 
            };
            parameters[0].Value = id;

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
        #endregion
        
        #region 【批量删除数据】
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
			#region 【正则判断提交过来的值全是数字类型不，如有其他字符则返回 false】
            bool _bool = true;
            if (idlist.IndexOf(",") > 0)
            {
                MatchCollection matches = Regex.Matches(idlist, @"[^,<]+");
                foreach (Match match in matches)
                {
                    if (!Regex.IsMatch(match.Groups[0].Value, (@"^[0-9]*$")))
                    {
                        _bool = false;
                        break;
                    }
                }
            }
            if (!_bool)
            {
                return false;
            }
            #endregion
        
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from applets_industry ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        #endregion

        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.applets.industryModel GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 id,title,cover,microcode,date,uid from applets_industry ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
    			new SqlParameter("@id", SqlDbType.Int,4)      
            };
            parameters[0].Value = id;

            HRMS.Model.applets.industryModel model = new HRMS.Model.applets.industryModel();
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
        public HRMS.Model.applets.industryModel GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 id,title,cover,microcode,date,uid from applets_industry ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" where " + strWhere);
            }

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.applets.industryModel DataRowToModel(DataRow row)
        {
            HRMS.Model.applets.industryModel model = new HRMS.Model.applets.industryModel();
            if (row != null)
            {
	    		
	    		if (row["id"] != null && row["id"].ToString() != "")
	    		{
	    			model.id = int.Parse(row["id"].ToString());
	    		}
	    		if (row["title"] != null)
	    		{
	    			model.title = row["title"].ToString();
	    		}
	    		if (row["cover"] != null)
	    		{
	    			model.cover = row["cover"].ToString();
	    		}
	    		if (row["microcode"] != null)
	    		{
	    			model.microcode = row["microcode"].ToString();
	    		}
	    		if (row["date"] != null && row["date"].ToString() != "")
	    		{
	    			model.date = DateTime.Parse(row["date"].ToString());
	    		}
	    		if (row["uid"] != null && row["uid"].ToString() != "")
	    		{
	    			model.uid = int.Parse(row["uid"].ToString());
	    		}
            }
            return model;
        }
        #endregion

        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,cover,microcode,date,uid ");
            strSql.Append(" FROM applets_industry ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region 【获得前几行数据】
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
            strSql.Append(" id,title,cover,microcode,date,uid ");
            strSql.Append(" FROM applets_industry ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region 【获取记录总数】
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM applets_industry ");
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
        #endregion
        
        #region 【分页获取数据列表】
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from applets_industry T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
        
		#region 【批量更新】
		/// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="set">更新字段=? 多个则 字段a=?,字段b=?</param>
        /// <returns></returns>
        /// Post.Update("Bool=0 where AdminID=2");   对应所有AdminID=2的字段Bool=0
        public bool Update(string set)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update applets_industry set "+ set);
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
        /// 批量更新
        /// </summary>
        /// <param name="set">更新字段=? 多个则 字段a=?,字段b=?</param>
        /// <param name="id">ID串</param>
        /// <returns></returns>
        public bool Update(string set, string id)
        {
			#region 【正则判断提交过来的值全是数字类型不，如有其他字符则返回 false】
            bool _bool = true;
            if (id.IndexOf(",") > 0)
            {
                MatchCollection matches = Regex.Matches(id, @"[^,<]+");
                foreach (Match match in matches)
                {
                    if (!Regex.IsMatch(match.Groups[0].Value, (@"^[0-9]*$")))
                    {
                        _bool = false;
                        break;
                    }
                }
            }
            if (!_bool)
            {
                return false;
            }
            #endregion
        
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update applets_industry set "+ set);
            strSql.Append(" where id in (" + id + ")  ");
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
        #endregion

        #endregion 【基本方法】BasicMethod

        #region  【编辑】ExtensionMethod
        
        #endregion  ExtensionMethod
    }
}