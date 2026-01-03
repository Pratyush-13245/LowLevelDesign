namespace OnlineShopping.Services;

public class CartService: ICartService
{
    public void AddTocart(Models.Products product, Models.Customers customer)
    {
        decimal discount = customer.type.ToLower() == "premium" ? product.Price * 0.1m : 0;

        decimal finalPrice = product.Price - discount;

        Console.WriteLine($"Customer Name: {customer.Name}");
        Console.WriteLine($"Customer Type: {customer.type}");
        Console.WriteLine($"Product: {product.ProductName}");
        Console.WriteLine($"Base Price: {product.Price}");
        Console.WriteLine($"Discount: {discount}");
        Console.WriteLine($"Final Price to be paid by {customer.Name}: {finalPrice}");
    }
}