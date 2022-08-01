using System;

namespace HRMS.Model.Article
{
    /// <summary>
    /// 文章系统
    /// </summary>
    [Serializable]
    public partial class ArticleModel
    {
        public ArticleModel()
        { }
        #region Model

        #region 【读取：文章系统 文章ID】
        private int _article_id;
        /// <summary>
        /// 文章系统 文章ID
        /// </summary>
        public int Article_ID
        {
            set { _article_id = value; }
            get { return _article_id; }
        }
        #endregion

        #region 【读取：转向链接启用】
        private bool _article_shift_link_urla;
        /// <summary>
        /// 转向链接启用
        /// </summary>
        public bool Article_Shift_link_URLA
        {
            set { _article_shift_link_urla = value; }
            get { return _article_shift_link_urla; }
        }
        #endregion

        #region 【读取：文章作者:后面给个选择如：【未知】【佚名】【登录帐号或帐号下填写的姓名】【请空】】
        private string _article_author;
        /// <summary>
        /// 文章作者:后面给个选择如：【未知】【佚名】【登录帐号或帐号下填写的姓名】【请空】
        /// </summary>
        public string Article_Author
        {
            set { _article_author = value; }
            get { return _article_author; }
        }
        #endregion

        #region 【读取：文章来源:【不详】【本站原创】【互联网】【请空】
        private string _article_article_source;
        /// <summary>
        /// 文章来源:【不详】【本站原创】【互联网】【请空
        /// </summary>
        public string Article_Article_source
        {
            set { _article_article_source = value; }
            get { return _article_article_source; }
        }
        #endregion

        #region 【读取：文章来源URL】
        private string _article_article_source_url;
        /// <summary>
        /// 文章来源URL
        /// </summary>
        public string Article_Article_source_URL
        {
            set { _article_article_source_url = value; }
            get { return _article_article_source_url; }
        }
        #endregion

        #region 【读取：文章关键字】
        private string _article_keyword;
        /// <summary>
        /// 文章关键字
        /// </summary>
        public string Article_Keyword
        {
            set { _article_keyword = value; }
            get { return _article_keyword; }
        }
        #endregion

        #region 【读取：文章导读】
        private string _article_guide;
        /// <summary>
        /// 文章导读
        /// </summary>
        public string Article_Guide
        {
            set { _article_guide = value; }
            get { return _article_guide; }
        }
        #endregion

        #region 【读取：导读截取】
        private bool _article_guidea;
        /// <summary>
        /// 导读截取
        /// </summary>
        public bool Article_GuideA
        {
            set { _article_guidea = value; }
            get { return _article_guidea; }
        }
        #endregion

        #region 【读取：附件上传:选择本地附件上传，插入已存在的附件提供给浏览者下载】
        private string _article_annex;
        /// <summary>
        /// 附件上传:选择本地附件上传，插入已存在的附件提供给浏览者下载
        /// </summary>
        public string Article_Annex
        {
            set { _article_annex = value; }
            get { return _article_annex; }
        }
        #endregion

        #region 【读取：文章内容：文章内容必须填写验证，但假如添加了多图可以不填写内容实现多样化】
        private string _article_content;
        /// <summary>
        /// 文章内容：文章内容必须填写验证，但假如添加了多图可以不填写内容实现多样化
        /// </summary>
        public string Article_Content
        {
            set { _article_content = value; }
            get { return _article_content; }
        }
        #endregion

        #region 【读取：封面图片：选择图片路径后页面选则那显示一个展示给人直观点知道选择什么样图片当封面】
        private string _article_cover_image;
        /// <summary>
        /// 封面图片：选择图片路径后页面选则那显示一个展示给人直观点知道选择什么样图片当封面
        /// </summary>
        public string Article_Cover_image
        {
            set { _article_cover_image = value; }
            get { return _article_cover_image; }
        }
        #endregion

        #region 【读取：文章添加人ID：只能是帐号的ID】
        private int _article_addpeopleid;
        /// <summary>
        /// 文章添加人ID：只能是帐号的ID
        /// </summary>
        public int Article_AddPeopleID
        {
            set { _article_addpeopleid = value; }
            get { return _article_addpeopleid; }
        }
        #endregion

        #region 【读取：缩略图尺寸X】
        private int? _article_thumbnail_sizex = 0;
        /// <summary>
        /// 缩略图尺寸X
        /// </summary>
        public int? Article_Thumbnail_sizeX
        {
            set { _article_thumbnail_sizex = value; }
            get { return _article_thumbnail_sizex; }
        }
        #endregion

