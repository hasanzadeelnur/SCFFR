using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories;
using TCYDMWebServices.Repositories.Abstracts;
using TCYDMWebServices.Repositories.Enums;
using TCYDMWebServices.Repositories.Filters;
using TCYDMWebServices.Repositories.Repos;

namespace TCYDMWebServices.Controllers.V1
{
    [Validator]
    [Route("api/v1/OurServices")]
    [ApiController]
    public class OurServicesController : ControllerBase
    {
        private readonly DatabaseContext _db;
        private readonly ITransactions<OurServicesDTO> _wwd;
        public OurServicesController(DatabaseContext db, ITransactions<OurServicesDTO> wwd)
        {
            _wwd = wwd;
            _db = db;
        }

        [HttpGet("OurServicesGet/{langId}")]
        public IActionResult OurServicesGet(int langId)
        {
            var services = _db.services.Where(a => a.LanguageId == langId).ToList().OrderBy(a => a.ServiceId);
            return Ok(new ReturnMessage(data: services));
        }

        [HttpGet("OurServicesGet")]
        public IActionResult OurServicesGet()
        {
            List<Service> db = _db.services.ToList();
            List<Service> services = db.GroupBy(t => t.ServiceId)
                      .Select(t => t.First())
                      .ToList();
            return Ok(new ReturnMessage(data: services));
        }

        [HttpGet("OurServicesGetById/{serviceId}/{langId}")]
        public IActionResult GetServiceById(int serviceId, int langId)
        {
            return Ok(new ReturnMessage(_db.services.Where(a => a.LanguageId == langId && a.ServiceId == serviceId).FirstOrDefault()));
        }

        [HttpPost("OurServicesAdd")]
        public IActionResult WhatWeDoAdd([FromBody] OurServicesDTO request)
        {
            #region FunctionBody
            bool langluagename = _db.services.Any(t => t.LanguageId == request.LanguageId && t.Name == request.Name);
            if (langluagename)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.AlreadyExists, message: "This is exists"));
            }
            bool data = _wwd.Add(request);
            if (data)
            {
                return StatusCode(200, new ReturnMessage(message: "Created"));

            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, code: 500));
            #endregion
        }

        [HttpDelete("OurServicesDelete/{id}/{lang}")]
        public IActionResult OurServicesDelete(int id,int lang)
        {
            Service data = _db.services.Include(t => t.ServiceAdditions).FirstOrDefault(t => t.ServiceId == id && t.LanguageId == lang);
            bool query = _db.onlinequeries.Any(t => t.ServiceId == data.Id);
            if (query)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            bool datafound = _db.services.Any(t => t.ServiceId == id&& t.LanguageId == lang);
            if (!datafound)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }

            try
            {
                if(data.ServiceAdditions.Count>0)
                {
                    foreach (var item in data.ServiceAdditions)
                    {
                        _db.serviceadditions.Remove(item);

                    }
                    _db.SaveChanges();
                }
                _db.services.Remove(data);
                _db.SaveChanges();
                return Ok(new ReturnMessage());
            }
            catch (Exception x )
            {
                return BadRequest(new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, x.Message));
            }
        }

        [HttpPut("OurServicesUpdate")]
        public IActionResult OurServicesUpdate([FromBody] OurServicesDTO request)
        {
            bool data = _db.services.Any(t => t.Id == request.Id);

            if (!data)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            bool langluagename = _db.services.Any(t => t.LanguageId == request.LanguageId && t.Name == request.Name);
            if (langluagename)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.AlreadyExists, message: "AlreadyExists"));
            }
            bool datafinal = _wwd.Update(request, request.Id);
            if (datafinal)
            {
                return Ok(new ReturnMessage());
            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Error Internal Server"));
        }

        [HttpGet("Additions/{Id}")]
        public async Task<object> GetServiceAdditions(int Id)
        {
            List<ServiceAddition> serviceAdditions = await _db.serviceadditions.Where(x => x.ServiceId == Id).OrderBy(x=>x.InputId).ToListAsync();
            return Ok(new ReturnMessage(serviceAdditions));
        }
    }
}
