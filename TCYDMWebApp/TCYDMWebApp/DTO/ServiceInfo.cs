﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class ServiceInfo
    {
        public int Id  { get; set; }
        public string Info { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public int LanguageId { get; set; }
    }
}
