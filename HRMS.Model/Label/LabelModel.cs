using System;

namespace HRMS.Model.Label
{
	/// <summary>
	/// Label
	/// </summary>
	[Serializable]
	public partial class LabelModel
	{
		public LabelModel()
		{ }

		#region 【基本方法】Model

		#region 【读取：表ID】
		private int _label_id;
		/// <summary>
		/// 表ID
		/// </summary>
		public int Label_ID
		{
			set { _label_id = value; }
			get { return _label_id; }
		}
		#endregion

		#region 【读取：更新内容时上方遮蔽层设置标签层宽】
		private string _label_layerwidth;
		/// <summary>
		/// 更新内容时上方遮蔽层设置标签层宽
		/// </summary>
		public string Label_LayerWidth
		{
			set { _label_layerwidth = value; }
			get { return _label_layerwidth; }
		}
		#endregion

		#region 【读取：更新内容时上方遮蔽层设置标签层高】
		private string _label_layerhigh;
		/// <summary>
		/// 更新内容时上方遮蔽层设置标签层高
		/// </summary>
		public string Label_LayerHigh
		{
			set { _label_layerhigh = value; }
			get { return _label_layerhigh; }
		}
		#endregion

		#region 【读取：文件地址或路径】
		private string _label_address;
		/// <summary>
		/// 文件地址或路径
		/// </summary>
		public string Label_Address
		{
			set { _label_address = value; }
			get { return _label_address; }
		}
		#endregion

		#region 【读取：超链接地址】
		private string _label_href;
		/// <summary>
		/// 超链接地址
		/// </summary>
		public string Label_Href
		{
			set { _label_href = value; }
			get { return _label_href; }
		}
		#endregion

		#region 【读取：超链接打开方式】
		private string _label_hreftarget;
		/// <summary>
		/// 超链接打开方式
		/// </summary>
		public string Label_Hreftarget
		{
			set { _label_hreftarget = value; }
			get { return _label_hreftarget; }
		}
		#endregion

		#region 【读取：宽】
		private string _label_width;
		/// <summary>
		/// 宽
		/// </summary>
		public string Label_Width
		{
			set { _label_width = value; }
			get { return _label_width; }
		}
		#endregion

		#region 【读取：高】
		private string _label_height;
		/// <summary>
		/// 高
		/// </summary>
		public string Label_Height
		{
			set { _label_height = value; }
			get { return _label_height; }
		}
		#endregion

		#region 【读取：描述】
		private string _label_description;
		/// <summary>
		/// 描述
		/// </summary>
		public string Label_Description
		{
			set { _label_description = value; }
			get { return _label_description; }
		}
		#endregion

		#region 【读取：风格父类】
		private string _label_stylefather;
		/// <summary>
		/// 风格父类
		/// </summary>
		public string Label_StyleFather
		{
			set { _label_stylefather = value; }
			get { return _label_stylefather; }
		}
		#endregion

		#region 【读取：风格子类】
		private string _label_stylesub;
		/// <summary>
		/// 风格子类
		/// </summary>
		public string Label_StyleSub
		{
			set { _label_stylesub = value; }
			get { return _label_stylesub; }
		}
		#endregion

		#region 【读取：标签类型】
		private int? _label_type = 0;
		/// <summary>
		/// 标签类型
		/// </summary>
		public int? Label_Type
		{
			set { _label_type = value; }
			get { return _label_type; }
		}
		#endregion

		#region 【读取：普通或分页显示】
		private bool _label_paging;
		/// <summary>
		/// 普通或分页显示
		/// </summary>
		public bool Label_Paging
		{
			set { _label_paging = value; }
			get { return _label_paging; }
		}
		#endregion

		#region 【读取：父栏目id已数组存储】
		private string _label_fatherid;
		/// <summary>
		/// 父栏目id已数组存储
		/// </summary>
		public string Label_FatherID
		{
			set { _label_fatherid = value; }
			get { return _label_fatherid; }
		}
		#endregion

		#region 【读取：子栏目id已数组存储】
		private string _label_subid;
		/// <summary>
		/// 子栏目id已数组存储
		/// </summary>
		public string Label_SubID
		{
			set { _label_subid = value; }
			get { return _label_subid; }
		}
		#endregion

