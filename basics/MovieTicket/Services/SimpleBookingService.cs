namespace MovieTicket.Services;

using MovieTicket.Models;
    
public class SimpleSimpleBookingService: IBookingService
{
    public void BookTicket(User user,Movie movie)
    {
        System.Console.WriteLine($"Ticket booked for {user.name}, Movie:{movie.title}");
    }
}
