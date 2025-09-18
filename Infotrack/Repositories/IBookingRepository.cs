using Infotrack.Models;

namespace Infotrack.Repositories
{
    public interface IBookingRepository
    {
        void CreateBooking(BookingResult booking);

        IReadOnlyList<BookingResult> GetBookings();
    }
}