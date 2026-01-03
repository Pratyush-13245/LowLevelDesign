namespace OnlineFoodOrdering.services;

public class FoodOrderingService
{
    private readonly IFoodOrderingService foodOrderingService;

    public FoodOrderingService(IFoodOrderingService foodOrderingService)
    {
        this.foodOrderingService = foodOrderingService;
    }

    public void placeOrder(Models.User user, Models.Item item)
    {
        foodOrderingService.placeOrder(user, item);
        
    }
}