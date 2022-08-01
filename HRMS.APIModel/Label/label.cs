using System;

/// <summary>
/// 表描述:Label
/// </summary>
namespace HRMS.APIModel.Label
{
    [Serializable]
    public partial class label
    {
        public label()
        { }

        #region 【Model】

        private int _id;        //表ID
        private string _layerwidth;        //更新内容时上方遮蔽层设置标签层宽
        private string _layerhigh;        //更新内容时上方遮蔽层设置标签层高
        private string _address;        //文件地址或路径
        private string _href;        //超链接地址
        private string _hreftarget;        //超链接打开方式
        private string _width;        //宽
        private string _height;        //高
        private string _description;        //描述
        private string _stylefather;        //风格父类
        private string _stylesub;        //风格子类
        private int _type;        //标签类型
        private bool _paging;        //普通或分页显示
        private string _fatherid;        //父栏目id已数组存储
        private string _subid;        //子栏目id已数组存储
        private bool _displaytype;        //显示类型全部还是已审核
        private bool _sorta;        //内容排序筛选默认还是自定义
        private int _sortb;        //内容排序字段
        private string _sortc;        //内容排序升降
        private string _sortd;        //内容排序自定义代码
        private bool _sqlchoice;        //SQL选择启用否
        private string _sqlcode;        //SQL语句代码
        private string _mark;        //创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突
        private string _show;        //内容只显示数组
        private string _showno;        //内容不显示数组
        private string _line;        //内容循环几行
        private string _column;        //内容循环几列
        private string _titlelength;        //内容标题长度
        private bool _titleellipsis;        //内容标题是否启用省略号
        private string _bytelength;        //内容字节长度
        private string _class;        //插入Class名称
        private string _classway;        //插入Class方式，固定位置，循环插入
        private string _classpage;        //插入Class位置
        private string _name;        //标签名称
        private int _roll;        //滚动：不滚动0默认 向左1 向右2 向上3
        private string _rolla;        //滚动速度
        private string _rollb;        //滚动框架高度
        private string _rollc;        //滚动行高
        private string _newest;        //多久发布为最新
        private string _hot;        //点击率多少为热门
        private string _navfocus;        //导航焦点名称
        private string _nodata;        //列表页相关栏目无数据显示什么代码
        private string _nosearchdata;        //搜索内容跳转到相关页面无数据则显示什么代码
        private bool _inissue;        //文章显示，立即发布，true显示立即发布，False显示全部
        private string _callpage;        //标签前台调用页网址
        private bool _signin;        //文章显示，签收，true显示签收的，False显示全部
        private int _styleid;        //存放风格模板ID
        private string _templatepage;        //标签模板页路径
        private string _codeoutside;        //样式代码外
        private string _code;        //样式代码内
        private bool _hide;        //标签内容是否隐藏,暂时不显示

        #region 【表ID】
        /// <summary>
        ///表ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion

        #region 【更新内容时上方遮蔽层设置标签层宽】
        /// <summary>
        ///更新内容时上方遮蔽层设置标签层宽
        /// </summary>
        public string LayerWidth
        {
            set { _layerwidth = value; }
            get { return _layerwidth; }
        }
        #endregion

        #region 【更新内容时上方遮蔽层设置标签层高】
        /// <summary>
        ///更新内容时上方遮蔽层设置标签层高
        /// </summary>
        public string LayerHigh
        {
            set { _layerhigh = value; }
            get { return _layerhigh; }
        }
        #endregion

        #region 【文件地址或路径】
        /// <summary>
        ///文件地址或路径
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        #endregion

        #region 【超链接地址】
        /// <summary>
        ///超链接地址
        /// </summary>
        public string Href
        {
            set { _href = value; }
            get { return _href; }
        }
        #endregion

        #region 【超链接打开方式】
        /// <summary>
        ///超链接打开方式
        /// </summary>
        public string Hreftarget
        {
            set { _hreftarget = value; }
            get { return _hreftarget; }
        }
        #endregion

        #region 【宽】
        /// <summary>
        ///宽
        /// </summary>
        public string Width
        {
            set { _width = value; }
            get { return _width; }
        }
        #endregion

        #region 【高】
        /// <summary>
        ///高
        /// </summary>
        public string Height
        {
            set { _height = value; }
            get { return _height; }
        }
        #endregion

        #region 【描述】
        /// <summary>
        ///描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        #endregion

