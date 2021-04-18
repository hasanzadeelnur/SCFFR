using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Models
{
    public class ServiceAdditionNumber
    {
        [Key]
        public int Id { get; set; }
        public OnlineQuery OnlineQuery { get; set; }
        public int Content { get; set; }
    }
}
