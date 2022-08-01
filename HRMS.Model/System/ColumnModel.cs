using System;
namespace HRMS.Model.System
{
	/// <summary>
	/// 系统栏目：添加文章系统，它里面有什么栏目如，公司新闻，行业新闻，我们去发布文章就可以选择发布到公司新闻还是行业新闻里面去。
	/// </summary>
	[Serializable]
	public partial class ColumnModel
	{
		public ColumnModel()
		{}
		#region 【基本方法】Model

		#region 【读取：表ID】
		private int _column_id;
		/// <summary>
		/// 表ID
		/// </summary>
		public int Column_ID
		{
			set { _column_id = value; }
			get { return _column_id; }
		}
		#endregion

		#region 【读取：对应当前表ID】
		private int? _column_aid = 0;
		/// <summary>
		/// 对应当前表ID
		/// </summary>
		public int? Column_Aid
		{
			set { _column_aid = value; }
			get { return _column_aid; }
		}
		#endregion

		#region 【读取：栏目名称】
		private string _column_name;
		/// <summary>
		/// 栏目名称
		/// </summary>
		public string Column_Name
		{
			set { _column_name = value; }
			get { return _column_name; }
		}
		#endregion

		#region 【读取：排序】
		private int? _column_sort = 0;
		/// <summary>
		/// 排序
		/// </summary>
		public int? Column_Sort
		{
			set { _column_sort = value; }
			get { return _column_sort; }
		}
		#endregion

		#region 【读取：专题模板头部】
		private string _column_top_special;
		/// <summary>
		/// 专题模板头部
		/// </summary>
		public string Column_Top_Special
		{
			set { _column_top_special = value; }
			get { return _column_top_special; }
		}
		#endregion

		#region 【读取：专题模板主题】
		private string _column_body_special;
		/// <summary>
		/// 专题模板主题
		/// </summary>
		public string Column_Body_Special
		{
			set { _column_body_special = value; }
			get { return _column_body_special; }
		}
		#endregion

		#region 【读取：专题模板版权】
		private string _column_tail_special;
		/// <summary>
		/// 专题模板版权
		/// </summary>
		public string Column_Tail_Special
		{
			set { _column_tail_special = value; }
			get { return _column_tail_special; }
		}
		#endregion

		#region 【读取：列表模板头部】
		private string _column_top_list;
		/// <summary>
		/// 列表模板头部
		/// </summary>
		public string Column_Top_List
		{
			set { _column_top_list = value; }
			get { return _column_top_list; }
		}
		#endregion

		#region 【读取：列表模板主题】
		private string _column_body_list;
		/// <summary>
		/// 列表模板主题
		/// </summary>
		public string Column_Body_List
		{
			set { _column_body_list = value; }
			get { return _column_body_list; }
		}
		#endregion

		#region 【读取：列表模板版权】
		private string _column_tail_list;
		/// <summary>
		/// 列表模板版权
		/// </summary>
		public string Column_Tail_List
		{
			set { _column_tail_list = value; }
			get { return _column_tail_list; }
		}
		#endregion

		#region 【读取：详情模板头部】
		private string _column_top_details;
		/// <summary>
		/// 详情模板头部
		/// </summary>
		public string Column_Top_Details
		{
			set { _column_top_details = value; }
			get { return _column_top_details; }
		}
		#endregion

		#region 【读取：详情模板主题】
		private string _column_body_details;
		/// <summary>
		/// 详情模板主题
		/// </summary>
		public string Column_Body_Details
		{
			set { _column_body_details = value; }
			get { return _column_body_details; }
		}
		#endregion

		#region 【读取：详情模板版权】
		private string _column_tail_details;
		/// <summary>
		/// 详情模板版权
		/// </summary>
		public string Column_Tail_Details
		{
			set { _column_tail_details = value; }
			get { return _column_tail_details; }
		}
		#endregion

		#region 【读取：网页关键字Keyword】
		private string _column_keyword;
		/// <summary>
		/// 网页关键字Keyword
		/// </summary>
		public string Column_Keyword
		{
			set { _column_keyword = value; }
			get { return _column_keyword; }
		}
		#endregion

		#region 【读取：网页描述description】
		private string _column_description;
		/// <summary>
		/// 网页描述description
		/// </summary>
		public string Column_description
		{
			set { _column_description = value; }
			get { return _column_description; }
		}
		#endregion

		#region 【读取：对应系统:如是单页系统，新闻系统，图片系统，软件系统】
		private int? _column_systemid = 0;
		/// <summary>
		/// 对应系统:如是单页系统，新闻系统，图片系统，软件系统
		/// </summary>
		public int? Column_SystemID
		{
			set { _column_systemid = value; }
			get { return _column_systemid; }
		}
		#endregion

