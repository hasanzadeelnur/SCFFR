using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories;
using TCYDMWebServices.Repositories.Abstracts;
using TCYDMWebServices.Repositories.Enums;

namespace TCYDMWebServices.Controllers.V1
{
    [Route("api/v1/serviceinfo")]
    [ApiController]
    public class ServiceInfoController : ControllerBase
    {
        private readonly DatabaseContext _db;
        private readonly ITransactions<ServiceInfo> _wwd;
        public ServiceInfoController(DatabaseContext db, ITransactions<ServiceInfo> wwd)
        {
            _wwd = wwd;
            _db = db;
        }
        [HttpGet("get/{langId}")]
        public IActionResult ServicesGet(int langId)
        {
            return Ok(new ReturnMessage(data: _db.serviceinfos.Where(a => a.LanguageId == langId).ToList()));
        }
        [HttpGet("getid/{id}")]
        public IActionResult ServicesGetById(int id)
        {
            return Ok(new ReturnMessage(data: _db.serviceinfos.Find(id)));
        }
        [HttpGet("getidfull/{id}/{lang}")]
        public IActionResult ServicesGetByIdFull(int id,int lang)
        {
            Service service = _db.services.Include(t=>t.ServiceAdditions).FirstOrDefault(t => t.ServiceId == id && t.LanguageId == lang);
            List<AddServiceAddition> addServices = service.ServiceAdditions.Select(t => new AddServiceAddition { InputId = t.InputId, PlaceHolder = t.PlaceHolder }).ToList();
            ServiceInfo serviceinfo = _db.serviceinfos.FirstOrDefault(t => t.ServiceId == id && t.LanguageId == lang);
            AddServices response = new AddServices { Id = service.Id, IsLocal = service.IsLocal, ServiceId = service.ServiceId, LanguageId = service.LanguageId, Name = service.Name, NeedsAdittion = service.NeedsAdittion, NeedsPayment = service.NeedsPayment, ServiceAdditions = addServices, Info = serviceinfo.Info };
            return Ok(new ReturnMessage(data: response));
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IEnumerable<ServiceInfoApp> serviceInfoApp = from service in _db.serviceinfos
                                                         join langluage in _db.languages on service.LanguageId equals langluage.Id
                                                         select new ServiceInfoApp
                                                         {
                                                             Id = service.Id,
                                                             Name = service.Name,
                                                             Info = service.Info,
                                                             ServiceId = service.ServiceId,
                                                             Language = langluage.LangluageName,
                                                             LanguageId=service.LanguageId
                                                         };
            return Ok(new ReturnMessage(data: serviceInfoApp));
        }
        [HttpGet("get/{serviceId}/{langId}")]
        public IActionResult ServicesGetById(int serviceId,int langId)
        {
            return Ok(new ReturnMessage(data: _db.serviceinfos.Where(a => a.LanguageId == langId && a.ServiceId == serviceId).FirstOrDefault()));
        }
        [HttpPost("add")]
        public IActionResult ServiceInfoAdd([FromBody] AddServices request)
        {
            if(request.ServiceId==0 ||request.ServiceId==null)
            {
                int? b = _db.services?.Max(s => s.ServiceId);
                if(b==null)
                {
                    b = 0;
                }
                request.ServiceId = b+1;
            }
            #region FunctionBody
            bool langluagename = _db.serviceinfos.Any(t => t.LanguageId == request.LanguageId && t.Name == request.Name);

            if (langluagename)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.AlreadyExists, message: "This is exists"));
            }
            List<ServiceAddition> serviceaddition = new List<ServiceAddition>();
            if(request.ServiceAdditions!=null)
            {
                List<AddServiceAddition> addserviceaddition = request.ServiceAdditions.ToList();
                foreach (var item in addserviceaddition)
                {
                    ServiceAddition c = new ServiceAddition { ServiceId = request.ServiceId, InputId = item.InputId, PlaceHolder = item.PlaceHolder };
                    serviceaddition.Add(c);
                };
            }

            int? serviceid = _db.services.ToList().LastOrDefault()?.Id + 1;
            if(serviceid==null)
            {
                serviceid = 1;
            }
            Service service = new Service()
            {
                IsLocal = request.IsLocal,
                Name = request.Name,
                LanguageId = request.LanguageId,
                NeedsAdittion = request.NeedsAdittion,
                ServiceAdditions = serviceaddition,
                NeedsPayment = request.NeedsPayment,
                ServiceId=request.ServiceId
            };
            _db.services.Add(service);
            ServiceInfo serviceInfo = new ServiceInfo()
            {
                Name = request.Name,
                ServiceId = request.ServiceId,
                Info = request.Info,
                LanguageId = request.LanguageId
            };
            bool data = _wwd.Add(serviceInfo);
            _db.SaveChanges();
            if (data)
            {
                return StatusCode(200, new ReturnMessage(message: "Created"));
            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, code: 500));
            #endregion
        }

        [HttpDelete("delete/{id}/{lang}")]
        public IActionResult ServicesDelete(int id, int lang)
        {
            bool datafound = _db.serviceinfos.Any(t => t.ServiceId == id && t.LanguageId == lang);
            if (!datafound)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            ServiceInfo data = _db.serviceinfos.FirstOrDefault(t=>t.ServiceId==id && t.LanguageId==lang);
            
            bool request = _wwd.Delete(data);
            if (request)
            { 
                return Ok(new ReturnMessage(200, message: "Success"));
            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Internal server error"));
        }

        [HttpPut("update")]
        public IActionResult ServicesUpdate(AddServices request)
        {
            try
            {
                bool data = _db.serviceinfos.Any(t => t.ServiceId == request.ServiceId);

                if (!data)
                {
                    return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
                }
                bool langluagename = _db.serviceinfos.Any(t => t.LanguageId == request.LanguageId && t.Name == request.Name);
                if (langluagename)
                {
                    return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.AlreadyExists, message: "AlreadyExists"));
                }
                Service service = _db.services.Include(t => t.ServiceAdditions).FirstOrDefault(t => t.ServiceId == request.ServiceId && t.LanguageId == request.LanguageId);
                if (service == null)
                {
                    service = _db.services.Include(t => t.ServiceAdditions).FirstOrDefault(t => t.ServiceId == request.ServiceId);
                }


                List<ServiceAddition> additions = _db.serviceadditions.Where(g => g.ServiceId == service.Id).ToList();

                if (additions != null)
                {
                    foreach (var item in additions)
                    {
                        _db.serviceadditions.Remove(item);
                        _db.SaveChanges();
                    }
                }
                List<ServiceAddition> addServices = request.ServiceAdditions.Select(t => new ServiceAddition { InputId = t.InputId, PlaceHolder = t.PlaceHolder, ServiceId = request.ServiceId }).ToList();


                service.IsLocal = request.IsLocal;
                service.ServiceId = request.ServiceId;
                service.LanguageId = request.LanguageId;
                service.Name = request.Name;
                service.NeedsAdittion = request.NeedsAdittion;
                service.NeedsPayment = request.NeedsPayment;
                service.ServiceAdditions = addServices;

                _db.SaveChanges();
                ServiceInfo serviceinfo = _db.serviceinfos.FirstOrDefault(t => t.ServiceId == request.ServiceId && t.LanguageId == request.LanguageId);

                serviceinfo.ServiceId = request.ServiceId;
                serviceinfo.LanguageId = request.LanguageId;
                serviceinfo.Name = request.Name;
                serviceinfo.Info = request.Info;
                _db.SaveChanges();
                return Ok(new ReturnMessage());
            }
            catch(Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Error Internal Server"));
            }         
        }
    }
}
