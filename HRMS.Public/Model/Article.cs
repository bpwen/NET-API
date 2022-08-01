using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using HRMS.Model.Label;

namespace HRMS.Public.Model
{
    /// <summary>
    /// 文章系统
    /// 文章标签编译
    /// 文章标签类
    /// </summary>
    public class Article
    {
        ArticleModel Variable = new ArticleModel();//文章参数变量存储
        BLL.Article.ArticleBLL ArticleBLL = new BLL.Article.ArticleBLL();

        Paging.Styleone.Paging_BLL Paging_BLL = new Paging.Styleone.Paging_BLL();
        Paging.Styleone.PagingModel PagingModel = new Paging.Styleone.PagingModel();

        BPW.paging.parameter Properties = new BPW.paging.parameter();

        /// <summary>
        /// 文章系统
        /// </summary>
        /// <returns></returns>
        public string Bpwen_Replace(LabelModel model)
        {
            DataSet ds = null;
            int Count = 0;

            #region 【Sql语句加载】
            #region 【判断显示类型分页不】
            if (!model.Label_Paging)
            {
                #region 【不分页-判断有指定显示栏目ID不】
                if (!BPW.IF.Null(model.Label_FatherID) || !BPW.IF.Null(model.Label_SubID))
                {
                    #region 【判断父栏目id已数组存储有内容不】
                    if (!BPW.IF.Null(model.Label_FatherID))
                    {
                        Variable.SqlWhere += "Column_Aid in (" + model.Label_FatherID + ") ";
                    }
                    #endregion

                    #region 【判断子栏目id已数组存储】
                    if (!BPW.IF.Null(model.Label_SubID))
                    {
                        if (!BPW.IF.Null(model.Label_FatherID))
                        {
                            Variable.SqlWhere += "or ";
                        }
                        Variable.SqlWhere += "Column_ID in (" + model.Label_SubID + ") ";
                    }
                    #endregion
                }
                #endregion
            }
            else
            {
                #region 【分页】
                if (BPW.IF.Null(model.Label_FatherID) && BPW.IF.Null(model.Label_SubID))
                {
                    #region 【判断没有制定栏目则执行】
                    int fid = BPW.Request.QueryStringInt("fid");
                    if (fid != -1)
                    {
                        Variable.SqlWhere += "Column_ID=" + fid + " ";
                    }
                    #endregion
                }
                else
                {
                    #region 【判断父栏目id已数组存储有内容不】
                    if (!BPW.IF.Null(model.Label_FatherID))
                    {
                        Variable.SqlWhere += "Column_Aid in (" + model.Label_FatherID + ") ";
                    }
                    #endregion

                    #region 【判断子栏目id已数组存储】
                    if (!BPW.IF.Null(model.Label_SubID))
                    {
                        if (!BPW.IF.Null(model.Label_FatherID))
                        {
                            Variable.SqlWhere += "or ";
                        }
                        Variable.SqlWhere += "Column_ID in (" + model.Label_SubID + ") ";
                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            #region 【判断是否只输出“已审核”的内容】
            if (model.Label_Displaytype)
            {
                Variable.Sql += SqlAnd("Article_Auditing=1 ");
            }
            #endregion

            #region 【判断是否只输出“已发布”的内容】
            if (model.Label_inissue)
            {
                Variable.Sql += SqlAnd("Article_Release=1 ");
            }
            #endregion

            #region 【判断是否只输出“签收”的内容】
            if (model.Label_signin)
            {
                Variable.Sql += SqlAnd("Article_AuditpersonID != 0 ");
            }
            #endregion

            #region 【判断是否启用自定义SQL语句】
            if (model.Label_SqlChoice)
            {
                Variable.Sql += SqlAnd(model.Label_SqlCode);
                Variable.Sql += " ";
            }
            #endregion

            #region 【搜索关键字不为空的情况下,开始模糊查询】
            string wd = BPW.Request.QueryString("wd");//读取搜索关键字
            if (wd != null)
            {
                Variable.Sql += SqlAnd("Article_Title like '%" + wd + "%' or Article_Keyword like '%" + wd + "%'");
                //Variable.Sql += SqlAnd("Article_Title like '%" + wd + "%' or Article_Keyword like '%" + wd + "%' or Article_Content like '%" + wd + "%'");
            }
            #endregion

            #region 【排序方式】
            if (model.Label_SortA)
            {
                Variable.Orderby = model.Label_SortD;
            }
            else
            {   //下拉选中排序方式
                Variable.Orderby += " order by ";
                if (model.Label_SortB == 5)
                {
                    Variable.Orderby += "Article_Release_date";
                }
                else
                {
                    Variable.Orderby += "Article_ID";
                }
                Variable.Orderby += " " + model.Label_SortC;
            }
            #endregion

            Variable.Sql += SqlAnd("Article_Release_date <='" + DateTime.Now + "' "); //发布时间大于当前时间才显示
            #endregion

            #region 【数据循环】

            #region 【相关参数】
            if (Variable.Sql == null) { Variable.Sql = ""; }
            ds = ArticleBLL.Getlist(Variable.SqlWhere, Variable.Sql, Variable.Orderby);
            Count = ds.Tables[0].Rows.Count;
            int Moreni = 0; //默认循环i等于这个数
            int PageSize = 0;

            if (model.Label_Paging)
            {
                #region 【分页则执行】
                PageSize = 10;
                #region 【假如管理员设置了多条则重新赐予】
                if (!BPW.IF.Null(model.Label_Line))
                {
                    if (model.Label_Line != "0")
                    {
                        PageSize = Convert.ToInt32(model.Label_Line);
                    }
                }
                #endregion
                PagingModel.PageSize = PageSize;//一页显示多少个
                PagingModel.Datavalue = ds;//数据源
                PagingModel.Totalrecord = Count;//总数据多少条
                PagedDataSource pds = Paging_BLL.Bpwen_Fenye(PagingModel);//执行相关操作
                Count = pds.Count;//改变数量
                #region 【分页配置循环下一页改变默认循环i等于当前page*显示行数】
                if (PagingModel.CurrentPageIndex != 0)
                {
                    Moreni = PagingModel.CurrentPageIndex * PageSize;
                    Count = Moreni + Count;
                }
                #endregion
                #endregion
            }
            else
            {
                #region 【假如读取的总数目大于管理员设置的行数则重新赐予】
                if (!BPW.IF.Null(model.Label_Line))
                {
                    if (model.Label_Line != "0")
                    {
                        if (Count > Convert.ToInt32(model.Label_Line))
                        {
                            Count = Convert.ToInt32(model.Label_Line);
                        }
                    }
                }
                #endregion
            }
            #endregion

            //Properties.recordcount = PagingModel.Totalrecord;
            //Properties.pagecount = 1;
            //Properties.page = 0;
            //Properties.pagesize = PagingModel.PageSize;
            //Properties.begin_count = 1;
            //Properties.end_count = 10;


            #region 【循环】
            if (Count != 0)
            {
                #region 【数据循环】
                int Fori = 0;
                List<ArticleModelA> Model = new List<ArticleModelA>();
                for (int i = Moreni; i < Count; i++)
                {
                    int Article_ID = Convert.ToInt32(ds.Tables[0].Rows[i]["Article_ID"]);

                    Fori = Fori + 1;
                    #region 【序列】
                    int Fenyexulie = i + 1;
                    if (model.Label_Paging)
                    {
                        int Pagei = BPW.Request.QueryStringInt("page");
                        if (Pagei != -1)
                        {
                            if (Pagei == 0) { Pagei = 1; }
                            if (Pagei > PagingModel.PageCount) { Pagei = PagingModel.PageCount; }
                            Fenyexulie = (Pagei - 1) * PageSize + Fori;
                        }
                    }
                    #endregion

                    #region 【描述】
                    string Guide = ds.Tables[0].Rows[i]["Article_Guide"].ToString();
                    if (model.Label_Bytelength != "")
                    {
                        Guide = BPW.@string.SubStr(Guide, Convert.ToInt32(model.Label_Bytelength)) + "...";
                    }
                    #endregion

                    Model.Add(new ArticleModelA()
                    {
                        id = Article_ID,
                        uid = Fenyexulie,
                        title = ds.Tables[0].Rows[i]["Article_Title"].ToString(),
                        complete_title = ds.Tables[0].Rows[i]["Article_Complete_Title"].ToString(),
                        img = ds.Tables[0].Rows[i]["Article_Cover_image"].ToString(),
                        shift_link_urla = Convert.ToBoolean(ds.Tables[0].Rows[i]["Article_Shift_link_URLA"]),
                        shift_link_url = ds.Tables[0].Rows[i]["Article_Shift_link_URL"].ToString(),
                        add_date = Convert.ToDateTime(ds.Tables[0].Rows[i]["Article_Add_date"]).ToString("yyyy-MM-dd HH:mm:ss"),
                        release_date = Convert.ToDateTime(ds.Tables[0].Rows[i]["Article_Release_date"]).ToString("yyyy-MM-dd HH:mm:ss"),
                        column_id = Convert.ToInt32(ds.Tables[0].Rows[i]["Column_ID"]).ToString(),
                        column_name = ds.Tables[0].Rows[i]["Column_Name"].ToString(),
                        guide = Guide,
                        click_rate = "0"//clickrate.GetRecordCount(Article_ID).ToString(),

                    });
                }
                return BPW.Response.GetModel(Model, PagingModel.Totalrecord);
                #endregion
            }
            else
            {
                if (wd != null)
                {
                    return BPW.Response.alert("搜索的内容不存在");
                }
                else
                {
                    //列表无数据显示
                    return BPW.Response.alert("暂无任何内容");
                }
            }
            #endregion

            #endregion
        }

        #region 【Sql判断添加and语句】
        /// <summary>
        /// 判断Variable.Sql有值了没有则增加 and 语句
        /// </summary>
        /// <param name="sql">需要插入的sql判断语句</param>
        /// <returns></returns>
        public string SqlAnd(string sql)
        {
            string tet = null;
            if (Variable.Sql != null)
            {
                tet = "and " + sql;
            }
            else
            {
                tet = sql + " ";
            }
            return tet;
        }
        #endregion
    }
}