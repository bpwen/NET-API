using System;
using System.Data;

namespace HRMS.IDAL.Label
{
	/// <summary>
	/// 接口层标签幻灯片
	/// </summary>
	public interface ISlidesDAL
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int Slides_ID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(HRMS.Model.Label.SlidesModel model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(HRMS.Model.Label.SlidesModel model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int Slides_ID);
		bool DeleteList(string Slides_IDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		HRMS.Model.Label.SlidesModel GetModel(int Slides_ID);
		HRMS.Model.Label.SlidesModel DataRowToModel(DataRow row);
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
        /// 是否存在该记录
        /// </summary>
        bool ExistsA(int Slides_Aid);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool DeleteA(int Slides_Aid);
        /// <summary>
        /// 批量删除数据
        /// </summary>
        bool DeleteListA(string Slides_IDlist, int Slides_Aid);
		#endregion  MethodEx
	} 
}
