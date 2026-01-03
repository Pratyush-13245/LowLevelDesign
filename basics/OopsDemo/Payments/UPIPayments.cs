namespace OOPSDemo.Payments;

class UPIPayments : IPayment
{
    public void pay(double amount)
    {
         Console.WriteLine($"Paid {amount} using UPI");
    }
}