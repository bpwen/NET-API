using System;
using System.Data;
using System.Collections.Generic;
using HRMS.DALFactory;
using HRMS.IDAL.System;
namespace HRMS.BLL.System
{
	/// <summary>
	/// 系统栏目：添加文章系统
	/// </summary>
	public partial class ColumnBLL
	{
		private readonly IIColumnDAL dal=DataAccess.CreateIColumnDAL();
		public ColumnBLL()
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
        public bool Exists(int Column_ID)
        {
            return dal.Exists(Column_ID);
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
        public int Add(HRMS.Model.System.ColumnModel model)
        {
            return dal.Add(model);
        }
        #endregion

        #region 【更新一条数据】
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HRMS.Model.System.ColumnModel model)
        {
            return dal.Update(model);
        }
        #endregion

        #region 【删除一条数据】
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Column_ID)
        {

            return dal.Delete(Column_ID);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="strWhere">删除字段名称</param>
        /// <param name="type_id">数字ID</param>
        /// <returns></returns>
        public bool Delete(string strWhere, int Column_ID)
        {

            return dal.Delete(strWhere, Column_ID);
        }
        #endregion

        #region 【批量删除数据】
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Column_IDlist)
        {
            return dal.DeleteList(HRMS.Common.PageValidate.SafeLongFilter(Column_IDlist, 0));
        }
        #endregion

        #region 【得到一个对象实体】
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HRMS.Model.System.ColumnModel GetModel(int Column_ID)
        {

            return dal.GetModel(Column_ID);
        }

        public HRMS.Model.System.ColumnModel GetModel(string strWhere)
        {

            return dal.GetModel(strWhere);
        }
        #endregion

        #region 【得到一个对象实体，从缓存中】
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public HRMS.Model.System.ColumnModel GetModelByCache(int Column_ID)
        {
            string CacheKey = "System_ColumnModel-" + Column_ID;
            object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Column_ID);
                    if (objModel != null)
                    {
                        int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (HRMS.Model.System.ColumnModel)objModel;
        }

        public HRMS.Model.System.ColumnModel GetModelByCache(string strWhere)
        {
            string Array = "-,_,:,/,=,', ,.";
            string _strWhere = strWhere;
            string[] Division = Array.Split(',');
            for (int i = 0; i < Division.Length; i++)
            {
                _strWhere = _strWhere.Replace(Division[i], "");
            }

            string CacheKey = "System_ColumnModel-" + _strWhere;
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
            return (HRMS.Model.System.ColumnModel)objModel;
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
        public List<HRMS.Model.System.ColumnModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        #endregion

        #region 【获得数据列表】
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HRMS.Model.System.ColumnModel> DataTableToList(DataTable dt)
        {
            List<HRMS.Model.System.ColumnModel> modelList = new List<HRMS.Model.System.ColumnModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                HRMS.Model.System.ColumnModel model;
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

