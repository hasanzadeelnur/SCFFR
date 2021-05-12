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
using TCYDMWebServices.Repositories.Abstracts;
using TCYDMWebServices.Repositories.Enums;
using TCYDMWebServices.Repositories.Filters;
using TCYDMWebServices.Repositories.Repos;

namespace TCYDMWebServices.Controllers.V1
{
    [Validator]
    [Route("api/v1/ContactUs")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly DatabaseContext _db;
        private readonly ITransactions<ContactUsDTO> _wwd;
        public ContactUsController(DatabaseContext db, ITransactions<ContactUsDTO> wwd)
        {
            _wwd = wwd;
            _db = db;
        }
        [HttpGet("ContactUsGet/{languageId}")]
        public IActionResult ContactUsGet(int languageId)
        {
            return Ok(new ReturnMessage(_db.contactuss.Where(a => a.LanguageId == languageId).FirstOrDefault()));
        }
        [HttpGet("ContactUsGetId/{id}")]
        public IActionResult ContactUsGetId(int id)
        {
            return Ok(new ReturnMessage(_db.contactuss.Find(id)));
        }

        [HttpGet("ContactUsGetAll")]
        public IActionResult ContactUsGetAll(int languageId)
        {
            IEnumerable<ContactUsAppDTO> contacts = from contact in _db.contactuss
                                                    join langluage in _db.languages on contact.LanguageId equals langluage.Id
                                                    select new ContactUsAppDTO
                                                    {
                                                        Id = contact.Id,
                                                        Adress = contact.Adress,
                                                        Content = contact.Content,
                                                        Email = contact.Email,
                                                        Phone = contact.Phone,
                                                        LandLine=contact.LandLine,
                                                        Language = langluage.LangluageName
                                                    };
            return Ok(new ReturnMessage(contacts));
        }

        [HttpPost("ContactUsAdd")]
        public IActionResult ContactUsAdd([FromBody] ContactUsDTO request)
        {
            #region FunctionBody
            bool langluageid = _db.contactuss.Any(t => t.LanguageId == request.LanguageId);
            if (langluageid)
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

        [HttpDelete("ContactUsDelete/{id}")]
        public IActionResult ContactUsDelete(int id)
        {
            #region FunctionBody
            ContactUs data = _db.contactuss.Find(id);
            if (data==null)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            ContactUsDTO dto = new ContactUsDTO
            {
                Id = id,
                Adress=data.Adress,
                Email=data.Email,
                Phone=data.Phone,
                Content = data.Content,
                LanguageId = data.LanguageId
            };
            bool request = _wwd.Delete(dto);
            if (request)
            {
                return Ok(new ReturnMessage(200, message: "Success"));
            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Internal server error"));
            #endregion
        }

        [HttpPut("ContactUsUpdate")]
        public IActionResult ContactUsUpdate([FromBody] ContactUsDTO request)
        {
            #region FunctionBody
            bool data = _db.contactuss.Any(t => t.Id == request.Id);
            if (!data)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            bool datafinal = _wwd.Update(request, request.Id);
            if (datafinal)
            {
                return Ok(new ReturnMessage());
            }
            return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Error Internal Server"));
            #endregion
        }
    }
}
