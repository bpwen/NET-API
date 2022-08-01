using System;
using System.Data;
namespace HRMS.IDAL.Admin
{
	/// <summary>
	/// 接口层用户系统
	/// </summary>
	public interface IAdminDAL
	{
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int Admin_ID);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(HRMS.Model.Admin.AdminModel model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(HRMS.Model.Admin.AdminModel model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Admin_ID);
        bool DeleteList(string Admin_IDlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        HRMS.Model.Admin.AdminModel GetModel(int Admin_ID);
        HRMS.Model.Admin.AdminModel DataRowToModel(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法

        #region  【编辑】MethodEx
        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        bool ExistsUsername(string Admin_username);

        /// <summary>
        /// 用户登录
        /// </summary>
        HRMS.Model.Admin.AdminModel Login(string username, string passwoed);

        /// <summary>
        /// 检查用户是否在线用，会话查询查询到该用户其他信息
        /// </summary>
        /// <param name="SessionID">固定值必须：Session.SessionID</param>
        /// <returns></returns>
        bool Exists_Online(string SessionID);

        /// <summary>
        /// 用会话查询得到一个对象实体
        /// </summary>
        HRMS.Model.Admin.AdminModel GetModel_Online(string Admin_Online);



        #endregion  MethodEx
    } 
}
