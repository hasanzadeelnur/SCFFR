using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Filters;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminFilter]
    public class VisionMissionValuesController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public VisionMissionValuesController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ReturnMessage< List<VMCDTO>> response = new ServiceNode<object, List<VMCDTO>>(_fc)
            .GetClient("/api/v1/vision/getall");
            return View(response.Data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
             .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMVDTO request)
        {

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
            ReturnMessage<object> response = new ServiceNode<VMVDTO, object>(_localizer, _fc).PostClient(request, "api/v1/vision/post");
            if(response.Code==200)
            {
                return RedirectToAction("Index");
            }    
            else
            {
                ViewBag.Error = response.Message.ToString();
                return View(request);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
             .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            VMVDTO response = new VMVDTO();
            response = new ServiceNode<object, VMVDTO>(_fc)
            .GetClient("/api/v1/vision/getbyid/"+id).Data;
            return View(response);
        }
        [HttpPost]
        public IActionResult Edit(VMVDTO request)
        {
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
             .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            if(!ModelState.IsValid)
            {
                return View(request);
            }

            ReturnMessage<object> response = new ServiceNode<VMVDTO, object>(_localizer,_fc)
            .PutClient(request,"/api/v1/vision/put/");
            if(response.Code==200)
            {
                return RedirectToAction("Index");
            }
            return View(request);
        }
        public IActionResult Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<VMVDTO, object>(_localizer,_fc)
           .DeleteClient("/api/v1/vision/delete/"+id);
            TempData["Error"] = null;
            if (response.Code!=200)
            {
                TempData["Error"] = response.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
