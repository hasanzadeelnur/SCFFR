using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Repositories.Enums;

namespace TCYDMWebServices.Models
{
    public class ServiceAddition
    {
        public int Id { get; set; }
        public Service Service { get; set; }
        public int? ServiceId { get; set; }
        public InputType InputId { get; set; }
        public string PlaceHolder { get; set; }
    }
}
