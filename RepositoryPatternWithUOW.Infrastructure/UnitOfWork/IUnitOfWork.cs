
using RepositoryPatternWithUOW.Infrastructure.Abstracts;

namespace RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IBookRepository BookRepository { get;  }
    IAuthorRepository AuthorRepository { get;  }
    ICategoryRepository CategoryRepository { get;  }
    int SaveChanges();

}
