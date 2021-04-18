using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class ServiceAdditionNumber
    {
        [Key]
        public int Id { get; set; }
        public OnlineQueryDTO OnlineQuery { get; set; }
        public int Content { get; set; }
    }
}
