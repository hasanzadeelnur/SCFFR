using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TCYDMWebApp.Models;
using TCYDMWebApp.Repositories.Lang;

namespace TCYDMWebApp.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public ErrorController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }
        [HttpGet("/Error/{statuscode}")]
        public IActionResult ExceptionHandler(int statuscode)
        {
            ViewData["ErrorCode"] = statuscode;
            switch (statuscode)
            {
                case 404:
                    
                    ViewData["ErrorMessage"] = _localizer["Page is not found"].ToString();
                    break;
                case 500:
                    ViewData["ErrorMessage"] = _localizer["There is problem with server, try again later"].ToString();
                    break;
                default:
                    ViewData["ErrorMessage"] = _localizer["There is problem with server, try again later"].ToString();
                    break;
            }
            return View("GlobalException");

        }
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.Message = exception.Error.Message;
            return View("Error");
        }
    }
}
