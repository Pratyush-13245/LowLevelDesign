using OOPSDemo.Payments;

namespace OOPSDemo.Services;

class OrderServices
{
    private readonly IPayment payment;

    public OrderServices(IPayment paymentMethod)
    {
        this.payment = paymentMethod;
    }

    public void ProcessOrder(double amount)
    {
        payment.pay(amount);
    }
}


    