		#region 【读取：显示类型全部还是已审核】
		private bool _label_displaytype;
		/// <summary>
		/// 显示类型全部还是已审核
		/// </summary>
		public bool Label_Displaytype
		{
			set { _label_displaytype = value; }
			get { return _label_displaytype; }
		}
		#endregion

		#region 【读取：内容排序筛选默认还是自定义】
		private bool _label_sorta;
		/// <summary>
		/// 内容排序筛选默认还是自定义
		/// </summary>
		public bool Label_SortA
		{
			set { _label_sorta = value; }
			get { return _label_sorta; }
		}
		#endregion

		#region 【读取：内容排序字段】
		private int? _label_sortb = 0;
		/// <summary>
		/// 内容排序字段
		/// </summary>
		public int? Label_SortB
		{
			set { _label_sortb = value; }
			get { return _label_sortb; }
		}
		#endregion

		#region 【读取：内容排序升降】
		private string _label_sortc;
		/// <summary>
		/// 内容排序升降
		/// </summary>
		public string Label_SortC
		{
			set { _label_sortc = value; }
			get { return _label_sortc; }
		}
		#endregion

		#region 【读取：内容排序自定义代码】
		private string _label_sortd;
		/// <summary>
		/// 内容排序自定义代码
		/// </summary>
		public string Label_SortD
		{
			set { _label_sortd = value; }
			get { return _label_sortd; }
		}
		#endregion

		#region 【读取：SQL选择启用否】
		private bool _label_sqlchoice;
		/// <summary>
		/// SQL选择启用否
		/// </summary>
		public bool Label_SqlChoice
		{
			set { _label_sqlchoice = value; }
			get { return _label_sqlchoice; }
		}
		#endregion

		#region 【读取：SQL语句代码】
		private string _label_sqlcode;
		/// <summary>
		/// SQL语句代码
		/// </summary>
		public string Label_SqlCode
		{
			set { _label_sqlcode = value; }
			get { return _label_sqlcode; }
		}
		#endregion

		#region 【读取：创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突】
		private decimal? _label_mark = 0;
		/// <summary>
		/// 创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突
		/// </summary>
		public decimal? Label_Mark
		{
			set { _label_mark = value; }
			get { return _label_mark; }
		}
		#endregion

		#region 【读取：内容只显示数组】
		private string _label_show;
		/// <summary>
		/// 内容只显示数组
		/// </summary>
		public string Label_Show
		{
			set { _label_show = value; }
			get { return _label_show; }
		}
		#endregion

		#region 【读取：内容不显示数组】
		private string _label_showno;
		/// <summary>
		/// 内容不显示数组
		/// </summary>
		public string Label_Showno
		{
			set { _label_showno = value; }
			get { return _label_showno; }
		}
		#endregion

		#region 【读取：内容循环几行】
		private string _label_line;
		/// <summary>
		/// 内容循环几行
		/// </summary>
		public string Label_Line
		{
			set { _label_line = value; }
			get { return _label_line; }
		}
		#endregion

		#region 【读取：内容循环几列】
		private string _label_column;
		/// <summary>
		/// 内容循环几列
		/// </summary>
		public string Label_Column
		{
			set { _label_column = value; }
			get { return _label_column; }
		}
		#endregion

		#region 【读取：内容标题长度】
		private string _label_titlelength;
		/// <summary>
		/// 内容标题长度
		/// </summary>
		public string Label_TitleLength
		{
			set { _label_titlelength = value; }
			get { return _label_titlelength; }
		}
		#endregion

		#region 【读取：内容标题是否启用省略号】
		private bool _label_titleellipsis;
		/// <summary>
		/// 内容标题是否启用省略号
		/// </summary>
		public bool Label_TitleEllipsis
		{
			set { _label_titleellipsis = value; }
			get { return _label_titleellipsis; }
		}
		#endregion

		#region 【读取：内容字节长度】
		private string _label_bytelength;
		/// <summary>
		/// 内容字节长度
		/// </summary>
		public string Label_Bytelength
		{
			set { _label_bytelength = value; }
			get { return _label_bytelength; }
		}
		#endregion

