using HRMS.BPW;
using Newtonsoft.Json.Linq;
using System.Web.Http;

namespace HRMS.Web.Controllers.system
{
    
    public class ColumnController : ApiController
    {
        HRMS.API.System.ColumnAPI ColumnAPI = new API.System.ColumnAPI();

        #region 【获取首页导航栏目】
        /// <summary>
        /// 获取首页导航栏目
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JObject Homenav()
        {
            return json.parse(ColumnAPI.List("Column_styleid=11 and Column_Aid=0"));
        }
        #endregion
    }
}