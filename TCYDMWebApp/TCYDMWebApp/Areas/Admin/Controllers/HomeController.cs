using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using TCYDMWebApp.DTO;
using TCYDMWebApp.Filters;
using TCYDMWebApp.Helper;
using TCYDMWebApp.Libs;
using TCYDMWebApp.Repositories.Lang;
using TCYDMWebServices.Repositories;

namespace TCYDMWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminFilter]
    public class HomeController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public HomeController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetDocument(int id)
        {
            List<object> service = new ServiceNode<List<object>, List<object>>(_fc)
            .GetClient("api/v1/admin/getdocument/"+id).Data;
            var data = JsonConvert.SerializeObject(service);
            return Json(data);
        }

        public async Task<IActionResult> OnlineQuery(int page=1)
        {
            List<GetOnlineQueryDTO> query = new List<GetOnlineQueryDTO>();
            ViewBag.Page = page;
            using (var httpClient = new HttpClient())
            
            {
                using var reguest = await httpClient.GetAsync("http://localhost:45000/api/v1/admin/getonlinequery?page="+page);
                string response = await reguest.Content.ReadAsStringAsync();

                query = JsonConvert.DeserializeObject<List<GetOnlineQueryDTO>>(response);
            }
            return View(query);
        }

        public IActionResult StartQuery(string ToUser, string ToEmail, int id)
        {
            MailSender.SendEmail(
             _configuration["Mail-Key"].ToString(),
             _configuration["AdminEmail"].ToString(),
              ToUser.ToString(),
              ToEmail.ToString(),
             "About Your Query",
                "<p>Your query Accepted. We will be back as soon as possible See you soon! </p>".ToString(),
              _configuration["AdminEmail"].ToString(),
             _configuration["AdminPassword"].ToString()
             );
            OnlineQueryDTO service = new ServiceNode<OnlineQueryDTO, OnlineQueryDTO>(_fc)
            .GetClient("api/v1/admin/IsSeen/" + id).Data;
            return RedirectToAction("OnlineQuery");
        }

        public IActionResult EndQuery(string ToUser, string ToEmail, int id)
        {
            MailSender.SendEmail(
             _configuration["Mail-Key"],
             _configuration["AdminEmail"],
              ToUser,
              ToEmail,
             "Your query is completed",
                "<p>Your query is completed.</p>",
              _configuration["AdminEmail"],
             _configuration["AdminPassword"]
             );
            ReturnMessage<object> response = new ServiceNode<OnlineQueryDTO, object>(_localizer, _fc).DeleteClient("api/v1/admin/deleteonlinequery/" + id);
            return RedirectToAction("OnlineQuery");
        }

        public async Task<IActionResult> HomeView()
        {
           
            List<HomePage> home = new ServiceNode<object, List<HomePage>>(_fc).GetClient("/api/v1/admin/gethomeview").Data.OrderByDescending(u => u.Id).ToList();

            return View(home);
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
        public async Task<IActionResult> Create([Bind("Id,Photo,PhotoUpload")] HomePage home)
        {
            if (home.PhotoUpload.Length < (1024 * 1024) * 2 && (home.PhotoUpload.ContentType == "image/png" ||
                   home.PhotoUpload.ContentType == "image/svg+xml" ||
                   home.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(home.PhotoUpload, "home");
                home.Photo = filename;
            }
            List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
            .GetClient("api/lang/getlangs").Data;
            ViewBag.Lang = langs.Select(x => new SelectListItem
            {
                Text = x.langluageName,
                Value = x.id.ToString()
            });
            TempData["adminusername"] = Request.Cookies["adminusername"];
            ReturnMessage<object> response = new ServiceNode<HomePage, object>(_localizer, _fc).PostClient(home, "/api/v1/admin/addhomeview");
            return RedirectToAction("homeview");
        }

        

        //Get Edit Doctor
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            HomePage home = new HomePage();

            using (var httpClient = new HttpClient())
            {
                using var reguest = await httpClient.GetAsync($"http://localhost:5000/api/v1/admin/gethomeview/{id}");
                string response = await reguest.Content.ReadAsStringAsync();

                home = JsonConvert.DeserializeObject<HomePage>(response);

            }
            
            return View(home);
        }

        //Post Edit Doctor
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,Photo,PhotoUpload")] HomePage home, int id)
        {
            if (home.PhotoUpload.Length < (1024 * 1024) * 2 && (home.PhotoUpload.ContentType == "image/png" ||
                  home.PhotoUpload.ContentType == "image/svg+xml" ||
                  home.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(home.PhotoUpload, "home");
                home.Photo = filename;
            }
            ReturnMessage<object> response = new ServiceNode<ServiceInfo, object>(_localizer, _fc).PutClient(home, "/api/v1/admin/edithomeview/" + id);
            if (response.IsCatched == 1)
            {
                List<Lang> langs = new ServiceNode<Lang, List<Lang>>(_fc)
                .GetClient("api/lang/getlangs").Data;
                ViewData["ServerResponseError"] = response.Message;

            }
            TempData["adminusername"] = Request.Cookies["adminusername"];
            return RedirectToAction("homeview");
        }


        //delete

        public async Task<IActionResult> Delete(int id)
        {
            ReturnMessage<object> response = new ServiceNode<HomePage, object>(_localizer, _fc).DeleteClient("/api/v1/admin/deletehomeview/" + id);
            return RedirectToAction("homeview");
        }
    }
}
