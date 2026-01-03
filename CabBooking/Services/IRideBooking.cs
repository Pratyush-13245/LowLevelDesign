namespace CabBooking.Services;

using CabBooking.Models;

public interface IRideBooking
{
    public void ConfirmRide(Ride ride, User user);

}