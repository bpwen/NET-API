using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using HRMS.IDAL.Label;
using HRMS.DBUtility;
using System.Text.RegularExpressions;

namespace HRMS.SQLServerDAL.Label
{
    /// <summary>
    /// Label
    /// </summary>
    public partial class LabelDAL : ILabelDAL
    {
        public LabelDAL()
        { }
        #region 【基本方法】BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Label_ID", "Label");
        }
        #endregion

        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Label_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Label");
            strSql.Append(" where Label_ID=@Label_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Label_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Label_ID;
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
            strSql.Append("select count(1) from Label");
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
        public int Add(HRMS.Model.Label.LabelModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Label(");
            strSql.Append("Label_LayerWidth,Label_LayerHigh,Label_Address,Label_Href,Label_Hreftarget,Label_Width,Label_Height,Label_Description,Label_StyleFather,Label_StyleSub,Label_Type,Label_Paging,Label_FatherID,Label_SubID,Label_Displaytype,Label_SortA,Label_SortB,Label_SortC,Label_SortD,Label_SqlChoice,Label_SqlCode,Label_Mark,Label_Show,Label_Showno,Label_Line,Label_Column,Label_TitleLength,Label_TitleEllipsis,Label_Bytelength,Label_Class,Label_Classway,Label_Classpage,Label_Name,Label_Roll,Label_RollA,Label_RollB,Label_RollC,Label_Newest,Label_Hot,Label_navfocus,Label_NoData,Label_NoSearchData,Label_inissue,Label_Callpage,Label_signin,Label_styleid,Label_Templatepage,Label_CodeOutside,Label_Code,Label_Hide)");
            strSql.Append(" values (");
            strSql.Append("@Label_LayerWidth,@Label_LayerHigh,@Label_Address,@Label_Href,@Label_Hreftarget,@Label_Width,@Label_Height,@Label_Description,@Label_StyleFather,@Label_StyleSub,@Label_Type,@Label_Paging,@Label_FatherID,@Label_SubID,@Label_Displaytype,@Label_SortA,@Label_SortB,@Label_SortC,@Label_SortD,@Label_SqlChoice,@Label_SqlCode,@Label_Mark,@Label_Show,@Label_Showno,@Label_Line,@Label_Column,@Label_TitleLength,@Label_TitleEllipsis,@Label_Bytelength,@Label_Class,@Label_Classway,@Label_Classpage,@Label_Name,@Label_Roll,@Label_RollA,@Label_RollB,@Label_RollC,@Label_Newest,@Label_Hot,@Label_navfocus,@Label_NoData,@Label_NoSearchData,@Label_inissue,@Label_Callpage,@Label_signin,@Label_styleid,@Label_Templatepage,@Label_CodeOutside,@Label_Code,@Label_Hide)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Label_LayerWidth", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_LayerHigh", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Address", SqlDbType.NText),
                    new SqlParameter("@Label_Href", SqlDbType.NText),
                    new SqlParameter("@Label_Hreftarget", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Width", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Height", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Description", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_StyleFather", SqlDbType.NText),
                    new SqlParameter("@Label_StyleSub", SqlDbType.NText),
                    new SqlParameter("@Label_Type", SqlDbType.Int,4),
                    new SqlParameter("@Label_Paging", SqlDbType.Bit,1),
                    new SqlParameter("@Label_FatherID", SqlDbType.NText),
                    new SqlParameter("@Label_SubID", SqlDbType.NText),
                    new SqlParameter("@Label_Displaytype", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SortA", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SortB", SqlDbType.Int,4),
                    new SqlParameter("@Label_SortC", SqlDbType.NVarChar,5),
                    new SqlParameter("@Label_SortD", SqlDbType.NVarChar,100),
                    new SqlParameter("@Label_SqlChoice", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SqlCode", SqlDbType.NText),
                    new SqlParameter("@Label_Mark", SqlDbType.Decimal,9),
                    new SqlParameter("@Label_Show", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_Showno", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_Line", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Column", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_TitleLength", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_TitleEllipsis", SqlDbType.Bit,1),
                    new SqlParameter("@Label_Bytelength", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Class", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Classway", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Classpage", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Roll", SqlDbType.Int,4),
                    new SqlParameter("@Label_RollA", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_RollB", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_RollC", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Newest", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Hot", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_navfocus", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_NoData", SqlDbType.NText),
                    new SqlParameter("@Label_NoSearchData", SqlDbType.NText),
                    new SqlParameter("@Label_inissue", SqlDbType.Bit,1),
                    new SqlParameter("@Label_Callpage", SqlDbType.NText),
                    new SqlParameter("@Label_signin", SqlDbType.Bit,1),
                    new SqlParameter("@Label_styleid", SqlDbType.Int,4),
                    new SqlParameter("@Label_Templatepage", SqlDbType.NText),
                    new SqlParameter("@Label_CodeOutside", SqlDbType.NText),
                    new SqlParameter("@Label_Code", SqlDbType.NText),
                    new SqlParameter("@Label_Hide", SqlDbType.Bit,1)
            };
            parameters[0].Value = model.Label_LayerWidth;
            parameters[1].Value = model.Label_LayerHigh;
            parameters[2].Value = model.Label_Address;
            parameters[3].Value = model.Label_Href;
            parameters[4].Value = model.Label_Hreftarget;
            parameters[5].Value = model.Label_Width;
            parameters[6].Value = model.Label_Height;
            parameters[7].Value = model.Label_Description;
            parameters[8].Value = model.Label_StyleFather;
            parameters[9].Value = model.Label_StyleSub;
            parameters[10].Value = model.Label_Type;
            parameters[11].Value = model.Label_Paging;
            parameters[12].Value = model.Label_FatherID;
            parameters[13].Value = model.Label_SubID;
            parameters[14].Value = model.Label_Displaytype;
            parameters[15].Value = model.Label_SortA;
            parameters[16].Value = model.Label_SortB;
            parameters[17].Value = model.Label_SortC;
            parameters[18].Value = model.Label_SortD;
            parameters[19].Value = model.Label_SqlChoice;
            parameters[20].Value = model.Label_SqlCode;
            parameters[21].Value = model.Label_Mark;
            parameters[22].Value = model.Label_Show;
            parameters[23].Value = model.Label_Showno;
            parameters[24].Value = model.Label_Line;
            parameters[25].Value = model.Label_Column;
            parameters[26].Value = model.Label_TitleLength;
            parameters[27].Value = model.Label_TitleEllipsis;
            parameters[28].Value = model.Label_Bytelength;
            parameters[29].Value = model.Label_Class;
            parameters[30].Value = model.Label_Classway;
            parameters[31].Value = model.Label_Classpage;
            parameters[32].Value = model.Label_Name;
            parameters[33].Value = model.Label_Roll;
            parameters[34].Value = model.Label_RollA;
            parameters[35].Value = model.Label_RollB;
            parameters[36].Value = model.Label_RollC;
            parameters[37].Value = model.Label_Newest;
            parameters[38].Value = model.Label_Hot;
            parameters[39].Value = model.Label_navfocus;
            parameters[40].Value = model.Label_NoData;
            parameters[41].Value = model.Label_NoSearchData;
            parameters[42].Value = model.Label_inissue;
            parameters[43].Value = model.Label_Callpage;
            parameters[44].Value = model.Label_signin;
            parameters[45].Value = model.Label_styleid;
            parameters[46].Value = model.Label_Templatepage;
            parameters[47].Value = model.Label_CodeOutside;
            parameters[48].Value = model.Label_Code;
            parameters[49].Value = model.Label_Hide;

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
        public bool Update(HRMS.Model.Label.LabelModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Label set ");
            strSql.Append("Label_LayerWidth=@Label_LayerWidth,");
            strSql.Append("Label_LayerHigh=@Label_LayerHigh,");
            strSql.Append("Label_Address=@Label_Address,");
            strSql.Append("Label_Href=@Label_Href,");
            strSql.Append("Label_Hreftarget=@Label_Hreftarget,");
            strSql.Append("Label_Width=@Label_Width,");
            strSql.Append("Label_Height=@Label_Height,");
            strSql.Append("Label_Description=@Label_Description,");
            strSql.Append("Label_StyleFather=@Label_StyleFather,");
            strSql.Append("Label_StyleSub=@Label_StyleSub,");
            strSql.Append("Label_Type=@Label_Type,");
            strSql.Append("Label_Paging=@Label_Paging,");
            strSql.Append("Label_FatherID=@Label_FatherID,");
            strSql.Append("Label_SubID=@Label_SubID,");
            strSql.Append("Label_Displaytype=@Label_Displaytype,");
            strSql.Append("Label_SortA=@Label_SortA,");
            strSql.Append("Label_SortB=@Label_SortB,");
            strSql.Append("Label_SortC=@Label_SortC,");
            strSql.Append("Label_SortD=@Label_SortD,");
            strSql.Append("Label_SqlChoice=@Label_SqlChoice,");
            strSql.Append("Label_SqlCode=@Label_SqlCode,");
            strSql.Append("Label_Mark=@Label_Mark,");
            strSql.Append("Label_Show=@Label_Show,");
            strSql.Append("Label_Showno=@Label_Showno,");
            strSql.Append("Label_Line=@Label_Line,");
            strSql.Append("Label_Column=@Label_Column,");
            strSql.Append("Label_TitleLength=@Label_TitleLength,");
            strSql.Append("Label_TitleEllipsis=@Label_TitleEllipsis,");
            strSql.Append("Label_Bytelength=@Label_Bytelength,");
            strSql.Append("Label_Class=@Label_Class,");
            strSql.Append("Label_Classway=@Label_Classway,");
            strSql.Append("Label_Classpage=@Label_Classpage,");
            strSql.Append("Label_Name=@Label_Name,");
            strSql.Append("Label_Roll=@Label_Roll,");
            strSql.Append("Label_RollA=@Label_RollA,");
            strSql.Append("Label_RollB=@Label_RollB,");
            strSql.Append("Label_RollC=@Label_RollC,");
            strSql.Append("Label_Newest=@Label_Newest,");
            strSql.Append("Label_Hot=@Label_Hot,");
            strSql.Append("Label_navfocus=@Label_navfocus,");
            strSql.Append("Label_NoData=@Label_NoData,");
            strSql.Append("Label_NoSearchData=@Label_NoSearchData,");
            strSql.Append("Label_inissue=@Label_inissue,");
            strSql.Append("Label_Callpage=@Label_Callpage,");
            strSql.Append("Label_signin=@Label_signin,");
            strSql.Append("Label_styleid=@Label_styleid,");
            strSql.Append("Label_Templatepage=@Label_Templatepage,");
            strSql.Append("Label_CodeOutside=@Label_CodeOutside,");
            strSql.Append("Label_Code=@Label_Code,");
            strSql.Append("Label_Hide=@Label_Hide");
            strSql.Append(" where Label_ID=@Label_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Label_ID", SqlDbType.Int,4),
                    new SqlParameter("@Label_LayerWidth", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_LayerHigh", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Address", SqlDbType.NText),
                    new SqlParameter("@Label_Href", SqlDbType.NText),
                    new SqlParameter("@Label_Hreftarget", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Width", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Height", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Description", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_StyleFather", SqlDbType.NText),
                    new SqlParameter("@Label_StyleSub", SqlDbType.NText),
                    new SqlParameter("@Label_Type", SqlDbType.Int,4),
                    new SqlParameter("@Label_Paging", SqlDbType.Bit,1),
                    new SqlParameter("@Label_FatherID", SqlDbType.NText),
                    new SqlParameter("@Label_SubID", SqlDbType.NText),
                    new SqlParameter("@Label_Displaytype", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SortA", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SortB", SqlDbType.Int,4),
                    new SqlParameter("@Label_SortC", SqlDbType.NVarChar,5),
                    new SqlParameter("@Label_SortD", SqlDbType.NVarChar,100),
                    new SqlParameter("@Label_SqlChoice", SqlDbType.Bit,1),
                    new SqlParameter("@Label_SqlCode", SqlDbType.NText),
                    new SqlParameter("@Label_Mark", SqlDbType.Decimal,9),
                    new SqlParameter("@Label_Show", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_Showno", SqlDbType.NVarChar,200),
                    new SqlParameter("@Label_Line", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Column", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_TitleLength", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_TitleEllipsis", SqlDbType.Bit,1),
                    new SqlParameter("@Label_Bytelength", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Class", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Classway", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Classpage", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Roll", SqlDbType.Int,4),
                    new SqlParameter("@Label_RollA", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_RollB", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_RollC", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Newest", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_Hot", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_navfocus", SqlDbType.NVarChar,50),
                    new SqlParameter("@Label_NoData", SqlDbType.NText),
                    new SqlParameter("@Label_NoSearchData", SqlDbType.NText),
                    new SqlParameter("@Label_inissue", SqlDbType.Bit,1),
                    new SqlParameter("@Label_Callpage", SqlDbType.NText),
                    new SqlParameter("@Label_signin", SqlDbType.Bit,1),
                    new SqlParameter("@Label_styleid", SqlDbType.Int,4),
                    new SqlParameter("@Label_Templatepage", SqlDbType.NText),
                    new SqlParameter("@Label_CodeOutside", SqlDbType.NText),
                    new SqlParameter("@Label_Code", SqlDbType.NText),
                    new SqlParameter("@Label_Hide", SqlDbType.Bit,1)
            };
            parameters[0].Value = model.Label_ID;
            parameters[1].Value = model.Label_LayerWidth;
            parameters[2].Value = model.Label_LayerHigh;
            parameters[3].Value = model.Label_Address;
            parameters[4].Value = model.Label_Href;
            parameters[5].Value = model.Label_Hreftarget;
            parameters[6].Value = model.Label_Width;
            parameters[7].Value = model.Label_Height;
            parameters[8].Value = model.Label_Description;
            parameters[9].Value = model.Label_StyleFather;
            parameters[10].Value = model.Label_StyleSub;
            parameters[11].Value = model.Label_Type;
            parameters[12].Value = model.Label_Paging;
            parameters[13].Value = model.Label_FatherID;
            parameters[14].Value = model.Label_SubID;
            parameters[15].Value = model.Label_Displaytype;
            parameters[16].Value = model.Label_SortA;
            parameters[17].Value = model.Label_SortB;
            parameters[18].Value = model.Label_SortC;
            parameters[19].Value = model.Label_SortD;
            parameters[20].Value = model.Label_SqlChoice;
            parameters[21].Value = model.Label_SqlCode;
            parameters[22].Value = model.Label_Mark;
            parameters[23].Value = model.Label_Show;
            parameters[24].Value = model.Label_Showno;
            parameters[25].Value = model.Label_Line;
            parameters[26].Value = model.Label_Column;
            parameters[27].Value = model.Label_TitleLength;
            parameters[28].Value = model.Label_TitleEllipsis;
            parameters[29].Value = model.Label_Bytelength;
            parameters[30].Value = model.Label_Class;
            parameters[31].Value = model.Label_Classway;
            parameters[32].Value = model.Label_Classpage;
            parameters[33].Value = model.Label_Name;
            parameters[34].Value = model.Label_Roll;
            parameters[35].Value = model.Label_RollA;
            parameters[36].Value = model.Label_RollB;
            parameters[37].Value = model.Label_RollC;
            parameters[38].Value = model.Label_Newest;
            parameters[39].Value = model.Label_Hot;
            parameters[40].Value = model.Label_navfocus;
            parameters[41].Value = model.Label_NoData;
            parameters[42].Value = model.Label_NoSearchData;
            parameters[43].Value = model.Label_inissue;
            parameters[44].Value = model.Label_Callpage;
            parameters[45].Value = model.Label_signin;
            parameters[46].Value = model.Label_styleid;
            parameters[47].Value = model.Label_Templatepage;
            parameters[48].Value = model.Label_CodeOutside;
            parameters[49].Value = model.Label_Code;
            parameters[50].Value = model.Label_Hide;

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
        public bool Delete(int Label_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Label ");
            strSql.Append(" where Label_ID=@Label_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Label_ID", SqlDbType.Int,4)

            };
            parameters[0].Value = Label_ID;

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

        public bool Delete(string strWhere, int Label_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Label ");
            strSql.Append(" where " + strWhere + "=@Label_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Label_ID", SqlDbType.Int,4)

            };
            parameters[0].Value = Label_ID;

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
        public bool DeleteList(string Label_IDlist)
        {
            #region 【正则判断提交过来的值全是数字类型不，如有其他字符则返回 false】
            bool _bool = true;
            if (Label_IDlist.IndexOf(",") > 0)
            {
                MatchCollection matches = Regex.Matches(Label_IDlist, @"[^,<]+");
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
            strSql.Append("delete from Label ");
            strSql.Append(" where Label_ID in (" + Label_IDlist + ")  ");
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
        public HRMS.Model.Label.LabelModel GetModel(int Label_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Label_ID,Label_LayerWidth,Label_LayerHigh,Label_Address,Label_Href,Label_Hreftarget,Label_Width,Label_Height,Label_Description,Label_StyleFather,Label_StyleSub,Label_Type,Label_Paging,Label_FatherID,Label_SubID,Label_Displaytype,Label_SortA,Label_SortB,Label_SortC,Label_SortD,Label_SqlChoice,Label_SqlCode,Label_Mark,Label_Show,Label_Showno,Label_Line,Label_Column,Label_TitleLength,Label_TitleEllipsis,Label_Bytelength,Label_Class,Label_Classway,Label_Classpage,Label_Name,Label_Roll,Label_RollA,Label_RollB,Label_RollC,Label_Newest,Label_Hot,Label_navfocus,Label_NoData,Label_NoSearchData,Label_inissue,Label_Callpage,Label_signin,Label_styleid,Label_Templatepage,Label_CodeOutside,Label_Code,Label_Hide from Label ");
            strSql.Append(" where Label_ID=@Label_ID");
            SqlParameter[] parameters = {
                new SqlParameter("@Label_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Label_ID;

            HRMS.Model.Label.LabelModel model = new HRMS.Model.Label.LabelModel();
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
        public HRMS.Model.Label.LabelModel GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Label_ID,Label_LayerWidth,Label_LayerHigh,Label_Address,Label_Href,Label_Hreftarget,Label_Width,Label_Height,Label_Description,Label_StyleFather,Label_StyleSub,Label_Type,Label_Paging,Label_FatherID,Label_SubID,Label_Displaytype,Label_SortA,Label_SortB,Label_SortC,Label_SortD,Label_SqlChoice,Label_SqlCode,Label_Mark,Label_Show,Label_Showno,Label_Line,Label_Column,Label_TitleLength,Label_TitleEllipsis,Label_Bytelength,Label_Class,Label_Classway,Label_Classpage,Label_Name,Label_Roll,Label_RollA,Label_RollB,Label_RollC,Label_Newest,Label_Hot,Label_navfocus,Label_NoData,Label_NoSearchData,Label_inissue,Label_Callpage,Label_signin,Label_styleid,Label_Templatepage,Label_CodeOutside,Label_Code,Label_Hide from Label ");
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
        public HRMS.Model.Label.LabelModel DataRowToModel(DataRow row)
        {
            HRMS.Model.Label.LabelModel model = new HRMS.Model.Label.LabelModel();
            if (row != null)
            {

                if (row["Label_ID"] != null && row["Label_ID"].ToString() != "")
                {
                    model.Label_ID = int.Parse(row["Label_ID"].ToString());
                }
                if (row["Label_LayerWidth"] != null)
                {
                    model.Label_LayerWidth = row["Label_LayerWidth"].ToString();
                }
                if (row["Label_LayerHigh"] != null)
                {
                    model.Label_LayerHigh = row["Label_LayerHigh"].ToString();
                }
                if (row["Label_Address"] != null)
                {
                    model.Label_Address = row["Label_Address"].ToString();
                }
                if (row["Label_Href"] != null)
                {
                    model.Label_Href = row["Label_Href"].ToString();
                }
                if (row["Label_Hreftarget"] != null)
                {
                    model.Label_Hreftarget = row["Label_Hreftarget"].ToString();
                }
                if (row["Label_Width"] != null)
                {
                    model.Label_Width = row["Label_Width"].ToString();
                }
                if (row["Label_Height"] != null)
                {
                    model.Label_Height = row["Label_Height"].ToString();
                }
                if (row["Label_Description"] != null)
                {
                    model.Label_Description = row["Label_Description"].ToString();
                }
                if (row["Label_StyleFather"] != null)
                {
                    model.Label_StyleFather = row["Label_StyleFather"].ToString();
                }
                if (row["Label_StyleSub"] != null)
                {
                    model.Label_StyleSub = row["Label_StyleSub"].ToString();
                }
                if (row["Label_Type"] != null && row["Label_Type"].ToString() != "")
                {
                    model.Label_Type = int.Parse(row["Label_Type"].ToString());
                }
                if (row["Label_Paging"] != null && row["Label_Paging"].ToString() != "")
                {
                    if ((row["Label_Paging"].ToString() == "1") || (row["Label_Paging"].ToString().ToLower() == "true"))
                    {
                        model.Label_Paging = true;
                    }
                    else
                    {
                        model.Label_Paging = false;
                    }
                }
                if (row["Label_FatherID"] != null)
                {
                    model.Label_FatherID = row["Label_FatherID"].ToString();
                }
                if (row["Label_SubID"] != null)
                {
                    model.Label_SubID = row["Label_SubID"].ToString();
                }
                if (row["Label_Displaytype"] != null && row["Label_Displaytype"].ToString() != "")
                {
                    if ((row["Label_Displaytype"].ToString() == "1") || (row["Label_Displaytype"].ToString().ToLower() == "true"))
                    {
                        model.Label_Displaytype = true;
                    }
                    else
                    {
                        model.Label_Displaytype = false;
                    }
                }
                if (row["Label_SortA"] != null && row["Label_SortA"].ToString() != "")
                {
                    if ((row["Label_SortA"].ToString() == "1") || (row["Label_SortA"].ToString().ToLower() == "true"))
                    {
                        model.Label_SortA = true;
                    }
                    else
                    {
                        model.Label_SortA = false;
                    }
                }
                if (row["Label_SortB"] != null && row["Label_SortB"].ToString() != "")
                {
                    model.Label_SortB = int.Parse(row["Label_SortB"].ToString());
                }
                if (row["Label_SortC"] != null)
                {
                    model.Label_SortC = row["Label_SortC"].ToString();
                }
                if (row["Label_SortD"] != null)
                {
                    model.Label_SortD = row["Label_SortD"].ToString();
                }
                if (row["Label_SqlChoice"] != null && row["Label_SqlChoice"].ToString() != "")
                {
                    if ((row["Label_SqlChoice"].ToString() == "1") || (row["Label_SqlChoice"].ToString().ToLower() == "true"))
                    {
                        model.Label_SqlChoice = true;
                    }
                    else
                    {
                        model.Label_SqlChoice = false;
                    }
                }
                if (row["Label_SqlCode"] != null)
                {
                    model.Label_SqlCode = row["Label_SqlCode"].ToString();
                }
                if (row["Label_Mark"] != null && row["Label_Mark"].ToString() != "")
                {
                    model.Label_Mark = decimal.Parse(row["Label_Mark"].ToString());
                }
                if (row["Label_Show"] != null)
                {
                    model.Label_Show = row["Label_Show"].ToString();
                }
                if (row["Label_Showno"] != null)
                {
                    model.Label_Showno = row["Label_Showno"].ToString();
                }
                if (row["Label_Line"] != null)
                {
                    model.Label_Line = row["Label_Line"].ToString();
                }
                if (row["Label_Column"] != null)
                {
                    model.Label_Column = row["Label_Column"].ToString();
                }
                if (row["Label_TitleLength"] != null)
                {
                    model.Label_TitleLength = row["Label_TitleLength"].ToString();
                }
                if (row["Label_TitleEllipsis"] != null && row["Label_TitleEllipsis"].ToString() != "")
                {
                    if ((row["Label_TitleEllipsis"].ToString() == "1") || (row["Label_TitleEllipsis"].ToString().ToLower() == "true"))
                    {
                        model.Label_TitleEllipsis = true;
                    }
                    else
                    {
                        model.Label_TitleEllipsis = false;
                    }
                }
                if (row["Label_Bytelength"] != null)
                {
                    model.Label_Bytelength = row["Label_Bytelength"].ToString();
                }
                if (row["Label_Class"] != null)
                {
                    model.Label_Class = row["Label_Class"].ToString();
                }
                if (row["Label_Classway"] != null)
                {
                    model.Label_Classway = row["Label_Classway"].ToString();
                }
                if (row["Label_Classpage"] != null)
                {
                    model.Label_Classpage = row["Label_Classpage"].ToString();
                }
                if (row["Label_Name"] != null)
                {
                    model.Label_Name = row["Label_Name"].ToString();
                }
                if (row["Label_Roll"] != null && row["Label_Roll"].ToString() != "")
                {
                    model.Label_Roll = int.Parse(row["Label_Roll"].ToString());
                }
                if (row["Label_RollA"] != null)
                {
                    model.Label_RollA = row["Label_RollA"].ToString();
                }
                if (row["Label_RollB"] != null)
                {
                    model.Label_RollB = row["Label_RollB"].ToString();
                }
                if (row["Label_RollC"] != null)
                {
                    model.Label_RollC = row["Label_RollC"].ToString();
                }
                if (row["Label_Newest"] != null)
                {
                    model.Label_Newest = row["Label_Newest"].ToString();
                }
                if (row["Label_Hot"] != null)
                {
                    model.Label_Hot = row["Label_Hot"].ToString();
                }
                if (row["Label_navfocus"] != null)
                {
                    model.Label_navfocus = row["Label_navfocus"].ToString();
                }
                if (row["Label_NoData"] != null)
                {
                    model.Label_NoData = row["Label_NoData"].ToString();
                }
                if (row["Label_NoSearchData"] != null)
                {
                    model.Label_NoSearchData = row["Label_NoSearchData"].ToString();
                }
                if (row["Label_inissue"] != null && row["Label_inissue"].ToString() != "")
                {
                    if ((row["Label_inissue"].ToString() == "1") || (row["Label_inissue"].ToString().ToLower() == "true"))
                    {
                        model.Label_inissue = true;
                    }
                    else
                    {
                        model.Label_inissue = false;
                    }
                }
                if (row["Label_Callpage"] != null)
                {
                    model.Label_Callpage = row["Label_Callpage"].ToString();
                }
                if (row["Label_signin"] != null && row["Label_signin"].ToString() != "")
                {
                    if ((row["Label_signin"].ToString() == "1") || (row["Label_signin"].ToString().ToLower() == "true"))
                    {
                        model.Label_signin = true;
                    }
                    else
                    {
                        model.Label_signin = false;
                    }
                }
                if (row["Label_styleid"] != null && row["Label_styleid"].ToString() != "")
                {
                    model.Label_styleid = int.Parse(row["Label_styleid"].ToString());
                }
                if (row["Label_Templatepage"] != null)
                {
                    model.Label_Templatepage = row["Label_Templatepage"].ToString();
                }
                if (row["Label_CodeOutside"] != null)
                {
                    model.Label_CodeOutside = row["Label_CodeOutside"].ToString();
                }
                if (row["Label_Code"] != null)
                {
                    model.Label_Code = row["Label_Code"].ToString();
                }
                if (row["Label_Hide"] != null && row["Label_Hide"].ToString() != "")
                {
                    if ((row["Label_Hide"].ToString() == "1") || (row["Label_Hide"].ToString().ToLower() == "true"))
                    {
                        model.Label_Hide = true;
                    }
                    else
                    {
                        model.Label_Hide = false;
                    }
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
            strSql.Append("select Label_ID,Label_LayerWidth,Label_LayerHigh,Label_Address,Label_Href,Label_Hreftarget,Label_Width,Label_Height,Label_Description,Label_StyleFather,Label_StyleSub,Label_Type,Label_Paging,Label_FatherID,Label_SubID,Label_Displaytype,Label_SortA,Label_SortB,Label_SortC,Label_SortD,Label_SqlChoice,Label_SqlCode,Label_Mark,Label_Show,Label_Showno,Label_Line,Label_Column,Label_TitleLength,Label_TitleEllipsis,Label_Bytelength,Label_Class,Label_Classway,Label_Classpage,Label_Name,Label_Roll,Label_RollA,Label_RollB,Label_RollC,Label_Newest,Label_Hot,Label_navfocus,Label_NoData,Label_NoSearchData,Label_inissue,Label_Callpage,Label_signin,Label_styleid,Label_Templatepage,Label_CodeOutside,Label_Code,Label_Hide ");
            strSql.Append(" FROM Label ");
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
            strSql.Append(" Label_ID,Label_LayerWidth,Label_LayerHigh,Label_Address,Label_Href,Label_Hreftarget,Label_Width,Label_Height,Label_Description,Label_StyleFather,Label_StyleSub,Label_Type,Label_Paging,Label_FatherID,Label_SubID,Label_Displaytype,Label_SortA,Label_SortB,Label_SortC,Label_SortD,Label_SqlChoice,Label_SqlCode,Label_Mark,Label_Show,Label_Showno,Label_Line,Label_Column,Label_TitleLength,Label_TitleEllipsis,Label_Bytelength,Label_Class,Label_Classway,Label_Classpage,Label_Name,Label_Roll,Label_RollA,Label_RollB,Label_RollC,Label_Newest,Label_Hot,Label_navfocus,Label_NoData,Label_NoSearchData,Label_inissue,Label_Callpage,Label_signin,Label_styleid,Label_Templatepage,Label_CodeOutside,Label_Code,Label_Hide ");
            strSql.Append(" FROM Label ");
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
            strSql.Append("select count(1) FROM Label ");
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
                strSql.Append("order by T.Label_ID desc");
            }
            strSql.Append(")AS Row, T.*  from Label T ");
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
            strSql.Append("update Label set " + set);
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
            strSql.Append("update Label set " + set);
            strSql.Append(" where Label_ID in (" + id + ")  ");
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