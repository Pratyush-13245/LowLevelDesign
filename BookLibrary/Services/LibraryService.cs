namespace OOPS.BookLibrary.Services;

using System.ComponentModel;
using System.Linq.Expressions;
using OOPS.BookLibrary.Models;

public class LibraryService
{
    private readonly IBorrowService borrowService;

    public LibraryService(IBorrowService borrowService)
    {
        this.borrowService = borrowService;
    }

    public void BorrowBook(Member member, Book book)
    {
        borrowService.BorrowBook(member,book);
    }
}
