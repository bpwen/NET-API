using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.System;
using HRMS.DBUtility;//Please add references
using System.Text.RegularExpressions;

namespace HRMS.SQLServerDAL.System
{
	/// <summary>
	/// 数据访问类:IColumnDAL
	/// </summary>
	public partial class IColumnDAL:IIColumnDAL
	{
		public IColumnDAL()
		{}
        #region 【基本方法】BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Column_ID", "System_Column");
        }
        #endregion

        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Column_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from System_Column");
            strSql.Append(" where Column_ID=@Column_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Column_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Column_ID;
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
            strSql.Append("select count(1) from System_Column");
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
        public int Add(HRMS.Model.System.ColumnModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into System_Column(");
            strSql.Append("Column_Aid,Column_Name,Column_Sort,Column_Top_Special,Column_Body_Special,Column_Tail_Special,Column_Top_List,Column_Body_List,Column_Tail_List,Column_Top_Details,Column_Body_Details,Column_Tail_Details,Column_Keyword,Column_description,Column_SystemID,Column_FatherID,Column_ExternalUrl,Column_Singlecontent,Column_MessageID,Column_UserRelease,Column_Jcnmqy,Column_JcnmqyID,Column_Subtitle,Column_styleid,Column_englishname,Column_type,Column_type_name,Column_spcs,Column_setmeal,Column_icon)");
            strSql.Append(" values (");
            strSql.Append("@Column_Aid,@Column_Name,@Column_Sort,@Column_Top_Special,@Column_Body_Special,@Column_Tail_Special,@Column_Top_List,@Column_Body_List,@Column_Tail_List,@Column_Top_Details,@Column_Body_Details,@Column_Tail_Details,@Column_Keyword,@Column_description,@Column_SystemID,@Column_FatherID,@Column_ExternalUrl,@Column_Singlecontent,@Column_MessageID,@Column_UserRelease,@Column_Jcnmqy,@Column_JcnmqyID,@Column_Subtitle,@Column_styleid,@Column_englishname,@Column_type,@Column_type_name,@Column_spcs,@Column_setmeal,@Column_icon)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Column_Aid", SqlDbType.Int,4),
                    new SqlParameter("@Column_Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Column_Sort", SqlDbType.Int,4),
                    new SqlParameter("@Column_Top_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Top_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Top_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Keyword", SqlDbType.NText),
                    new SqlParameter("@Column_description", SqlDbType.NText),
                    new SqlParameter("@Column_SystemID", SqlDbType.Int,4),
                    new SqlParameter("@Column_FatherID", SqlDbType.Int,4),
                    new SqlParameter("@Column_ExternalUrl", SqlDbType.NText),
                    new SqlParameter("@Column_Singlecontent", SqlDbType.Text),
                    new SqlParameter("@Column_MessageID", SqlDbType.Int,4),
                    new SqlParameter("@Column_UserRelease", SqlDbType.Bit,1),
                    new SqlParameter("@Column_Jcnmqy", SqlDbType.Int,4),
                    new SqlParameter("@Column_JcnmqyID", SqlDbType.Int,4),
                    new SqlParameter("@Column_Subtitle", SqlDbType.NText),
                    new SqlParameter("@Column_styleid", SqlDbType.Int,4),
                    new SqlParameter("@Column_englishname", SqlDbType.NVarChar,50),
                    new SqlParameter("@Column_type", SqlDbType.Int,4),
                    new SqlParameter("@Column_type_name", SqlDbType.Int,4),
                    new SqlParameter("@Column_spcs", SqlDbType.Int,4),
                    new SqlParameter("@Column_setmeal", SqlDbType.Int,4),
                    new SqlParameter("@Column_icon", SqlDbType.NVarChar,500)
            };
            parameters[0].Value = model.Column_Aid;
            parameters[1].Value = model.Column_Name;
            parameters[2].Value = model.Column_Sort;
            parameters[3].Value = model.Column_Top_Special;
            parameters[4].Value = model.Column_Body_Special;
            parameters[5].Value = model.Column_Tail_Special;
            parameters[6].Value = model.Column_Top_List;
            parameters[7].Value = model.Column_Body_List;
            parameters[8].Value = model.Column_Tail_List;
            parameters[9].Value = model.Column_Top_Details;
            parameters[10].Value = model.Column_Body_Details;
            parameters[11].Value = model.Column_Tail_Details;
            parameters[12].Value = model.Column_Keyword;
            parameters[13].Value = model.Column_description;
            parameters[14].Value = model.Column_SystemID;
            parameters[15].Value = model.Column_FatherID;
            parameters[16].Value = model.Column_ExternalUrl;
            parameters[17].Value = model.Column_Singlecontent;
            parameters[18].Value = model.Column_MessageID;
            parameters[19].Value = model.Column_UserRelease;
            parameters[20].Value = model.Column_Jcnmqy;
            parameters[21].Value = model.Column_JcnmqyID;
            parameters[22].Value = model.Column_Subtitle;
            parameters[23].Value = model.Column_styleid;
            parameters[24].Value = model.Column_englishname;
            parameters[25].Value = model.Column_type;
            parameters[26].Value = model.Column_type_name;
            parameters[27].Value = model.Column_spcs;
            parameters[28].Value = model.Column_setmeal;
            parameters[29].Value = model.Column_icon;

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
        public bool Update(HRMS.Model.System.ColumnModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update System_Column set ");
            strSql.Append("Column_Aid=@Column_Aid,");
            strSql.Append("Column_Name=@Column_Name,");
            strSql.Append("Column_Sort=@Column_Sort,");
            strSql.Append("Column_Top_Special=@Column_Top_Special,");
            strSql.Append("Column_Body_Special=@Column_Body_Special,");
            strSql.Append("Column_Tail_Special=@Column_Tail_Special,");
            strSql.Append("Column_Top_List=@Column_Top_List,");
            strSql.Append("Column_Body_List=@Column_Body_List,");
            strSql.Append("Column_Tail_List=@Column_Tail_List,");
            strSql.Append("Column_Top_Details=@Column_Top_Details,");
            strSql.Append("Column_Body_Details=@Column_Body_Details,");
            strSql.Append("Column_Tail_Details=@Column_Tail_Details,");
            strSql.Append("Column_Keyword=@Column_Keyword,");
            strSql.Append("Column_description=@Column_description,");
            strSql.Append("Column_SystemID=@Column_SystemID,");
            strSql.Append("Column_FatherID=@Column_FatherID,");
            strSql.Append("Column_ExternalUrl=@Column_ExternalUrl,");
            strSql.Append("Column_Singlecontent=@Column_Singlecontent,");
            strSql.Append("Column_MessageID=@Column_MessageID,");
            strSql.Append("Column_UserRelease=@Column_UserRelease,");
            strSql.Append("Column_Jcnmqy=@Column_Jcnmqy,");
            strSql.Append("Column_JcnmqyID=@Column_JcnmqyID,");
            strSql.Append("Column_Subtitle=@Column_Subtitle,");
            strSql.Append("Column_styleid=@Column_styleid,");
            strSql.Append("Column_englishname=@Column_englishname,");
            strSql.Append("Column_type=@Column_type,");
            strSql.Append("Column_type_name=@Column_type_name,");
            strSql.Append("Column_spcs=@Column_spcs,");
            strSql.Append("Column_setmeal=@Column_setmeal,");
            strSql.Append("Column_icon=@Column_icon");
            strSql.Append(" where Column_ID=@Column_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Column_ID", SqlDbType.Int,4),
                    new SqlParameter("@Column_Aid", SqlDbType.Int,4),
                    new SqlParameter("@Column_Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Column_Sort", SqlDbType.Int,4),
                    new SqlParameter("@Column_Top_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_Special", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Top_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_List", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Top_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Body_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Tail_Details", SqlDbType.NVarChar,500),
                    new SqlParameter("@Column_Keyword", SqlDbType.NText),
                    new SqlParameter("@Column_description", SqlDbType.NText),
                    new SqlParameter("@Column_SystemID", SqlDbType.Int,4),
                    new SqlParameter("@Column_FatherID", SqlDbType.Int,4),
                    new SqlParameter("@Column_ExternalUrl", SqlDbType.NText),
                    new SqlParameter("@Column_Singlecontent", SqlDbType.Text),
                    new SqlParameter("@Column_MessageID", SqlDbType.Int,4),
                    new SqlParameter("@Column_UserRelease", SqlDbType.Bit,1),
                    new SqlParameter("@Column_Jcnmqy", SqlDbType.Int,4),
                    new SqlParameter("@Column_JcnmqyID", SqlDbType.Int,4),
                    new SqlParameter("@Column_Subtitle", SqlDbType.NText),
                    new SqlParameter("@Column_styleid", SqlDbType.Int,4),
                    new SqlParameter("@Column_englishname", SqlDbType.NVarChar,50),
                    new SqlParameter("@Column_type", SqlDbType.Int,4),
                    new SqlParameter("@Column_type_name", SqlDbType.Int,4),
                    new SqlParameter("@Column_spcs", SqlDbType.Int,4),
                    new SqlParameter("@Column_setmeal", SqlDbType.Int,4),
                    new SqlParameter("@Column_icon", SqlDbType.NVarChar,500)
            };
            parameters[0].Value = model.Column_ID;
            parameters[1].Value = model.Column_Aid;
            parameters[2].Value = model.Column_Name;
            parameters[3].Value = model.Column_Sort;
            parameters[4].Value = model.Column_Top_Special;
            parameters[5].Value = model.Column_Body_Special;
            parameters[6].Value = model.Column_Tail_Special;
            parameters[7].Value = model.Column_Top_List;
            parameters[8].Value = model.Column_Body_List;
            parameters[9].Value = model.Column_Tail_List;
            parameters[10].Value = model.Column_Top_Details;
            parameters[11].Value = model.Column_Body_Details;
            parameters[12].Value = model.Column_Tail_Details;
            parameters[13].Value = model.Column_Keyword;
            parameters[14].Value = model.Column_description;
            parameters[15].Value = model.Column_SystemID;
            parameters[16].Value = model.Column_FatherID;
            parameters[17].Value = model.Column_ExternalUrl;
            parameters[18].Value = model.Column_Singlecontent;
            parameters[19].Value = model.Column_MessageID;
            parameters[20].Value = model.Column_UserRelease;
            parameters[21].Value = model.Column_Jcnmqy;
            parameters[22].Value = model.Column_JcnmqyID;
            parameters[23].Value = model.Column_Subtitle;
            parameters[24].Value = model.Column_styleid;
            parameters[25].Value = model.Column_englishname;
            parameters[26].Value = model.Column_type;
            parameters[27].Value = model.Column_type_name;
            parameters[28].Value = model.Column_spcs;
            parameters[29].Value = model.Column_setmeal;
            parameters[30].Value = model.Column_icon;

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
        public bool Delete(int Column_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from System_Column ");
            strSql.Append(" where Column_ID=@Column_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Column_ID", SqlDbType.Int,4)

            };
            parameters[0].Value = Column_ID;

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

        public bool Delete(string strWhere, int Column_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from System_Column ");
            strSql.Append(" where " + strWhere + "=@Column_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Column_ID", SqlDbType.Int,4)

            };
            parameters[0].Value = Column_ID;

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
        public bool DeleteList(string Column_IDlist)
        {
            #region 【正则判断提交过来的值全是数字类型不，如有其他字符则返回 false】
            bool _bool = true;
            if (Column_IDlist.IndexOf(",") > 0)
            {
                MatchCollection matches = Regex.Matches(Column_IDlist, @"[^,<]+");
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
            strSql.Append("delete from System_Column ");
            strSql.Append(" where Column_ID in (" + Column_IDlist + ")  ");
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
        public HRMS.Model.System.ColumnModel GetModel(int Column_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Column_ID,Column_Aid,Column_Name,Column_Sort,Column_Top_Special,Column_Body_Special,Column_Tail_Special,Column_Top_List,Column_Body_List,Column_Tail_List,Column_Top_Details,Column_Body_Details,Column_Tail_Details,Column_Keyword,Column_description,Column_SystemID,Column_FatherID,Column_ExternalUrl,Column_Singlecontent,Column_MessageID,Column_UserRelease,Column_Jcnmqy,Column_JcnmqyID,Column_Subtitle,Column_styleid,Column_englishname,Column_type,Column_type_name,Column_spcs,Column_setmeal,Column_icon from System_Column ");
            strSql.Append(" where Column_ID=@Column_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Column_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Column_ID;

            HRMS.Model.System.ColumnModel model = new HRMS.Model.System.ColumnModel();
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
        public HRMS.Model.System.ColumnModel GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Column_ID,Column_Aid,Column_Name,Column_Sort,Column_Top_Special,Column_Body_Special,Column_Tail_Special,Column_Top_List,Column_Body_List,Column_Tail_List,Column_Top_Details,Column_Body_Details,Column_Tail_Details,Column_Keyword,Column_description,Column_SystemID,Column_FatherID,Column_ExternalUrl,Column_Singlecontent,Column_MessageID,Column_UserRelease,Column_Jcnmqy,Column_JcnmqyID,Column_Subtitle,Column_styleid,Column_englishname,Column_type,Column_type_name,Column_spcs,Column_setmeal,Column_icon from System_Column ");
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
        public HRMS.Model.System.ColumnModel DataRowToModel(DataRow row)
        {
            HRMS.Model.System.ColumnModel model = new HRMS.Model.System.ColumnModel();
            if (row != null)
            {

                if (row["Column_ID"] != null && row["Column_ID"].ToString() != "")
                {
                    model.Column_ID = int.Parse(row["Column_ID"].ToString());
                }
                if (row["Column_Aid"] != null && row["Column_Aid"].ToString() != "")
                {
                    model.Column_Aid = int.Parse(row["Column_Aid"].ToString());
                }
                if (row["Column_Name"] != null)
                {
                    model.Column_Name = row["Column_Name"].ToString();
                }
                if (row["Column_Sort"] != null && row["Column_Sort"].ToString() != "")
                {
                    model.Column_Sort = int.Parse(row["Column_Sort"].ToString());
                }
                if (row["Column_Top_Special"] != null)
                {
                    model.Column_Top_Special = row["Column_Top_Special"].ToString();
                }
                if (row["Column_Body_Special"] != null)
                {
                    model.Column_Body_Special = row["Column_Body_Special"].ToString();
                }
                if (row["Column_Tail_Special"] != null)
                {
                    model.Column_Tail_Special = row["Column_Tail_Special"].ToString();
                }
                if (row["Column_Top_List"] != null)
                {
                    model.Column_Top_List = row["Column_Top_List"].ToString();
                }
                if (row["Column_Body_List"] != null)
                {
                    model.Column_Body_List = row["Column_Body_List"].ToString();
                }
                if (row["Column_Tail_List"] != null)
                {
                    model.Column_Tail_List = row["Column_Tail_List"].ToString();
                }
                if (row["Column_Top_Details"] != null)
                {
                    model.Column_Top_Details = row["Column_Top_Details"].ToString();
                }
                if (row["Column_Body_Details"] != null)
                {
                    model.Column_Body_Details = row["Column_Body_Details"].ToString();
                }
                if (row["Column_Tail_Details"] != null)
                {
                    model.Column_Tail_Details = row["Column_Tail_Details"].ToString();
                }
                if (row["Column_Keyword"] != null)
                {
                    model.Column_Keyword = row["Column_Keyword"].ToString();
                }
                if (row["Column_description"] != null)
                {
                    model.Column_description = row["Column_description"].ToString();
                }
                if (row["Column_SystemID"] != null && row["Column_SystemID"].ToString() != "")
                {
                    model.Column_SystemID = int.Parse(row["Column_SystemID"].ToString());
                }
                if (row["Column_FatherID"] != null && row["Column_FatherID"].ToString() != "")
                {
                    model.Column_FatherID = int.Parse(row["Column_FatherID"].ToString());
                }
                if (row["Column_ExternalUrl"] != null)
                {
                    model.Column_ExternalUrl = row["Column_ExternalUrl"].ToString();
                }
                if (row["Column_Singlecontent"] != null)
                {
                    model.Column_Singlecontent = row["Column_Singlecontent"].ToString();
                }
                if (row["Column_MessageID"] != null && row["Column_MessageID"].ToString() != "")
                {
                    model.Column_MessageID = int.Parse(row["Column_MessageID"].ToString());
                }
                if (row["Column_UserRelease"] != null && row["Column_UserRelease"].ToString() != "")
                {
                    if ((row["Column_UserRelease"].ToString() == "1") || (row["Column_UserRelease"].ToString().ToLower() == "true"))
                    {
                        model.Column_UserRelease = true;
                    }
                    else
                    {
                        model.Column_UserRelease = false;
                    }
                }
                if (row["Column_Jcnmqy"] != null && row["Column_Jcnmqy"].ToString() != "")
                {
                    model.Column_Jcnmqy = int.Parse(row["Column_Jcnmqy"].ToString());
                }
                if (row["Column_JcnmqyID"] != null && row["Column_JcnmqyID"].ToString() != "")
                {
                    model.Column_JcnmqyID = int.Parse(row["Column_JcnmqyID"].ToString());
                }
                if (row["Column_Subtitle"] != null)
                {
                    model.Column_Subtitle = row["Column_Subtitle"].ToString();
                }
                if (row["Column_styleid"] != null && row["Column_styleid"].ToString() != "")
                {
                    model.Column_styleid = int.Parse(row["Column_styleid"].ToString());
                }
                if (row["Column_englishname"] != null)
                {
                    model.Column_englishname = row["Column_englishname"].ToString();
                }
                if (row["Column_type"] != null && row["Column_type"].ToString() != "")
                {
                    model.Column_type = int.Parse(row["Column_type"].ToString());
                }
                if (row["Column_type_name"] != null && row["Column_type_name"].ToString() != "")
                {
                    model.Column_type_name = int.Parse(row["Column_type_name"].ToString());
                }
                if (row["Column_spcs"] != null && row["Column_spcs"].ToString() != "")
                {
                    model.Column_spcs = int.Parse(row["Column_spcs"].ToString());
                }
                if (row["Column_setmeal"] != null && row["Column_setmeal"].ToString() != "")
                {
                    model.Column_setmeal = int.Parse(row["Column_setmeal"].ToString());
                }
                if (row["Column_icon"] != null)
                {
                    model.Column_icon = row["Column_icon"].ToString();
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
            strSql.Append("select Column_ID,Column_Aid,Column_Name,Column_Sort,Column_Top_Special,Column_Body_Special,Column_Tail_Special,Column_Top_List,Column_Body_List,Column_Tail_List,Column_Top_Details,Column_Body_Details,Column_Tail_Details,Column_Keyword,Column_description,Column_SystemID,Column_FatherID,Column_ExternalUrl,Column_Singlecontent,Column_MessageID,Column_UserRelease,Column_Jcnmqy,Column_JcnmqyID,Column_Subtitle,Column_styleid,Column_englishname,Column_type,Column_type_name,Column_spcs,Column_setmeal,Column_icon ");
            strSql.Append(" FROM System_Column ");
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
            strSql.Append(" Column_ID,Column_Aid,Column_Name,Column_Sort,Column_Top_Special,Column_Body_Special,Column_Tail_Special,Column_Top_List,Column_Body_List,Column_Tail_List,Column_Top_Details,Column_Body_Details,Column_Tail_Details,Column_Keyword,Column_description,Column_SystemID,Column_FatherID,Column_ExternalUrl,Column_Singlecontent,Column_MessageID,Column_UserRelease,Column_Jcnmqy,Column_JcnmqyID,Column_Subtitle,Column_styleid,Column_englishname,Column_type,Column_type_name,Column_spcs,Column_setmeal,Column_icon ");
            strSql.Append(" FROM System_Column ");
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
            strSql.Append("select count(1) FROM System_Column ");
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
                strSql.Append("order by T.Column_ID desc");
            }
            strSql.Append(")AS Row, T.*  from System_Column T ");
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
        public bool Update(string set)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update System_Column set " + set);
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
            strSql.Append("update System_Column set " + set);
            strSql.Append(" where Column_ID in (" + id + ")  ");
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

