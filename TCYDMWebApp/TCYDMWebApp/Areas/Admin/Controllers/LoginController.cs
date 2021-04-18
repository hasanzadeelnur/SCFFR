using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public LoginController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            string UserKey = Request.Cookies["UserKey"];
            if(UserKey!=null)
            {
                return NotFound();
            }
            if (HttpContext.User.FindFirst(System.Security.Claims.ClaimTypes.Role) != null)
            {
                    return RedirectToAction("OnlineQuery", "Home");
            }

                return View();
        }
        [HttpPost]
        public IActionResult Index(AdminTable request)
        {
            ReturnMessage<AdminTable> response = new ServiceNode<AdminTable, AdminTable>(_localizer, _fc).PostClient(request, "/api/v1/admin/AdminLogin");
            if (response.IsCatched==1)
            {
                return View();
            }
                if (response.IsCatched==0)
                {
                    #region Clear Cookies
                    Response.Cookies.Delete("UserKey");
                    Response.Cookies.Delete("email");
                    Response.Cookies.Delete("name");
                    Response.Cookies.Delete("surname");
                    Response.Cookies.Delete("refreshToken");
                    Response.Cookies.Delete("jwtToken");
                    Response.Cookies.Delete("cId");
                    Response.Cookies.Delete("rId");
                    #endregion
                    ClaimsIdentity identity = null;
                    identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Role,"Admin")
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                    var Principal = new ClaimsPrincipal(identity);

                    var Adminlogin = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Principal);
                    TempData["Adminusername"] = response.Data.Username;
                }
                return RedirectToAction("OnlineQuery", "Home");
        }
    }
}
