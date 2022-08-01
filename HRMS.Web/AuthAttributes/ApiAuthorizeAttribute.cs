using HRMS.Web.Models;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;

/// <summary>
/// 权限拦截器
/// </summary>
namespace HRMS.Web.AuthAttributes
{
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var authHeader = from t in actionContext.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();
            if (authHeader != null)
            {
                string token = authHeader.FirstOrDefault();
                if (!string.IsNullOrEmpty(token))
                {
                    try
                    {
                        const string secret = "To Live is to change the world";
                        //secret需要加密
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                        IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                        var json = decoder.DecodeToObject<AuthInfo>(token, secret, verify: true);
                        if (json != null)
                        {
                            if (Convert.ToDateTime(json.ExpirationTime) < DateTime.Now.AddHours(2) && !string.IsNullOrEmpty(json.ExpirationTime))
                            {
                                actionContext.RequestContext.RouteData.Values.Add("auth", json);
                                return true;
                            }
                            else return true;
                        }
                        return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}