		#region 【读取：插入Class名称】
		private string _label_class;
		/// <summary>
		/// 插入Class名称
		/// </summary>
		public string Label_Class
		{
			set { _label_class = value; }
			get { return _label_class; }
		}
		#endregion

		#region 【读取：插入Class方式，固定位置，循环插入】
		private string _label_classway;
		/// <summary>
		/// 插入Class方式，固定位置，循环插入
		/// </summary>
		public string Label_Classway
		{
			set { _label_classway = value; }
			get { return _label_classway; }
		}
		#endregion

		#region 【读取：插入Class位置】
		private string _label_classpage;
		/// <summary>
		/// 插入Class位置
		/// </summary>
		public string Label_Classpage
		{
			set { _label_classpage = value; }
			get { return _label_classpage; }
		}
		#endregion

		#region 【读取：标签名称】
		private string _label_name;
		/// <summary>
		/// 标签名称
		/// </summary>
		public string Label_Name
		{
			set { _label_name = value; }
			get { return _label_name; }
		}
		#endregion

		#region 【读取：滚动：不滚动0默认 向左1 向右2 向上3】
		private int? _label_roll = 0;
		/// <summary>
		/// 滚动：不滚动0默认 向左1 向右2 向上3
		/// </summary>
		public int? Label_Roll
		{
			set { _label_roll = value; }
			get { return _label_roll; }
		}
		#endregion

		#region 【读取：滚动速度】
		private string _label_rolla;
		/// <summary>
		/// 滚动速度
		/// </summary>
		public string Label_RollA
		{
			set { _label_rolla = value; }
			get { return _label_rolla; }
		}
		#endregion

		#region 【读取：滚动框架高度】
		private string _label_rollb;
		/// <summary>
		/// 滚动框架高度
		/// </summary>
		public string Label_RollB
		{
			set { _label_rollb = value; }
			get { return _label_rollb; }
		}
		#endregion

		#region 【读取：滚动行高】
		private string _label_rollc;
		/// <summary>
		/// 滚动行高
		/// </summary>
		public string Label_RollC
		{
			set { _label_rollc = value; }
			get { return _label_rollc; }
		}
		#endregion

		#region 【读取：多久发布为最新】
		private string _label_newest;
		/// <summary>
		/// 多久发布为最新
		/// </summary>
		public string Label_Newest
		{
			set { _label_newest = value; }
			get { return _label_newest; }
		}
		#endregion

		#region 【读取：点击率多少为热门】
		private string _label_hot;
		/// <summary>
		/// 点击率多少为热门
		/// </summary>
		public string Label_Hot
		{
			set { _label_hot = value; }
			get { return _label_hot; }
		}
		#endregion

		#region 【读取：导航焦点名称】
		private string _label_navfocus;
		/// <summary>
		/// 导航焦点名称
		/// </summary>
		public string Label_navfocus
		{
			set { _label_navfocus = value; }
			get { return _label_navfocus; }
		}
		#endregion

		#region 【读取：列表页相关栏目无数据显示什么代码】
		private string _label_nodata;
		/// <summary>
		/// 列表页相关栏目无数据显示什么代码
		/// </summary>
		public string Label_NoData
		{
			set { _label_nodata = value; }
			get { return _label_nodata; }
		}
		#endregion

		#region 【读取：搜索内容跳转到相关页面无数据则显示什么代码】
		private string _label_nosearchdata;
		/// <summary>
		/// 搜索内容跳转到相关页面无数据则显示什么代码
		/// </summary>
		public string Label_NoSearchData
		{
			set { _label_nosearchdata = value; }
			get { return _label_nosearchdata; }
		}
		#endregion

		#region 【读取：文章显示，立即发布，true显示立即发布，False显示全部】
		private bool _label_inissue;
		/// <summary>
		/// 文章显示，立即发布，true显示立即发布，False显示全部
		/// </summary>
		public bool Label_inissue
		{
			set { _label_inissue = value; }
			get { return _label_inissue; }
		}
		#endregion

		#region 【读取：标签前台调用页网址】
		private string _label_callpage;
		/// <summary>
		/// 标签前台调用页网址
		/// </summary>
		public string Label_Callpage
		{
			set { _label_callpage = value; }
			get { return _label_callpage; }
		}
		#endregion

