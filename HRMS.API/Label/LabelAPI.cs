using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HRMS.BPW;
using HRMS.BLL.Label;
using HRMS.Model.Label;


namespace HRMS.API.Label
{
    /// <summary>
    /// 表描述:Label
    /// </summary>
    public class LabelAPI
    {
        LabelBLL Post = new LabelBLL();
        LabelModel M_Model = new LabelModel();

        #region  数据接口

        #region  是否存在该记录
        public bool Exists(string strWhere)
        {
            if (Post.Exists(strWhere))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  是否存在该记录

        #region  得到一个对象实体
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetModel(string strWhere)
        {
            #region 【获取指定数据是否存在】
            M_Model = Post.GetModel(strWhere);
            if (M_Model == null)
            {
                return Response.error("对不起,数据不存在或已被删除。");
            }
            #endregion

            #region 【加载数据】
            List<HRMS.APIModel.Label.label> Model = new List<HRMS.APIModel.Label.label>();
            Model.Add(new HRMS.APIModel.Label.label()
            {
                ID = Convert.ToInt32(M_Model.Label_ID),   //表ID
                LayerWidth = M_Model.Label_LayerWidth,   //更新内容时上方遮蔽层设置标签层宽
                LayerHigh = M_Model.Label_LayerHigh,   //更新内容时上方遮蔽层设置标签层高
                Address = M_Model.Label_Address,   //文件地址或路径
                Href = M_Model.Label_Href,   //超链接地址
                Hreftarget = M_Model.Label_Hreftarget,   //超链接打开方式
                Width = M_Model.Label_Width,   //宽
                Height = M_Model.Label_Height,   //高
                Description = M_Model.Label_Description,   //描述
                StyleFather = M_Model.Label_StyleFather,   //风格父类
                StyleSub = M_Model.Label_StyleSub,   //风格子类
                Type = Convert.ToInt32(M_Model.Label_Type),   //标签类型
                Paging = Convert.ToBoolean(M_Model.Label_Paging),   //普通或分页显示
                FatherID = M_Model.Label_FatherID,   //父栏目id已数组存储
                SubID = M_Model.Label_SubID,   //子栏目id已数组存储
                Displaytype = Convert.ToBoolean(M_Model.Label_Displaytype),   //显示类型全部还是已审核
                SortA = Convert.ToBoolean(M_Model.Label_SortA),   //内容排序筛选默认还是自定义
                SortB = Convert.ToInt32(M_Model.Label_SortB),   //内容排序字段
                SortC = M_Model.Label_SortC,   //内容排序升降
                SortD = M_Model.Label_SortD,   //内容排序自定义代码
                SqlChoice = Convert.ToBoolean(M_Model.Label_SqlChoice),   //SQL选择启用否
                SqlCode = M_Model.Label_SqlCode,   //SQL语句代码
                Mark = M_Model.Label_Mark.ToString(),   //创建标签生成的一组ID按年月日时分秒+随机数产生一组数组可以用来当JS函数,框架ID,如防止一个JS多次调用后在一个页面产生冲突
                Show = M_Model.Label_Show,   //内容只显示数组
                Showno = M_Model.Label_Showno,   //内容不显示数组
                Line = M_Model.Label_Line,   //内容循环几行
                Column = M_Model.Label_Column,   //内容循环几列
                TitleLength = M_Model.Label_TitleLength,   //内容标题长度
                TitleEllipsis = Convert.ToBoolean(M_Model.Label_TitleEllipsis),   //内容标题是否启用省略号
                Bytelength = M_Model.Label_Bytelength,   //内容字节长度
                Class = M_Model.Label_Class,   //插入Class名称
                Classway = M_Model.Label_Classway,   //插入Class方式，固定位置，循环插入
                Classpage = M_Model.Label_Classpage,   //插入Class位置
                Name = M_Model.Label_Name,   //标签名称
                Roll = Convert.ToInt32(M_Model.Label_Roll),   //滚动：不滚动0默认 向左1 向右2 向上3
                RollA = M_Model.Label_RollA,   //滚动速度
                RollB = M_Model.Label_RollB,   //滚动框架高度
                RollC = M_Model.Label_RollC,   //滚动行高
                Newest = M_Model.Label_Newest,   //多久发布为最新
                Hot = M_Model.Label_Hot,   //点击率多少为热门
                navfocus = M_Model.Label_navfocus,   //导航焦点名称
                NoData = M_Model.Label_NoData,   //列表页相关栏目无数据显示什么代码
                NoSearchData = M_Model.Label_NoSearchData,   //搜索内容跳转到相关页面无数据则显示什么代码
                inissue = Convert.ToBoolean(M_Model.Label_inissue),   //文章显示，立即发布，true显示立即发布，False显示全部
                Callpage = M_Model.Label_Callpage,   //标签前台调用页网址
                signin = Convert.ToBoolean(M_Model.Label_signin),   //文章显示，签收，true显示签收的，False显示全部
                styleid = Convert.ToInt32(M_Model.Label_styleid),   //存放风格模板ID
                Templatepage = M_Model.Label_Templatepage,   //标签模板页路径
                CodeOutside = M_Model.Label_CodeOutside,   //样式代码外
                Code = M_Model.Label_Code,   //样式代码内
                Hide = Convert.ToBoolean(M_Model.Label_Hide)   //标签内容是否隐藏,暂时不显示
            });
            #endregion

            return Response.GetModel(Model);
        }
        #endregion  得到一个对象实体

        #endregion  数据接口

        #region 其他数据

        #endregion  其他数据
    }
}