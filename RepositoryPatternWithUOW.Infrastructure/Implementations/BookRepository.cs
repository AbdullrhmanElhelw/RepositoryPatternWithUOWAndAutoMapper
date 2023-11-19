using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.Abstracts;
using RepositoryPatternWithUOW.Infrastructure.Context;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Implementations;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public Book? FindBook(Func<Book, bool> condition) => _context.Books.Where(condition).FirstOrDefault();

    public Book? GetBookWithAuthor(int id) => _context.Books.Include(x => x.Author).FirstOrDefault(x => x.Id == id);
}
