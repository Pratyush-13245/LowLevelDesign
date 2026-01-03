namespace MovieTicket.Services;

using MovieTicket.Models;
public interface IBookingService
{
    void BookTicket(User user, Movie movie);
}