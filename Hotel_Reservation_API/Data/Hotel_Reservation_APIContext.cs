using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_API.Models;

namespace Hotel_Reservation_API.Data
{
    public class Hotel_Reservation_APIContext : DbContext
    {
        public Hotel_Reservation_APIContext (DbContextOptions<Hotel_Reservation_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_Reservation_API.Models.ReservationDetails> ReservationDetails { get; set; }
    }
}
