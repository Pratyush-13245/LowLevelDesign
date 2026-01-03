namespace OOPSDemo.Models;

class ElctronicProducts:Products
{
    public override double getDiscountedPrice()
    {
        return price * 0.9;
    }
}

