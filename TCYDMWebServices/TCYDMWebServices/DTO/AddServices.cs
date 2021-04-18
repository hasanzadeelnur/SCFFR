using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Models;

namespace TCYDMWebServices.DTO
{
    public class AddServices
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        public int LanguageId { get; set; }
        public int NeedsAdittion { get; set; }
        [Required]
        public int NeedsPayment { get; set; }
        public int? ServiceId { get; set; }
        [Required]
        public int IsLocal { get; set; }
        [Required]
        public string Info { get; set; }
        public ICollection<AddServiceAddition> ServiceAdditions { get; set; }

    }
}
