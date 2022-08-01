using System;

namespace HRMS.Model.cpweb
{
    /// <summary>
    /// cpweb_list
    /// </summary>
    [Serializable]
    public partial class listModel
    {
        public listModel()
        { }

        #region 【基本方法】Model

        #region 【读取：ID】
        private int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion

        #region 【读取：订购地址】
        private string _orderurl;
        /// <summary>
        /// 订购地址
        /// </summary>
        public string orderurl
        {
            set { _orderurl = value; }
            get { return _orderurl; }
        }
        #endregion

        #region 【读取：预览地址】
        private string _previewurl;
        /// <summary>
        /// 预览地址
        /// </summary>
        public string previewurl
        {
            set { _previewurl = value; }
            get { return _previewurl; }
        }
        #endregion

        #region 【读取：添加时间】
        private DateTime? _date = DateTime.Now;
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? date
        {
            set { _date = value; }
            get { return _date; }
        }
        #endregion

        #region 【读取：编号】
        private string _uid;
        /// <summary>
        /// 编号
        /// </summary>
        public string uid
        {
            set { _uid = value; }
            get { return _uid; }
        }
        #endregion

        #region 【读取：名称】
        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        #endregion

        #region 【读取：封面】
        private string _cover;
        /// <summary>
        /// 封面
        /// </summary>
        public string cover
        {
            set { _cover = value; }
            get { return _cover; }
        }
        #endregion

        #region 【读取：缩略图】
        private string _thumbnail;
        /// <summary>
        /// 缩略图
        /// </summary>
        public string thumbnail
        {
            set { _thumbnail = value; }
            get { return _thumbnail; }
        }
        #endregion

        #region 【读取：应用分类】
        private int _applytype;
        /// <summary>
        /// 应用分类
        /// </summary>
        public int applytype
        {
            set { _applytype = value; }
            get { return _applytype; }
        }
        #endregion

        #region 【读取：行业分类】
        private int _industrytype;
        /// <summary>
        /// 行业分类
        /// </summary>
        public int industrytype
        {
            set { _industrytype = value; }
            get { return _industrytype; }
        }
        #endregion

        #endregion 【基本方法】Model
    }
}