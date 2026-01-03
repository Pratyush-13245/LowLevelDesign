namespace OnlineFoodOrdering.services;

public class SimpleFoodOrderingService : IFoodOrderingService
{
    public void placeOrder(Models.User user, Models.Item item)
    {
         int serviceChargePercent = 5;

    decimal serviceCharge = item.CalculateServiceCharge(serviceChargePercent);
    decimal finalPrice = item.CalculateFinalPrice(serviceChargePercent);

    Console.WriteLine($"Order placed by {user.Username} for {item.Name}");
    Console.WriteLine($"Base Price: {item.Price}");
    Console.WriteLine($"Service Charge: {serviceCharge}");
    Console.WriteLine($"Final Price: {finalPrice}");
    }
}