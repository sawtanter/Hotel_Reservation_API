using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_API.Data;
using Hotel_Reservation_API.Models;

namespace Hotel_Reservation_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationDetailsController : ControllerBase
    {
        private readonly Hotel_Reservation_APIContext _context;

        public ReservationDetailsController(Hotel_Reservation_APIContext context)
        {
            _context = context;
        }

        // GET: api/ReservationDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationDetails>>> GetReservationDetails()
        {
            return await _context.ReservationDetails.ToListAsync();
        }

        // GET: api/ReservationDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetails>> GetReservationDetails(int id)
        {
            var reservationDetails = await _context.ReservationDetails.FindAsync(id);

            if (reservationDetails == null)
            {
                return NotFound();
            }

            return reservationDetails;
        }

        // PUT: api/ReservationDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationDetails(int id, ReservationDetails reservationDetails)
        {
            if (id != reservationDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(reservationDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ReservationDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReservationDetails>> PostReservationDetails(ReservationDetails reservationDetails)
        {
            _context.ReservationDetails.Add(reservationDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservationDetails", new { id = reservationDetails.Id }, reservationDetails);
        }

        // DELETE: api/ReservationDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReservationDetails>> DeleteReservationDetails(int id)
        {
            var reservationDetails = await _context.ReservationDetails.FindAsync(id);
            if (reservationDetails == null)
            {
                return NotFound();
            }

            _context.ReservationDetails.Remove(reservationDetails);
            await _context.SaveChangesAsync();

            return reservationDetails;
        }

        private bool ReservationDetailsExists(int id)
        {
            return _context.ReservationDetails.Any(e => e.Id == id);
        }
    }
}
