namespace CabBooking.Models;

public class Ride
{
    public int Distance { get; set; }
    public decimal Fare { get; set; }

    public Ride(int distance, int baseFare)
    {
        Distance = distance;
        Fare = distance * baseFare; // Assuming fare per km is baseFare
    }
}