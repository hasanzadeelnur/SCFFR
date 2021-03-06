using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Filters;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Models;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebApp.ViewModels;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly HttpClient _fc;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, IStringLocalizer<SharedResource> localizer, IHttpClientFactory fc)
        {
            _logger = logger;
            _configuration = config;
            _localizer = localizer;
            _fc = fc.CreateClient(name: "ApiRequests");

        }
        public IActionResult Index()
        {
            IEnumerable<HomePage> home = new List<HomePage>();         
                home = new ServiceNode<object, IEnumerable<HomePage>>(_fc)
               .GetClient("/api/v1/admin/gethomeview").Data?.OrderByDescending(m=>m.Id);
            return View(home);
        }

        [HttpGet("/home/services/{serviceId}")]
        public IActionResult ServiceInfo(int serviceId)
        {
            #region ServiceData
                        int langId = 1;

                        if (Request.Cookies["LangKey"] != null)
                        {
                            langId = Convert.ToInt32(Request.Cookies["LangKey"]);
                        }
                        OurServicesDTO prms = new OurServicesDTO();
                        ServiceInfo service = new ServiceInfo();
                        Task tsk1 = Task.Factory.StartNew(() =>
                        {
                            prms = new ServiceNode<object, OurServicesDTO>(_fc)
                           .GetClient("/api/v1/OurServices/OurServicesGetById/"+ serviceId +"/" + langId).Data;
                        });
                        Task tsk2 = Task.Factory.StartNew(() =>
                        {
                            service = new ServiceNode<object, ServiceInfo>(_fc)
                           .GetClient("/api/v1/serviceinfo/get/"+serviceId+"/" + langId).Data;
                        });
                        Parallel.Invoke();
                        tsk1.Wait();
                        tsk2.Wait();
                        ServiceInfoViewModel model = new ServiceInfoViewModel();
                        model.ServiceInfo = service;
                        model.ServiceParams = prms;
                        #endregion
            return View("ServiceInfo", model);
        }

        [HttpGet]
        public IActionResult WhatWeDo()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            WhatWeDoDTO model = new ServiceNode<object, WhatWeDoDTO>(_fc)
                   .GetClient("/api/v1/WhatWeDo/WhatWeDoGet/"+langId).Data;

            #endregion
            return View(model);     
        }

        [HttpGet]
        public IActionResult WhoWeAre()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            WhoWeAreDTO model = new ServiceNode<object, WhoWeAreDTO>(_fc)
                   .GetClient("/api/v1/WhoWeAre/WhoWeAreGet/" + langId).Data;

            #endregion
            return View(model);
        }

        public IActionResult OurVision()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            VMVDTO model = new ServiceNode<object, VMVDTO>(_fc)
                   .GetClient("/api/v1/vision/getbylang/" + langId).Data;

            #endregion
            return View(model);
        }
        public IActionResult OurMission()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            VMVDTO model = new ServiceNode<object, VMVDTO>(_fc)
                   .GetClient("/api/v1/vision/getbylang/" + langId).Data;

            #endregion
            return View(model);
        }
        public IActionResult OurValues()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            VMVDTO model = new ServiceNode<object, VMVDTO>(_fc)
                   .GetClient("/api/v1/vision/getbylang/" + langId).Data;

            #endregion
            return View(model);
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            #region ServiceData
            int langId = 1;

            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            ContactUsDTO model = new ServiceNode<object, ContactUsDTO>(_fc)
           .GetClient("/api/v1/ContactUs/ContactUsGet/" + langId).Data;

            #endregion
            return View(model);
        }

        [HttpGet]
        public IActionResult Blog(int page=1)
        {
            #region ServiceData
            int langId = 1;
            ViewBag.Page = page;
            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }

            BlogsDTO model = new ServiceNode<object, BlogsDTO>(_fc)
           .GetClient("/api/v1/Blog/BlogGet/"+ langId + "/"+page).Data;

            #endregion
            return View(model);
        }

        [HttpGet]
        public IActionResult SingleBlog(int id)
        {

            BlogFindDTO model = new ServiceNode<object, BlogFindDTO>(_fc)
             .GetClient("/api/v1/Blog/BlogGetId/" + id).Data;
            ViewBag.Photo = model.Blog.ImagePath;
            ViewBag.Title = model.Blog.Header;
            return View(model);
        }

        [HttpGet]
        public IActionResult OurTeam()
        {
            int langId = 1;
            if (Request.Cookies["LangKey"] != null)
            {
                langId = Convert.ToInt32(Request.Cookies["LangKey"]);
            }
            List<OurTeam> model = new ServiceNode<object, List<OurTeam>>(_fc)
            .GetClient("/api/v1/OurTeam/OurTeamGet/"+langId).Data;
            return View(model);
        }


        [HttpPost]
        public IActionResult SetLanguage([FromForm] LangDTO request)
        {
            #region SetLangCookie
            var resp = new ServiceNode<object, Lang>(_localizer, _fc).GetClient("/api/lang/get/"+request.culture);
              Response.Cookies.Append("LangKey",resp.Data.id.ToString(),
              new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) });
              Response.Cookies.Append(
              CookieRequestCultureProvider.DefaultCookieName,
              CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(resp.Data.valueKey)),
              new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) }
          );
            #endregion
            return LocalRedirect(request.returnurl);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.Message = exception.Error.Message;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
