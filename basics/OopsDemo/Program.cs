using OOPSDemo.Payments;
using OOPSDemo.Services;
using OOPSDemo.Models;

class Program
{
    static void Main()
    {
        Customer customer = new Customer("C001", "C001@gmail.com" );
        Products product = new ElctronicProducts
        {
            Name = "Laptop",
            price = 50000
        };
        IPayment paymentMethod = new UPIPayments();
        OrderServices orderService = new OrderServices(paymentMethod);

        Console.WriteLine($"Customer: {customer.Name}, Email: {customer.Email}");
        Console.WriteLine($"Product: {product.Name}, Original Price: {product.price}");

        orderService.ProcessOrder(product.getDiscountedPrice());

    }
}