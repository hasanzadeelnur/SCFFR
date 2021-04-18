﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCYDMWebServices.Data;
using TCYDMWebServices.Repositories;

namespace TCYDMWebServices.Controllers.V1
{
    [Route("api/lang")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly DatabaseContext _lng;
        public LanguageController(DatabaseContext lng)
        {
            _lng = lng;
        }
        [HttpGet("get/{Id}")]
        public IActionResult GetLangByKey(int Id)
        {
            return Ok(new ReturnMessage(data:_lng.languages.Where(a => a.Id == Id).FirstOrDefault()));
        }
        [HttpGet("getlangs")]
        public IActionResult GetLangs()
        {
            return Ok(new ReturnMessage(data: _lng.languages.ToList()));
        }
        [HttpGet("get/country/{langId}")]
        public IActionResult GetCountry(int langId)
        {
            return Ok(new ReturnMessage(_lng.countries.Where(a => a.LanguageId == langId).ToList()));
        }
        [HttpGet("get/region/{langId}")]
        public IActionResult GetRegion(int langId)
        {
            return Ok(new ReturnMessage(_lng.regions.Where(a => a.LanguageId == langId).ToList()));
        }

    }
}
