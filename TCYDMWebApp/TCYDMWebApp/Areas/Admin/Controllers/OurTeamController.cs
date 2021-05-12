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
using TCYDMWebApp.Libs;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurTeamController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public OurTeamController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ReturnMessage<List<OurTeamDTO>> response = new ServiceNode<object, List<OurTeamDTO>>(_fc)
            .GetClient("/api/v1/OurTeam/OurTeamAll");
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
        public IActionResult Create(OurTeamAddDTO request)
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
            OurTeam add = new OurTeam { FullName = request.FullName, Job = request.Job,LanguageId=request.LanguageId };
            if (request.Image.Length < (1024 * 1024) * 2 && (request.Image.ContentType == "image/png" ||
       request.Image.ContentType == "image/svg+xml" ||
       request.Image.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(request.Image, "team");
                add.ImagePath = filename;
            }

            ReturnMessage<object> response = new ServiceNode<OurTeam, object>(_localizer, _fc).PostClient(add, "api/v1/OurTeam/OurTeamAdd");
            if (response.Code == 200)
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
            OurTeam blog = new ServiceNode<object, OurTeam>(_fc)
           .GetClient("api/v1/OurTeam/OurTeamGetId/" + id).Data;
            OurTeamAddDTO blog1 = new OurTeamAddDTO() { FullName = blog.FullName, Job = blog.Job, Id = blog.Id, ImagePath = blog.ImagePath, LanguageId = blog.LanguageId };
            return View(blog1);
        }
        [HttpPost]
        public IActionResult Edit(OurTeamAddDTO request)
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
            OurTeam add = new OurTeam { FullName = request.FullName, Job = request.Job,LanguageId=request.LanguageId,Id=request.Id };
            if (request.Image.Length < (1024 * 1024) * 2 && (request.Image.ContentType == "image/png" ||
       request.Image.ContentType == "image/svg+xml" ||
       request.Image.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(request.Image, "team");
                add.ImagePath = filename;
            }

            ReturnMessage<object> response = new ServiceNode<OurTeam, object>(_localizer, _fc).PutClient(add, "api/v1/OurTeam/OurTeamUpdate");
            if (response.Code == 200)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = response.Message.ToString();
                return View(request);
            }
        }
        public IActionResult Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<OurTeam, object>(_localizer, _fc)
           .DeleteClient("/api/v1/OurTeam/OurTeamDelete/" + id);
            TempData["Error"] = null;
            if (response.Code != 200)
            {
                TempData["Error"] = response.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
