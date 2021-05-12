using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Models
{
    public class Blog
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
        public int LanguageId { get; set; }
    }
}
