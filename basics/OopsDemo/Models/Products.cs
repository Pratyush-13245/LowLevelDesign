using System.Reflection.Metadata.Ecma335;
using OOPSDemo.Models;

class Products
{
    public string Name {get;set;}
    public double price {get;set;}

    public virtual double getDiscountedPrice()
    {
        return price;
    }
}
