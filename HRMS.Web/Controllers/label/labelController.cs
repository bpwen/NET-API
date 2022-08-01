using HRMS.BPW;
using Newtonsoft.Json.Linq;
using System.Web.Http;
using HRMS.Web.AuthAttributes;

namespace HRMS.Web.Controllers.label
{
    [ApiAuthorize]
    public class labelController : ApiController
    {
        HRMS.Public.Model.Data Label = new Public.Model.Data();

        #region 【获取首页导航栏目】
        /// <summary>
        /// 获取自定义标签
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JObject GetModel()
        {
            int id = BPW.Request.Form("id", 0);
            if (id != -1)
            {
                return json.parse(Label.GetModel(id));
            }
            else
            {
                return json.parse(BPW.Response.error("参数异常"));
            }
        }
        #endregion
    }
}