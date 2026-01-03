namespace MovieTicket.Services;

using MovieTicket.Models;

public class BookingService
{
    private readonly IBookingService bookingService;

    public BookingService(IBookingService bookingService)
    {
        this.bookingService = bookingService;
    }

    public void BookTicket(User user, Movie movie)
    {
        bookingService.BookTicket(user, movie);
    }

}