        #region 【风格父类】
        /// <summary>
        ///风格父类
        /// </summary>
        public string StyleFather
        {
            set { _stylefather = value; }
            get { return _stylefather; }
        }
        #endregion

        #region 【风格子类】
        /// <summary>
        ///风格子类
        /// </summary>
        public string StyleSub
        {
            set { _stylesub = value; }
            get { return _stylesub; }
        }
        #endregion

        #region 【标签类型】
        /// <summary>
        ///标签类型
        /// </summary>
        public int Type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion

        #region 【普通或分页显示】
        /// <summary>
        ///普通或分页显示
        /// </summary>
        public bool Paging
        {
            set { _paging = value; }
            get { return _paging; }
        }
        #endregion

        #region 【父栏目id已数组存储】
        /// <summary>
        ///父栏目id已数组存储
        /// </summary>
        public string FatherID
        {
            set { _fatherid = value; }
            get { return _fatherid; }
        }
        #endregion

        #region 【子栏目id已数组存储】
        /// <summary>
        ///子栏目id已数组存储
        /// </summary>
        public string SubID
        {
            set { _subid = value; }
            get { return _subid; }
        }
        #endregion

        #region 【显示类型全部还是已审核】
        /// <summary>
        ///显示类型全部还是已审核
        /// </summary>
        public bool Displaytype
        {
            set { _displaytype = value; }
            get { return _displaytype; }
        }
        #endregion

        #region 【内容排序筛选默认还是自定义】
        /// <summary>
        ///内容排序筛选默认还是自定义
        /// </summary>
        public bool SortA
        {
            set { _sorta = value; }
            get { return _sorta; }
        }
        #endregion

        #region 【内容排序字段】
        /// <summary>
        ///内容排序字段
        /// </summary>
        public int SortB
        {
            set { _sortb = value; }
            get { return _sortb; }
        }
        #endregion

        #region 【内容排序升降】
        /// <summary>
        ///内容排序升降
        /// </summary>
        public string SortC
        {
            set { _sortc = value; }
            get { return _sortc; }
        }
        #endregion

        #region 【内容排序自定义代码】
        /// <summary>
        ///内容排序自定义代码
        /// </summary>
        public string SortD
        {
            set { _sortd = value; }
            get { return _sortd; }
        }
        #endregion

        #region 【SQL选择启用否】
        /// <summary>
        ///SQL选择启用否
        /// </summary>
        public bool SqlChoice
        {
            set { _sqlchoice = value; }
            get { return _sqlchoice; }
        }
        #endregion

        #region 【SQL语句代码】
        /// <summary>
        ///SQL语句代码
        /// </summary>
        public string SqlCode
        {
            set { _sqlcode = value; }
            get { return _sqlcode; }
        }
        #endregion

        #region 【创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突】
        /// <summary>
        ///创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突
        /// </summary>
        public string Mark
        {
            set { _mark = value; }
            get { return _mark; }
        }
        #endregion

        #region 【内容只显示数组】
        /// <summary>
        ///内容只显示数组
        /// </summary>
        public string Show
        {
            set { _show = value; }
            get { return _show; }
        }
        #endregion

        #region 【内容不显示数组】
        /// <summary>
        ///内容不显示数组
        /// </summary>
        public string Showno
        {
            set { _showno = value; }
            get { return _showno; }
        }
        #endregion

        #region 【内容循环几行】
        /// <summary>
        ///内容循环几行
        /// </summary>
        public string Line
        {
            set { _line = value; }
            get { return _line; }
        }
        #endregion

        #region 【内容循环几列】
        /// <summary>
        ///内容循环几列
        /// </summary>
        public string Column
        {
            set { _column = value; }
            get { return _column; }
        }
        #endregion

        #region 【内容标题长度】
        /// <summary>
        ///内容标题长度
        /// </summary>
        public string TitleLength
        {
            set { _titlelength = value; }
            get { return _titlelength; }
        }
        #endregion

        #region 【内容标题是否启用省略号】
        /// <summary>
        ///内容标题是否启用省略号
        /// </summary>
        public bool TitleEllipsis
        {
            set { _titleellipsis = value; }
            get { return _titleellipsis; }
        }
        #endregion

        #region 【内容字节长度】
        /// <summary>
        ///内容字节长度
        /// </summary>
        public string Bytelength
        {
            set { _bytelength = value; }
            get { return _bytelength; }
        }
        #endregion

        #region 【插入Class名称】
        /// <summary>
        ///插入Class名称
        /// </summary>
        public string Class
        {
            set { _class = value; }
            get { return _class; }
        }
        #endregion

