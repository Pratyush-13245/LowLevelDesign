using CabBooking.Models;

namespace CabBooking.Services;

public class BookRide : IRideBooking
{
    public void ConfirmRide(Ride ride, User user)
    {
        decimal Discount = ride.Distance> 10 ? ride.Fare * 0.1m : 0;
        decimal finalFare = ride.Fare - Discount;
       Console.WriteLine($"Ride Booked for {user.Name}"); 
       Console.WriteLine($"Distance: {ride.Distance} km");

       Console.WriteLine($"Base Fare: {ride.Fare}");
       Console.WriteLine($"Discount Applied: {Discount}");
         Console.WriteLine($"Final Fare to be paid: {finalFare}");
    }

}