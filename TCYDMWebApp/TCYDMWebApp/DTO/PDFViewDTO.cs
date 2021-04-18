using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebApp.DTO
{
    public class PDFViewDTO
    {   
            public int Id { get; set; }
            public string PDFName { get; set; }
            public long OnlineQueryId { get; set; }
            public int UserId { get; set; }

    }
}
