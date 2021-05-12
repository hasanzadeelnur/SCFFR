using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class OurTeamAddDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public int LanguageId { get; set; }
    }
}
