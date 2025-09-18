using Infotrack.Models;

namespace Infotrack.Services
{
    public interface IBookingService
    {
        BookingResult CreateBooking(Booking booking);
    }
}