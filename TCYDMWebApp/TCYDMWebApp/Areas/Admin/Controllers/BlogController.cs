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
    public class BlogController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public BlogController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ReturnMessage<List<BlogDTO>> response = new ServiceNode<object, List<BlogDTO>>(_fc)
            .GetClient("/api/v1/Blog/BlogAll");
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
        public IActionResult Create(BlogAddDTO request)
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
            Blog add = new Blog { Body = request.Body, Header = request.Header,Date=DateTime.Now,LanguageId=request.LanguageId,View=0 };
            if (request.Image.Length < (1024 * 1024) * 2 && (request.Image.ContentType == "image/png" ||
       request.Image.ContentType == "image/svg+xml" ||
       request.Image.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(request.Image, "blog");
                add.ImagePath = filename;
            }

            ReturnMessage<object> response = new ServiceNode<Blog, object>(_localizer, _fc).PostClient(add, "api/v1/Blog/BlogAdd");
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
            Blog blog = new ServiceNode<object, Blog>(_fc)
           .GetClient("api/v1/Blog/BlogGetAdminId/" + id).Data;
            BlogUpdateDTO blog1 = new BlogUpdateDTO() { Body = blog.Body, Header = blog.Header, Id = blog.Id, ImagePath = blog.ImagePath, LanguageId = blog.LanguageId };
            return View(blog1);
        }
        [HttpPost]
        public IActionResult Edit(BlogUpdateDTO request)
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


            Blog add = new Blog { Body = request.Body, Header = request.Header, Date = DateTime.Now, LanguageId = request.LanguageId,Id=request.Id};
            if (request.Image.Length < (1024 * 1024) * 2 && (request.Image.ContentType == "image/png" ||
               request.Image.ContentType == "image/svg+xml" ||
               request.Image.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(request.Image, "blog");
                add.ImagePath = filename;
            }
            ReturnMessage<object> response = new ServiceNode<Blog, object>(_localizer, _fc)
            .PutClient(add, "/api/v1/blog/BlogUpdate");
            if (response.Code == 200)
            {
                return RedirectToAction("Index");
            }
            return View(request);
        }
        public IActionResult Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<Blog, object>(_localizer, _fc)
           .DeleteClient("/api/v1/blog/BlogDelete/" + id);
            TempData["Error"] = null;
            if (response.Code != 200)
            {
                TempData["Error"] = response.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
