using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Models
{
    public class ServiceAdditionFile
    {
        [Key]
        public int Id { get; set; }
        public OnlineQuery OnlineQuery { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string Content { get; set; }

    }
}
