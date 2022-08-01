using System;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace HRMS.Public.Paging.Styleone
{
    /// <summary>
    /// 分页BLL
    /// </summary>
    public class Paging_BLL
    {
        #region 【加载分页Model】
        /// <summary>
        /// 全局变量：存储用户分页配置给分页【Paging_Model】
        /// </summary>
        PagingModel Model = new PagingModel();
        #endregion

        #region 【读取用户设置的分页配置】
        /// <summary>
        /// 读取用户设置的分页配置
        /// </summary>
        /// <param name="PageSize">1页输出多少条记录</param>
        /// <param name="PageIndex">默认那一页,第一页则输入0</param>
        /// <param name="Datasource">数据源</param>
        /// <param name="Fillbs">数据源中的行如sda.Fill(ds, "name"); 就是 name 动软生成的 填写ds</param>
        /// <returns></returns>
        public PagedDataSource Bpwen_Fenye(PagingModel Amodel)
        {
            if (Amodel.Page == null) { Amodel.Page = "page"; }
            if (Amodel.Displaypage < 5) { Amodel.Displaypage = 5; }
            if (Amodel.PageFixedposition < 3) { Amodel.PageFixedposition = 3; }
            if (Amodel.Fill == null) { Amodel.Fill = "ds"; }
            Model = Amodel;
            return Bpwen_DataSql();
        }
        #endregion

        #region 【读取分页数据源】
        /// <summary>
        /// 读取分页数据源
        /// </summary>
        /// <returns></returns>
        private PagedDataSource Bpwen_DataSql()
        {
            DataSet ds = Model.Datavalue;
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = ds.Tables[Model.Fill].DefaultView;
            pds.AllowPaging = true;//允许分页
            pds.PageSize = Model.PageSize;//单页显示项数
            int pagecount = pds.PageCount;//总页数
            Model.PageCount = pagecount;
            int page = 0;
            if (!Convert.ToBoolean(IsQueryStringNullOrEmpty(Model.Page)))
            {
                if (IsDigital(HttpContext.Current.Request.Form[Model.Page]))
                {
                    page = Convert.ToInt32(HttpContext.Current.Request.Form[Model.Page]);
                    if (page == 1) { page = 0; }
                    if (page > 1) { page = page - 1; }
                    if (page > pagecount - 1) { page = pagecount - 1; }
                }
            }

            pds.CurrentPageIndex = page;
            Model.CurrentPageIndex = page;
            return pds;
        }
        #endregion


        #region 【分页相关】
        /// <summary>
        /// //验证表单提交的page= 为空不 ,为空则True  有则Flash
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static bool IsQueryStringNullOrEmpty(string page)
        {
            return string.IsNullOrEmpty(HttpContext.Current.Request.Form[page]);
        }

        #region 【正则表达式】判断True还是False
        private static bool IsMatch(string str, string value)
        {
            Regex regex = new System.Text.RegularExpressions.Regex(value);
            return Regex.IsMatch(value, str);
        }
        #endregion

        #region 验证是否数字
        /// <summary>
        ///IsDigital 的摘要说明:验证是否数字
        /// </summary>
        public bool IsDigital(string itemValue)
        {
            return (IsMatch(@"^[0-9]*$", itemValue));
        }
        #endregion
        #endregion
    }
}