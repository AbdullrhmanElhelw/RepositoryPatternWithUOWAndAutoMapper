using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.Abstracts;
using RepositoryPatternWithUOW.Infrastructure.Context;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Implementations;

public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
{
    private readonly ApplicationDbContext _context;

    public AuthorRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Author> FindAuthors(Func<Author, bool> condition, Func<IEnumerable<Author>, IOrderedEnumerable<Author>> orderBy = null)
    {
        var authors = _context.Authors.Where(condition);
        return orderBy != null ? orderBy(authors) : authors;
    }

    public Author? FindAuthor(Func<Author, bool> predicate) => 
        _context.Authors.Where(predicate).FirstOrDefault();

    public Author? GetAuthorWithBooks(int id) =>
        _context.Authors.Where(a => a.Id == id).Include(a => a.Books).FirstOrDefault();

}
