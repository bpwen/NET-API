using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.Article;
using HRMS.DBUtility;//Please add references

namespace HRMS.SQLServerDAL.Article
{
	/// <summary>
	/// 数据访问类:IArticleDAL
	/// </summary>
	public partial class IArticleDAL: IDAL.Article.IArticleDAL
	{
		public IArticleDAL()
		{}
        #region  BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Article_ID", "Article");
        }
        #endregion

        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Article_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Article");
            strSql.Append(" where Article_ID=@Article_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Article_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Article_ID;
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
            strSql.Append("select count(1) from Article");
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
        public int Add(HRMS.Model.Article.ArticleModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Article(");
            strSql.Append("Article_Shift_link_URLA,Article_Author,Article_Article_source,Article_Article_source_URL,Article_Keyword,Article_Guide,Article_GuideA,Article_Annex,Article_Content,Article_Cover_image,Article_AddPeopleID,Article_Thumbnail_sizeX,Article_Thumbnail_sizeY,Article_Class,Article_Auditing,Article_Release_date,Article_IPaddress,Article_Release,Article_AuditpersonID,Article_Auditdate,Article_Add_date,Article_Type,Article_Ordernumber,Article_Stock,Article_Unit,Article_Xssx,Article_Discount,Article_RetailPrice,Article_Promotion,Article_Title,Article_hitsg,Article_hitsn,Article_hitsy,Article_hitsz,Article_hitst,Article_hitsntime,Article_hitsytime,Article_hitsztime,Article_hitsttime,Article_Font_style,Article_login,Article_comment,Article_sptype,Article_spgodate,Article_spenddate,Article_jgmin,Article_jgmax,Article_Title_Color,Article_Complete_Title,Article_Column,Article_Shift_link_URL)");
            strSql.Append(" values (");
            strSql.Append("@Article_Shift_link_URLA,@Article_Author,@Article_Article_source,@Article_Article_source_URL,@Article_Keyword,@Article_Guide,@Article_GuideA,@Article_Annex,@Article_Content,@Article_Cover_image,@Article_AddPeopleID,@Article_Thumbnail_sizeX,@Article_Thumbnail_sizeY,@Article_Class,@Article_Auditing,@Article_Release_date,@Article_IPaddress,@Article_Release,@Article_AuditpersonID,@Article_Auditdate,@Article_Add_date,@Article_Type,@Article_Ordernumber,@Article_Stock,@Article_Unit,@Article_Xssx,@Article_Discount,@Article_RetailPrice,@Article_Promotion,@Article_Title,@Article_hitsg,@Article_hitsn,@Article_hitsy,@Article_hitsz,@Article_hitst,@Article_hitsntime,@Article_hitsytime,@Article_hitsztime,@Article_hitsttime,@Article_Font_style,@Article_login,@Article_comment,@Article_sptype,@Article_spgodate,@Article_spenddate,@Article_jgmin,@Article_jgmax,@Article_Title_Color,@Article_Complete_Title,@Article_Column,@Article_Shift_link_URL)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Article_Shift_link_URLA", SqlDbType.Bit,1),
                    new SqlParameter("@Article_Author", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Article_source", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Article_source_URL", SqlDbType.NText),
                    new SqlParameter("@Article_Keyword", SqlDbType.NText),
                    new SqlParameter("@Article_Guide", SqlDbType.NText),
                    new SqlParameter("@Article_GuideA", SqlDbType.Bit,1),
                    new SqlParameter("@Article_Annex", SqlDbType.NText),
                    new SqlParameter("@Article_Content", SqlDbType.NText),
                    new SqlParameter("@Article_Cover_image", SqlDbType.NText),
                    new SqlParameter("@Article_AddPeopleID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Thumbnail_sizeX", SqlDbType.Int,4),
                    new SqlParameter("@Article_Thumbnail_sizeY", SqlDbType.Int,4),
                    new SqlParameter("@Article_Class", SqlDbType.Int,4),
                    new SqlParameter("@Article_Auditing", SqlDbType.Int,4),
                    new SqlParameter("@Article_Release_date", SqlDbType.DateTime),
                    new SqlParameter("@Article_IPaddress", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Release", SqlDbType.Bit,1),
                    new SqlParameter("@Article_AuditpersonID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Auditdate", SqlDbType.DateTime),
                    new SqlParameter("@Article_Add_date", SqlDbType.DateTime),
                    new SqlParameter("@Article_Type", SqlDbType.Int,4),
                    new SqlParameter("@Article_Ordernumber", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Stock", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Unit", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Xssx", SqlDbType.Int,4),
                    new SqlParameter("@Article_Discount", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_RetailPrice", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Promotion", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Title", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_hitsg", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsn", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsy", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsz", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitst", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsntime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsytime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsztime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsttime", SqlDbType.DateTime),
                    new SqlParameter("@Article_Font_style", SqlDbType.Int,4),
                    new SqlParameter("@Article_login", SqlDbType.Bit,1),
                    new SqlParameter("@Article_comment", SqlDbType.Bit,1),
                    new SqlParameter("@Article_sptype", SqlDbType.Bit,1),
                    new SqlParameter("@Article_spgodate", SqlDbType.DateTime),
                    new SqlParameter("@Article_spenddate", SqlDbType.DateTime),
                    new SqlParameter("@Article_jgmin", SqlDbType.Decimal,9),
                    new SqlParameter("@Article_jgmax", SqlDbType.Decimal,9),
                    new SqlParameter("@Article_Title_Color", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Complete_Title", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Column", SqlDbType.Int,4),
                    new SqlParameter("@Article_Shift_link_URL", SqlDbType.NText)
            };
            parameters[0].Value = model.Article_Shift_link_URLA;
            parameters[1].Value = model.Article_Author;
            parameters[2].Value = model.Article_Article_source;
            parameters[3].Value = model.Article_Article_source_URL;
            parameters[4].Value = model.Article_Keyword;
            parameters[5].Value = model.Article_Guide;
            parameters[6].Value = model.Article_GuideA;
            parameters[7].Value = model.Article_Annex;
            parameters[8].Value = model.Article_Content;
            parameters[9].Value = model.Article_Cover_image;
            parameters[10].Value = model.Article_AddPeopleID;
            parameters[11].Value = model.Article_Thumbnail_sizeX;
            parameters[12].Value = model.Article_Thumbnail_sizeY;
            parameters[13].Value = model.Article_Class;
            parameters[14].Value = model.Article_Auditing;
            parameters[15].Value = model.Article_Release_date;
            parameters[16].Value = model.Article_IPaddress;
            parameters[17].Value = model.Article_Release;
            parameters[18].Value = model.Article_AuditpersonID;
            parameters[19].Value = model.Article_Auditdate;
            parameters[20].Value = model.Article_Add_date;
            parameters[21].Value = model.Article_Type;
            parameters[22].Value = model.Article_Ordernumber;
            parameters[23].Value = model.Article_Stock;
            parameters[24].Value = model.Article_Unit;
            parameters[25].Value = model.Article_Xssx;
            parameters[26].Value = model.Article_Discount;
            parameters[27].Value = model.Article_RetailPrice;
            parameters[28].Value = model.Article_Promotion;
            parameters[29].Value = model.Article_Title;
            parameters[30].Value = model.Article_hitsg;
            parameters[31].Value = model.Article_hitsn;
            parameters[32].Value = model.Article_hitsy;
            parameters[33].Value = model.Article_hitsz;
            parameters[34].Value = model.Article_hitst;
            parameters[35].Value = model.Article_hitsntime;
            parameters[36].Value = model.Article_hitsytime;
            parameters[37].Value = model.Article_hitsztime;
            parameters[38].Value = model.Article_hitsttime;
            parameters[39].Value = model.Article_Font_style;
            parameters[40].Value = model.Article_login;
            parameters[41].Value = model.Article_comment;
            parameters[42].Value = model.Article_sptype;
            parameters[43].Value = model.Article_spgodate;
            parameters[44].Value = model.Article_spenddate;
            parameters[45].Value = model.Article_jgmin;
            parameters[46].Value = model.Article_jgmax;
            parameters[47].Value = model.Article_Title_Color;
            parameters[48].Value = model.Article_Complete_Title;
            parameters[49].Value = model.Article_Column;
            parameters[50].Value = model.Article_Shift_link_URL;

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
        public bool Update(HRMS.Model.Article.ArticleModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("Article_Shift_link_URLA=@Article_Shift_link_URLA,");
            strSql.Append("Article_Author=@Article_Author,");
            strSql.Append("Article_Article_source=@Article_Article_source,");
            strSql.Append("Article_Article_source_URL=@Article_Article_source_URL,");
            strSql.Append("Article_Keyword=@Article_Keyword,");
            strSql.Append("Article_Guide=@Article_Guide,");
            strSql.Append("Article_GuideA=@Article_GuideA,");
            strSql.Append("Article_Annex=@Article_Annex,");
            strSql.Append("Article_Content=@Article_Content,");
            strSql.Append("Article_Cover_image=@Article_Cover_image,");
            strSql.Append("Article_AddPeopleID=@Article_AddPeopleID,");
            strSql.Append("Article_Thumbnail_sizeX=@Article_Thumbnail_sizeX,");
            strSql.Append("Article_Thumbnail_sizeY=@Article_Thumbnail_sizeY,");
            strSql.Append("Article_Class=@Article_Class,");
            strSql.Append("Article_Auditing=@Article_Auditing,");
            strSql.Append("Article_Release_date=@Article_Release_date,");
            strSql.Append("Article_IPaddress=@Article_IPaddress,");
            strSql.Append("Article_Release=@Article_Release,");
            strSql.Append("Article_AuditpersonID=@Article_AuditpersonID,");
            strSql.Append("Article_Auditdate=@Article_Auditdate,");
            strSql.Append("Article_Add_date=@Article_Add_date,");
            strSql.Append("Article_Type=@Article_Type,");
            strSql.Append("Article_Ordernumber=@Article_Ordernumber,");
            strSql.Append("Article_Stock=@Article_Stock,");
            strSql.Append("Article_Unit=@Article_Unit,");
            strSql.Append("Article_Xssx=@Article_Xssx,");
            strSql.Append("Article_Discount=@Article_Discount,");
            strSql.Append("Article_RetailPrice=@Article_RetailPrice,");
            strSql.Append("Article_Promotion=@Article_Promotion,");
            strSql.Append("Article_Title=@Article_Title,");
            strSql.Append("Article_hitsg=@Article_hitsg,");
            strSql.Append("Article_hitsn=@Article_hitsn,");
            strSql.Append("Article_hitsy=@Article_hitsy,");
            strSql.Append("Article_hitsz=@Article_hitsz,");
            strSql.Append("Article_hitst=@Article_hitst,");
            strSql.Append("Article_hitsntime=@Article_hitsntime,");
            strSql.Append("Article_hitsytime=@Article_hitsytime,");
            strSql.Append("Article_hitsztime=@Article_hitsztime,");
            strSql.Append("Article_hitsttime=@Article_hitsttime,");
            strSql.Append("Article_Font_style=@Article_Font_style,");
            strSql.Append("Article_login=@Article_login,");
            strSql.Append("Article_comment=@Article_comment,");
            strSql.Append("Article_sptype=@Article_sptype,");
            strSql.Append("Article_spgodate=@Article_spgodate,");
            strSql.Append("Article_spenddate=@Article_spenddate,");
            strSql.Append("Article_jgmin=@Article_jgmin,");
            strSql.Append("Article_jgmax=@Article_jgmax,");
            strSql.Append("Article_Title_Color=@Article_Title_Color,");
            strSql.Append("Article_Complete_Title=@Article_Complete_Title,");
            strSql.Append("Article_Column=@Article_Column,");
            strSql.Append("Article_Shift_link_URL=@Article_Shift_link_URL");
            strSql.Append(" where Article_ID=@Article_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Article_ID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Shift_link_URLA", SqlDbType.Bit,1),
                    new SqlParameter("@Article_Author", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Article_source", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Article_source_URL", SqlDbType.NText),
                    new SqlParameter("@Article_Keyword", SqlDbType.NText),
                    new SqlParameter("@Article_Guide", SqlDbType.NText),
                    new SqlParameter("@Article_GuideA", SqlDbType.Bit,1),
                    new SqlParameter("@Article_Annex", SqlDbType.NText),
                    new SqlParameter("@Article_Content", SqlDbType.NText),
                    new SqlParameter("@Article_Cover_image", SqlDbType.NText),
                    new SqlParameter("@Article_AddPeopleID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Thumbnail_sizeX", SqlDbType.Int,4),
                    new SqlParameter("@Article_Thumbnail_sizeY", SqlDbType.Int,4),
                    new SqlParameter("@Article_Class", SqlDbType.Int,4),
                    new SqlParameter("@Article_Auditing", SqlDbType.Int,4),
                    new SqlParameter("@Article_Release_date", SqlDbType.DateTime),
                    new SqlParameter("@Article_IPaddress", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Release", SqlDbType.Bit,1),
                    new SqlParameter("@Article_AuditpersonID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Auditdate", SqlDbType.DateTime),
                    new SqlParameter("@Article_Add_date", SqlDbType.DateTime),
                    new SqlParameter("@Article_Type", SqlDbType.Int,4),
                    new SqlParameter("@Article_Ordernumber", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Stock", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Unit", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Xssx", SqlDbType.Int,4),
                    new SqlParameter("@Article_Discount", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_RetailPrice", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Promotion", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Title", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_hitsg", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsn", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsy", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsz", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitst", SqlDbType.Int,4),
                    new SqlParameter("@Article_hitsntime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsytime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsztime", SqlDbType.DateTime),
                    new SqlParameter("@Article_hitsttime", SqlDbType.DateTime),
                    new SqlParameter("@Article_Font_style", SqlDbType.Int,4),
                    new SqlParameter("@Article_login", SqlDbType.Bit,1),
                    new SqlParameter("@Article_comment", SqlDbType.Bit,1),
                    new SqlParameter("@Article_sptype", SqlDbType.Bit,1),
                    new SqlParameter("@Article_spgodate", SqlDbType.DateTime),
                    new SqlParameter("@Article_spenddate", SqlDbType.DateTime),
                    new SqlParameter("@Article_jgmin", SqlDbType.Decimal,9),
                    new SqlParameter("@Article_jgmax", SqlDbType.Decimal,9),
                    new SqlParameter("@Article_Title_Color", SqlDbType.NVarChar,50),
                    new SqlParameter("@Article_Complete_Title", SqlDbType.NVarChar,100),
                    new SqlParameter("@Article_Column", SqlDbType.Int,4),
                    new SqlParameter("@Article_Shift_link_URL", SqlDbType.NText)
            };
            parameters[0].Value = model.Article_ID;
            parameters[1].Value = model.Article_Shift_link_URLA;
            parameters[2].Value = model.Article_Author;
            parameters[3].Value = model.Article_Article_source;
            parameters[4].Value = model.Article_Article_source_URL;
            parameters[5].Value = model.Article_Keyword;
            parameters[6].Value = model.Article_Guide;
            parameters[7].Value = model.Article_GuideA;
            parameters[8].Value = model.Article_Annex;
            parameters[9].Value = model.Article_Content;
            parameters[10].Value = model.Article_Cover_image;
            parameters[11].Value = model.Article_AddPeopleID;
            parameters[12].Value = model.Article_Thumbnail_sizeX;
            parameters[13].Value = model.Article_Thumbnail_sizeY;
            parameters[14].Value = model.Article_Class;
            parameters[15].Value = model.Article_Auditing;
            parameters[16].Value = model.Article_Release_date;
            parameters[17].Value = model.Article_IPaddress;
            parameters[18].Value = model.Article_Release;
            parameters[19].Value = model.Article_AuditpersonID;
            parameters[20].Value = model.Article_Auditdate;
            parameters[21].Value = model.Article_Add_date;
            parameters[22].Value = model.Article_Type;
            parameters[23].Value = model.Article_Ordernumber;
            parameters[24].Value = model.Article_Stock;
            parameters[25].Value = model.Article_Unit;
            parameters[26].Value = model.Article_Xssx;
            parameters[27].Value = model.Article_Discount;
            parameters[28].Value = model.Article_RetailPrice;
            parameters[29].Value = model.Article_Promotion;
            parameters[30].Value = model.Article_Title;
            parameters[31].Value = model.Article_hitsg;
            parameters[32].Value = model.Article_hitsn;
            parameters[33].Value = model.Article_hitsy;
            parameters[34].Value = model.Article_hitsz;
            parameters[35].Value = model.Article_hitst;
            parameters[36].Value = model.Article_hitsntime;
            parameters[37].Value = model.Article_hitsytime;
            parameters[38].Value = model.Article_hitsztime;
            parameters[39].Value = model.Article_hitsttime;
            parameters[40].Value = model.Article_Font_style;
            parameters[41].Value = model.Article_login;
            parameters[42].Value = model.Article_comment;
            parameters[43].Value = model.Article_sptype;
            parameters[44].Value = model.Article_spgodate;
            parameters[45].Value = model.Article_spenddate;
            parameters[46].Value = model.Article_jgmin;
            parameters[47].Value = model.Article_jgmax;
            parameters[48].Value = model.Article_Title_Color;
            parameters[49].Value = model.Article_Complete_Title;
            parameters[50].Value = model.Article_Column;
            parameters[51].Value = model.Article_Shift_link_URL;

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
        public bool Delete(int Article_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Article ");
            strSql.Append(" where Article_ID=@Article_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Article_ID", SqlDbType.Int,4)

            };
            parameters[0].Value = Article_ID;

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
        public bool DeleteList(string Article_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Article ");
            strSql.Append(" where Article_ID in (" + Article_IDlist + ")  ");
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
        public HRMS.Model.Article.ArticleModel GetModel(int Article_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Article_ID,Article_Shift_link_URLA,Article_Author,Article_Article_source,Article_Article_source_URL,Article_Keyword,Article_Guide,Article_GuideA,Article_Annex,Article_Content,Article_Cover_image,Article_AddPeopleID,Article_Thumbnail_sizeX,Article_Thumbnail_sizeY,Article_Class,Article_Auditing,Article_Release_date,Article_IPaddress,Article_Release,Article_AuditpersonID,Article_Auditdate,Article_Add_date,Article_Type,Article_Ordernumber,Article_Stock,Article_Unit,Article_Xssx,Article_Discount,Article_RetailPrice,Article_Promotion,Article_Title,Article_hitsg,Article_hitsn,Article_hitsy,Article_hitsz,Article_hitst,Article_hitsntime,Article_hitsytime,Article_hitsztime,Article_hitsttime,Article_Font_style,Article_login,Article_comment,Article_sptype,Article_spgodate,Article_spenddate,Article_jgmin,Article_jgmax,Article_Title_Color,Article_Complete_Title,Article_Column,Article_Shift_link_URL from Article ");
            strSql.Append(" where Article_ID=@Article_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Article_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Article_ID;

            HRMS.Model.Article.ArticleModel model = new HRMS.Model.Article.ArticleModel();
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
        public HRMS.Model.Article.ArticleModel GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Article_ID,Article_Shift_link_URLA,Article_Author,Article_Article_source,Article_Article_source_URL,Article_Keyword,Article_Guide,Article_GuideA,Article_Annex,Article_Content,Article_Cover_image,Article_AddPeopleID,Article_Thumbnail_sizeX,Article_Thumbnail_sizeY,Article_Class,Article_Auditing,Article_Release_date,Article_IPaddress,Article_Release,Article_AuditpersonID,Article_Auditdate,Article_Add_date,Article_Type,Article_Ordernumber,Article_Stock,Article_Unit,Article_Xssx,Article_Discount,Article_RetailPrice,Article_Promotion,Article_Title,Article_hitsg,Article_hitsn,Article_hitsy,Article_hitsz,Article_hitst,Article_hitsntime,Article_hitsytime,Article_hitsztime,Article_hitsttime,Article_Font_style,Article_login,Article_comment,Article_sptype,Article_spgodate,Article_spenddate,Article_jgmin,Article_jgmax,Article_Title_Color,Article_Complete_Title,Article_Column,Article_Shift_link_URL from Article ");
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
        public HRMS.Model.Article.ArticleModel DataRowToModel(DataRow row)
        {
            HRMS.Model.Article.ArticleModel model = new HRMS.Model.Article.ArticleModel();
            if (row != null)
            {

                if (row["Article_ID"] != null && row["Article_ID"].ToString() != "")
                {
                    model.Article_ID = int.Parse(row["Article_ID"].ToString());
                }
                if (row["Article_Shift_link_URLA"] != null && row["Article_Shift_link_URLA"].ToString() != "")
                {
                    if ((row["Article_Shift_link_URLA"].ToString() == "1") || (row["Article_Shift_link_URLA"].ToString().ToLower() == "true"))
                    {
                        model.Article_Shift_link_URLA = true;
                    }
                    else
                    {
                        model.Article_Shift_link_URLA = false;
                    }
                }
                if (row["Article_Author"] != null)
                {
                    model.Article_Author = row["Article_Author"].ToString();
                }
                if (row["Article_Article_source"] != null)
                {
                    model.Article_Article_source = row["Article_Article_source"].ToString();
                }
                if (row["Article_Article_source_URL"] != null)
                {
                    model.Article_Article_source_URL = row["Article_Article_source_URL"].ToString();
                }
                if (row["Article_Keyword"] != null)
                {
                    model.Article_Keyword = row["Article_Keyword"].ToString();
                }
                if (row["Article_Guide"] != null)
                {
                    model.Article_Guide = row["Article_Guide"].ToString();
                }
                if (row["Article_GuideA"] != null && row["Article_GuideA"].ToString() != "")
                {
                    if ((row["Article_GuideA"].ToString() == "1") || (row["Article_GuideA"].ToString().ToLower() == "true"))
                    {
                        model.Article_GuideA = true;
                    }
                    else
                    {
                        model.Article_GuideA = false;
                    }
                }
                if (row["Article_Annex"] != null)
                {
                    model.Article_Annex = row["Article_Annex"].ToString();
                }
                if (row["Article_Content"] != null)
                {
                    model.Article_Content = row["Article_Content"].ToString();
                }
                if (row["Article_Cover_image"] != null)
                {
                    model.Article_Cover_image = row["Article_Cover_image"].ToString();
                }
                if (row["Article_AddPeopleID"] != null && row["Article_AddPeopleID"].ToString() != "")
                {
                    model.Article_AddPeopleID = int.Parse(row["Article_AddPeopleID"].ToString());
                }
                if (row["Article_Thumbnail_sizeX"] != null && row["Article_Thumbnail_sizeX"].ToString() != "")
                {
                    model.Article_Thumbnail_sizeX = int.Parse(row["Article_Thumbnail_sizeX"].ToString());
                }
                if (row["Article_Thumbnail_sizeY"] != null && row["Article_Thumbnail_sizeY"].ToString() != "")
                {
                    model.Article_Thumbnail_sizeY = int.Parse(row["Article_Thumbnail_sizeY"].ToString());
                }
                if (row["Article_Class"] != null && row["Article_Class"].ToString() != "")
                {
                    model.Article_Class = int.Parse(row["Article_Class"].ToString());
                }
                if (row["Article_Auditing"] != null && row["Article_Auditing"].ToString() != "")
                {
                    model.Article_Auditing = int.Parse(row["Article_Auditing"].ToString());
                }
                if (row["Article_Release_date"] != null && row["Article_Release_date"].ToString() != "")
                {
                    model.Article_Release_date = DateTime.Parse(row["Article_Release_date"].ToString());
                }
                if (row["Article_IPaddress"] != null)
                {
                    model.Article_IPaddress = row["Article_IPaddress"].ToString();
                }
                if (row["Article_Release"] != null && row["Article_Release"].ToString() != "")
                {
                    if ((row["Article_Release"].ToString() == "1") || (row["Article_Release"].ToString().ToLower() == "true"))
                    {
                        model.Article_Release = true;
                    }
                    else
                    {
                        model.Article_Release = false;
                    }
                }
                if (row["Article_AuditpersonID"] != null && row["Article_AuditpersonID"].ToString() != "")
                {
                    model.Article_AuditpersonID = int.Parse(row["Article_AuditpersonID"].ToString());
                }
                if (row["Article_Auditdate"] != null && row["Article_Auditdate"].ToString() != "")
                {
                    model.Article_Auditdate = DateTime.Parse(row["Article_Auditdate"].ToString());
                }
                if (row["Article_Add_date"] != null && row["Article_Add_date"].ToString() != "")
                {
                    model.Article_Add_date = DateTime.Parse(row["Article_Add_date"].ToString());
                }
                if (row["Article_Type"] != null && row["Article_Type"].ToString() != "")
                {
                    model.Article_Type = int.Parse(row["Article_Type"].ToString());
                }
                if (row["Article_Ordernumber"] != null)
                {
                    model.Article_Ordernumber = row["Article_Ordernumber"].ToString();
                }
                if (row["Article_Stock"] != null)
                {
                    model.Article_Stock = row["Article_Stock"].ToString();
                }
                if (row["Article_Unit"] != null)
                {
                    model.Article_Unit = row["Article_Unit"].ToString();
                }
                if (row["Article_Xssx"] != null && row["Article_Xssx"].ToString() != "")
                {
                    model.Article_Xssx = int.Parse(row["Article_Xssx"].ToString());
                }
                if (row["Article_Discount"] != null)
                {
                    model.Article_Discount = row["Article_Discount"].ToString();
                }
                if (row["Article_RetailPrice"] != null)
                {
                    model.Article_RetailPrice = row["Article_RetailPrice"].ToString();
                }
                if (row["Article_Promotion"] != null)
                {
                    model.Article_Promotion = row["Article_Promotion"].ToString();
                }
                if (row["Article_Title"] != null)
                {
                    model.Article_Title = row["Article_Title"].ToString();
                }
                if (row["Article_hitsg"] != null && row["Article_hitsg"].ToString() != "")
                {
                    model.Article_hitsg = int.Parse(row["Article_hitsg"].ToString());
                }
                if (row["Article_hitsn"] != null && row["Article_hitsn"].ToString() != "")
                {
                    model.Article_hitsn = int.Parse(row["Article_hitsn"].ToString());
                }
                if (row["Article_hitsy"] != null && row["Article_hitsy"].ToString() != "")
                {
                    model.Article_hitsy = int.Parse(row["Article_hitsy"].ToString());
                }
                if (row["Article_hitsz"] != null && row["Article_hitsz"].ToString() != "")
                {
                    model.Article_hitsz = int.Parse(row["Article_hitsz"].ToString());
                }
                if (row["Article_hitst"] != null && row["Article_hitst"].ToString() != "")
                {
                    model.Article_hitst = int.Parse(row["Article_hitst"].ToString());
                }
                if (row["Article_hitsntime"] != null && row["Article_hitsntime"].ToString() != "")
                {
                    model.Article_hitsntime = DateTime.Parse(row["Article_hitsntime"].ToString());
                }
                if (row["Article_hitsytime"] != null && row["Article_hitsytime"].ToString() != "")
                {
                    model.Article_hitsytime = DateTime.Parse(row["Article_hitsytime"].ToString());
                }
                if (row["Article_hitsztime"] != null && row["Article_hitsztime"].ToString() != "")
                {
                    model.Article_hitsztime = DateTime.Parse(row["Article_hitsztime"].ToString());
                }
                if (row["Article_hitsttime"] != null && row["Article_hitsttime"].ToString() != "")
                {
                    model.Article_hitsttime = DateTime.Parse(row["Article_hitsttime"].ToString());
                }
                if (row["Article_Font_style"] != null && row["Article_Font_style"].ToString() != "")
                {
                    model.Article_Font_style = int.Parse(row["Article_Font_style"].ToString());
                }
                if (row["Article_login"] != null && row["Article_login"].ToString() != "")
                {
                    if ((row["Article_login"].ToString() == "1") || (row["Article_login"].ToString().ToLower() == "true"))
                    {
                        model.Article_login = true;
                    }
                    else
                    {
                        model.Article_login = false;
                    }
                }
                if (row["Article_comment"] != null && row["Article_comment"].ToString() != "")
                {
                    if ((row["Article_comment"].ToString() == "1") || (row["Article_comment"].ToString().ToLower() == "true"))
                    {
                        model.Article_comment = true;
                    }
                    else
                    {
                        model.Article_comment = false;
                    }
                }
                if (row["Article_sptype"] != null && row["Article_sptype"].ToString() != "")
                {
                    if ((row["Article_sptype"].ToString() == "1") || (row["Article_sptype"].ToString().ToLower() == "true"))
                    {
                        model.Article_sptype = true;
                    }
                    else
                    {
                        model.Article_sptype = false;
                    }
                }
                if (row["Article_spgodate"] != null && row["Article_spgodate"].ToString() != "")
                {
                    model.Article_spgodate = DateTime.Parse(row["Article_spgodate"].ToString());
                }
                if (row["Article_spenddate"] != null && row["Article_spenddate"].ToString() != "")
                {
                    model.Article_spenddate = DateTime.Parse(row["Article_spenddate"].ToString());
                }
                if (row["Article_jgmin"] != null && row["Article_jgmin"].ToString() != "")
                {
                    model.Article_jgmin = decimal.Parse(row["Article_jgmin"].ToString());
                }
                if (row["Article_jgmax"] != null && row["Article_jgmax"].ToString() != "")
                {
                    model.Article_jgmax = decimal.Parse(row["Article_jgmax"].ToString());
                }
                if (row["Article_Title_Color"] != null)
                {
                    model.Article_Title_Color = row["Article_Title_Color"].ToString();
                }
                if (row["Article_Complete_Title"] != null)
                {
                    model.Article_Complete_Title = row["Article_Complete_Title"].ToString();
                }
                if (row["Article_Column"] != null && row["Article_Column"].ToString() != "")
                {
                    model.Article_Column = int.Parse(row["Article_Column"].ToString());
                }
                if (row["Article_Shift_link_URL"] != null)
                {
                    model.Article_Shift_link_URL = row["Article_Shift_link_URL"].ToString();
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
            strSql.Append("select Article_ID,Article_Shift_link_URLA,Article_Author,Article_Article_source,Article_Article_source_URL,Article_Keyword,Article_Guide,Article_GuideA,Article_Annex,Article_Content,Article_Cover_image,Article_AddPeopleID,Article_Thumbnail_sizeX,Article_Thumbnail_sizeY,Article_Class,Article_Auditing,Article_Release_date,Article_IPaddress,Article_Release,Article_AuditpersonID,Article_Auditdate,Article_Add_date,Article_Type,Article_Ordernumber,Article_Stock,Article_Unit,Article_Xssx,Article_Discount,Article_RetailPrice,Article_Promotion,Article_Title,Article_hitsg,Article_hitsn,Article_hitsy,Article_hitsz,Article_hitst,Article_hitsntime,Article_hitsytime,Article_hitsztime,Article_hitsttime,Article_Font_style,Article_login,Article_comment,Article_sptype,Article_spgodate,Article_spenddate,Article_jgmin,Article_jgmax,Article_Title_Color,Article_Complete_Title,Article_Column,Article_Shift_link_URL ");
            strSql.Append(" FROM Article ");
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
            strSql.Append(" Article_ID,Article_Shift_link_URLA,Article_Author,Article_Article_source,Article_Article_source_URL,Article_Keyword,Article_Guide,Article_GuideA,Article_Annex,Article_Content,Article_Cover_image,Article_AddPeopleID,Article_Thumbnail_sizeX,Article_Thumbnail_sizeY,Article_Class,Article_Auditing,Article_Release_date,Article_IPaddress,Article_Release,Article_AuditpersonID,Article_Auditdate,Article_Add_date,Article_Type,Article_Ordernumber,Article_Stock,Article_Unit,Article_Xssx,Article_Discount,Article_RetailPrice,Article_Promotion,Article_Title,Article_hitsg,Article_hitsn,Article_hitsy,Article_hitsz,Article_hitst,Article_hitsntime,Article_hitsytime,Article_hitsztime,Article_hitsttime,Article_Font_style,Article_login,Article_comment,Article_sptype,Article_spgodate,Article_spenddate,Article_jgmin,Article_jgmax,Article_Title_Color,Article_Complete_Title,Article_Column,Article_Shift_link_URL ");
            strSql.Append(" FROM Article ");
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
            strSql.Append("select count(1) FROM Article ");
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
                strSql.Append("order by T.Article_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Article T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #endregion  BasicMethod

        #region  ExtensionMethod

        #region 【查询系统类型 系统类型下有那些系统栏目】
        /// <summary>
        /// 查询系统类型 系统类型下有那些系统栏目
        /// </summary>
        /// <param name="storedProcName">存储过程名:System_Type_ColumnA</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <param name="aid">系统栏目Column_Aid</param>
        /// <param name="sql">0查看全部没筛选，1筛选管理系统ID[Type_ID]等于几的如1只输出 文章系统，2只输出图片系统</param>
        /// <returns></returns>
        public DataSet Bpwen_Column(string storedProcName, int id, int aid, int sql)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@Aid", SqlDbType.Int,4),
                    new SqlParameter("@Sql", SqlDbType.Int,4)
                    };
            parameters[0].Value = id;
            parameters[1].Value = aid;
            parameters[2].Value = sql;
            return DbHelperSQL.RunProcedure(storedProcName, parameters, "ds");
        }
        #endregion

        #region 【查询系统类型 系统栏目 文章如：查询某个系统下当前栏目下它所有的发布内容文章】
        /// <summary>
        /// 查询系统类型 系统栏目 文章如：查询某个系统下当前栏目下它所有的发布内容文章
        /// </summary>
        /// <param name="storedProcName">存储过程名:System_type_Column_ArticleA</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <param name="sql">0查看全部没筛选，1筛选管理系统ID[Type_ID]等于几的如1只输出 文章系统，2只输出图片系统</param>
        /// <param name="Count">要返回的参数 sql 为2则需要</param>
        /// <param name="aid">系统栏目Column_Aid</param>
        /// <returns></returns>
        public DataSet Bpwen_Breadline(string storedProcName, int id, int sql, int Count,int aid)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@Sql", SqlDbType.Int,4),
                    new SqlParameter("@Count", SqlDbType.Int,4),
                    new SqlParameter("@Aid", SqlDbType.Int,4)
                    };
            parameters[0].Value = id;
            parameters[1].Value = sql;
            parameters[2].Value = Count;
            parameters[3].Value = aid;
            return DbHelperSQL.RunProcedure(storedProcName, parameters, "ds");
        }
        #endregion

        #region 【批量修改审核】
        /// <summary>
        /// 批量修改审核
        /// </summary>
        /// <param name="Article_IDlist">in (id)</param>
        /// <param name="AuditpersonID">审核人ID</param>
        /// <returns></returns>
        public bool Auditthrough(string Article_IDlist, int AuditpersonID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("Article_Auditing=@Article_Auditing,");
            strSql.Append("Article_AuditpersonID=@Article_AuditpersonID,");
            strSql.Append("Article_Auditdate=@Article_Auditdate");
            strSql.Append(" where Article_ID in (" + Article_IDlist + ")");
            SqlParameter[] parameters = {
                    new SqlParameter("@Article_Auditing", SqlDbType.Int,4),
                    new SqlParameter("@Article_AuditpersonID", SqlDbType.Int,4),
                    new SqlParameter("@Article_Auditdate", SqlDbType.DateTime),
            };
            parameters[0].Value = 1;
            parameters[1].Value = AuditpersonID;
            parameters[2].Value = DateTime.Now;

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

        #region 【往下查询所有子栏目】
        /// <summary>
        /// 往下查询所有子栏目
        /// </summary>
        /// <param name="name">存储过程名:System_Column_B</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <returns></returns>
        public DataSet bpw_AllSonColumn(string name, int id)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@Column_ID", SqlDbType.Int,4),
                    };
            parameters[0].Value = id;
            return DbHelperSQL.RunProcedure(name, parameters, "ds");
        }
        #endregion

        #region 【获取栏目下所有的文章】
        /// <summary>
        /// 获取栏目下所有的文章
        /// </summary>
        /// <param name="strWhere">栏目条件</param>
        /// <param name="sql">自定义一些条件如：and date=2017 ,and也可以是or</param>
        /// <param name="orderby">排序</param>
        /// <returns></returns>
        public DataSet Getlist(string strWhere, string sql, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            if ((strWhere != null) && (strWhere != String.Empty))
            {
                strSql.Append("with cte1 as(");
                strSql.Append("select * from System_Column Where " + strWhere);
                strSql.Append(" union all ");
                strSql.Append("select System_Column.*from cte1 inner join System_Column on cte1.Column_ID = System_Column.Column_Aid");
                strSql.Append("),");
                strSql.Append("cte2 as(");
                strSql.Append("select * from System_type_Column_Article");
                if (sql.Trim() != "")
                {
                    strSql.Append(" Where " + sql);
                }
                strSql.Append(")");
                strSql.Append("select a.* from cte2 a, cte1 b Where b.Column_ID = a.Article_Column");
                if (!string.IsNullOrEmpty(orderby.Trim()))
                {
                    strSql.Append(orderby);
                }
                else
                {
                    strSql.Append("order by a.Article_ID desc");
                }
            }
            else
            {
                strSql.Append("select * from System_type_Column_Article");
                if (sql.Trim() != "")
                {
                    strSql.Append(" Where " + sql);
                }
                if (!string.IsNullOrEmpty(orderby.Trim()))
                {
                    strSql.Append(orderby);
                }
                else
                {
                    strSql.Append("order by Article_ID desc");
                }
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        /// <param name="id">栏目id，如果该栏目下有子栏目也会遍历对应子栏目的文章出来</param>
        /// <param name="sql">自定义一些条件如：and date=2017 ,and也可以是or</param>
        /// <returns></returns>
        public int GetRecordCount(int id, string sql)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("with cte1 as(");
            strSql.Append("select * from System_Column Where Column_ID = " + id);
            strSql.Append(" union all ");
            strSql.Append("select System_Column.*from cte1 inner join System_Column on cte1.Column_ID = System_Column.Column_Aid");
            strSql.Append("),");
            strSql.Append("cte2 as(");
            strSql.Append("select * from System_type_Column_Article");
            if (sql.Trim() != "")
            {
                strSql.Append(" Where " + sql);
            }
            strSql.Append(")");
            strSql.Append("select count(1) from cte2 a, cte1 b Where b.Column_ID = a.Article_Column");
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
        public DataSet GetListByPagea(string strWhere, string strWhereb, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("with cte1 as(");
            strSql.Append("    select * from System_Column");
            if (!string.IsNullOrEmpty(strWhereb.Trim()))
            {
                strSql.Append(" WHERE " + strWhereb);
            }
            strSql.Append("    union all");
            strSql.Append("    select System_Column.*from cte1 inner join System_Column on cte1.Column_ID = System_Column.Column_Aid");
            strSql.Append("),cte2 as(");
            strSql.Append("    select * from System_type_Column_Article");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(")");
            strSql.Append("SELECT* FROM (");
            strSql.Append("SELECT ROW_NUMBER() OVER(");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by a." + orderby);
            }
            else
            {
                strSql.Append("order by a.Article_ID desc");
            }
            strSql.Append(")AS Row, a.* from cte2 a, cte1 b ");
            strSql.Append(" WHERE b.Column_ID = a.Article_Column");
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        public int GetRecordCountA(string strWhere, string strWhereb)
        {
            //with cte1 as(
            //    select * from System_Column WHERE Column_SystemID = 1
            //    union all
            //    select System_Column.*from cte1 inner join System_Column on cte1.Column_ID = System_Column.Column_Aid
            //),
            //cte2 as(
            //    select * from System_type_Column_Article WHERE Column_SystemID = 1
            //)
            //select count(1) from cte2 a, cte1 b Where b.Column_ID = a.Article_Column

            StringBuilder strSql = new StringBuilder();
            strSql.Append("with cte1 as(");
            strSql.Append("select * from System_Column");
            if (!string.IsNullOrEmpty(strWhereb.Trim()))
            {
                strSql.Append(" WHERE " + strWhereb);
            }
            strSql.Append(" union all ");
            strSql.Append("select System_Column.*from cte1 inner join System_Column on cte1.Column_ID = System_Column.Column_Aid");
            strSql.Append("),");
            strSql.Append("cte2 as(");
            strSql.Append("select * from System_type_Column_Article");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(")");
            strSql.Append("select count(1) from cte2 a, cte1 b Where b.Column_ID = a.Article_Column");
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
        public DataSet GetListByPageb(string strWhere, string orderby, int startIndex, int endIndex)
        {
            /// SELECT * FROM ( 
            /// SELECT ROW_NUMBER() OVER(order by T.Article_ID desc)AS Row, T.*  from System_type_Column_Article T WHERE Column_SystemID=1) TT
            /// WHERE TT.Row between 0 and 10
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Article_ID desc");
            }
            strSql.Append(")AS Row, T.*  from System_type_Column_Article T ");
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
        /// <param name="id">ID串</param>
        /// <returns></returns>
        public bool Update(string set, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set "+ set);
            strSql.Append(" where Article_ID in (" + id + ")  ");
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

        #endregion  ExtensionMethod
    }
}