        #region 【插入Class方式，固定位置，循环插入】
        /// <summary>
        ///插入Class方式，固定位置，循环插入
        /// </summary>
        public string Classway
        {
            set { _classway = value; }
            get { return _classway; }
        }
        #endregion

        #region 【插入Class位置】
        /// <summary>
        ///插入Class位置
        /// </summary>
        public string Classpage
        {
            set { _classpage = value; }
            get { return _classpage; }
        }
        #endregion

        #region 【标签名称】
        /// <summary>
        ///标签名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        #endregion

        #region 【滚动：不滚动0默认 向左1 向右2 向上3】
        /// <summary>
        ///滚动：不滚动0默认 向左1 向右2 向上3
        /// </summary>
        public int Roll
        {
            set { _roll = value; }
            get { return _roll; }
        }
        #endregion

        #region 【滚动速度】
        /// <summary>
        ///滚动速度
        /// </summary>
        public string RollA
        {
            set { _rolla = value; }
            get { return _rolla; }
        }
        #endregion

        #region 【滚动框架高度】
        /// <summary>
        ///滚动框架高度
        /// </summary>
        public string RollB
        {
            set { _rollb = value; }
            get { return _rollb; }
        }
        #endregion

        #region 【滚动行高】
        /// <summary>
        ///滚动行高
        /// </summary>
        public string RollC
        {
            set { _rollc = value; }
            get { return _rollc; }
        }
        #endregion

        #region 【多久发布为最新】
        /// <summary>
        ///多久发布为最新
        /// </summary>
        public string Newest
        {
            set { _newest = value; }
            get { return _newest; }
        }
        #endregion

        #region 【点击率多少为热门】
        /// <summary>
        ///点击率多少为热门
        /// </summary>
        public string Hot
        {
            set { _hot = value; }
            get { return _hot; }
        }
        #endregion

        #region 【导航焦点名称】
        /// <summary>
        ///导航焦点名称
        /// </summary>
        public string navfocus
        {
            set { _navfocus = value; }
            get { return _navfocus; }
        }
        #endregion

        #region 【列表页相关栏目无数据显示什么代码】
        /// <summary>
        ///列表页相关栏目无数据显示什么代码
        /// </summary>
        public string NoData
        {
            set { _nodata = value; }
            get { return _nodata; }
        }
        #endregion

        #region 【搜索内容跳转到相关页面无数据则显示什么代码】
        /// <summary>
        ///搜索内容跳转到相关页面无数据则显示什么代码
        /// </summary>
        public string NoSearchData
        {
            set { _nosearchdata = value; }
            get { return _nosearchdata; }
        }
        #endregion

        #region 【文章显示，立即发布，true显示立即发布，False显示全部】
        /// <summary>
        ///文章显示，立即发布，true显示立即发布，False显示全部
        /// </summary>
        public bool inissue
        {
            set { _inissue = value; }
            get { return _inissue; }
        }
        #endregion

        #region 【标签前台调用页网址】
        /// <summary>
        ///标签前台调用页网址
        /// </summary>
        public string Callpage
        {
            set { _callpage = value; }
            get { return _callpage; }
        }
        #endregion

        #region 【文章显示，签收，true显示签收的，False显示全部】
        /// <summary>
        ///文章显示，签收，true显示签收的，False显示全部
        /// </summary>
        public bool signin
        {
            set { _signin = value; }
            get { return _signin; }
        }
        #endregion

        #region 【存放风格模板ID】
        /// <summary>
        ///存放风格模板ID
        /// </summary>
        public int styleid
        {
            set { _styleid = value; }
            get { return _styleid; }
        }
        #endregion

        #region 【标签模板页路径】
        /// <summary>
        ///标签模板页路径
        /// </summary>
        public string Templatepage
        {
            set { _templatepage = value; }
            get { return _templatepage; }
        }
        #endregion

        #region 【样式代码外】
        /// <summary>
        ///样式代码外
        /// </summary>
        public string CodeOutside
        {
            set { _codeoutside = value; }
            get { return _codeoutside; }
        }
        #endregion

        #region 【样式代码内】
        /// <summary>
        ///样式代码内
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        #endregion

        #region 【标签内容是否隐藏,暂时不显示】
        /// <summary>
        ///标签内容是否隐藏,暂时不显示
        /// </summary>
        public bool Hide
        {
            set { _hide = value; }
            get { return _hide; }
        }
        #endregion

        #endregion 【Model】
    }
}