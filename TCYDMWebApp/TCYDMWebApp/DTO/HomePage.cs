using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class HomePage
    {
        public int Id { get; set; }
        [NotMapped]
        [Required]
        public IFormFile PhotoUpload { get; set; }
        public string Photo { get; set; }
    }
}
