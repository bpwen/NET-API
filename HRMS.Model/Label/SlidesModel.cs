using System;
namespace HRMS.Model.Label
{
	/// <summary>
	/// 标签幻灯片
	/// </summary>
	[Serializable]
	public partial class SlidesModel
	{
		public SlidesModel()
		{}
		#region Model
		private int _slides_id;
		private int _slides_aid;
		private string _slides_route;
		private string _slides_url;
		private string _slides_text;
        private string _slides_panel_img;
        private string _slides_move_img;

        /// <summary>
        /// 表ID
        /// </summary>
        public int Slides_ID
		{
			set{ _slides_id=value;}
			get{return _slides_id;}
		}
		/// <summary>
		/// 对应Aid
		/// </summary>
		public int Slides_Aid
		{
			set{ _slides_aid=value;}
			get{return _slides_aid;}
		}
		/// <summary>
		/// 图片地址
		/// </summary>
		public string Slides_Route
		{
			set{ _slides_route=value;}
			get{return _slides_route;}
		}
		/// <summary>
		/// 跳转连接地址
		/// </summary>
		public string Slides_Url
		{
			set{ _slides_url=value;}
			get{return _slides_url;}
		}
		/// <summary>
		/// 文本介绍
		/// </summary>
		public string Slides_Text
		{
			set{ _slides_text=value;}
			get{return _slides_text;}
		}

        #region 【读取：平板图片地址】
        /// <summary>
        /// 平板图片地址
        /// </summary>
        public string Slides_panel_img
        {
            set { _slides_panel_img = value; }
            get { return _slides_panel_img; }
        }
        #endregion

        #region 【读取：手机图片地址】
        /// <summary>
        /// 手机图片地址
        /// </summary>
        public string Slides_move_img
        {
            set { _slides_move_img = value; }
            get { return _slides_move_img; }
        }
        #endregion

        #endregion Model

    }
}

