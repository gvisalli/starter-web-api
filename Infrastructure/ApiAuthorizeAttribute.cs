using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace StarternWebApi.Infrastructure
{
    public class ApiAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
                throw new Exception("Invalid Token or Token Expired.");


        }
    }
}
