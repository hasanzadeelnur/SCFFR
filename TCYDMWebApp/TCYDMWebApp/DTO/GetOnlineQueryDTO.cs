using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class GetOnlineQueryDTO
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BornYear { get; set; }
        public string Sex { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Info { get; set; }
        public string Service { get; set; }
        public decimal Count { get; set; }
        public int IsSeen { get; set; }
    }
}
