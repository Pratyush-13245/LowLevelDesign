namespace OnlineShopping.Services;

public class AddTocart
{
    public readonly ICartService cartService;   

    public AddTocart(ICartService cartService)
    {
        this.cartService=cartService;
    }
    public void AddProductToCart(Models.Products product, Models.Customers customer)
    {
        cartService.AddTocart(product, customer);
    } 
}