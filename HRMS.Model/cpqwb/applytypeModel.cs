using System;

namespace HRMS.Model.cpweb
{
	/// <summary>
	/// cpweb_applytype
	/// </summary>
	[Serializable]
	public partial class applytypeModel
	{
		public applytypeModel()
		{}
		
		#region 【基本方法】Model
		
		#region 【读取：ID】
		private int _id;
		/// <summary>
		/// ID
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