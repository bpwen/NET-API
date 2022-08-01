using System;

namespace HRMS.Public.Model
{
    /// <summary>
    /// 数据库操作 标签类型选择
    /// </summary>
    public class Data
    {
        HRMS.BLL.Label.LabelBLL LabelBLL = new HRMS.BLL.Label.LabelBLL();
        HRMS.Model.Label.LabelModel LabelModel = new HRMS.Model.Label.LabelModel();
        HRMS.Model.Label.LabelModelA LabelModelA = new HRMS.Model.Label.LabelModelA();
        HRMS.Model.Label.LabelModelB LabelModelB = new HRMS.Model.Label.LabelModelB();

        /// <summary>
        /// 是否存在该标签
        /// </summary>
        /// <param name="Label">标签</param>
        /// <param name="Code">标签里面的编码</param>
        /// <param name="RouteModel"></param>
        /// <returns></returns>
        public string GetModel(int value)
        {
            bool isTrue = LabelBLL.Exists(value);
            if (isTrue)
            {
                #region 【标签存在则执行以下方法】
                LabelModel = LabelBLL.GetModel(value);
                string Receive = null;
                switch (Convert.ToInt32(LabelModel.Label_Type))
                {
                    case 0://html源代码
                        Receive = BPW.Response.GetModel(LabelModel.Label_Code);
                        break;
                    case 1://单张图片源代码
                        LabelModelA.src = LabelModel.Label_Address;
                        LabelModelA.description = LabelModel.Label_Description;
                        LabelModelA.height = LabelModel.Label_Height;
                        LabelModelA.width = LabelModel.Label_Width;
                        LabelModelA.href = LabelModel.Label_Href;
                        LabelModelA.target = LabelModel.Label_Hreftarget;

                        Receive = BPW.Response.GetModel(LabelModelA);
                        break;
                    case 2://单张Flash
                        LabelModelB.src = LabelModel.Label_Address;
                        LabelModelB.height = LabelModel.Label_Height;
                        LabelModelB.width = LabelModel.Label_Width;

                        Receive = BPW.Response.GetModel(LabelModelA);
                        break;
                    case 3://幻灯片
                        Slides Slides = new Slides();
                        Receive = Slides.Bpwen_Replace(LabelModel);
                        break;
                    case 4://文章系统
                        Article Article = new Article();
                        Receive = Article.Bpwen_Replace(LabelModel);
                        break;
                    //case 5://导航系统
                    //    Navigation Navigation = new Navigation();
                    //    Receive = Navigation.Bpwen_Replace(LabelModel);
                    //    break;
                    //case 6://留言系统
                    //    Message Message = new Message();
                    //    Receive = Message.Bpwen_Replace(LabelModel);
                    //    break;
                    default:
                        Receive = BPW.Response.GetModel(LabelModel);
                        break;
                }


                if (LabelModel.Label_Hide)
                {
                    return Receive;
                }
                else
                {
                    return null;
                }
                
                #endregion
            }
            else
            {
                return BPW.Response.alert("内容不存在或已被删除");
            }
        }
    }
}
