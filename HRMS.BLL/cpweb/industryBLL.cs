using System;
using System.Data;
using System.Collections.Generic;
using HRMS.DALFactory;
using HRMS.IDAL.cpweb;

namespace HRMS.BLL.cpweb
{
	/// <summary>
	/// cpweb_industry
	/// </summary>
	public partial class industryBLL
	{
        private readonly IindustryDAL dal = DataAccess.CreateindustryDAL();

        public industryBLL()
		{}
		
        #region 【基本方法】BasicMethod

        #region 【得到最大ID】
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }
        #endregion
        
        #region 【是否存在该记录】
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="key_id"></param>
        /// <returns>没有则返回false，有则返回true</returns>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }
        
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns>没有则返回false，有则返回true</returns>
        public bool Exists(string strWhere)
        {
            return dal.Exists(strWhere);
        }
        #endregion

        #region 【增加一条数据】
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(HRMS.Model.cpweb.industryModel model)
        {
            return dal.Add(model);
        }
        #endregion

        #region 【更新一条数据】
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HRMS.Model.cpweb.industryModel model)
        {
            return dal.Update(model);
        }
        #endregion

        #region 【删除一条数据】
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="strWhere">删除字段名称</param>
        /// <param name="type_id">数字ID</param>
        /// <returns></returns>
        public bool Delete(string strWhere, int id)
        {
            return dal.Delete(strWhere, id);
        }
        #endregion
        
        #region 【批量删除数据】
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(HRMS.Common.PageValidate.SafeLongFilter(idlist, 0));
        }
        #endregion

        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.cpweb.industryModel GetModel(int id)
        {
            return dal.GetModel(id);
        }
        
        public HRMS.Model.cpweb.industryModel GetModel(string strWhere)
        {
            return dal.GetModel(strWhere);
        }
        #endregion

        #region 【得到一个对象实体，从缓存中】
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public HRMS.Model.cpweb.industryModel GetModelByCache(int id)
        {
            string CacheKey = "cpweb_industryModel-" + id;
            object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(id);
                    if (objModel != null)
                    {
                        int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (HRMS.Model.cpweb.industryModel)objModel;
        }
        
        public HRMS.Model.cpweb.industryModel GetModelByCache(string strWhere)
        {
            string Array = "-,_,:,/,=,', ,.";
            string _strWhere = strWhere;
            string[] Division = Array.Split(',');
            for (int i = 0; i < Division.Length; i++)
            {
                _strWhere = _strWhere.Replace(Division[i], "");
            }
        
            string CacheKey = "cpweb_industryModel-" + _strWhere;
            object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(_strWhere);
                    if (objModel != null)
                    {
                        int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (HRMS.Model.cpweb.industryModel)objModel;
        }
        #endregion

        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        #endregion
        
        #region 【获得前几行数据】
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        #endregion
        
        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HRMS.Model.cpweb.industryModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        #endregion
        
        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HRMS.Model.cpweb.industryModel> DataTableToList(DataTable dt)
        {
            List<HRMS.Model.cpweb.industryModel> modelList = new List<HRMS.Model.cpweb.industryModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                HRMS.Model.cpweb.industryModel model;
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
        #endregion

        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

        #region 【获取记录总数】
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        #endregion
        
        #region 【分页获取数据列表】
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        #endregion
        
        #region 【批量更新】
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="set">跟新字段=？</param>
        /// <returns></returns>
        /// Post.Update("Bool=0 where AdminID=2");   对应所有AdminID=2的字段Bool=0
        public bool Update(string set)
        {
            return dal.Update(set);
        }
        
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="set">跟新字段=？</param>
        /// <param name="id">ID串</param>
        /// <returns></returns>
        public bool Update(string set, string id)
        {
            return dal.Update(set, id);
        }
        #endregion
        
        #endregion  【基本方法】BasicMethod
        
        #region  【编辑】ExtensionMethod
        
        #endregion  【编辑】ExtensionMethod
    }
}