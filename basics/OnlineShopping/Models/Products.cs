namespace OnlineShopping.Models;

public class Products
{
    public string ProductName {get;set;}
    public decimal Price {get;set;}

    public Products (string productName, decimal price)
    {
        ProductName = productName;
        Price = price;
        
    }
}