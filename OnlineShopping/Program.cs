using OnlineShopping.Models;
using OnlineShopping.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var customer = new Customers("Alice","abc@abc","premium");
        var product = new Products("Laptop",50000);

        ICartService cartService = new CartService();
        var service = new AddTocart(cartService);
        service.AddProductToCart(product, customer);

    }
}