using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TCYDMWebApp.Filters
{
    public class AdminFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("Middleware Started");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            
            if (context.HttpContext.User.FindFirstValue(System.Security.Claims.ClaimTypes.Role) != "Admin")
            {
                context.Result = new RedirectToRouteResult(
                   new RouteValueDictionary
                   {
                    { "controller", "Login" },
                    { "action", "Index" }
                   });
            }
        }
    }
}
