using OOPS.BookLibrary.Models;
using OOPS.BookLibrary.Services;

class Program
{
    static void Main()
    {
        // Polymorphism: Book reference, EBook object
        Book book = new EBook("C# Programming", "John Doe", 1000);
        Member member = new Member("Alice","123@email.com");

        IBorrowService borrowService = new SimpleBorrowService();
        LibraryService libraryService = new LibraryService(borrowService);

        Console.WriteLine($"Book: {book.Title}, Author: {book.Author}");
        Console.WriteLine($"Final Price: {book.GetPrice()}");

        libraryService.BorrowBook(member,book);
        libraryService.BorrowBook(member, book);
        libraryService.BorrowBook(member, book);

    }
}
