using System;
using System.Data;
using System.Collections.Generic;
using HRMS.Common;
using HRMS.Model.Admin;
using HRMS.DALFactory;
using HRMS.IDAL.Admin;

namespace HRMS.BLL.Admin
{
	/// <summary>
	/// 用户系统
	/// </summary>
	public partial class AdminBLL
	{
        private readonly IAdminDAL dal = DataAccess.CreateAdminDAL();

        public AdminBLL()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Admin_ID)
        {
            return dal.Exists(Admin_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(HRMS.Model.Admin.AdminModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HRMS.Model.Admin.AdminModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Admin_ID)
        {

            return dal.Delete(Admin_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Admin_IDlist)
        {
            return dal.DeleteList(HRMS.Common.PageValidate.SafeLongFilter(Admin_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.Admin.AdminModel GetModel(int Admin_ID)
        {

            return dal.GetModel(Admin_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public HRMS.Model.Admin.AdminModel GetModelByCache(int Admin_ID)
        {

            string CacheKey = "AdminModelModel-" + Admin_ID;
            object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Admin_ID);
                    if (objModel != null)
                    {
                        int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (HRMS.Model.Admin.AdminModel)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HRMS.Model.Admin.AdminModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HRMS.Model.Admin.AdminModel> DataTableToList(DataTable dt)
        {
            List<HRMS.Model.Admin.AdminModel> modelList = new List<HRMS.Model.Admin.AdminModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                HRMS.Model.Admin.AdminModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        #region  【编辑】ExtensionMethod

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        public bool ExistsUsername(string Admin_username)
        {
            return dal.ExistsUsername(Admin_username);
        }

        /// <summary>
        /// 检查用户是否在线用，会话查询查询到该用户其他信息
        /// </summary>
        /// <param name="SessionID">固定值必须：Session.SessionID</param>
        /// <returns></returns>
        public bool Exists_Online(string SessionID)
        {
            return dal.Exists_Online(SessionID);
        }

        /// <summary>
        /// 用会话查询得到一个对象实体
        /// </summary>
        public HRMS.Model.Admin.AdminModel GetModel_Online(string Admin_Online)
        {
            return dal.GetModel_Online(Admin_Online);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username">帐号</param>
        /// <param name="passwoed">密码</param>
        /// <returns></returns>
        public HRMS.Model.Admin.AdminModel Login(string username,string passwoed)
        {
            return dal.Login(username, BPW.MD5.Encrypt(passwoed));
        }
        #endregion  ExtensionMethod
    }
}

