using System.Collections.Immutable;
using Infotrack.Models;

namespace Infotrack.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly List<BookingResult> _bookings = [];

        public void CreateBooking(BookingResult booking)
        {
            _bookings.Add(booking);
        }

        public IReadOnlyList<BookingResult> GetBookings()
        {
            return _bookings.OrderBy(x => x.Booking.BookingTime).ToImmutableList();
        }
    }
}