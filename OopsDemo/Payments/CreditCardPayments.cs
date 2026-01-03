namespace OOPSDemo.Payments;

class CreditCardpayments : IPayment
{
    public void pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using credit card");
    }
}