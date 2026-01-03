using OnlineFoodOrdering.Models;
using OnlineFoodOrdering.services;

class Program
{
    static void Main()
    {
        Item pizza = new Item("Pizza",100);
        User user = new User("Alice","Alice@example.com");
        
        IFoodOrderingService foodOrderingService = new SimpleFoodOrderingService();
        FoodOrderingService service = new FoodOrderingService(foodOrderingService);
        service.placeOrder(user, pizza);     

    }
}