        #region 【读取：缩略图尺寸Y】
        private int? _article_thumbnail_sizey = 0;
        /// <summary>
        /// 缩略图尺寸Y
        /// </summary>
        public int? Article_Thumbnail_sizeY
        {
            set { _article_thumbnail_sizey = value; }
            get { return _article_thumbnail_sizey; }
        }
        #endregion

        #region 【读取：文章等级：可手动设置几星级或点击率到多少可以自动调整到几星级，0-4，就是5星，0为1星，默认为0】
        private int? _article_class = 0;
        /// <summary>
        /// 文章等级：可手动设置几星级或点击率到多少可以自动调整到几星级，0-4，就是5星，0为1星，默认为0
        /// </summary>
        public int? Article_Class
        {
            set { _article_class = value; }
            get { return _article_class; }
        }
        #endregion

        #region 【读取：审核状态：单选按钮：待审核0，已审核 1，退稿则为2，默认为0用户发布，管理员发布则为1，用户发布的则等待管理员【签收、审核】通过才能到前台显示，要是退稿则签收状态那也的改成2，-    但用户界面管理那可以自己看到和审核状态）如会员发布直接发布为1，普通用户发布为0，我们要查会员发布没审的则查文章审核人为0的】
        private int? _article_auditing = 0;
        /// <summary>
        /// 审核状态：单选按钮：待审核0，已审核 1，退稿则为2，默认为0用户发布，管理员发布则为1，用户发布的则等待管理员【签收、审核】通过才能到前台显示，要是退稿则签收状态那也的改成2，-    但用户界面管理那可以自己看到和审核状态）如会员发布直接发布为1，普通用户发布为0，我们要查会员发布没审的则查文章审核人为0的
        /// </summary>
        public int? Article_Auditing
        {
            set { _article_auditing = value; }
            get { return _article_auditing; }
        }
        #endregion

        #region 【读取：发布日期：这个是需要文章那天发布显示如：当前日期2015/05/21 我们设置成 2015/05/25    那么小于或者等于21号的则显示，大于21的如我们设置的25号则不会显示，就能实现功能是否【立即发布】】
        private DateTime? _article_release_date = DateTime.Now;
        /// <summary>
        /// 发布日期：这个是需要文章那天发布显示如：当前日期2015/05/21 我们设置成 2015/05/25    那么小于或者等于21号的则显示，大于21的如我们设置的25号则不会显示，就能实现功能是否【立即发布】
        /// </summary>
        public DateTime? Article_Release_date
        {
            set { _article_release_date = value; }
            get { return _article_release_date; }
        }
        #endregion

        #region 【读取：发布IP地址：记录文章发布的时候是那个地方的IP地址发布的】
        private string _article_ipaddress;
        /// <summary>
        /// 发布IP地址：记录文章发布的时候是那个地方的IP地址发布的
        /// </summary>
        public string Article_IPaddress
        {
            set { _article_ipaddress = value; }
            get { return _article_ipaddress; }
        }
        #endregion

        #region 【读取：立即发布，不立即发布则是草稿】
        private bool _article_release;
        /// <summary>
        /// 立即发布，不立即发布则是草稿
        /// </summary>
        public bool Article_Release
        {
            set { _article_release = value; }
            get { return _article_release; }
        }
        #endregion

        #region 【读取：审核人ID:没人审核则为0默认也为0】
        private int? _article_auditpersonid = 0;
        /// <summary>
        /// 审核人ID:没人审核则为0默认也为0
        /// </summary>
        public int? Article_AuditpersonID
        {
            set { _article_auditpersonid = value; }
            get { return _article_auditpersonid; }
        }
        #endregion

        #region 【读取：审核日期】
        private DateTime? _article_auditdate = DateTime.Now;
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime? Article_Auditdate
        {
            set { _article_auditdate = value; }
            get { return _article_auditdate; }
        }
        #endregion

        #region 【读取：文章添加日期：这个是文章真正的添加日期，不能修改】
        private DateTime? _article_add_date = DateTime.Now;
        /// <summary>
        /// 文章添加日期：这个是文章真正的添加日期，不能修改
        /// </summary>
        public DateTime? Article_Add_date
        {
            set { _article_add_date = value; }
            get { return _article_add_date; }
        }
        #endregion

        #region 【读取：文章类型:页面用下拉（默认0,图文1,组图2,推荐3,注意4,公告5,视频6）】
        private int? _article_type = 0;
        /// <summary>
        /// 文章类型:页面用下拉（默认0,图文1,组图2,推荐3,注意4,公告5,视频6）
        /// </summary>
        public int? Article_Type
        {
            set { _article_type = value; }
            get { return _article_type; }
        }
        #endregion

