using System.Data;

namespace HRMS.IDAL.applets
{
	/// <summary>
	/// applets_industry
	/// </summary>
	public interface IindustryDAL
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
        bool Exists(int id);
        bool Exists(string strWhere);
        #endregion
        
        #region 【增加一条数据】
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(HRMS.Model.applets.industryModel model);
        #endregion
        
        #region 【更新一条数据】
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(HRMS.Model.applets.industryModel model);
        #endregion
        
        #region 【删除一条数据】
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int id);
        bool Delete(string strWhere, int id);
        bool DeleteList(string idlist);
        #endregion
        
        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        HRMS.Model.applets.industryModel GetModel(int id);
        HRMS.Model.applets.industryModel GetModel(string strWhere);
        HRMS.Model.applets.industryModel DataRowToModel(DataRow row);
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