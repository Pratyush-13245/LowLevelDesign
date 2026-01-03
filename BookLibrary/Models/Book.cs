namespace OOPS.BookLibrary.Models;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public double Price { get; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public virtual double GetPrice()
    {
        return Price;
    }
}
