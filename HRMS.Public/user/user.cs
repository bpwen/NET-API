using System;
using System.Web;
using System.Web.Security;
using System.Collections;

//using Microsoft.AspNetCore.Authentication.JwtBearer;

//using Microsoft.IdentityModel.Tokens;

//using System.IdentityModel.Tokens.Jwt;

//using System.Security.Claims;


namespace HRMS.Public.user
{

    public class user
    {
        #region 【后台用户登录】
        /// <summary>
        /// 后台用户登录
        /// </summary>
        /// <returns></returns>
        public string admin_Login()
        {
            if (HttpContext.Current.Request.HttpMethod.ToUpper() == "POST")
            {
                #region 【读取提交过来的记录+验证】

                #region 【读取：登录帐号】
                string Admin_username = BPW.Request.Form("username");
                if (Admin_username == null)
                {
                    return BPW.Response.error("请输入登录帐号!");
                }
                #endregion

                #region 【读取：登录密码】
                string Admin_password = BPW.Request.Form("password");
                if (Admin_password == null)
                {
                    return BPW.Response.error("请输入登录密码!");
                }
                #endregion

                #endregion

                Hashtable user = new Hashtable();
                user["Admin_username"] = Admin_username;
                user["Admin_password"] = Admin_password;
                user["Jurisdiction"] = 1; //用于 Login_Jurisdiction 表示没权限返回提示是后台的还是前台的 1后台 2前台
                user["Loglog_Type"] = 1; //表示前台登录 用于记录登录日志 登录类型
                user["alert"] = 1; //错误，成功返回的方式 1返回json

                return Login(user);
            }
            return BPW.Response.error("数据异常,请联系管理员!");
        }
        #endregion


        public string Login(Hashtable username)
        {
            #region 【引用业务逻辑执行相关操作】

            HRMS.BLL.Admin.AdminBLL mge = new HRMS.BLL.Admin.AdminBLL();

            //判断输入的帐号是否存在
            bool JianchaUesrName = mge.ExistsUsername(username["Admin_username"].ToString());
            if (JianchaUesrName == false)
            {
                if (Convert.ToInt32(username["alert"]) == 1)
                {
                    return BPW.Response.error("此用户名不存在!");
                }
                else
                {
                    return "此用户名不存在!";
                }
            }
            else
            {
                HRMS.Model.Admin.AdminModel user = mge.Login(username["Admin_username"].ToString(), username["Admin_password"].ToString());

                #region 【判断返回值】
                if (user == null)
                {
                    if (Convert.ToInt32(username["alert"]) == 1)
                    {
                        return BPW.Response.error("用户密码错误,请重新输入!");
                    }
                    else
                    {
                        return "用户密码错误,请重新输入!";
                    }
                }
                else
                {
                    #region 【写用户缓存】
                    //HttpCookie cookie = new HttpCookie("userinfo");
                    //cookie["ID"] = user.Admin_ID.ToString();
                    //cookie["username"] = user.Admin_username;
                    ////保存到用户电脑上  append只是一个方法，只追加了，而不返回任何东西，是procedure
                    //Response.AppendCookie(cookie);
                    #endregion

                    #region 【读取用户权限标识】
                    //HRMS.BLL.Jurisdiction.JurisdictionBLL JurisdictionBLL = new BLL.Jurisdiction.JurisdictionBLL();
                    //HRMS.Model.Jurisdiction.JurisdictionModel JurisdictionModel = JurisdictionBLL.GetModel(Convert.ToInt32(user.Admin_User_group));
                    string UserData = "admin,User";//JurisdictionModel.Jurisdiction_Thereisno;
                    #endregion

                    //Forms身份验证初始化 
                    FormsAuthentication.Initialize();

                    #region 首先要根据用户标示，和用户属于的角色的字符串来创建身份验证票
                    //创建身份验证票据
                    FormsAuthenticationTicket Ticket = new FormsAuthenticationTicket(
                        1,//设为1
                        "" + user.Admin_ID.ToString() + "," + user.Admin_username + "",//用户标示 一般用用户名
                        DateTime.Now,//Cookie 的发出时间, 设置为 DateTime.Now
                        DateTime.Now.AddMinutes(30),//过期时间
                        false,//是否持久性(根据需要设置,若是设置为持久性,在发出cookie时,cookie的Expires设置一定要设置)  为true表示后面生成身份验证票的Cookie存在 30分钟 ，关闭浏览器一样存在，而 false 则关闭浏览器则取消生成的身份验证票的Cookie存在
                        UserData,
                        //用户所属的角色字符串  如还有个 Users目录 让它可以访问则  admin,User  ,就是它可以访问的目录及以内的文件
                        //访问的是<allow roles="admin"/>
                        //
                        //Web.config文件里面我们设置了
                        //不允许访问的文件文件夹
                        //<location path="admin">//不允许匿名访问admin这个文件夹 必须登录有票据
                        //    <system.web>
                        //      <authorization>
                        //        <allow roles="admin"/>
                        //        <deny users="?"/>
                        //      </authorization>
                        //    </system.web>
                        //  </location>
                        FormsAuthentication.FormsCookiePath// 设为"/",这要同发出cookie的路径一致,因为刷新cookie要用这个路径
                    );
                    #endregion

                    #region 生成身份验证票的Cookie
                    //加密身份验证票据 
                    string HashTicket = FormsAuthentication.Encrypt(Ticket);
                    //生成创建要发送到客户端的cookie 
                    HttpCookie UserCookie = new HttpCookie(FormsAuthentication.FormsCookieName, HashTicket);
                    UserCookie.HttpOnly = true;//把加密后的Ticket 存储在Response Cookie中(客户端js不需要读取到这个Cookie，所以最好设置HttpOnly=True，防止浏览器攻击窃取、伪造Cookie)。这样下次可以从Request Cookie中读取了。

                    //FormsAuthentication.FormsCookieName 是用来获取web.config中设置的身份验证cookie的名字,缺省为" .ASPXAUTH".
                    //若身份验证票中的isPersistent属性设置为持久类,则这个cookie的Expires属性一定要设置,这样这个cookie才会被做为持久cookie保存到客户端的cookie文件中.
                    //是否持久性 为true则有下面的if语句
                    //if (Ticket.IsPersistent)
                    //{
                    //    UserCookie.Expires = Ticket.Expiration;
                    //}
                    #endregion

                    #region 将身份验证票Cookie输出到客户端
                    //将身份验证票Cookie附加到输出的cookie集合中,发送到客户端.
                    HttpContext.Current.Response.Cookies.Add(UserCookie);
                    #endregion

                    //方法 a) 指验证后返回请求页面，俗称“从哪来就打哪去”。比如：用户没登录前直接在 IE 地址栏
                    //输入 http://localhost/FormTest/UserInfo.aspx ，那么该用户将看到的是
                    //loginto.aspx?ReturnUrl=UserInfo.aspx ，输入用户名与密码登录成功后，系统将根据“ReturnUrl”的值，
                    //返回相应的页面
                    //Response.Redirect(Context.Request["ReturnUrl"]); // 重定向到用户申请的初始页面

                    //HttpContext.Current.Response.Redirect(LoginModel.Admin_SuccessJumppage);// 定向到某一个页面

                    if (Convert.ToInt32(username["alert"]) == 1)
                    {
                        return BPW.Response.alert("登录成功");
                    }
                    else
                    {
                        return "登录成功";
                    }

                    //Read_Js.JStx_Popupdialogbox1(page, "登录成功。", "JStx_Pagejump_A", "index.html", 2);
                }
                #endregion
            }
            #endregion
        }
    }
}
