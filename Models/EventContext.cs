using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventService.Models
{
    public class EventContext : DbContext
    {
        
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }



        public EventContext(DbContextOptions options) : base (options)
        {

        }
    }
}