		#region 【读取：文章显示，签收，true显示签收的，False显示全部】
		private bool _label_signin;
		/// <summary>
		/// 文章显示，签收，true显示签收的，False显示全部
		/// </summary>
		public bool Label_signin
		{
			set { _label_signin = value; }
			get { return _label_signin; }
		}
		#endregion

		#region 【读取：存放风格模板ID】
		private int? _label_styleid = 0;
		/// <summary>
		/// 存放风格模板ID
		/// </summary>
		public int? Label_styleid
		{
			set { _label_styleid = value; }
			get { return _label_styleid; }
		}
		#endregion

		#region 【读取：标签模板页路径】
		private string _label_templatepage;
		/// <summary>
		/// 标签模板页路径
		/// </summary>
		public string Label_Templatepage
		{
			set { _label_templatepage = value; }
			get { return _label_templatepage; }
		}
		#endregion

		#region 【读取：样式代码外】
		private string _label_codeoutside;
		/// <summary>
		/// 样式代码外
		/// </summary>
		public string Label_CodeOutside
		{
			set { _label_codeoutside = value; }
			get { return _label_codeoutside; }
		}
		#endregion

		#region 【读取：样式代码内】
		private string _label_code;
		/// <summary>
		/// 样式代码内
		/// </summary>
		public string Label_Code
		{
			set { _label_code = value; }
			get { return _label_code; }
		}
		#endregion

		#region 【读取：标签内容是否隐藏,暂时不显示】
		private bool _label_hide;
		/// <summary>
		/// 标签内容是否隐藏,暂时不显示
		/// </summary>
		public bool Label_Hide
		{
			set { _label_hide = value; }
			get { return _label_hide; }
		}
		#endregion

		#endregion 【基本方法】Model
	}

	/// <summary>
	/// Label
	/// </summary>
	[Serializable]
	public partial class LabelModelA
	{
		public LabelModelA()
		{ }

		#region 【基本方法】Model

		#region 【读取：文件地址或路径】
		private string _label_address;
		/// <summary>
		/// 文件地址或路径
		/// </summary>
		public string src
		{
			set { _label_address = value; }
			get { return _label_address; }
		}
		#endregion

		#region 【读取：宽】
		private string _label_width;
		/// <summary>
		/// 宽
		/// </summary>
		public string width
		{
			set { _label_width = value; }
			get { return _label_width; }
		}
		#endregion

		#region 【读取：高】
		private string _label_height;
		/// <summary>
		/// 高
		/// </summary>
		public string height
		{
			set { _label_height = value; }
			get { return _label_height; }
		}
		#endregion

		#region 【读取：描述】
		private string _label_description;
		/// <summary>
		/// 描述
		/// </summary>
		public string description
		{
			set { _label_description = value; }
			get { return _label_description; }
		}
		#endregion

		#region 【读取：超链接地址】
		private string _label_href;
		/// <summary>
		/// 超链接地址
		/// </summary>
		public string href
		{
			set { _label_href = value; }
			get { return _label_href; }
		}
		#endregion

		#region 【读取：超链接打开方式】
		private string _label_hreftarget;
		/// <summary>
		/// 超链接打开方式
		/// </summary>
		public string target
		{
			set { _label_hreftarget = value; }
			get { return _label_hreftarget; }
		}
		#endregion

		#endregion 【基本方法】Model
	}

	public partial class LabelModelB
	{
		public LabelModelB()
		{ }

		#region 【基本方法】Model

		#region 【读取：文件地址或路径】
		private string _label_address;
		/// <summary>
		/// 文件地址或路径
		/// </summary>
		public string src
		{
			set { _label_address = value; }
			get { return _label_address; }
		}
		#endregion

		#region 【读取：宽】
		private string _label_width;
		/// <summary>
		/// 宽
		/// </summary>
		public string width
		{
			set { _label_width = value; }
			get { return _label_width; }
		}
		#endregion

		#region 【读取：高】
		private string _label_height;
		/// <summary>
		/// 高
		/// </summary>
		public string height
		{
			set { _label_height = value; }
			get { return _label_height; }
		}
		#endregion

		#endregion 【基本方法】Model
	}
}