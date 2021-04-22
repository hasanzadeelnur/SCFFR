using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TCYDMWebApp.Areas.Admin.Models;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Filters;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Models;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminFilter]
    public class ServicesController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public ServicesController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            List<ServiceInfoApp> whos = new List<ServiceInfoApp>();
            whos = new ServiceNode<ServiceInfoApp, List<ServiceInfoApp>>(_fc)
            .GetClient("/api/v1/serviceinfo/getall").Data;
            return View(whos);
        }
        public async Task<IActionResult> Create()
        {
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            List<Service> services = new ServiceNode<Service, List<Service>>(_fc)
            .GetClient("api/v1/OurServices/OurServicesGet").Data;
             ViewBag.Services = services.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ServiceId.ToString()
            });
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddServices request)
        {
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            if (request.ServiceAdditions==null || request.ServiceAdditions.Count>0)
            {
                request.NeedsAdittion = 1;
            }

            List<Service> services = new ServiceNode<Service, List<Service>>(_fc)
            .GetClient("api/v1/OurServices/OurServicesGet").Data;
            ViewBag.Services = services.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ServiceId.ToString()
            }); 
            if (!ModelState.IsValid)
            {
                return View(request);
            }
                ReturnMessage<object> response = new ServiceNode<AddServices, object>(_localizer, _fc).PostClient(request, "/api/v1/serviceinfo/add");
            if(response.Code!=200)
            {
                ViewBag.Error = response.Message;
                return View(request);
            }
                return RedirectToAction("index");
        }
        [HttpGet]
        [Route("Admin/Services/Edit/{id}/{lang}")]
        public async Task<IActionResult> Edit(int id,int lang)
        {
            AddServices service = new ServiceNode<AddServices, AddServices>(_fc)
            .GetClient("api/v1/serviceinfo/getidfull/" + id+"/"+lang).Data;
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddServices request)
        {
            ViewBag.Lang = null;
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            if (request.ServiceAdditions != null)
            {
                if(request.ServiceAdditions.Count > 0)
                {
                    request.NeedsAdittion = 1;
                }
            }
            if(!ModelState.IsValid)
            {
                return View(request);
            }
            ReturnMessage<object> response = new ServiceNode<AddServices, object>(_localizer, _fc).PutClient(request, "/api/v1/serviceinfo/update");
            if (response.IsCatched == 1)
            {

                ViewData["ServerResponseError"] = response.Message;
                return View(request);
            }
            return RedirectToAction("index");
        }
        [Route("Admin/Services/Delete/{id}/{lang}")]
        public async Task<IActionResult> Delete(int id, int lang)
        {
            ReturnMessage<object> response2 = new ServiceNode<OurServicesDTO, object>(_localizer, _fc).DeleteClient("/api/v1/OurServices/OurServicesDelete/" + id + "/" + lang);
            if(response2.Code!=200)
            {
                TempData["ErrorMessage"] = "Servis Sorğuda hal-hazırda işlənir";
                return RedirectToAction("Index");
            }
            ReturnMessage<object> response = new ServiceNode<ServiceInfo, object>(_localizer, _fc).DeleteClient("/api/v1/serviceinfo/delete/" + id+"/"+lang);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Info(int id)
        {
            ServiceInfo service = new ServiceNode<ServiceInfo, ServiceInfo>(_fc)
            .GetClient("api/v1/serviceinfo/getid/" + id).Data;
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            return View(service);
        }
    }
}

