using System;

namespace HRMS.Model.cpweb
{
	/// <summary>
	/// cpweb_industry
	/// </summary>
	[Serializable]
	public partial class industryModel
	{
		public industryModel()
		{}
		
		#region 【基本方法】Model
		
		#region 【读取：】
		private int _id;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id = value;}
			get{return _id;}
		}
		#endregion

		#region 【读取：】
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name = value;}
			get{return _name;}
		}
		#endregion

		#endregion 【基本方法】Model
	}
}