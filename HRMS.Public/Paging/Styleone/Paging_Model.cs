using System;
using System.Data;

namespace HRMS.Public.Paging.Styleone
{
    /// <summary>
    /// 分页Model
    /// </summary>
    [Serializable]
    public partial class PagingModel
    {
        public PagingModel()
        { }
        #region Model


        private string _container;                   //分页列表存放的Label控件ID
        private int _pagesize;                       //1页输出多少条记录
        private DataSet _datavalue;                  //分页数据源【ds】必须有穿值
        private int _pagecount;                      //分页总页数不可赐予
        private int _currentpageindex;               //记录当前页page系统赐予
        private string _fill;                        //数据源中的行如sda.Fill(ds, "name"); 就是 name 动软生成的 填写ds
        private int _totalrecord;                    //数据总记录数目用户填写
        private string _page;                        //URL地址那自定义，可为空则默认page=?
        private int _displaypage;                    //分页列表输出几位,默认为5
        private int _pagefixedposition;              //分页走动到中间后固定位置显示如Displaypage设置为显示5个，这里输入3，那么下一页到3那就固定到那个位置,默认为3
        private bool? _listoff = true;               //分页列表关闭,默认为开启：true，关闭则：false
        private bool? _jumpoff = true;               //跳转关闭,默认为开启：true，关闭则：false
        private bool? _informationoff = true;        //输出分页信息关闭,默认为开启：true，关闭则：false 面板：1/30 页 共:100条 每页:20条
        private bool? _numberofbarsoff = true;       //记录总条数关闭,默认为开启：true，关闭则：false 面板：共:100条
        private bool? _pagexxoff = true;             //输出面板一页多少条记录关闭,默认为开启：true，关闭则：false 面板：每页:5条
        private bool? _pagetotal = true;             //输出面板当前页/总页数：1/26 页


        #region 【】
        /// <summary>
        /// 分页列表存放的Label控件ID,必须填写
        /// </summary>
        public string Container
        {
            set { _container = value; }
            get { return _container; }
        }

        /// <summary>
        /// 1页输出多少条记录
        /// </summary>
        public int PageSize
        {
            set { _pagesize = value; }
            get { return _pagesize; }
        }

        /// <summary>
        /// 分页数据源【ds】必须有穿值
        /// </summary>
        public DataSet Datavalue
        {
            set { _datavalue = value; }
            get { return _datavalue; }
        }

        /// <summary>
        /// 分页总页数不可赐予
        /// </summary>
        public int PageCount
        {
            set { _pagecount = value; }
            get { return _pagecount; }
        }

        /// <summary>
        /// 记录当前页page系统赐予
        /// </summary>
        public int CurrentPageIndex
        {
            set { _currentpageindex = value; }
            get { return _currentpageindex; }
        }

        /// <summary>
        /// 数据源中的行如sda.Fill(ds, "name"); 就是 name 动软生成的 填写ds,为空则：ds
        /// </summary>
        public string Fill
        {
            set { _fill = value; }
            get { return _fill; }
        }

        /// <summary>
        /// 数据总记录数目用户填写
        /// </summary>
        public int Totalrecord
        {
            set { _totalrecord = value; }
            get { return _totalrecord; }
        }

        /// <summary>
        /// URL地址那自定义，可为空则默认page=?
        /// </summary>
        public string Page
        {
            set { _page = value; }
            get { return _page; }
        }

        /// <summary>
        /// 分页列表输出几位,默认为5
        /// </summary>
        public int Displaypage
        {
            set { _displaypage = value; }
            get { return _displaypage; }
        }

        /// <summary>
        /// 分页走动到中间后固定位置显示如Displaypage设置为显示5个，这里输入3，那么下一页到3那就固定到那个位置,默认为3
        /// </summary>
        public int PageFixedposition
        {
            set { _pagefixedposition = value; }
            get { return _pagefixedposition; }
        }

        /// <summary>
        /// 分页列表关闭,默认为开启：true，关闭则：false
        /// </summary>
        public bool? Listoff
        {
            set { _listoff = value; }
            get { return _listoff; }
        }

        /// <summary>
        /// 跳转关闭,默认为开启：true，关闭则：false
        /// </summary>
        public bool? Jumpoff
        {
            set { _jumpoff = value; }
            get { return _jumpoff; }
        }

        /// <summary>
        /// 输出分页信息关闭,默认为开启：true，关闭则：false 面板：1/30 页 共:100条 每页:20条
        /// </summary>
        public bool? Informationoff
        {
            set { _informationoff = value; }
            get { return _informationoff; }
        }

        /// <summary>
        /// 输出总条数关闭,默认为开启：true，关闭则：false 面板：共:100条
        /// </summary>
        public bool? Numberofbarsoff
        {
            set { _numberofbarsoff = value; }
            get { return _numberofbarsoff; }
        }

        /// <summary>
        /// 输出面板一页多少条记录关闭,默认为开启：true，关闭则：false 面板：每页:5条
        /// </summary>
        public bool? Pagexxoff
        {
            set { _pagexxoff = value; }
            get { return _pagexxoff; }
        }

        /// <summary>
        /// 输出面板当前页/总页数：1/26 页
        /// </summary>
        public bool? PageTotal
        {
            set { _pagetotal = value; }
            get { return _pagetotal; }
        }
        #endregion

        #endregion
    }
}