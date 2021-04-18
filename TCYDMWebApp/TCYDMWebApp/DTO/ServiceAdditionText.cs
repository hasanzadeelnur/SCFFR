using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class ServiceAdditionText
    {
        [Key]
        public int Id { get; set; }
        public OnlineQueryDTO OnlineQuery { get; set; }
        public string Content { get; set; }
    }
}
