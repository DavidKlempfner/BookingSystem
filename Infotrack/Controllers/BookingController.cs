using Infotrack.Models;
using Infotrack.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infotrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController(IBookingService bookingService) : ControllerBase
    {
        [HttpPost]
        public BookingResult CreateBooking(Booking booking)
        {
            return bookingService.CreateBooking(booking);
        }
    }
}