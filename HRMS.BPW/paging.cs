using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.BPW
{
    /// <summary>
    /// 分页
    /// </summary>
    public class paging
    {
        /// <summary>
        /// 分页列表参数
        /// </summary>
        public class parameter
        {
            /// <summary>
            /// 列表当前页
            /// </summary>
            public int page { get; set; }
            /// <summary>
            /// 列表总共多少条数据
            /// </summary>
            /// <returns></returns>
            public int recordcount { get; set; }
            /// <summary>
            /// 列表第几条开始
            /// </summary>
            public int begin_count { get; set; }
            /// <summary>
            /// 列表第几条结束
            /// </summary>
            public int end_count { get; set; }
            /// <summary>
            /// 每页显示多少条数据
            /// </summary>
            public int pagesize { get; set; }
            /// <summary>
            /// 列表有多少页
            /// </summary>
            public int pagecount { get; set; }
        }
    }
}