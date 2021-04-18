using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
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
    [RefreshApiToken]
    public class ActionsController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly HttpClient _fc;

        public ActionsController(IConfiguration config, IStringLocalizer<SharedResource> localizer, IHttpClientFactory fc)
        {

            _configuration = config;
            _localizer = localizer;
            _fc = fc.CreateClient(name: "ApiRequests");

        }
        [HttpGet]
        public IActionResult OnlineTurn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetOnlineTurn([Bind("ServiceId,Info,ServiceDate,Files,FileNumber,ServiceTime")] OnlineQueryViewModel request,
                                                                                                             List<string> addtexts,
                                                                                                             IFormFileCollection addfiles,
                                                                                                             List<int> addnumbers,
                                                                                                             int fcount)
        {
            #region Service Prosess
            string parsedTime = request.ServiceDate.ToString("yyyy-MM-dd") + " " + request.ServiceTime;
            DateTime time = Convert.ToDateTime(parsedTime);
            var UserId = Convert.ToInt32(Request.Cookies["UserKey"]);
            OnlineQueryDTO data = new OnlineQueryDTO();
            data.UserId = UserId;
            data.Info = request.Info;
            data.ServiceDate = request.ServiceDate;
            data.ServiceId = request.ServiceId;
            data.ServiceDate = time;
            data.StartDate = DateTime.Now;

            data.ServiceAdditionFiles = new List<ServiceAdditionFile>();
            data.ServiceAdditionNumbers = new List<ServiceAdditionNumber>();
            data.ServiceAdditionTexts = new List<ServiceAdditionText>();

            AddServicesToQuery(data, addtexts, addnumbers);
            int datecompare = DateTime.Compare(data.StartDate, request.ServiceDate);
            if (datecompare >= 0)
            {
                TempData["ServerResponseError"] = _localizer["Please select valid hour"].ToString();
                return RedirectToAction("OnlineTurn");
            }
            List<PDFDTO> files = new List<PDFDTO>();
            List<ServiceAdditionFile> additionFiles = new List<ServiceAdditionFile>();
            if (addfiles != null)
            {
                if (fcount != addfiles.Count)
                {
                    TempData["ServerResponseError"] = _localizer["Please send all required files, because if files not send operation will be not succeeded."].ToString();
                    return RedirectToAction("OnlineTurn");
                }
                for (int i = 0; i < addfiles.Count; i++)
                {
                    var filename = FileManager.IFormSaveLocal(addfiles[i], "PDFFiles");
                    additionFiles.Add(new ServiceAdditionFile { Content = filename });
                }
                data.ServiceAdditionFiles = additionFiles;
            }



            ReturnMessage<object> response = new ServiceNode<OnlineQueryDTO, object>(_localizer, _fc)
                .PostClient(data, "/api/v1/users/online_query", HttpContext.Session.GetString("JwtSession"));
            if (response.IsCatched == 1)
            {
                TempData["ServerResponseError"] = response.Message;
                return View("OnlineTurn");
            }
            #endregion
            TempData["SuccessResponse"] = "Success";
            return Redirect("/");
        }

        [HttpPost("ActionsController/GetServiceAdditions")]
        public IActionResult GetServiceAdditions(int Id)
        {
            var model = new ServiceNode<object, List<ServiceAdditionsDTO>>(_fc).GetClient($"/api/v1/OurServices/Additions/{Id}");
            return Ok(model);
        }

        #region add service additions to online query
        public void AddServicesToQuery(OnlineQueryDTO onlineQuery, List<string> addtexts, List<int> addnumbers)
        {
            for (int i = 0; i < addtexts.Count; i++)
            {
                onlineQuery.ServiceAdditionTexts.Add(new ServiceAdditionText() { Content = addtexts[i] });
            }

            for (int i = 0; i < addnumbers.Count; i++)
            {
                onlineQuery.ServiceAdditionNumbers.Add(new ServiceAdditionNumber() { Content = addnumbers[i] });
            }
        }
        #endregion


    }
}
