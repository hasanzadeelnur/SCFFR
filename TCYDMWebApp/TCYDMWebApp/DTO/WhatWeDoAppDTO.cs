using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class WhatWeDoAppDTO
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Language { get; set; }
    }
}
