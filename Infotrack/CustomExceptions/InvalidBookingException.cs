namespace Infotrack.CustomExceptions
{
    public class InvalidBookingException : Exception
    {
        public InvalidBookingException()
        {
        }

        public InvalidBookingException(string message)
            : base(message)
        {
        }

        public InvalidBookingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}