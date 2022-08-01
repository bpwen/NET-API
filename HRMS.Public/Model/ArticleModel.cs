using System;

namespace HRMS.Public.Model
{
    /// <summary>
    /// 文章参数变量存储
    /// </summary>
    [Serializable]
    public class ArticleModel
    {
        public ArticleModel()
        { }
        #region Model
        private string _sql;
        private string _sqlwhere;
        private string _orderby;

        /// <summary>
        /// SQL语句组合存储
        /// </summary>
        public string Sql
        {
            set { _sql = value; }
            get { return _sql; }
        }
        /// <summary>
        /// SQL语句组合存储
        /// </summary>
        public string SqlWhere
        {
            set { _sqlwhere = value; }
            get { return _sqlwhere; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public string Orderby
        {
            set { _orderby = value; }
            get { return _orderby; }
        }


        #endregion

    }

    /// <summary>
    /// 文章参数变量存储
    /// </summary>
    [Serializable]
    public class ArticleModelA
    {
        public ArticleModelA()
        { }
        #region Model

        #region 【读取：序号】
        private int _article_uid;
        /// <summary>
        /// 序号
        /// </summary>
        public int uid
        {
            set { _article_uid = value; }
            get { return _article_uid; }
        }
        #endregion

        #region 【读取：文章ID】
        private int _article_id;
        /// <summary>
        /// 文章系统 文章ID
        /// </summary>
        public int id
        {
            set { _article_id = value; }
            get { return _article_id; }
        }
        #endregion

        #region 【读取：文章标题】
        private string _article_title;
        /// <summary>
        /// 文章标题
        /// </summary>
        public string title
        {
            set { _article_title = value; }
            get { return _article_title; }
        }
        #endregion

        #region 【读取：完整标题】
        private string _article_complete_title;
        /// <summary>
        /// 完整标题
        /// </summary>
        public string complete_title
        {
            set { _article_complete_title = value; }
            get { return _article_complete_title; }
        }
        #endregion

        #region 【读取：封面图片：选择图片路径后页面选则那显示一个展示给人直观点知道选择什么样图片当封面】
        private string _article_cover_image;
        /// <summary>
        /// 封面图片：选择图片路径后页面选则那显示一个展示给人直观点知道选择什么样图片当封面
        /// </summary>
        public string img
        {
            set { _article_cover_image = value; }
            get { return _article_cover_image; }
        }
        #endregion

        #region 【读取：转向链接启用】
        private bool _article_shift_link_urla;
        /// <summary>
        /// 转向链接启用
        /// </summary>
        public bool shift_link_urla
        {
            set { _article_shift_link_urla = value; }
            get { return _article_shift_link_urla; }
        }
        #endregion

        #region 【读取：转向链接：默认为不能填写必须在后面添加一个是否启用转向链接负选框,假如不启用提交默认为null】
        private string _article_shift_link_url;
        /// <summary>
        /// 转向链接：默认为不能填写必须在后面添加一个是否启用转向链接负选框,假如不启用提交默认为null
        /// </summary>
        public string shift_link_url
        {
            set { _article_shift_link_url = value; }
            get { return _article_shift_link_url; }
        }
        #endregion

        #region 【读取：文章添加日期：这个是文章真正的添加日期，不能修改】
        private string _article_add_date;
        /// <summary>
        /// 文章添加日期：这个是文章真正的添加日期，不能修改
        /// </summary>
        public string add_date
        {
            set { _article_add_date = value; }
            get { return _article_add_date; }
        }
        #endregion

        #region 【读取：发布日期：这个是需要文章那天发布显示如：当前日期2015/05/21 我们设置成 2015/05/25    那么小于或者等于21号的则显示，大于21的如我们设置的25号则不会显示，就能实现功能是否【立即发布】】
        private string _article_release_date;
        /// <summary>
        /// 发布日期：这个是需要文章那天发布显示如：当前日期2015/05/21 我们设置成 2015/05/25    那么小于或者等于21号的则显示，大于21的如我们设置的25号则不会显示，就能实现功能是否【立即发布】
        /// </summary>
        public string release_date
        {
            set { _article_release_date = value; }
            get { return _article_release_date; }
        }
        #endregion

        #region 【栏目id】
        private string _column_id;
        /// <summary>
        /// 栏目id
        /// </summary>
        public string column_id
        {
            set { _column_id = value; }
            get { return _column_id; }
        }
        #endregion


        #region 【栏目名称】
        private string _column_name;
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string column_name
        {
            set { _column_name = value; }
            get { return _column_name; }
        }
        #endregion

        #region 【读取：文章导读】
        private string _article_guide;
        /// <summary>
        /// 文章导读
        /// </summary>
        public string guide
        {
            set { _article_guide = value; }
            get { return _article_guide; }
        }
        #endregion

        #region 【读取：文章点击率】
        private string _click_rate;
        /// <summary>
        /// 文章点击率
        /// </summary>
        public string click_rate
        {
            set { _click_rate = value; }
            get { return _click_rate; }
        }
        #endregion

        

        #endregion
    }
}