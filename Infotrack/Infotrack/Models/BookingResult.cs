using System.Text.Json.Serialization;

namespace Infotrack.Models
{
    public class BookingResult
    {
        [JsonIgnore]
        public Booking Booking { get; set; }
        public Guid BookingId { get; set; }
    }
}