using System;
using System.Reflection;
using System.Configuration;

namespace HRMS.DALFactory
{
    /// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="HRMS.SQLServerDAL" />。
    /// </summary>
    public sealed class DataAccess
    {
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];

        #region CreateObject
        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = DataCache.GetCache(classNamespace);//从缓存读取
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);//反射创建
                    DataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
        #endregion

        #region 【cpweb_list】
        /// <summary>
        /// cpweb_list
        /// </summary>
        public static HRMS.IDAL.cpweb.IlistDAL CreatelistDAL()
        {
            string ClassNamespace = AssemblyPath + ".cpweb.listDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.cpweb.IlistDAL)objType;
        }
        #endregion

        #region 【cpweb_industry】
        /// <summary>
        /// cpweb_industry
        /// </summary>
        public static HRMS.IDAL.cpweb.IindustryDAL CreateindustryDAL()
        {
            string ClassNamespace = AssemblyPath + ".cpweb.industryDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.cpweb.IindustryDAL)objType;
        }
        #endregion

        #region 【cpweb_applytype】
        /// <summary>
        /// cpweb_applytype
        /// </summary>
        public static HRMS.IDAL.cpweb.IapplytypeDAL CreateapplytypeDAL()
        {
            string ClassNamespace = AssemblyPath + ".cpweb.applytypeDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.cpweb.IapplytypeDAL)objType;
        }
        #endregion

        #region 【applets_type】
        /// <summary>
        /// applets_type
        /// </summary>
        public static HRMS.IDAL.applets.ItypeDAL CreatetypeDAL()
        {
            string ClassNamespace = AssemblyPath + ".applets.typeDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.applets.ItypeDAL)objType;
        }
        #endregion

        #region 【applets_industry】
        /// <summary>
        /// applets_industry
        /// </summary>
        public static HRMS.IDAL.applets.IindustryDAL CreateappindustryDAL()
        {
            string ClassNamespace = AssemblyPath + ".applets.industryDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.applets.IindustryDAL)objType;
        }
        #endregion

        #region 【applets_customer】
        /// <summary>
        /// applets_customer
        /// </summary>
        public static HRMS.IDAL.applets.IcustomerDAL CreatecustomerDAL()
        {
            string ClassNamespace = AssemblyPath + ".applets.customerDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.applets.IcustomerDAL)objType;
        }
        #endregion


        #region 【Admin开头的用户表】
        /// <summary>
        /// 创建AdminDAL数据层接口。用户系统
        /// </summary>
        public static HRMS.IDAL.Admin.IAdminDAL CreateAdminDAL()
        {

            string ClassNamespace = AssemblyPath + ".Admin.AdminDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.Admin.IAdminDAL)objType;
        }
        #endregion

        #region 【Article开头的表】
        /// <summary>
        /// 创建IArticleDAL数据层接口。文章系统
        /// </summary>
        public static HRMS.IDAL.Article.IArticleDAL CreateIArticleDAL()
        {

            string ClassNamespace = AssemblyPath + ".Article.IArticleDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.Article.IArticleDAL)objType;
        }
        #endregion

        #region 【System】
        /// <summary>
		/// 创建IColumnDAL数据层接口。系统栏目：添加文章系统
		/// </summary>
		public static HRMS.IDAL.System.IIColumnDAL CreateIColumnDAL()
        {

            string ClassNamespace = AssemblyPath + ".System.IColumnDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.System.IIColumnDAL)objType;
        }
        #endregion

        #region 【Label】
        /// <summary>
        /// Label
        /// </summary>
        public static HRMS.IDAL.Label.ILabelDAL CreateLabelDAL()
        {
            string ClassNamespace = AssemblyPath + ".Label.LabelDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.Label.ILabelDAL)objType;
        }

        /// <summary>
        /// 创建ISlidesDAL数据层接口。标签幻灯片
        /// </summary>
        public static HRMS.IDAL.Label.ISlidesDAL CreateISlidesDAL()
        {
            string ClassNamespace = AssemblyPath + ".Label.ISlidesDAL";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (HRMS.IDAL.Label.ISlidesDAL)objType;
        }
        #endregion
    }
}