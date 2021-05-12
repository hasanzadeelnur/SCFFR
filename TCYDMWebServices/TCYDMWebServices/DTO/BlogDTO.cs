using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.DTO
{
    public class BlogDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
        public int View { get; set; }
        [Required]
        public string Language { get; set; }
    }
}