        #region 【读取：产品订单号】
        private string _article_ordernumber;
        /// <summary>
        /// 产品订单号
        /// </summary>
        public string Article_Ordernumber
        {
            set { _article_ordernumber = value; }
            get { return _article_ordernumber; }
        }
        #endregion

        #region 【读取：库存:产品库存数量】
        private string _article_stock;
        /// <summary>
        /// 库存:产品库存数量
        /// </summary>
        public string Article_Stock
        {
            set { _article_stock = value; }
            get { return _article_stock; }
        }
        #endregion

        #region 【读取：商品单位】
        private string _article_unit;
        /// <summary>
        /// 商品单位
        /// </summary>
        public string Article_Unit
        {
            set { _article_unit = value; }
            get { return _article_unit; }
        }
        #endregion

        #region 【读取：销售选择:正常销售,涨价销售,降级销售】
        private int? _article_xssx = 0;
        /// <summary>
        /// 销售选择:正常销售,涨价销售,降级销售
        /// </summary>
        public int? Article_Xssx
        {
            set { _article_xssx = value; }
            get { return _article_xssx; }
        }
        #endregion

        #region 【读取：商品打折如9.5折】
        private string _article_discount;
        /// <summary>
        /// 商品打折如9.5折
        /// </summary>
        public string Article_Discount
        {
            set { _article_discount = value; }
            get { return _article_discount; }
        }
        #endregion

        #region 【读取：原始零售价】
        private string _article_retailprice;
        /// <summary>
        /// 原始零售价
        /// </summary>
        public string Article_RetailPrice
        {
            set { _article_retailprice = value; }
            get { return _article_retailprice; }
        }
        #endregion

        #region 【读取：当前零售价】
        private string _article_promotion;
        /// <summary>
        /// 当前零售价
        /// </summary>
        public string Article_Promotion
        {
            set { _article_promotion = value; }
            get { return _article_promotion; }
        }
        #endregion

        #region 【读取：文章标题】
        private string _article_title;
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Article_Title
        {
            set { _article_title = value; }
            get { return _article_title; }
        }
        #endregion

        #region 【读取：总点击率】
        private int _article_hitsg;
        /// <summary>
        /// 总点击率
        /// </summary>
        public int Article_hitsg
        {
            set { _article_hitsg = value; }
            get { return _article_hitsg; }
        }
        #endregion

        #region 【读取：记录这一年总点击率】
        private int _article_hitsn;
        /// <summary>
        /// 记录这一年总点击率
        /// </summary>
        public int Article_hitsn
        {
            set { _article_hitsn = value; }
            get { return _article_hitsn; }
        }
        #endregion

        #region 【读取：点击率存储年份】
        private DateTime? _article_hitsntime = null;
        /// <summary>
        /// 点击率存储年份
        /// </summary>
        public DateTime? Article_hitsntime
        {
            set { _article_hitsntime = value; }
            get { return _article_hitsntime; }
        }
        #endregion

        #region 【读取：月点击率】
        private int _article_hitsy;
        /// <summary>
        /// 月点击率
        /// </summary>
        public int Article_hitsy
        {
            set { _article_hitsy = value; }
            get { return _article_hitsy; }
        }
        #endregion

        #region 【读取：点击率存储月份】
        private DateTime? _article_hitsytime = null;
        /// <summary>
        /// 点击率存储月份
        /// </summary>
        public DateTime? Article_hitsytime
        {
            set { _article_hitsytime = value; }
            get { return _article_hitsytime; }
        }
        #endregion

        #region 【读取：周点击率】
        private int _article_hitsz;
        /// <summary>
        /// 周点击率
        /// </summary>
        public int Article_hitsz
        {
            set { _article_hitsz = value; }
            get { return _article_hitsz; }
        }
        #endregion

        #region 【读取：点击率存储周份】
        private DateTime? _article_hitsztime = null;
        /// <summary>
        /// 点击率存储周份
        /// </summary>
        public DateTime? Article_hitsztime
        {
            set { _article_hitsztime = value; }
            get { return _article_hitsztime; }
        }
        #endregion

        #region 【读取：当天点击率】
        private int _article_hitst;
        /// <summary>
        /// 当天点击率
        /// </summary>
        public int Article_hitst
        {
            set { _article_hitst = value; }
            get { return _article_hitst; }
        }
        #endregion

