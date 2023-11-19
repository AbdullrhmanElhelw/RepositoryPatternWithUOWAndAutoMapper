using RepositoryPatternWithUOW.Infrastructure.Abstracts;
using RepositoryPatternWithUOW.Infrastructure.Context;
using RepositoryPatternWithUOW.Infrastructure.Implementations;


namespace RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IBookRepository BookRepository { get; private set; }

    public IAuthorRepository AuthorRepository { get; private set; }

    public ICategoryRepository CategoryRepository { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        BookRepository = new BookRepository(_context);
        AuthorRepository = new AuthorRepository(_context);
        CategoryRepository = new CategoryRepository(_context);
    }

    public void Dispose() => _context.Dispose();

    public int SaveChanges() => _context.SaveChanges();
}
