namespace   OOPS.BookLibrary.Services;
using OOPS.BookLibrary.Models;

class SimpleBorrowService : IBorrowService
{
    public void BorrowBook(Member member, Book book)
    {
        Console.WriteLine($" Member {member.Name} borrowed {book.Title} successfully");
    }
}