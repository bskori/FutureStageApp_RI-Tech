using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.CustFilter
{
    public class SchoolAuth : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("SchoolID") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Action = "doLogin", Controller = "ManageSchool",Area="" }));
            }
        }
    }
}
