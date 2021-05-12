using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class BlogUpdateDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int LanguageId { get; set; }
    }
}
