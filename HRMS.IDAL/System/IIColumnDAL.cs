
using System;
using System.Data;
namespace HRMS.IDAL.System
{
    /// <summary>
    /// 系统栏目：添加文章系统，它里面有什么栏目如，公司新闻，行业新闻，我们去发布文章就可以选择发布到公司新闻还是行业新闻里面去。
    /// </summary>
    public interface IIColumnDAL
	{
        #region  【基本方法】BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        #endregion

        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int Column_ID);
        bool Exists(string strWhere);
        #endregion

        #region 【增加一条数据】
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(HRMS.Model.System.ColumnModel model);
        #endregion

        #region 【更新一条数据】
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(HRMS.Model.System.ColumnModel model);
        #endregion

        #region 【删除一条数据】
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Column_ID);
        bool Delete(string strWhere, int Column_ID);
        bool DeleteList(string Column_IDlist);
        #endregion

        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        HRMS.Model.System.ColumnModel GetModel(int Column_ID);
        HRMS.Model.System.ColumnModel GetModel(string strWhere);
        HRMS.Model.System.ColumnModel DataRowToModel(DataRow row);
        #endregion

        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        #endregion

        #region 【获得前几行数据】
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        #endregion

        #region 【批量更新】
        bool Update(string set);
        bool Update(string set, string id);
        #endregion

        #endregion  【基本方法】BasicMethod

        #region  【编辑】ExtensionMethod

        #endregion  ExtensionMethod
    }
}
