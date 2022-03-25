using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventService.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public int EventId { get; set; }
        public Guid BookingRefId { get; set; }
        public Event Event { get; set; }
    }
}
