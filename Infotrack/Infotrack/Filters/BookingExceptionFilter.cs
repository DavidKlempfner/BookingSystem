using Infotrack.CustomExceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Infotrack.Filters
{
    public class BookingExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is BookingConflictException bookingConflictException)
            {
                context.Result = new ConflictObjectResult(new { error = bookingConflictException.Message });
            }
        }
    }
}