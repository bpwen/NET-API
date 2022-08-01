using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HRMS.BPW;
using HRMS.BLL.System;
using HRMS.Model.System;

namespace HRMS.API.System
{
    /// <summary>
    /// 表描述:系统栏目：添加文章系统，它里面有什么栏目如，公司新闻，行业新闻，我们去发布文章就可以选择发布到公司新闻还是行业新闻里面去。
    /// </summary>
    public class ColumnAPI
    {
        ColumnBLL Post = new ColumnBLL();
        ColumnModel M_Model = new ColumnModel();

        #region  数据接口

        #region  得到一个对象实体
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetModel(int id)
        {
            #region 【获取指定数据是否存在】
            M_Model = Post.GetModel(id);
            if (M_Model == null)
            {
                return Response.error("对不起,数据不存在或已被删除。");
            }
            #endregion

            #region 【加载数据】
            List<HRMS.APIModel.system.column> Model = new List<HRMS.APIModel.system.column>();
            Model.Add(new HRMS.APIModel.system.column()
            {
                ID = Convert.ToInt32(M_Model.Column_ID),   //表ID
                Name = M_Model.Column_Name,   //栏目名称
                icon = M_Model.Column_icon,   //栏目图标

            });
            #endregion

            return Response.GetModel(Model);
        }
        #endregion  得到一个对象实体

        #region 加载全部列表
        /// <summary>
        /// 获取全部列表
        /// </summary>
        /// <returns></returns>
        public string List(string strWhere)
        {
            #region 【获取数据源】
            DataSet ds = Post.GetList(strWhere);
            int Count = ds.Tables[0].Rows.Count;//当前数据总数

            if (Count == 0)
            {
                return Response.alert("没有查询到符合条件的信息!");
            }

            #region 【加载数据】
            List<HRMS.APIModel.system.column> Model = new List<HRMS.APIModel.system.column>();
            for (int i = 0; i < Count; i++)
            {
                Model.Add(new HRMS.APIModel.system.column()
                {
                    ID = Convert.ToInt32(ds.Tables[0].Rows[i]["Column_ID"]),   //表ID
                    Name = ds.Tables[0].Rows[i]["Column_Name"].ToString(),   //栏目名称
                    icon = ds.Tables[0].Rows[i]["Column_icon"].ToString(),   //栏目图标
                    ExternalUrl = ds.Tables[0].Rows[i]["Column_ExternalUrl"].ToString()   //外部连接
                });
            }
            #endregion
            return Response.GetModel(Model);
            #endregion
        }
        #endregion  加载全部列表

        #region  加载分页列表
        /// <summary>
        /// 加载分页列表
        /// </summary>
        /// <returns></returns>
        public string GetList()
        {
            paging.parameter Properties = new paging.parameter();

            #region 【读取 pagesize 一页显示多少条】
            int pagesize = Request.Form("pagesize", 0);
            if (pagesize == -1)
            {
                pagesize = 10;
            }
            #endregion

            #region 【读取page】
            int begin_count = 1;//开始
            int end_count = pagesize;//结束
            int page = Request.Form("page", 0);
            if (page == -1)
            {
                page = 1;
            }
            else
            {
                if (page == 0)
                {
                    page = 1;
                }
                if (page > 1 || page < 2)
                {
                    begin_count = (end_count * (page - 1)) + 1;
                    end_count = (end_count * (page - 1)) + end_count;
                }
                else
                {
                    begin_count = (end_count * page) + 1;
                    end_count = (end_count * page) + end_count;
                }
            }
            #endregion

            #region 【指定SQL语句获取条件】
            string list_sql = "";

            #region 【搜索用户名】
            //string user_nema = Request.Form("user_name");
            //if (user_nema != null)
            //{
            //    if (!Regex.IsMatch(user_nema, @"\s+"))
            //    {
            //        int usertype = Request.Form("user_type", 0);
            //        if (usertype == 0)
            //        {
            //            list_sql += "Admin_username like '%" + user_nema + "%'";
            //        }
            //        else
            //        {
            //            list_sql += "Admin_username='" + user_nema + "'";
            //        }
            //    }
            //    else
            //    {
            //        return Response.error("查询用户名格式错误，不能带有空格。");
            //    }
            //}
            #endregion

            #region 【搜索用户组】
            //int user_level = Request.Form("user_level",0);
            //if(user_level != -1)
            //{
            //    if(list_sql != "")
            //    {
            //        list_sql += " and ";
            //    }
            //    list_sql += "Admin_User_group=" + user_level;
            //}
            #endregion

            #region 【排序】
            //string sort = Request.Form("sort");
            string orderby = "";
            //if (sort != null)
            //{
            //    switch (sort)
            //    {
            //        case "hitsg_0":
            //            orderby = "style_sort desc";
            //            break;
            //        case "hitsg_1":
            //            orderby = "style_sort asc";
            //            break;
            //        case "date_0":
            //            orderby = "style_date desc";
            //            break;
            //        case "date_1":
            //            orderby = "style_date asc";
            //            break;
            //    }
            //}
            #endregion

            #endregion

            #region 【分页判断】
            Properties.recordcount = Post.GetRecordCount(list_sql);
            if (Properties.recordcount == 0)
            {
                Properties.pagecount = 0;
            }
            else
            {
                if (Properties.recordcount > pagesize)
                {
                    #region 【判断分页总页数】
                    decimal result = Math.Round((decimal)Properties.recordcount / pagesize, 2);
                    int PageCount;
                    if (Regex.IsMatch(result.ToString(), @"\d*\.\d*"))//判断有小数不
                    {
                        PageCount = (int)result + 1;//取整后加一页，因为有小数
                    }
                    else
                    {
                        PageCount = Convert.ToInt32(result);
                    }
                    Properties.pagecount = PageCount;
                    #endregion
                }
                else
                {
                    Properties.pagecount = 1;
                }
            }
            #endregion

            #region 【列表参数】
            Properties.page = page;
            Properties.pagesize = pagesize;
            Properties.begin_count = begin_count;
            Properties.end_count = end_count;
            #endregion

            #region 【获取数据源】
            DataSet ds = Post.GetListByPage(list_sql, orderby, begin_count, end_count);
            int Count = ds.Tables[0].Rows.Count;//当前数据总数

            if (Count == 0)
            {
                return Response.alert("没有查询到符合条件的信息!");
            }

            #region 【加载数据】
            List<HRMS.APIModel.system.column> Model = new List<HRMS.APIModel.system.column>();
            //string snap_name = null;    //临时存储用户名
            for (int i = 0; i < Count; i++)
            {
                #region 【用户名】
                //if (!string.IsNullOrEmpty(user_nema))
                //{
                //    snap_name = ds.Tables[0].Rows[i]["Admin_username"].ToString().Replace(user_nema, "<font color=\"#FF0000\"><b>" + user_nema + "</b></font>");
                //}
                //else
                //{
                //    snap_name = ds.Tables[0].Rows[i]["Admin_username"].ToString();
                //}
                #endregion

                Model.Add(new HRMS.APIModel.system.column()
                {
                    ID = Convert.ToInt32(ds.Tables[0].Rows[i]["Column_ID"]),   //表ID
                    Name = ds.Tables[0].Rows[i]["Column_Name"].ToString(),   //栏目名称
                    icon = ds.Tables[0].Rows[i]["Column_icon"].ToString()   //栏目图标
                });
            }
            #endregion

            return Response.GetModel(Model, Properties);
            #endregion
        }
        #endregion  加载分页列表

        #endregion  数据接口
    }
}