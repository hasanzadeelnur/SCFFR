using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories;
using TCYDMWebServices.Repositories.Enums;

namespace TCYDMWebServices.Controllers.V1
{
    [Route("api/v1/vision")]
    [ApiController]
    public class VisionMissionValuesController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public VisionMissionValuesController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet,Route("getall")]
        public IActionResult GetAll()
        {
            try
            {
              IEnumerable<VMCDTO> response = (from vision in _db.visionmissionvalues.ToList()
                               join lang in _db.languages on vision.LangId equals lang.Id
                               select new VMCDTO
                               {
                                   Id=vision.Id,
                                   Vision = vision.Vision,
                                   Mission = vision.Mission,
                                   Values = vision.Values,
                                   Lang = lang.LangluageName
                               }).ToList();
                return Ok(new ReturnMessage(data: response));
            }
            catch (Exception x)
            {
                return BadRequest(new ReturnErrorMessage((int)ErrorTypes.Errors.Internal,"Error"));
            }
        }

        [HttpGet,Route("getbyid/{id}")]
        public IActionResult GetbyId(int id)
        {
            try
            {
               IEnumerable<VMVDTO> response = from vision in _db.visionmissionvalues
                               where vision.Id == id
                               select new VMVDTO
                               {
                                   Id=vision.Id,
                                   Vision = vision.Vision,
                                   Mission = vision.Mission,
                                   Values = vision.Values,
                                   LangId = vision.LangId
                               };

                return Ok(new ReturnMessage(data: response.FirstOrDefault()));
            }
            catch (Exception x)
            {
                return StatusCode(500, x.Message.ToString());
            }

        }

        [HttpGet, Route("getbylang/{langid}")]
        public IActionResult GetbyLang(int langid)
        {
            try
            {
                VMVDTO response = (from vision in _db.visionmissionvalues
                               where vision.LangId == langid
                               select new VMVDTO
                               {
                                   Vision = vision.Vision,
                                   Mission = vision.Mission,
                                   Values = vision.Values,
                                   LangId = vision.LangId
                               }).FirstOrDefault();

                return Ok(new ReturnMessage(data: response));
            }
            catch (Exception x)
            {
                return StatusCode(500, x.Message.ToString());
            }

        }

        [HttpPost,Route("post")]
        public IActionResult Post(VisionMissionValues request)
        {
            try
            {
                if(_db.visionmissionvalues.Any(t=>t.LangId==request.LangId))
                {
                    return BadRequest(new ReturnErrorMessage((int)ErrorTypes.Errors.AlreadyExists ,"Error"));
                }
                _db.visionmissionvalues.Add(request);
                _db.SaveChanges();
                return Ok(new ReturnMessage());
            }
            catch (Exception x)
            {
                return StatusCode(500, x.Message.ToString());
            }
        }

        [HttpPut,Route("put")]
        public IActionResult Put(VMVDTO request)
        {
            try
            {
                VisionMissionValues vision = _db.visionmissionvalues.Find(request.Id);
                vision.LangId = request.LangId;
                vision.Mission = request.Mission;
                vision.Values = request.Values;
                vision.Vision = request.Vision;
                _db.SaveChanges();
                return Ok(new ReturnMessage(data:vision));
            }
            catch (Exception x)
            {
                return StatusCode(500, x.Message.ToString());
            }
        }

        [HttpDelete,Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                VisionMissionValues data = _db.visionmissionvalues.Find(id);
                _db.visionmissionvalues.Remove(data);
                _db.SaveChanges();
                return Ok(new ReturnMessage());
            }
            catch (Exception x)
            {
                return BadRequest(new ReturnErrorMessage((int)ErrorTypes.Errors.Internal,"Error"));
            }

        }

    }
}
