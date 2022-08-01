using System;

/// <summary>
/// 表描述:系统栏目：添加文章系统，它里面有什么栏目如，公司新闻，行业新闻，我们去发布文章就可以选择发布到公司新闻还是行业新闻里面去。
/// </summary>
namespace HRMS.APIModel.system
{
    [Serializable]
    public partial class column
    {
        public column()
        { }

        #region 【Model】

        private int _id;        //表ID
        private string _name;        //栏目名称
        private string _icon;        //栏目图标
        private string _externalurl;        //外部连接：存放外部链接地址

        /// <summary>
        ///表ID
        /// </summary>
        public int ID { set { _id = value; } get { return _id; } }
        /// <summary>
        ///栏目名称
        /// </summary>
        public string Name { set { _name = value; } get { return _name; } }
        /// <summary>
        ///栏目图标
        /// </summary>
        public string icon { set { _icon = value; } get { return _icon; } }
        /// <summary>
        ///外部连接：存放外部链接地址
        /// </summary>
        public string ExternalUrl { set { _externalurl = value; } get { return _externalurl; } }
        #endregion 【Model】
    }
}