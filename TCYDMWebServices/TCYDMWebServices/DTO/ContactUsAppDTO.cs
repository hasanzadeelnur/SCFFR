using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.DTO
{
    public class ContactUsAppDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string LandLine { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Language { get; set; }
    }
}
