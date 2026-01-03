using CabBooking.Models;

namespace CabBooking.Services;

public class RideBookingService
{
    public readonly IRideBooking rideBooking;

    public RideBookingService(IRideBooking rideBooking)
    {
        this.rideBooking = rideBooking;
    }

    public void ConfirmRide(Ride ride,User user)
    {
        rideBooking.ConfirmRide(ride, user);
    }
}

