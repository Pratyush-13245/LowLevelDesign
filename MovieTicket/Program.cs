
using MovieTicket.Models;
using MovieTicket.Services;
class Program
{
    static void Main()
    {
        Movie movie = new Movie("Movie1", 120);
        User user = new User("User1", "user1@email.com");

        IBookingService bookingService = new SimpleSimpleBookingService();
        BookingService service = new BookingService(bookingService);

        service.BookTicket(user, movie);
        


    }
}
