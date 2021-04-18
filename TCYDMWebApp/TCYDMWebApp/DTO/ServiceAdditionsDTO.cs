using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class ServiceAdditionsDTO
    {
        public int Id { get; set; }
        public OurServicesDTO Service { get; set; }
        public int ServiceId { get; set; }
        public InputType InputId { get; set; }
        public string PlaceHolder { get; set; }
    }
}