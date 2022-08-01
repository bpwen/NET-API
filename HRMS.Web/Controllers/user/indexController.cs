using System;
using System.Collections.Generic;
using System.Web.Http;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using HRMS.Web.Models;
using System.Text;

namespace HRMS.Web.Controllers.user
{
    public class indexController : ApiController
    {
        #region 【获取首页导航栏目】
        /// <summary>
        /// 获取自定义标签
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public TokenInfo login([FromBody] LoginRequest loginRequest)
        {
            //return json.parse(user.admin_Login());

            TokenInfo tokenInfo = new TokenInfo();//需要返回的口令信息

            if (loginRequest != null)
            {
                string userName = loginRequest.UserName;
                string passWord = loginRequest.Password;
                bool isAdmin = (userName == "admin") ? true : false;
                //模拟数据库数据，真正的数据应该从数据库读取
                //身份验证信息
                AuthInfo authInfo = new AuthInfo { UserName = userName, Roles = new List<string> { "admin", "commonrole" }, IsAdmin = isAdmin, ExpirationTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") };
                const string secretKey = "To Live is to change the world";//口令加密秘钥
                try
                {
                    byte[] key = Encoding.UTF8.GetBytes(secretKey);
                    IJwtAlgorithm algorithm = new HMACSHA256Algorithm();//加密方式
                    IJsonSerializer serializer = new JsonNetSerializer();//序列化Json
                    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//base64加解密
                    IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);//JWT编码
                    var token = encoder.Encode(authInfo, key);//生成令牌
                    //口令信息
                    tokenInfo.Success = true;
                    tokenInfo.Token = token;
                    tokenInfo.Message = "OK";
                }
                catch (Exception ex)
                {
                    tokenInfo.Success = false;
                    tokenInfo.Message = ex.Message.ToString();
                }
            }
            else
            {
                tokenInfo.Success = false;
                tokenInfo.Message = "用户信息为空";
            }
            return tokenInfo;


        }
        #endregion
    }
}