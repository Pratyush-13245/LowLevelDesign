namespace OnlineShopping.Services;

public interface ICartService
{
    void AddTocart(Models.Products product, Models.Customers customer);
}