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
    public class BlogController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public BlogController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet("BlogGet/{langId}/{page}")]
        public IActionResult BlogGet(int langId,int page)
        {
            if (page <= 0)
            {
                page = 1;
            }
            decimal datacount = _db.blogs.Count();

            decimal count = Math.Ceiling(datacount / 10);
            if (count != 0 && page > count)
            {
                page = (int)count;
            }
            List<Blog> blogs = _db.blogs.Where(a => a.LanguageId == langId).OrderByDescending(a => a.Id).Skip((page - 1) * 9).Take(9).ToList();
            BlogsDTO blogs1 = new BlogsDTO() { Blog = blogs, Count = (int)count };
            return Ok(new ReturnMessage(blogs1));
        }
        [HttpGet("BlogAll")]
        public IActionResult BlogGetAll()
        {
            IEnumerable<BlogDTO> what = from wwd in _db.blogs
                                           join langluage in _db.languages on wwd.LanguageId equals langluage.Id
                                           select new BlogDTO
                                           {
                                               Id = wwd.Id,
                                               Body = wwd.Body,
                                               Header=wwd.Header,
                                               ImagePath=wwd.ImagePath,
                                               Date=wwd.Date,
                                               View=wwd.View,
                                               Language = langluage.LangluageName
                                           };
            return Ok(new ReturnMessage(what.OrderByDescending(a=>a.Id)));
        }
        [HttpGet("BlogGetId/{id}")]
        public IActionResult BlogGetId(int id)
        {
            Blog blog = _db.blogs.Find(id);
            blog.View++;
            _db.SaveChanges();
            BlogFindDTO response = new BlogFindDTO() { Blog = blog, Blogs = _db.blogs.OrderByDescending(a => a.Id).Take(6).ToList() };
            return Ok(new ReturnMessage(response));
        }
        [HttpGet("BlogGetAdminId/{id}")]
        public IActionResult BlogGetAdminId(int id)
        {
            Blog blog = _db.blogs.Find(id);
            return Ok(new ReturnMessage(blog));
        }
        [HttpPost("BlogAdd")]
        public IActionResult BlogAdd([FromBody] Blog request)
        {
            try
            {
                _db.blogs.Add(request);
                _db.SaveChanges();
                return StatusCode(200, new ReturnMessage(message: "Created"));
            }
            catch (Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, code: 500));
            }
        }

        [HttpDelete("BlogDelete/{id}")]
        public IActionResult BlogDelete(int id)
        {
            bool datafound = _db.blogs.Any(t => t.Id == id);
            if (!datafound)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            Blog data = _db.blogs.Find(id);
            try
            {
                _db.blogs.Remove(data);
                _db.SaveChanges();
                return Ok(new ReturnMessage(200, message: "Success"));
            }
            catch (Exception)
            {
                return StatusCode(500, new ReturnErrorMessage((int)ErrorTypes.Errors.Internal, message: "Internal server error"));
            }

        }

        [HttpPut("BlogUpdate")]
        public IActionResult BlogUpdate([FromBody] Blog request)
        {
            bool data = _db.blogs.Any(t => t.Id == request.Id);
            if (!data)
            {
                return StatusCode(400, new ReturnErrorMessage((int)ErrorTypes.Errors.NotFound, message: "NotFound"));
            }
            try
            {
                Blog response = _db.blogs.Find(request.Id);
                response.Header = request.Header;
                response.Body = request.Body;
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
