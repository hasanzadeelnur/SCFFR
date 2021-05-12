using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Models;

namespace TCYDMWebServices.DTO
{
    public class BlogsDTO
    {
        public List<Blog> Blog { get; set; }
        public int Count { get; set; }
    }
}
