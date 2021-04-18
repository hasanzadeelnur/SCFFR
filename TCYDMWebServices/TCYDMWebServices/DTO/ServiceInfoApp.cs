using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.DTO
{
    public class ServiceInfoApp
    {
        public int Id  { get; set; }
        public string Info { get; set; }
        public string Name { get; set; }
        public int? ServiceId { get; set; }
        public string Language { get; set; }
        public int LanguageId { get; set; }
    }
}