        #region 【读取：记录点击率当天时间】
        private DateTime? _article_hitsttime = null;
        /// <summary>
        /// 记录点击率当天时间
        /// </summary>
        public DateTime? Article_hitsttime
        {
            set { _article_hitsttime = value; }
            get { return _article_hitsttime; }
        }
        #endregion

        #region 【读取：字体样式:下拉(默认字形0,粗体1,斜体2,粗+斜3)】
        private int? _article_font_style = 0;
        /// <summary>
        /// 字体样式:下拉(默认字形0,粗体1,斜体2,粗+斜3)
        /// </summary>
        public int? Article_Font_style
        {
            set { _article_font_style = value; }
            get { return _article_font_style; }
        }
        #endregion

        #region 【读取：记录点击率第几周】
        private int _article_hitszf;
        /// <summary>
        /// 记录点击率第几周
        /// </summary>
        public int Article_hitszf
        {
            set { _article_hitszf = value; }
            get { return _article_hitszf; }
        }
        #endregion

        #region 【读取：标题颜色】
        private string _article_title_color;
        /// <summary>
        /// 标题颜色
        /// </summary>
        public string Article_Title_Color
        {
            set { _article_title_color = value; }
            get { return _article_title_color; }
        }
        #endregion

        #region 【读取：完整标题】
        private string _article_complete_title;
        /// <summary>
        /// 完整标题
        /// </summary>
        public string Article_Complete_Title
        {
            set { _article_complete_title = value; }
            get { return _article_complete_title; }
        }
        #endregion

        #region 【读取：文章栏目，点击弹出一个DIV或其它层不用下拉要是多就加载卡  从【系统栏目 绑定模型选择文章系统】】
        private int? _article_column = 0;
        /// <summary>
        /// 文章栏目，点击弹出一个DIV或其它层不用下拉要是多就加载卡  从【系统栏目 绑定模型选择文章系统】
        /// </summary>
        public int? Article_Column
        {
            set { _article_column = value; }
            get { return _article_column; }
        }
        #endregion

        #region 【读取：转向链接：默认为不能填写必须在后面添加一个是否启用转向链接负选框,假如不启用提交默认为null】
        private string _article_shift_link_url;
        /// <summary>
        /// 转向链接：默认为不能填写必须在后面添加一个是否启用转向链接负选框,假如不启用提交默认为null
        /// </summary>
        public string Article_Shift_link_URL
        {
            set { _article_shift_link_url = value; }
            get { return _article_shift_link_url; }
        }
        #endregion

        #region 【读取：内容需要登录才可预览】
        private bool _article_login;
        /// <summary>
        /// 内容需要登录才可预览
        /// </summary>
        public bool Article_login
        {
            set { _article_login = value; }
            get { return _article_login; }
        }
        #endregion

        #region 【读取：内容需要用户评论才可预览】
        private bool _article_comment;
        /// <summary>
        /// 内容需要用户评论才可预览
        /// </summary>
        public bool Article_comment
        {
            set { _article_comment = value; }
            get { return _article_comment; }
        }
        #endregion

        #region 【读取：商品价格类型】
        private bool _article_sptype;
        /// <summary>
        /// 商品价格类型
        /// </summary>
        public bool Article_sptype
        {
            set { _article_sptype = value; }
            get { return _article_sptype; }
        }
        #endregion

        #region 【读取：商品销售开始时间】
        private DateTime? _article_spgodate = null;
        /// <summary>
        /// 商品销售开始时间
        /// </summary>
        public DateTime? Article_spgodate
        {
            set { _article_spgodate = value; }
            get { return _article_spgodate; }
        }
        #endregion

        #region 【读取：商品销售结束时间】
        private DateTime? _article_spenddate = null;
        /// <summary>
        /// 商品销售结束时间
        /// </summary>
        public DateTime? Article_spenddate
        {
            set { _article_spenddate = value; }
            get { return _article_spenddate; }
        }
        #endregion

        #region 【读取：最小价格】
        private decimal? _article_jgmin = 0;
        /// <summary>
        /// 最小价格
        /// </summary>
        public decimal? Article_jgmin
        {
            set { _article_jgmin = value; }
            get { return _article_jgmin; }
        }
        #endregion

        #region 【读取：最大价格】
        private decimal? _article_jgmax = 0;
        /// <summary>
        /// 最大价格
        /// </summary>
        public decimal? Article_jgmax
        {
            set { _article_jgmax = value; }
            get { return _article_jgmax; }
        }
        #endregion

        #endregion Model
    }
}