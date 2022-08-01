using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS.IDAL.Article
{
	/// <summary>
	/// 接口层文章系统
	/// </summary>
	public interface IArticleDAL
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int Article_ID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(HRMS.Model.Article.ArticleModel model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(HRMS.Model.Article.ArticleModel model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int Article_ID);
		bool DeleteList(string Article_IDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		HRMS.Model.Article.ArticleModel GetModel(int Article_ID);
        HRMS.Model.Article.ArticleModel GetModel(string strWhere);
        HRMS.Model.Article.ArticleModel DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法

		#region  MethodEx
        /// <summary>
        /// 查询系统类型 系统类型下有那些系统栏目
        /// </summary>
        DataSet Bpwen_Column(string storedProcName, int id, int aid, int sql);
        /// <summary>
        /// 查询系统类型 系统栏目 文章如：查询某个系统下当前栏目下它所有的发布内容文章
        /// </summary>
        DataSet Bpwen_Breadline(string storedProcName, int id, int sql, int Count,int aid);
        /// <summary>
        /// 批量审核
        /// </summary>
        bool Auditthrough(string Article_IDlist, int AuditpersonID);

        /// <summary>
        /// 往下查询所有子栏目
        /// </summary>
        DataSet bpw_AllSonColumn(string name, int id);

        #region 【获取栏目下所有的文章】
        /// <summary>
        /// 获取栏目下所有的文章
        /// </summary>
        DataSet Getlist(string strWhere, string sql, string orderby);
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        int GetRecordCount(int id, string sql);
        #endregion

        #region 【分页获取数据列表】
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        DataSet GetListByPagea(string strWhere, string strWhereb, string orderby, int startIndex, int endIndex);
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        int GetRecordCountA(string strWhere, string strWhereb);
        #endregion

        #region 【分页获取数据列表】
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        DataSet GetListByPageb(string strWhere, string orderby, int startIndex, int endIndex);
        #endregion

        #region 【批量更新】
        bool Update(string set, string id);
        #endregion


        #endregion  MethodEx
    }
}