		#region 【读取：存储父栏目ID：好去读取它的相关模板页面路径和关键字及描述。】
		private int? _column_fatherid = 0;
		/// <summary>
		/// 存储父栏目ID：好去读取它的相关模板页面路径和关键字及描述。
		/// </summary>
		public int? Column_FatherID
		{
			set { _column_fatherid = value; }
			get { return _column_fatherid; }
		}
		#endregion

		#region 【读取：外部连接：存放外部链接地址】
		private string _column_externalurl;
		/// <summary>
		/// 外部连接：存放外部链接地址
		/// </summary>
		public string Column_ExternalUrl
		{
			set { _column_externalurl = value; }
			get { return _column_externalurl; }
		}
		#endregion

		#region 【读取：存储单页内容代码】
		private string _column_singlecontent;
		/// <summary>
		/// 存储单页内容代码
		/// </summary>
		public string Column_Singlecontent
		{
			set { _column_singlecontent = value; }
			get { return _column_singlecontent; }
		}
		#endregion

		#region 【读取：留言ID】
		private int? _column_messageid = 0;
		/// <summary>
		/// 留言ID
		/// </summary>
		public int? Column_MessageID
		{
			set { _column_messageid = value; }
			get { return _column_messageid; }
		}
		#endregion

		#region 【读取：允许会员发布内容否:bool类型叫 bit 取值 可以是 0或1  或者 true false】
		private bool _column_userrelease;
		/// <summary>
		/// 允许会员发布内容否:bool类型叫 bit 取值 可以是 0或1  或者 true false
		/// </summary>
		public bool Column_UserRelease
		{
			set { _column_userrelease = value; }
			get { return _column_userrelease; }
		}
		#endregion

		#region 【读取：继承栏目启用】
		private int? _column_jcnmqy = 0;
		/// <summary>
		/// 继承栏目启用
		/// </summary>
		public int? Column_Jcnmqy
		{
			set { _column_jcnmqy = value; }
			get { return _column_jcnmqy; }
		}
		#endregion

		#region 【读取：继承栏目ID】
		private int? _column_jcnmqyid = 0;
		/// <summary>
		/// 继承栏目ID
		/// </summary>
		public int? Column_JcnmqyID
		{
			set { _column_jcnmqyid = value; }
			get { return _column_jcnmqyid; }
		}
		#endregion

		#region 【读取：栏目次标题】
		private string _column_subtitle;
		/// <summary>
		/// 栏目次标题
		/// </summary>
		public string Column_Subtitle
		{
			set { _column_subtitle = value; }
			get { return _column_subtitle; }
		}
		#endregion

		#region 【读取：对应风格ID】
		private int? _column_styleid = 0;
		/// <summary>
		/// 对应风格ID
		/// </summary>
		public int? Column_styleid
		{
			set { _column_styleid = value; }
			get { return _column_styleid; }
		}
		#endregion

		#region 【读取：栏目英文名称】
		private string _column_englishname;
		/// <summary>
		/// 栏目英文名称
		/// </summary>
		public string Column_englishname
		{
			set { _column_englishname = value; }
			get { return _column_englishname; }
		}
		#endregion

		#region 【读取：存储是：系统1、会员2。可以添加其他如店铺模板等】
		private int? _column_type = 1;
		/// <summary>
		/// 存储是：系统1、会员2。可以添加其他如店铺模板等
		/// </summary>
		public int? Column_type
		{
			set { _column_type = value; }
			get { return _column_type; }
		}
		#endregion

		#region 【读取：栏目类型：如指定栏目是会员，那这记录是会员的登录页还是登录后的首页，或不指定。】
		private int? _column_type_name = 0;
		/// <summary>
		/// 栏目类型：如指定栏目是会员，那这记录是会员的登录页还是登录后的首页，或不指定。
		/// </summary>
		public int? Column_type_name
		{
			set { _column_type_name = value; }
			get { return _column_type_name; }
		}
		#endregion

		#region 【读取：存储选择是产品，则这里存储对应的产品的商品参数id表System_Column_type】
		private int? _column_spcs = 0;
		/// <summary>
		/// 存储选择是产品，则这里存储对应的产品的商品参数id表System_Column_type
		/// </summary>
		public int? Column_spcs
		{
			set { _column_spcs = value; }
			get { return _column_spcs; }
		}
		#endregion

		#region 【读取：产品套餐】
		private int? _column_setmeal = 0;
		/// <summary>
		/// 产品套餐
		/// </summary>
		public int? Column_setmeal
		{
			set { _column_setmeal = value; }
			get { return _column_setmeal; }
		}
		#endregion

		#region 【读取：栏目图标】
		private string _column_icon;
		/// <summary>
		/// 栏目图标
		/// </summary>
		public string Column_icon
		{
			set { _column_icon = value; }
			get { return _column_icon; }
		}
		#endregion

		#endregion 【基本方法】Model

	}
}

