using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class VMVDTO
    {
        public int Id { get; set; }
        [Required]
        public string Vision { get; set; }
        [Required]
        public string Mission { get; set; }
        [Required]
        public string Values { get; set; }
        [Required]
        public int LangId { get; set; }
    }
}
