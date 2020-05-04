using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_API.Models
{
    public class ReservationDetails
    {
        //id of the reservation.
        public int Id { get; set; }
        
        //Client name
        public string Name { get; set; }

        //Client contact number.
        public string ContactNumber { get; set; }
        //hotel name 
        public string HotelName { get; set; }

        //The hotel Price per room
        public decimal PricePerRoom { get; set; }

        public DateTime ReservationDate { get; set; }
    }
}
