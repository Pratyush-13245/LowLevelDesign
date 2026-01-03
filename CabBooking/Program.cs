using CabBooking.Models;
using CabBooking.Services;
public class Program
{
    public static void Main()
    {
        User user = new User("Alice","123@123","1234567890");
        Ride ride = new Ride(12, 10);

        BookRide bookRide = new BookRide();
        RideBookingService service = new RideBookingService(bookRide);
        service.ConfirmRide(ride, user);
    }
}