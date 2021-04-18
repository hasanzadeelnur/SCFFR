using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Models
{
    public class ServiceAdditionText
    {
        [Key]
        public int Id { get; set; }
        public OnlineQuery OnlineQuery { get; set; }
        public string Content { get; set; }
    }
}
