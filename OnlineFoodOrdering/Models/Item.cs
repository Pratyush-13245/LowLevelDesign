namespace OnlineFoodOrdering.Models;

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name,decimal price)
    {
        Name = name;
        Price = price;
    }
    public decimal CalculateServiceCharge(int percentage)
    {
        return Price * percentage / 100;
    }

    public decimal CalculateFinalPrice(int percentage)
    {
        return Price + CalculateServiceCharge(percentage);
    }
}