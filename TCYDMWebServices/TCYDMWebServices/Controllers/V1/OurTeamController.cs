using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories;
using TCYDMWebServices.Repositories.Enums;

namespace TCYDMWebServices.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OurTeamController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public OurTeamController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet("OurTeamGet/{langId}")]
        public IActionResult WhatWeDoGet(int langId)
        {
            return Ok(new ReturnMessage(_db.ourteams.Where(a => a.LanguageId == langId).ToList()));
        }
        [HttpGet("OurTeamAll")]
        public IActionResult WhatWeDoGetAll()
        {
            IEnumerable<OurTeamDTO> what = from wwd in _db.ourteams
                                               join langluage in _db.languages on wwd.LanguageId equals langluage.Id
                                               select new OurTeamDTO
                                               {
                                                   Id = wwd.Id,
                                                   FullName = wwd.FullName,
                                                   Job=wwd.Job,
                                                   ImagePath=wwd.ImagePath,
                                                   Language = langluage.LangluageName
                                               };
            return Ok(new ReturnMessage(what));
        }
        [HttpGet("OurTeamGetId/{id}")]
        public IActionResult WhatWeDoGetId(int id)
        {
            return Ok(new ReturnMessage(_db.ourteams.Find(id)));
        }
        [HttpPost("OurTeamAdd")]
        public IActionResult WhatWeDoAdd([FromBody] OurTeam request)
        {
            try
            {
                _db.ourteams.Add(request);
                _db.SaveChanges();
                return StatusCode(200, new ReturnMessage(message: "Created"));
            }
            catch (Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, code: 500));
            }
        }

        [HttpDelete("OurTeamDelete/{id}")]
        public IActionResult WhatWeDoDelete(int id)
        {
            bool datafound = _db.ourteams.Any(t => t.Id == id);
            if (!datafound)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            OurTeam data = _db.ourteams.Find(id);
            try
            {
                _db.ourteams.Remove(data);
                _db.SaveChanges();
                return Ok(new ReturnMessage(200, message: "Success"));
            }
            catch (Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Internal server error"));
            }

        }

        [HttpPut("OurTeamUpdate")]
        public IActionResult WhatWeDoUpdate([FromBody] OurTeam request)
        {
            bool data = _db.ourteams.Any(t => t.Id == request.Id);
            if (!data)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            try
            {
                OurTeam response = _db.ourteams.Find(request.Id);
                response.FullName = request.FullName;
                response.Job = request.Job;
                response.ImagePath = request.ImagePath;
                response.LanguageId = request.LanguageId;
                _db.SaveChanges();
                return Ok(new ReturnMessage());
            }
            catch (Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Error Internal Server"));
            }     
        }
    }
}
