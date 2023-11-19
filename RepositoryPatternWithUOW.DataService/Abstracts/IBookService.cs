
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

namespace RepositoryPatternWithUOW.DataService.Abstracts;

public interface IBookService
{
    BookReadDTO? GetBook(int id);
    BookReadDTO? FindBook(Func<BookReadDTO, bool> critiria);
    BookWithAuthorReadDTO? GetBookWithAuthor(int id);
    BookCreateDTO? CreateBook(BookCreateDTO book);
    BookUpdateDTO? UpdateBook(BookUpdateDTO book);
    void DeleteBook(int id);
    IEnumerable<BookReadDTO> GetBooks();
   // BookWithAuthorReadDTO? FindBookWithAuthor(Func<BookWithAuthorReadDTO, bool> critiria);
}
