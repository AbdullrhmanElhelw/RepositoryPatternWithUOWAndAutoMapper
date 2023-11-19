using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Abstracts;

public interface IBookRepository : IBaseRepository<Book>
{
    Book? GetBookWithAuthor(int id);
    Book? FindBook(Func<Book, bool> condition);
}
