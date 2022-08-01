using System.Data;
using HRMS.BLL.Label;
using HRMS.Model.Label;
using System.Collections.Generic;

namespace HRMS.Public.Model
{
    /// <summary>
    /// 幻灯片
    /// </summary>
    public class Slides
    {
        SlidesBLL SlidesBLL = new SlidesBLL();

        /// <summary>
        /// 幻灯片标签替换
        /// </summary>
        /// <returns></returns>
        public string Bpwen_Replace(LabelModel item)
        {
            DataSet ds = SlidesBLL.GetList("Slides_Aid = " + item.Label_ID);
            int Count = ds.Tables[0].Rows.Count;
            if (Count != 0)
            {
                List<HRMS.Model.Label.LabelModelA> Model = new List<HRMS.Model.Label.LabelModelA>();
                for (int i = 0; i < Count; i++)
                {
                    Model.Add(new HRMS.Model.Label.LabelModelA()
                    {
                        src = ds.Tables[0].Rows[i]["Slides_Route"].ToString(),
                        href = ds.Tables[0].Rows[i]["Slides_Url"].ToString(),
                        description = ds.Tables[0].Rows[i]["Slides_Text"].ToString(),
                        width = item.Label_Width,
                        height = item.Label_Href,
                        target = item.Label_Hreftarget
                    });
                }
                return BPW.Response.GetModel(Model);
            }
            else
            {
                return BPW.Response.alert("抱歉,该栏目没有任何数据");
            }
        }
    }
}
