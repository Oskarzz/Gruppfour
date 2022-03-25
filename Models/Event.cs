using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventService.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Prioritize { get; set; }
        public int TicketsMax { get; set; }
        public int LocaleId { get; set; }
        public int HostId { get; set; }


        public byte[] Picture { get; set; }
        public List<Booking> Booking { get; set; }

        [NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile UploadedPic { get; set; }



    }
}
