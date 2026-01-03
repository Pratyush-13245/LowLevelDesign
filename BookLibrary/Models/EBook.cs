namespace OOPS.BookLibrary.Models;

public class EBook : Book
{
    public EBook(string title, string author, double price)
        : base(title, author, price)
    {
    }

    public override double GetPrice()
    {
        return Price * 0.8; // 20% discount
    }
}
