using System;
using System.Data;
using System.Collections.Generic;
using HRMS.DALFactory;
using HRMS.IDAL.Article;

namespace HRMS.BLL.Article
{
    /// <summary>
    /// 文章系统
    /// </summary>
    public partial class ArticleBLL
	{
		private readonly IArticleDAL dal=DataAccess.CreateIArticleDAL();
		public ArticleBLL()
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
		public bool Exists(int Article_ID)
		{
			return dal.Exists(Article_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(HRMS.Model.Article.ArticleModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HRMS.Model.Article.ArticleModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Article_ID)
		{
			
			return dal.Delete(Article_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Article_IDlist )
		{
			return dal.DeleteList(HRMS.Common.PageValidate.SafeLongFilter(Article_IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HRMS.Model.Article.ArticleModel GetModel(int Article_ID)
		{
			
			return dal.GetModel(Article_ID);
		}
        public HRMS.Model.Article.ArticleModel GetModel(string strWhere)
        {
            return dal.GetModel(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public HRMS.Model.Article.ArticleModel GetModelByCache(int Article_ID)
		{
			string CacheKey = "ArticleModelModel-" + Article_ID;
			object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Article_ID);
					if (objModel != null)
					{
						int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
						HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (HRMS.Model.Article.ArticleModel)objModel;
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HRMS.Model.Article.ArticleModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HRMS.Model.Article.ArticleModel> DataTableToList(DataTable dt)
		{
			List<HRMS.Model.Article.ArticleModel> modelList = new List<HRMS.Model.Article.ArticleModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HRMS.Model.Article.ArticleModel model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        #region  ExtensionMethod

        #region 【查询系统类型】
        /// <summary>
        /// 查询系统类型 系统类型下有那些系统栏目
        /// </summary>
        /// <param name="storedProcName">存储过程名:System_Type_ColumnA</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <param name="aid">系统栏目Column_Aid</param>
        /// <param name="sql">0查看全部没筛选，1筛选管理系统ID[Type_ID]等于几的如1只输出 文章系统，2只输出图片系统</param>
        /// <returns></returns>
        public DataSet Bpwen_Column(string storedProcName, int id, int aid, int sql)
        {
            return dal.Bpwen_Column(storedProcName, id, aid, sql);
        }

        /// <summary>
        /// 查询系统类型 系统栏目 文章如：查询某个系统下当前栏目下它所有的发布内容文章
        /// </summary>
        /// <param name="storedProcName">存储过程名:System_type_Column_ArticleA</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <param name="sql">0查看全部没筛选，1筛选管理系统ID[Type_ID]等于几的如1只输出 文章系统，2只输出图片系统</param>
        /// <param name="Count">要返回的参数 sql 为2则需要</param>
        /// <param name="aid">系统栏目Column_Aid</param>
        /// <returns></returns>
        public DataSet Bpwen_Breadline(string storedProcName, int id, int sql, int Count, int aid)
        {
            return dal.Bpwen_Breadline(storedProcName, id, sql, Count, aid);
        }
        #endregion

        #region 【批量审核】
        /// <summary>
        /// 批量审核
        /// </summary>
        /// <param name="Article_IDlist">in (id)</param>
        /// <param name="AuditpersonID">审核人ID</param>
        /// <returns></returns>
        public bool Auditthrough(string Article_IDlist, int AuditpersonID)
        {
            return dal.Auditthrough(Article_IDlist, AuditpersonID);
        }
        #endregion

        #region 【往下查询所有子栏目】
        /// <summary>
        /// 往下查询所有子栏目
        /// </summary>
        /// <param name="name">存储过程名:System_Column_B</param>
        /// <param name="id">系统类型Type_ID</param>
        /// <returns></returns>
        public string bpw_AllSonColumn(string name, int id)
        {

            string CacheKey = "文章列表下所有子栏目ID缓存-编号ID：" + id;
            object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    DataSet ds = dal.bpw_AllSonColumn(name, id);
                    int Count = ds.Tables[0].Rows.Count;
                    string add_id = "";
                    if (Count != 0)
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            add_id += ds.Tables[0].Rows[i]["Column_ID"];
                            if (i != (Count - 1))
                            {
                                add_id += ",";
                            }
                        }
                    }
                    objModel = add_id;
                    if (objModel != null)
                    {
                        int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return objModel.ToString();
        }
        public DataSet bpw_AllSonColumnA(string name, int id)
        {
            DataSet ds = dal.bpw_AllSonColumn(name, id);
            return ds;
        }
        #endregion

        #region 【获取栏目下所有的文章】
        /// <summary>
        /// 获取栏目下所有的文章
        /// </summary>
        /// <param name="strWhere">栏目条件</param>
        /// <param name="sql">自定义一些条件如：and date=2017 ,and也可以是or</param>
        /// <param name="orderby">排序</param>
        /// <returns></returns>
        public DataSet Getlist(string strWhere, string sql, string orderby)
        {
            return dal.Getlist(strWhere, sql, orderby);
        }
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        /// <param name="id">栏目id，如果该栏目下有子栏目也会遍历对应子栏目的文章出来</param>
        /// <param name="sql">自定义一些条件如：and date=2017 ,and也可以是or</param>
        /// <returns></returns>
        public int GetRecordCount(int id, string sql)
        {
            return dal.GetRecordCount(id, sql);
        }
        #endregion

        #region 【分页获取数据列表】
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPagea(string strWhere, string strWhereb, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPagea(strWhere, strWhereb, orderby, startIndex, endIndex);
        }
        #endregion

        #region 【获取栏目下所有的文章记录总数】
        /// <summary>
        /// 获取栏目下所有的文章记录总数
        /// </summary>
        public int GetRecordCountA(string strWhere, string strWhereb)
        {
            return dal.GetRecordCountA(strWhere, strWhereb);
        }
        #endregion

        #region 【分页获取数据列表】
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPageb(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPageb(strWhere, orderby, startIndex, endIndex);
        }
        #endregion

        #region 【批量更新】
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

        #endregion  ExtensionMethod
    }
}

