using CryptoHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories;
using TCYDMWebServices.Repositories.Enums;
using TCYDMWebServices.Repositories.Filters;

namespace TCYDMWebServices.Controllers.V1
{
    [Validator]
    [Route("api/v1/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public AdminController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("getonlinequery")]
        #region FunctionBody
        public IActionResult GetOnlineQueries(int page=1)
        {
            if (page <= 0)
            {
                page = 1;
            }
            decimal datacount = _db.onlinequeries.Count();

            decimal count = Math.Ceiling(datacount/10);
            if (count!=0 && page > count)
            {
                page = (int)count;
            }
            IEnumerable<GetOnlineQueryDTO> order = (from queries in _db.onlinequeries.Include(I => I.User).Include(I=>I.ServiceAdditionTexts).Include(I=>I.ServiceAdditionNumbers).Include(I=>I.ServiceAdditionFiles).Skip((page - 1) * 10).Take(10).ToList()
                                                    join services in _db.services on queries.Service.Id equals services.Id
                                                    join user in _db.users on queries.User.Id equals user.Id
                                                    join region in _db.regions on user.RegionId equals region.Id
                                                    join country in _db.countries on user.CountryId equals country.Id
                                                    join sex in _db.genders on user.SexId equals sex.Id
                                                    select new GetOnlineQueryDTO
                                                    {
                                                        Region = region.Name,
                                                        Country = country.Name,
                                                        Name = user.Name,
                                                        Surname = user.Surname,
                                                        BornYear = user.BornYear,
                                                        Sex = sex.Name,
                                                        TcNo = user.TCNo,
                                                        Email = user.Email,
                                                        Phone = user.PhoneNumber,
                                                        Id = queries.Id,
                                                        ServiceDate = queries.ServiceDate,
                                                        StartDate = queries.StartDate,
                                                        Info = queries.Info,
                                                        Service = queries.Service.Name,
                                                        IsSeen=queries.IsSeen,
                                                        Count = count,
                                                        Texts=queries.ServiceAdditionTexts.Select(m => m.Content).ToList(),
                                                        Files = queries.ServiceAdditionFiles.Select(m => m.Content).ToList(),
                                                        Numbers = queries.ServiceAdditionNumbers.Select(m => m.Content).ToList()
                                                    });


          
            return Ok(order);
        }
        #endregion
        [HttpGet]
        [Route("getdocument/{id}")]
        #region FunctionBody
        public IActionResult GetDocument(int id)
        {
            var order = (from queries in _db.onlinequeries.Include(I => I.User).Include(I => I.ServiceAdditionTexts).Include(I => I.ServiceAdditionNumbers).Include(I => I.ServiceAdditionFiles) where queries.Id==id

                                                    select new
                                                    {
                                                        Id = queries.Id,
                                                        Texts = queries.ServiceAdditionTexts.ToList(),
                                                        Files = queries.ServiceAdditionFiles.ToList(),
                                                        Numbers = queries.ServiceAdditionNumbers.ToList()
                                                    });

            return Ok(new ReturnMessage (order));
        }
        #endregion

        [HttpDelete]
        [Route("deleteonlinequery/{id}")]
        public IActionResult DeleteOnlineQueriey(long id)
        {
            try
            {
                
                OnlineQuery query = _db.onlinequeries.Include(m=>m.ServiceAdditionFiles).Include(m => m.ServiceAdditionTexts).Include(m => m.ServiceAdditionNumbers).FirstOrDefault(t=>t.Id==id);
                if (query == null)
                {
                    return BadRequest();
                }
                foreach(var item in query.ServiceAdditionFiles)
                {
                    _db.serviceadditionfile.Remove(item);
                }
                foreach (var item in query.ServiceAdditionNumbers)
                {
                    _db.serviceadditionnumber.Remove(item);
                }
                foreach (var item in query.ServiceAdditionTexts)
                {
                    _db.serviceadditiontext.Remove(item);
                }
                _db.onlinequeries.Remove(query);
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception x)
            {

                return BadRequest(x);
            }

        }

        [HttpGet]
        [Route("gethomeview")]
        public IActionResult GetHomeView()
        {
            IEnumerable<HomePage> photo = _db.homepage.ToList();
            return Ok(new ReturnMessage(photo));
        }

        [HttpGet]
        [Route("gethomeview/{id}")]
        public IActionResult SingleHomeView(int id)
        {
            var data = _db.homepage.Find(id);
            
            return Ok(data);
        }
        [HttpPost]
        [Route("addhomeview")]
        public IActionResult AddHomeView([FromBody] HomePage home)
        {
            var data = _db.homepage.Add(home);
            _db.SaveChanges();
            return Ok("success");
        }

        [HttpPut]
        [Route("edithomeview/{id}")]
        public IActionResult EditHomeView(HomePage home , int id )
        {
            var data = _db.homepage.Find(id);
            data.Photo = home.Photo;
            _db.SaveChanges();
             return Ok(data);
        }

        [HttpDelete]
        [Route("deletehomeview/{id}")]
        public IActionResult DeleteHomeView(int id)
        {
            var data = _db.homepage.Find(id);
            _db.homepage.Remove(data);
            _db.SaveChanges();
            return Ok("success");
        }

        [HttpGet]
        [Route("IsSeen/{id}")]
        public IActionResult IsSeen(long id)
        {
            var data = _db.onlinequeries.Find(id);
            data.IsSeen = 1;
            _db.SaveChanges();
            return Ok("success");
        }

        [HttpPost]
        [Route("adminregister")]
        public IActionResult AdminRegister(AdminTable request)
        {
            _db.admintables.Add(new AdminTable { Username = request.Username, Password=Crypto.HashPassword(request.Password) });
            _db.SaveChanges();
            return Ok();
        }
        [HttpPost]
        [Route("AdminLogin")]
        public IActionResult AdminLogin(AdminTableDTO request)
        {
            AdminTable admin = _db.admintables.FirstOrDefault(t => t.Username == request.Username);
            if(admin!=null)
            {
                if(Crypto.VerifyHashedPassword(admin.Password,request.Password))
                {
                    return Ok(new ReturnMessage(admin));
                }
                return BadRequest();
            }
            return BadRequest();
        }

    }
}
