using System;
using System.Data;
using System.Collections.Generic;
using HRMS.Common;
using HRMS.Model.Label;
using HRMS.DALFactory;
using HRMS.IDAL.Label;

namespace HRMS.BLL.Label
{
	/// <summary>
	/// 标签幻灯片
	/// </summary>
	public partial class SlidesBLL
	{
		private readonly ISlidesDAL dal = DataAccess.CreateISlidesDAL();

		public SlidesBLL()
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
		public bool Exists(int Slides_ID)
		{
			return dal.Exists(Slides_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(HRMS.Model.Label.SlidesModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HRMS.Model.Label.SlidesModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Slides_ID)
		{
			
			return dal.Delete(Slides_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Slides_IDlist )
		{
			return dal.DeleteList(HRMS.Common.PageValidate.SafeLongFilter(Slides_IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HRMS.Model.Label.SlidesModel GetModel(int Slides_ID)
		{
			
			return dal.GetModel(Slides_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public HRMS.Model.Label.SlidesModel GetModelByCache(int Slides_ID)
		{
			
			string CacheKey = "SlidesModelModel-" + Slides_ID;
			object objModel = HRMS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Slides_ID);
					if (objModel != null)
					{
						int ModelCache = HRMS.Common.ConfigHelper.GetConfigInt("ModelCache");
						HRMS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (HRMS.Model.Label.SlidesModel)objModel;
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
		public List<HRMS.Model.Label.SlidesModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HRMS.Model.Label.SlidesModel> DataTableToList(DataTable dt)
		{
			List<HRMS.Model.Label.SlidesModel> modelList = new List<HRMS.Model.Label.SlidesModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HRMS.Model.Label.SlidesModel model;
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
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsA(int Slides_Aid)
        {
            return dal.ExistsA(Slides_Aid);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteA(int Slides_Aid)
        {
            return dal.DeleteA(Slides_Aid);
        }

        /// <summary>
        /// 批量删除指定以外的数据
        /// </summary>
        public bool DeleteListA(string Slides_IDlist, int Slides_Aid)
        {
            return dal.DeleteListA(HRMS.Common.PageValidate.SafeLongFilter(Slides_IDlist, 0),Slides_Aid);
        }

		#endregion  ExtensionMethod
	}
}

