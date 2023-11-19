using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Abstracts;

public interface IAuthorRepository : IBaseRepository<Author>
{
    Author? GetAuthorWithBooks (int id);
    Author? FindAuthor(Func<Author, bool> predicate);
    IEnumerable<Author> FindAuthors(Func<Author, bool> condition, Func<IEnumerable<Author>, IOrderedEnumerable<Author>> orderBy = null);
}
