using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace Zeynep.Ecommerse.BusinessLogic.Authentication
{
    public class TokenAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public bool AllowMultiple => false;


        public TokenAuthenticationFilter()
        {
            
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            /*if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var tokenManager = context.HttpContext.RequestServices.GetService(typeof(ITokenManager)) as ITokenManager;

            var token = context.HttpContext.Request.Headers.First(x => x.Key == "Authorization").Value;
            try
            {
                tokenManager.VerifyToken(token);
            }
            catch
            {
                context.Result = new UnauthorizedResult();
                return;
            }*/
        }
    }
}
