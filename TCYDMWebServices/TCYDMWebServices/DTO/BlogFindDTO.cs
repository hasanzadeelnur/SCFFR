using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Models;

namespace TCYDMWebServices.DTO
{
    public class BlogFindDTO
    {
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
    }
}
