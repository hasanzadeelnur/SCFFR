using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Models
{
    public class VisionMissionValues
    {
        [Key]
        public int Id { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public string Values { get; set; }
        public int LangId { get; set; }
    }
}
