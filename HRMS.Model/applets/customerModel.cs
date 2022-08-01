using System;

namespace HRMS.Model.applets
{
	/// <summary>
	/// applets_customer
	/// </summary>
	[Serializable]
	public partial class customerModel
	{
		public customerModel()
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
		private string _title;
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title = value;}
			get{return _title;}
		}
		#endregion

		#region 【读取：】
		private string _cover;
		/// <summary>
		/// 
		/// </summary>
		public string cover
		{
			set{ _cover = value;}
			get{return _cover;}
		}
		#endregion

		#region 【读取：】
		private string _microcode;
		/// <summary>
		/// 
		/// </summary>
		public string microcode
		{
			set{ _microcode = value;}
			get{return _microcode;}
		}
		#endregion

		#region 【读取：】
		private DateTime? _date = DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date
		{
			set{ _date = value;}
			get{return _date;}
		}
		#endregion

		#endregion 【基本方法】Model
	}
}