using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.Label;
using HRMS.DBUtility;//Please add references
namespace HRMS.SQLServerDAL.Label
{
	/// <summary>
	/// 数据访问类:ISlidesDAL
	/// </summary>
	public partial class ISlidesDAL: IDAL.Label.ISlidesDAL
	{
		public ISlidesDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Slides_ID", "Label_Slides"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Slides_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Label_Slides");
			strSql.Append(" where Slides_ID=@Slides_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Slides_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Slides_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HRMS.Model.Label.SlidesModel model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Label_Slides(");
            strSql.Append("Slides_Aid,Slides_Route,Slides_Url,Slides_Text,Slides_panel_img,Slides_move_img)");
            strSql.Append(" values (");
            strSql.Append("@Slides_Aid,@Slides_Route,@Slides_Url,@Slides_Text,@Slides_panel_img,@Slides_move_img)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Slides_Aid", SqlDbType.Int,4),
                    new SqlParameter("@Slides_Route", SqlDbType.NText),
                    new SqlParameter("@Slides_Url", SqlDbType.NText),
                    new SqlParameter("@Slides_Text", SqlDbType.NText),
                    new SqlParameter("@Slides_panel_img", SqlDbType.NVarChar,100),
                    new SqlParameter("@Slides_move_img", SqlDbType.NVarChar,100)
            };
            parameters[0].Value = model.Slides_Aid;
            parameters[1].Value = model.Slides_Route;
            parameters[2].Value = model.Slides_Url;
            parameters[3].Value = model.Slides_Text;
            parameters[4].Value = model.Slides_panel_img;
            parameters[5].Value = model.Slides_move_img;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(HRMS.Model.Label.SlidesModel model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Label_Slides set ");
            strSql.Append("Slides_Aid=@Slides_Aid,");
            strSql.Append("Slides_Route=@Slides_Route,");
            strSql.Append("Slides_Url=@Slides_Url,");
            strSql.Append("Slides_Text=@Slides_Text,");
            strSql.Append("Slides_panel_img=@Slides_panel_img,");
            strSql.Append("Slides_move_img=@Slides_move_img");
            strSql.Append(" where Slides_ID=@Slides_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Slides_ID", SqlDbType.Int,4),
                    new SqlParameter("@Slides_Aid", SqlDbType.Int,4),
                    new SqlParameter("@Slides_Route", SqlDbType.NText),
                    new SqlParameter("@Slides_Url", SqlDbType.NText),
                    new SqlParameter("@Slides_Text", SqlDbType.NText),
                    new SqlParameter("@Slides_panel_img", SqlDbType.NVarChar,100),
                    new SqlParameter("@Slides_move_img", SqlDbType.NVarChar,100)
            };
            parameters[0].Value = model.Slides_ID;
            parameters[1].Value = model.Slides_Aid;
            parameters[2].Value = model.Slides_Route;
            parameters[3].Value = model.Slides_Url;
            parameters[4].Value = model.Slides_Text;
            parameters[5].Value = model.Slides_panel_img;
            parameters[6].Value = model.Slides_move_img;

            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int Slides_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Label_Slides ");
			strSql.Append(" where Slides_ID=@Slides_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Slides_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Slides_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Slides_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Label_Slides ");
			strSql.Append(" where Slides_ID in ("+Slides_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public HRMS.Model.Label.SlidesModel GetModel(int Slides_ID)
		{

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Slides_ID,Slides_Aid,Slides_Route,Slides_Url,Slides_Text,Slides_panel_img,Slides_move_img from Label_Slides ");
            strSql.Append(" where Slides_ID=@Slides_ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Slides_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Slides_ID;

			HRMS.Model.Label.SlidesModel model=new HRMS.Model.Label.SlidesModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public HRMS.Model.Label.SlidesModel DataRowToModel(DataRow row)
		{
			HRMS.Model.Label.SlidesModel model=new HRMS.Model.Label.SlidesModel();
			if (row != null)
			{
				if(row["Slides_ID"]!=null && row["Slides_ID"].ToString()!="")
				{
					model.Slides_ID=int.Parse(row["Slides_ID"].ToString());
				}
				if(row["Slides_Aid"]!=null && row["Slides_Aid"].ToString()!="")
				{
					model.Slides_Aid=int.Parse(row["Slides_Aid"].ToString());
				}
				if(row["Slides_Route"]!=null)
				{
					model.Slides_Route=row["Slides_Route"].ToString();
				}
				if(row["Slides_Url"]!=null)
				{
					model.Slides_Url=row["Slides_Url"].ToString();
				}
				if(row["Slides_Text"]!=null)
				{
					model.Slides_Text=row["Slides_Text"].ToString();
				}
                if (row["Slides_panel_img"] != null)
                {
                    model.Slides_panel_img = row["Slides_panel_img"].ToString();
                }
                if (row["Slides_move_img"] != null)
                {
                    model.Slides_move_img = row["Slides_move_img"].ToString();
                }
            }
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Slides_ID,Slides_Aid,Slides_Route,Slides_Url,Slides_Text,Slides_panel_img,Slides_move_img ");
            strSql.Append(" FROM Label_Slides ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
            strSql.Append(" Slides_ID,Slides_Aid,Slides_Route,Slides_Url,Slides_Text,Slides_panel_img,Slides_move_img ");
            strSql.Append(" FROM Label_Slides ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Label_Slides ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Slides_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Label_Slides T ");
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
			parameters[0].Value = "Label_Slides";
			parameters[1].Value = "Slides_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod

		#region  ExtensionMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsA(int Slides_Aid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Label_Slides");
            strSql.Append(" where Slides_Aid=@Slides_Aid");
            SqlParameter[] parameters = {
					new SqlParameter("@Slides_Aid", SqlDbType.Int,4)
			};
            parameters[0].Value = Slides_Aid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteA(int Slides_Aid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Label_Slides ");
            strSql.Append(" where Slides_Aid=@Slides_Aid");
            SqlParameter[] parameters = {
					new SqlParameter("@Slides_Aid", SqlDbType.Int,4)
			};
            parameters[0].Value = Slides_Aid;

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
        /// 批量删除指定以外的数据
        /// </summary>
        public bool DeleteListA(string Slides_IDlist, int Slides_Aid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Label_Slides ");
            strSql.Append(" where Slides_Aid=" + Slides_Aid + " and Slides_ID not in (" + Slides_IDlist + ")  ");
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
		#endregion  ExtensionMethod
	}
}

