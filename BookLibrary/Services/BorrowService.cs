namespace OOPS.BookLibrary.Services;

using OOPS.BookLibrary.Models;

public interface IBorrowService
{
    void BorrowBook(Member member,Book book);
}
