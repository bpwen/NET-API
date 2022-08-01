using System;

namespace HRMS.Model.applets
{
	/// <summary>
	/// applets_type
	/// </summary>
	[Serializable]
	public partial class typeModel
	{
		public typeModel()
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

		#region 【读取：名称】
		private string _name;
		/// <summary>
		/// 名称
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