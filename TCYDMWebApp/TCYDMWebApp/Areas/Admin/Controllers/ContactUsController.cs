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
    public class ContactUsController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public ContactUsController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            List<ContactUsAppDTO> response = new List<ContactUsAppDTO>();
            response = new ServiceNode<ContactUsAppDTO, List<ContactUsAppDTO>>(_fc)
            .GetClient("/api/v1/ContactUs/ContactUsGetAll").Data;
            return View(response);
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
        public async Task<IActionResult> Create(ContactUsDTO request)
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
            ReturnMessage<object> response = new ServiceNode<ContactUsDTO, object>(_localizer, _fc).PostClient(request, "/api/v1/ContactUs/ContactUsAdd");
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            ContactUsDTO response = new ServiceNode<ContactUsDTO, ContactUsDTO>(_fc)
            .GetClient("api/v1/ContactUs/ContactUsGetId/" + id).Data;
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ContactUsDTO request)
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
            ReturnMessage<object> response = new ServiceNode<ContactUsDTO, object>(_localizer, _fc).PutClient(request, "/api/v1/ContactUs/ContactUsUpdate");
            if (response.IsCatched == 1)
            {
                ViewData["ServerResponseError"] = response.Message;
                return RedirectToAction("Edit", request);
            }
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<ContactUsDTO, object>(_localizer, _fc).DeleteClient("/api/v1/ContactUs/ContactUsDelete/" + id);
            return RedirectToAction("Index");
        }
    }
}
