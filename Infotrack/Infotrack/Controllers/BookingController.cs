using Infotrack.Models;
using Infotrack.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infotrack.Controllers
{
    /// <summary>
    /// Handles settlement booking-related operations, such as creating new bookings.
    /// </summary>
    /// <remarks>This controller provides endpoints for managing bookings. It is designed to work with an 
    /// implementation of <see cref="IBookingService"/> to perform booking operations.</remarks>
    /// <param name="bookingService"></param>
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