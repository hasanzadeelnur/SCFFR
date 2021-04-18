using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Filters;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminFilter]
    public class WhatWeDoController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public WhatWeDoController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            List<WhatWeDoAppDTO> whos = new List<WhatWeDoAppDTO>();
            whos = new ServiceNode<WhatWeDoAppDTO, List<WhatWeDoAppDTO>>(_fc)
            .GetClient("/api/v1/WhatWeDo/WhatWeDoGetAll").Data;
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WhatWeDoDTO request)
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
            ReturnMessage<object> response = new ServiceNode<WhatWeDoDTO, object>(_localizer, _fc).PostClient(request, "/api/v1/WhatWeDo/WhatWeDoAdd");
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            WhatWeDoDTO whos = new ServiceNode<WhatWeDoDTO, WhatWeDoDTO>(_fc)
            .GetClient("api/v1/WhatWeDo/WhatWeDoGetId/" + id).Data;
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            return View(whos);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(WhatWeDoDTO request)
        {
            ViewBag.Lang = null;
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
            ReturnMessage<object> response = new ServiceNode<WhatWeDoDTO, object>(_localizer, _fc).PutClient(request, "/api/v1/WhatWeDo/WhatWeDoUpdate");
            if (response.IsCatched == 1)
            {

                ViewData["ServerResponseError"] = response.Message;
                return RedirectToAction("Edit", request);
            }
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<WhatWeDoDTO, object>(_localizer, _fc).DeleteClient("/api/v1/WhatWeDo/WhatWeDoDelete/" + id);
            return RedirectToAction("Index");
        }
    }
}
